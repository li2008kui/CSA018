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
        ///     <para>byte类型列表，长度可变。</para>
        ///     <para>具体使用时可能需要转换为字符串类型。</para>
        /// </summary>
        public List<byte> Value { get; set; }

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
        /// 通过“参数类型”和字节列表类型的“参数值”初始化参数对象实例
        /// </summary>
        /// <param name="type">
        /// 参数类型
        ///     <para>ushort类型，长度为2个字节</para>
        /// </param>
        /// <param name="value">字节列表类型的参数值</param>
        public Parameter(ParameterType type, List<byte> value)
            : this()
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// 通过“参数类型”和字符串类型的“参数值”初始化参数对象实例
        /// </summary>
        /// <param name="type">
        /// 参数类型
        ///     <para>ushort类型，长度为2个字节</para>
        /// </param>
        /// <param name="value">字符串类型的参数值</param>
        public Parameter(ParameterType type, string value)
            : this()
        {
            Type = type;
            Value = new List<byte>(Encoding.UTF8.GetBytes(value));
        }

        /// <summary>
        /// 获取参数字节数组
        /// </summary>
        /// <returns></returns>
        public byte[] GetParameter()
        {
            List<byte> pmt = new List<byte> {
                (byte)((ushort)(Type) >> 8),
                (byte)(Type)
            };

            if (Value != null && Value.Count > 0)
            {
                pmt.AddRange(Value);
            }

            pmt.Add(0x00);
            return pmt.ToArray();
        }

        /// <summary>
        /// 获取参数对象列表
        /// </summary>
        /// <param name="byteArray">消息报文字节数组</param>
        /// <param name="index">数组索引</param>
        /// <param name="pmtList">参数对象列表</param>
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

                parameter.Value = byteList;
                pmtList.Add(parameter);

                GetParameterList(byteArray, index + 3, ref pmtList);
            }
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

            foreach (var item in GetParameter())
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
            return Encoding.UTF8.GetString(GetParameter());
        }
    }
}