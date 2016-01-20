using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 参数结构体。
    /// </summary>
    public struct Parameter
    {
        /// <summary>
        /// 参数类型。
        /// <para><see cref="ParameterType"/>类型，长度为2个字节。</para>
        /// </summary>
        public ParameterType Type { get; set; }

        /// <summary>
        /// 参数值。
        /// <para>string类型，长度可变。</para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 参数值结束符。
        /// <para>只读属性。</para>
        /// <para>值为0x00。</para>
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
        /// 通过“参数类型”和字符串类型的“参数值”初始化参数对象实例。
        /// </summary>
        /// <param name="type">
        /// 参数类型。
        /// <para><see cref="ParameterType"/>类型，长度为2个字节。</para>
        /// </param>
        /// <param name="value">字符串类型的参数值。</param>
        public Parameter(ParameterType type, string value)
            : this()
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// 通过“参数类型”和字节数组类型的“参数值”初始化参数对象实例。
        /// </summary>
        /// <param name="type">
        /// 参数类型。
        /// <para><see cref="ParameterType"/>类型，长度为2个字节。</para>
        /// </param>
        /// <param name="value">字节数组类型的参数值。</param>
        public Parameter(ParameterType type, byte[] value)
            : this(type, Encoding.UTF8.GetString(value))
        { }

        /// <summary>
        /// 通过“参数类型”和字节类型的“参数值”初始化参数对象实例。
        /// </summary>
        /// <param name="type">
        /// 参数类型。
        /// <para><see cref="ParameterType"/>类型，长度为2个字节。</para>
        /// </param>
        /// <param name="value">字节类型的参数值。</param>
        public Parameter(ParameterType type, byte value)
            : this(type, new byte[] { value })
        { }

        /// <summary>
        /// 获取参数字节数组。
        /// </summary>
        /// <returns></returns>
        public byte[] GetParameter()
        {
            List<byte> pmt = new List<byte> {
                (byte)((ushort)(Type) >> 8),
                (byte)(Type)
            };

            if (!Value.IsNullOrEmpty())
            {
                pmt.AddRange(Value.ToByteArray());
            }

            pmt.Add(0x00);
            return pmt.ToArray();
        }

        /// <summary>
        /// 获取参数对象列表。
        /// </summary>
        /// <param name="byteArray">消息报文字节数组。</param>
        /// <param name="index">数组索引。</param>
        /// <param name="pmtList">参数对象列表。</param>
        internal static void GetParameterList(byte[] byteArray, int index, ref List<Parameter> pmtList)
        {
            if (byteArray.Length > index + 2)
            {
                Parameter parameter = new Parameter(); ;
                List<byte> byteList = new List<byte>();

                parameter.Type = (ParameterType)((byteArray[index] << 8) + byteArray[index + 1]);
                byte indexByte = byteArray[index + 2];

                while (indexByte != 0x00)
                {
                    byteList.Add(indexByte);
                    index++;
                    indexByte = byteArray[index + 2];
                }

                parameter.Value = byteList.ToArray().ToString2();
                pmtList.Add(parameter);

                GetParameterList(byteArray, index + 3, ref pmtList);
            }
        }

        /// <summary>
        /// 获取参数十六进制字符串。
        /// </summary>
        /// <param name="separator">
        /// 分隔符。
        /// <para>默认为空字符。</para>
        /// </param>
        /// <returns></returns>
        public string ToHexString(string separator = " ")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in GetParameter())
            {
                sb.Append(item.ToString("X2") + separator);
            }

            List<char> trimCharList = new List<char>(separator.ToCharArray());
            trimCharList.AddRange(new char[] { '0', ' ' });
            return sb.ToString().TrimEnd(trimCharList.ToArray());
        }

        /// <summary>
        /// 获取参数字符串。
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Encoding.UTF8.GetString(GetParameter());
    }
}