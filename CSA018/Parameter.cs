using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 参数结构体
    /// </summary>
    public struct Parameter
    {
        /// <summary>
        /// 参数类型
        ///     <para>ushort类型，长度为2个字节</para>
        /// </summary>
        public ParameterType Type { get; set; }

        /// <summary>
        /// 参数值
        ///     <para>字符串类型，长度可变</para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 参数值结束符
        ///     <para>只读属性</para>
        ///     <para>值为0x00</para>
        /// </summary>
        public byte End
        {
            get
            {
                return 0x00;
            }
            set { }
        }

        /// <summary>
        /// 通过“参数类型”和“参数值”初始化参数对象实例
        /// </summary>
        /// <param name="type">
        /// 参数类型
        ///     <para>ushort类型，长度为2个字节</para>
        /// </param>
        /// <param name="value">参数值</param>
        public Parameter(ParameterType type, string value)
            : this()
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// 获取参数字节数组
        /// </summary>
        /// <returns></returns>
        public byte[] GetParameter()
        {
            List<byte> pmt = new List<byte> {
                (byte)((ushort)(this.Type) >> 8),
                (byte)(this.Type)
            };

            if (this.Value != null && this.Value.Length > 0)
            {
                List<byte> byteValueList = new List<byte>(Encoding.UTF8.GetBytes(this.Value));
                pmt.AddRange(byteValueList);
            }

            pmt.Add(0x00);
            return pmt.ToArray();
        }

        /// <summary>
        /// 获取参数十六进制字符串
        /// </summary>
        /// <param name="separator">
        /// 分隔符
        ///     <para>默认为空字符</para>
        /// </param>
        /// <returns></returns>
        public string ToHexString(string separator = "")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.GetParameter())
            {
                sb.Append(item.ToString("X2") + separator);
            }

            return sb.ToString().TrimEnd(separator.ToCharArray());
        }

        /// <summary>
        /// 获取参数字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Encoding.UTF8.GetString(this.GetParameter());
        }
    }
}