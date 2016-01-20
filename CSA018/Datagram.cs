using System;
using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 报文结构体。
    /// </summary>
    public struct Datagram
    {
        /// <summary>
        /// 起始符。
        /// </summary>
        /// <value>只读属性，取值为0x02。</value>
        public byte Stx
        {
            get
            {
                return 0x02;
            }
            private set { }
        }

        /// <summary>
        /// 消息头。
        /// <para><see cref="MessageHead"/>类型，长度为16字节。</para>
        /// </summary>
        public MessageHead Head { get; set; }

        /// <summary>
        /// 消息体。
        /// <para><see cref="MessageBody"/>类型，长度可变。</para>
        /// </summary>
        public MessageBody Body { get; set; }

        /// <summary>
        /// 结束符。
        /// </summary>
        /// <value>只读属性，取值为0x03。</value>
        public byte Etx
        {
            get
            {
                return 0x03;
            }
            private set { }
        }

        /// <summary>
        /// 通过消息头初始化报文对象实例。
        /// </summary>
        /// <param name="head">
        /// 消息头。
        /// <para><see cref="MessageHead"/>类型，长度为16字节。</para>
        /// </param>
        public Datagram(MessageHead head)
            : this()
        {
            Head = head;
        }

        /// <summary>
        /// 通过消息头和消息体初始化报文对象实例。
        /// </summary>
        /// <param name="head">
        /// 消息头。
        /// <para><see cref="MessageHead"/>类型，长度为16字节。</para>
        /// </param>
        /// <param name="body">
        /// 消息体。
        /// <para><see cref="MessageBody"/>类型，长度可变。</para>
        /// </param>
        public Datagram(MessageHead head, MessageBody body)
            : this()
        {
            Head = head;
            Body = body;
        }

        /// <summary>
        /// 获取消息报文字节数组。
        /// </summary>
        /// <returns>消息报文字节数组。</returns>
        public byte[] GetDatagram()
        {
            if (Head.Type == MessageType.HeartbeatData)
            {
                return new byte[] { 0xFF };
            }
            else if (Head.Type == MessageType.HeartbeatResponse)
            {
                return new byte[] { 0xFE };
            }
            else
            {
                List<byte> dg = new List<byte> { Stx };
                byte[] head = Head.GetHead();
                dg.AddRange(Escaping(head));

                //“命令响应”和“事件和告警响应”类型的消息类型无消息体。
                if (Head.Type != MessageType.CommandACK
                    && Head.Type != MessageType.EventACK)
                {
                    byte[] body = Body.GetBody();
                    dg.AddRange(Escaping(body));
                }

                dg.Add(Etx);
                return dg.ToArray();
            }
        }

        /// <summary>
        /// 获取消息报文对象列表。
        /// </summary>
        /// <param name="dataArray">消息报文字节数组。</param>
        /// <param name="isTcpOrUdp">报文承载方式是否是TCP或UDP，默认为false。</param>
        /// <param name="isCheckCrc">是否校验CRC。</param>
        /// <returns>消息报文对象列表。</returns>
        public static List<Datagram> GetDatagramList(byte[] dataArray, bool isTcpOrUdp = false, bool isCheckCrc = true)
        {
            List<byte> dataList = new List<byte>(dataArray);

            for (int i = dataArray.Length - 1; i >= 0; i--)
            {
                if (dataList[i] > 0)
                {
                    break;
                }

                dataList.RemoveAt(i);
            }

            if (dataList.Count < 15)
            {
                foreach (var item in dataList)
                {
                    if (item == 0xFF)
                    {
                        return new List<Datagram>()
                        {
                            new Datagram
                            (
                                new MessageHead(MessageType.HeartbeatData)
                            )
                        };
                    }

                    if (item == 0xFE)
                    {
                        return new List<Datagram>()
                        {
                            new Datagram
                            (
                                new MessageHead(MessageType.HeartbeatResponse)
                            )
                        };
                    }
                }

                throw new CsaException("消息解析错误。", ErrorCode.MessageParseError);
            }

            List<Datagram> datagramList = new List<Datagram>();
            List<byte[]> newByteArrayList;

            if (!isTcpOrUdp)
            {
                List<byte[]> byteArrayList = new List<byte[]>();
                GetByteArrayList(dataList.ToArray(), 0, ref byteArrayList);
                newByteArrayList = Descaping(byteArrayList);
            }
            else
            {
                newByteArrayList = new List<byte[]> { dataList.ToArray() };
            }

            foreach (var tempByteArray in newByteArrayList)
            {
                if (!Enum.IsDefined(typeof(MessageType), tempByteArray[0]))
                {
                    throw new CsaException("参数类型未定义。", ErrorCode.ParameterTypeUndefined);
                }

                Datagram d = new Datagram();
                MessageHead mh = new MessageHead();
                mh.Type = (MessageType)tempByteArray[0];
                mh.SeqNumber = (uint)((tempByteArray[1] << 24) + (tempByteArray[2] << 16) + (tempByteArray[3] << 8) + tempByteArray[4]);
                mh.Length = (ushort)((tempByteArray[5] << 8) + tempByteArray[6]);
                mh.Reserved = (ulong)((tempByteArray[7] << 32) + (tempByteArray[8] << 24) + (tempByteArray[9] << 16) + (tempByteArray[10] << 8) + tempByteArray[11]);
                mh.Crc32 = (uint)((tempByteArray[12] << 24) + (tempByteArray[13] << 16) + (tempByteArray[14] << 8) + tempByteArray[15]);

                if (mh.Type == MessageType.Command
                    || mh.Type == MessageType.Event
                    || mh.Type == MessageType.CommandResult)
                {
                    if (tempByteArray.Length >= 30)
                    {
                        if (!Enum.IsDefined(typeof(MessageId), (ushort)((tempByteArray[16] << 8) + tempByteArray[17])))
                        {
                            throw new CsaException("消息ID未定义。", ErrorCode.MessageIdUndefined);
                        }

                        MessageBody mb = new MessageBody();
                        mb.MessageId = (MessageId)((tempByteArray[16] << 8) + tempByteArray[17]);
                        mb.GatewayId = ((uint)tempByteArray[18] << 24) + ((uint)tempByteArray[19] << 16) + ((uint)tempByteArray[20] << 8) + tempByteArray[21];
                        mb.LuminaireId = ((uint)tempByteArray[22] << 24) + ((uint)tempByteArray[23] << 16) + ((uint)tempByteArray[24] << 8) + tempByteArray[25];

                        if (mh.Type == MessageType.CommandResult)
                        {
                            mb.ErrorCode = (ErrorCode)((tempByteArray[26] << 24) + (tempByteArray[27] << 16) + (tempByteArray[28] << 8) + tempByteArray[29]);
                            List<byte> errorInfoArrayList = new List<byte>();

                            for (int i = 30; i < tempByteArray.Length; i++)
                            {
                                errorInfoArrayList.Add(tempByteArray[i]);
                            }

                            if (errorInfoArrayList.Count > 0)
                            {
                                mb.ErrorInfo = errorInfoArrayList.ToArray().ToString2();
                            }
                        }
                        else
                        {
                            List<Parameter> pmtList = new List<Parameter>();
                            Parameter.GetParameterList(tempByteArray, 26, ref pmtList);

                            if (pmtList.Count > 0)
                            {
                                mb.ParameterList = pmtList;
                            }
                            else
                            {
                                throw new CsaException("参数格式错误。", ErrorCode.ParameterFormatError);
                            }
                        }

                        if (isCheckCrc && Crc32.GetCrc32(mb.GetBody()) != mh.Crc32)
                        {
                            throw new CsaException("消息体CRC校验错误。", ErrorCode.ChecksumError);
                        }

                        d.Body = mb;
                    }
                    else
                    {
                        throw new CsaException("消息解析错误。", ErrorCode.MessageParseError);
                    }
                }

                d.Head = mh;
                datagramList.Add(d);
            }

            return datagramList;
        }

        /// <summary>
        /// 转义特殊字符。
        /// <para>STX转义为ESC和0xE7，即02->1BE7。</para>
        /// <para>ETX转义为ESC和0xE8，即03->1BE8。</para>
        /// <para>ESC转义为ESC和0x00，即1B->1B00。</para>
        /// </summary>
        /// <param name="byteArray">消息报文字节数组。</param>
        /// <returns>转义后的字节数组。</returns>
        private static byte[] Escaping(byte[] byteArray)
        {
            List<byte> byteList = new List<byte>();

            foreach (var item in byteArray)
            {
                if (item == 0x02)
                {
                    byteList.Add(0x1B);
                    byteList.Add(0xE7);
                }
                else if (item == 0x03)
                {
                    byteList.Add(0x1B);
                    byteList.Add(0xE8);
                }
                else if (item == 0x1B)
                {
                    byteList.Add(0x1B);
                    byteList.Add(0x00);
                }
                else
                {
                    byteList.Add(item);
                }
            }

            return byteList.ToArray();
        }

        /// <summary>
        /// 去除转义特殊字符。
        /// </summary>
        /// <param name="byteArray">原消息报文字节数组。</param>
        /// <returns>去除转义字符的字节数组。</returns>
        private static byte[] Descaping(byte[] byteArray)
        {
            List<byte> byteList = new List<byte>();

            for (int i = 0; i < byteArray.Length; i++)
            {
                if (byteArray[i] == 0x1B)
                {
                    if (i + 1 < byteArray.Length)
                    {
                        switch (byteArray[i + 1])
                        {
                            case 0xE7:
                                byteList.Add(0x02);
                                break;
                            case 0xE8:
                                byteList.Add(0x03);
                                break;
                            case 0x00:
                                byteList.Add(0x1B);
                                break;
                            default:
                                byteList.Add(byteArray[i + 1]);
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }

                    i++;
                }
                else
                {
                    byteList.Add(byteArray[i]);
                }
            }

            return byteList.ToArray();
        }

        /// <summary>
        /// 去除转义特殊字符。
        /// </summary>
        /// <param name="byteArrayList">原消息报文字节数组列表。</param>
        /// <returns>去除转义字符的字节数组列表。</returns>
        private static List<byte[]> Descaping(List<byte[]> byteArrayList)
        {
            List<byte[]> newByteArrayList = new List<byte[]>();
            byte[] byteArray;

            foreach (var item in byteArrayList)
            {
                byteArray = Descaping(item);
                newByteArrayList.Add(byteArray);
            }

            return newByteArrayList;
        }

        /// <summary>
        /// 获取消息报文字节数组列表。
        /// <para>此列表中的消息报文字节数组不包含起止符。</para>
        /// </summary>
        /// <param name="dataArray">消息报文字节数组。</param>
        /// <param name="index">数组索引。</param>
        /// <param name="byteArrayList">消息报文字节数组列表。</param>
        private static void GetByteArrayList(byte[] dataArray, int index, ref List<byte[]> byteArrayList)
        {
            bool isStx = false;
            List<byte> byteList = new List<byte>();

            for (int i = index; i < dataArray.Length; i++)
            {
                if (dataArray[i] == 0x02)
                {
                    byteList = new List<byte>();
                    isStx = true;
                }
                else if (dataArray[i] == 0x03)
                {
                    isStx = false;

                    if (byteList.Count > 0)
                    {
                        byteArrayList.Add(byteList.ToArray());
                    }

                    GetByteArrayList(dataArray, i + 1, ref byteArrayList);
                    break;
                }
                else if (isStx)
                {
                    byteList.Add(dataArray[i]);
                }
            }
        }

        /// <summary>
        /// 获取消息报文十六进制字符串。
        /// </summary>
        /// <param name="separator">
        /// 分隔符。
        /// <para>默认为空字符。</para>
        /// </param>
        /// <returns>消息报文十六进制字符串。</returns>
        public string ToHexString(string separator = " ")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in GetDatagram())
            {
                sb.Append(item.ToString("X2") + separator);
            }

            List<char> trimCharList = new List<char>(separator.ToCharArray());
            trimCharList.AddRange(new char[] { '0', ' ' });
            return sb.ToString().TrimEnd(trimCharList.ToArray());
        }

        /// <summary>
        /// 获取消息报文字符串。
        /// </summary>
        /// <returns>消息报文字符串。</returns>
        public override string ToString() => Encoding.UTF8.GetString(GetDatagram());
    }
}