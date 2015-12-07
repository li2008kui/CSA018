using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息体结构体
    /// </summary>
    public struct MessageBody
    {
        /// <summary>
        /// 消息ID
        ///     <para>ushort类型，长度为2个字节</para>
        /// </summary>
        public MessageId MessageId { get; set; }

        /// <summary>
        /// 网关ID
        ///     <para>uint类型，长度为4个字节</para>
        /// </summary>
        public uint GatewayId { get; set; }

        /// <summary>
        /// 灯具ID
        ///     <para>uint类型，长度为4个字节</para>
        /// </summary>
        public uint LampId { get; set; }

        /// <summary>
        /// 参数列表
        ///     <para>长度可变</para>
        /// </summary>
        public List<Parameter> ParameterList { get; set; }

        /// <summary>
        /// 通过“消息ID”、“网关ID”、“灯具ID”和“参数列表”初始化消息体对象实例
        /// </summary>
        /// <param name="messageId">
        /// 消息ID
        ///     <para>ushort类型，长度为2个字节</para>
        /// </param>
        /// <param name="gatewayId">
        /// 设备ID
        ///     <para>uint类型，长度为4个字节</para>
        /// </param>
        /// <param name="lampId">
        /// 设备ID
        ///     <para>uint类型，长度为4个字节</para>
        /// </param>
        /// <param name="parameterList">
        /// 参数列表
        ///     <para>长度可变</para>
        /// </param>
        public MessageBody(MessageId messageId, uint gatewayId, uint lampId, List<Parameter> parameterList)
            : this()
        {
            MessageId = messageId;
            GatewayId = gatewayId;
            LampId = lampId;
            ParameterList = parameterList;
        }

        /// <summary>
        /// 获取消息体字节数组
        /// </summary>
        /// <returns></returns>
        public byte[] GetBody()
        {
            List<byte> mb = new List<byte>{
                (byte)((ushort)(MessageId) >> 8),
                (byte)(MessageId)
            };

            for (int i = 24; i >= 0; i -= 8)
            {
                mb.Add((byte)(GatewayId >> i));
            }

            for (int j = 24; j >= 0; j -= 8)
            {
                mb.Add((byte)(LampId >> j));
            }

            foreach (var pmt in ParameterList ?? new List<Parameter>())
            {
                mb.AddRange(pmt.GetParameter());
            }

            return mb.ToArray();
        }

        /// <summary>
        /// 获取消息体十六进制字符串
        /// </summary>
        /// <param name="separator">
        /// 分隔符
        ///     <para>默认为空字符</para>
        /// </param>
        /// <returns></returns>
        public string ToHexString(string separator = "")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in GetBody())
            {
                sb.Append(item.ToString("X2") + separator);
            }

            return sb.ToString().TrimEnd(separator.ToCharArray());
        }

        /// <summary>
        /// 获取消息体字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Encoding.UTF8.GetString(GetBody());
        }
    }
}