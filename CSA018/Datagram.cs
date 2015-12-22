using System;
using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 报文结构体
    /// </summary>
    public struct Datagram
    {
        /// <summary>
        /// 起始符
        ///     <para>只读属性</para>
        ///     <para>值为0x02</para>
        /// </summary>
        public byte Stx
        {
            get
            {
                return 0x02;
            }
            private set { }
        }

        /// <summary>
        /// 消息头
        ///     <para>长度为16字节</para>
        /// </summary>
        public MessageHead Head { get; set; }

        /// <summary>
        /// 消息体
        ///     <para>长度可变</para>
        /// </summary>
        public MessageBody Body { get; set; }

        /// <summary>
        /// 结束符
        ///     <para>只读属性</para>
        ///     <para>值为0x03</para>
        /// </summary>
        public byte Etx
        {
            get
            {
                return 0x03;
            }
            private set { }
        }

        /// <summary>
        /// 通过消息头和消息体初始化报文对象实例
        /// </summary>
        /// <param name="head">
        /// 消息头
        ///     <para>长度为16字节</para>
        /// </param>
        /// <param name="body">
        /// 消息体
        ///     <para>长度可变</para>
        /// </param>
        public Datagram(MessageHead head, MessageBody body)
            : this()
        {
            Head = head;
            Body = body;
        }

        /// <summary>
        /// 获取消息报文字节数组
        /// </summary>
        /// <returns></returns>
        public byte[] GetDatagram()
        {
            List<byte> dg = new List<byte> { Stx };

            byte[] head = Head.GetHead();
            byte[] body = Body.GetBody();

            dg.AddRange(Escaping(head));
            dg.AddRange(Escaping(body));

            dg.Add(Etx);

            return dg.ToArray();
        }

        /// <summary>
        /// 获取消息报文对象列表
        /// </summary>
        /// <param name="dataArray">消息报文字节数组</param>
        /// <param name="isTcpOrUdp">报文承载方式是否是TCP或UDP，默认为false</param>
        /// <param name="isCheckCrc">是否校验CRC</param>
        /// <returns></returns>
        public static List<Datagram> GetDatagramList(byte[] dataArray, bool isTcpOrUdp = false, bool isCheckCrc = true)
        {
            if (dataArray.Length < 26)
            {
                throw new CsaException("消息解析错误。", ErrorCode.MessageParseError);
            }

            List<byte[]> newByteArrayList;

            if (!isTcpOrUdp)
            {
                List<byte[]> byteArrayList = new List<byte[]>();
                GetByteArrayList(dataArray, 0, ref byteArrayList);
                newByteArrayList = Descaping(byteArrayList);
            }
            else
            {
                newByteArrayList = new List<byte[]> { dataArray };
            }

            MessageHead mh = new MessageHead();
            MessageBody mb = new MessageBody();
            Datagram d = new Datagram();
            List<Datagram> datagramList = new List<Datagram>();

            foreach (var byteArray in newByteArrayList)
            {
                if (!Enum.IsDefined(typeof(MessageType), byteArray[0]))
                {
                    throw new CsaException("参数类型未定义。", ErrorCode.ParameterTypeUndefined);
                }

                mh.Type = (MessageType)byteArray[0];
                mh.SeqNumber = (uint)((byteArray[1] << 24) + (byteArray[2] << 16) + (byteArray[3] << 8) + byteArray[4]);
                mh.Length = (ushort)((byteArray[5] << 8) + byteArray[6]);
                mh.Reserved = (ulong)((byteArray[7] << 32) + (byteArray[8] << 24) + (byteArray[9] << 16) + (byteArray[10] << 8) + byteArray[11]);
                mh.Crc32 = (uint)((byteArray[12] << 24) + (byteArray[13] << 16) + (byteArray[14] << 8) + byteArray[15]);

                if (!Enum.IsDefined(typeof(MessageId), (ushort)((byteArray[16] << 8) + byteArray[17])))
                {
                    throw new CsaException("消息ID未定义。", ErrorCode.MessageIdUndefined);
                }

                mb.MessageId = (MessageId)((byteArray[16] << 8) + byteArray[17]);
                mb.GatewayId = ((uint)byteArray[18] << 24) + ((uint)byteArray[19] << 16) + ((uint)byteArray[20] << 8) + byteArray[21];
                mb.LuminaireId = ((uint)byteArray[22] << 24) + ((uint)byteArray[23] << 16) + ((uint)byteArray[24] << 8) + byteArray[25];

                List<Parameter> pmtList = new List<Parameter>();
                Parameter.GetParameterList(byteArray, 26, ref pmtList);

                if (pmtList.Count > 0)
                {
                    mb.ParameterList = pmtList;

                    if (isCheckCrc && Crc32.GetCrc32(mb.GetBody()) != mh.Crc32)
                    {
                        throw new CsaException("消息体CRC校验错误。", ErrorCode.ChecksumError);
                    }
                }
                else
                {
                    throw new CsaException("参数格式错误。", ErrorCode.ParameterFormatError);
                }

                d.Head = mh;
                d.Body = mb;
                datagramList.Add(d);
            }

            return datagramList;
        }

        /// <summary>
        /// 转义特殊字符
        ///     <para>STX转义为ESC和0xE7，即02->1BE7</para>
        ///     <para>ETX转义为ESC和0xE8，即03->1BE8</para>
        ///     <para>ESC转义为ESC和0x00，即1B->1B00</para>
        /// </summary>
        /// <param name="byteArray">消息报文字节数组</param>
        /// <returns></returns>
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
        /// 去除转义特殊字符
        /// </summary>
        /// <param name="byteArray">原消息报文字节数组</param>
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
        /// 去除转义特殊字符
        /// </summary>
        /// <param name="byteArrayList">原消息报文字节数组列表</param>
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
        /// 获取消息报文字节数组列表
        ///     <para>此列表中的消息报文字节数组不包含起止符。</para>
        /// </summary>
        /// <param name="dataArray">消息报文字节数组</param>
        /// <param name="index">数组索引</param>
        /// <param name="byteArrayList">消息报文字节数组列表</param>
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
        /// 获取消息报文十六进制字符串
        /// </summary>
        /// <param name="separator">
        /// 分隔符
        ///     <para>默认为空字符</para>
        /// </param>
        /// <returns></returns>
        public string ToHexString(string separator = "")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in GetDatagram())
            {
                sb.Append(item.ToString("X2") + separator);
            }

            return sb.ToString().TrimEnd(separator.ToCharArray());
        }

        /// <summary>
        /// 获取消息报文字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Encoding.UTF8.GetString(GetDatagram());
        }
    }
}