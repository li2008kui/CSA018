using System;
using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息头结构体
    /// </summary>
    public struct MessageHead
    {
        /// <summary>
        /// 消息类型
        ///     <para>Byte类型，长度为1个字节</para>
        /// </summary>
        public MessageType Type { get; set; }

        /// <summary>
        /// 消息序号
        ///     <para>UInt32类型，长度为4个字节</para>
        /// </summary>
        public UInt32 SeqNumber { get; set; }

        /// <summary>
        /// 消息体长度
        ///     <para>UInt16类型，长度为2个字节</para>
        /// </summary>
        public UInt16 Length { get; set; }

        /// <summary>
        /// 预留字段
        ///     <para>UInt64类型，长度为5字节</para>
        /// </summary>
        public UInt64 Reserved { get; set; }

        /// <summary>
        /// 消息体CRC32校验
        ///     <para>UInt32类型，长度为4个字节</para>
        /// </summary>
        public UInt32 Crc32 { get; set; }

        /// <summary>
        /// 通过“消息类型”、“消息序号”、“消息体长度”和“消息体CRC32校验”初始化消息头对象实例
        /// </summary>
        /// <param name="type">
        /// 消息类型
        ///     <para>Byte类型，长度为1个字节</para>
        /// </param>
        /// <param name="seqNumber">
        /// 消息序号
        ///     <para>UInt32类型，长度为4个字节</para>
        /// </param>
        /// <param name="length">
        /// 消息体长度
        ///     <para>UInt16类型，长度为2个字节</para>
        /// </param>
        /// <param name="crc32">
        /// 消息体CRC32校验
        ///     <para>UInt32类型，长度为4个字节</para>
        /// </param>
        public MessageHead(MessageType type, UInt16 length, UInt32 seqNumber, UInt32 crc32)
                : this()
        {
            Type = type;
            SeqNumber = seqNumber;
            Length = length;
            Crc32 = crc32;
        }

        /// <summary>
        /// 获取消息头字节数组
        /// </summary>
        /// <returns></returns>
        public Byte[] GetHead()
        {
            List<Byte> mh = new List<byte>();
            mh.Add((Byte)(this.Type));

            for (int i = 24; i >= 0; i -= 8)
            {
                mh.Add((Byte)(this.SeqNumber >> i));
            }

            mh.Add((Byte)(this.Length >> 8));
            mh.Add((Byte)(this.Length));

            for (int j = 0; j < 5; j++)
            {
                mh.Add(0x00);
            }

            for (int k = 24; k >= 0; k -= 8)
            {
                mh.Add((Byte)(this.Crc32 >> k));
            }

            return mh.ToArray();
        }

        /// <summary>
        /// 获取消息头十六进制字符串
        /// </summary>
        /// <param name="separator">
        /// 分隔符
        ///     <para>默认为空字符</para>
        /// </param>
        /// <returns></returns>
        public string ToHexString(string separator = "")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.GetHead())
            {
                sb.Append(item.ToString("X2") + separator);
            }

            return sb.ToString().TrimEnd(separator.ToCharArray());
        }

        /// <summary>
        /// 获取消息头字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Encoding.UTF8.GetString(this.GetHead());
        }
    }
}