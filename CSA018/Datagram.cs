using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<byte> dg = new List<byte> { this.Stx };

            byte[] head = this.Head.GetHead();
            byte[] body = this.Body.GetBody();

            dg.AddRange(Escaping(head));
            dg.AddRange(Escaping(body));

            dg.Add(this.Etx);

            return dg.ToArray();
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
        /// <param name="byteArrayList">原消息报文字节数组列表</param>
        /// <param name="newbyteArrayList">新消息报文字节数组列表</param>
        private static void Descaping(List<byte[]> byteArrayList, ref List<byte[]> newByteArrayList)
        {
            List<byte> byteList;

            foreach (var item in byteArrayList)
            {
                byteList = new List<byte>();

                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == 0x1B)
                    {
                        if (i + 1 < item.Length)
                        {
                            switch (item[i + 1])
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
                                    byteList.Add(item[i + 1]);
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
                        byteList.Add(item[i]);
                    }
                }

                newByteArrayList.Add(byteList.ToArray());
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

            foreach (var item in this.GetDatagram())
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
            return Encoding.UTF8.GetString(this.GetDatagram());
        }
    }
}