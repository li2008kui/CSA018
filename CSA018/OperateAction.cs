using System.Collections.Generic;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 操作动作行为类
    /// </summary>
    public class OperateAction : CsaAction
    {
        /// <summary>
        /// 通过消息类型、网关ID和灯具ID初始化操作动作行为类
        /// </summary>
        /// <param name="messageType">消息类型</param>
        /// <param name="gatewayId">
        /// 网关ID
        ///     <para>uint类型，长度为4个字节</para>
        /// </param>
        /// <param name="luminaireId">
        /// 灯具ID
        ///     <para>uint类型，长度为4个字节</para>
        ///     <para>0x00000000为保留地址，对于只需下发到网关的命令可以使用该地址，</para>
        ///     <para>0x00000001~0xFFFFFF00分别对应入网的单灯的具体地址，</para>
        ///     <para>0xFFFFFF01~0xFFFFFF20分别对应回路地址1～32路的地址，</para>
        ///     <para>0xFFFFFF21~0xFFFFFF40分别对应组地址(组号)1～32，</para>
        ///     <para>0xFFFFFF41~0xFFFFFFFE为保留地址，</para>
        ///     <para>0xFFFFFFFF为广播地址，命令将下发到指定网关下的所有灯具设备。</para>
        /// </param>
        public OperateAction(MessageType messageType, uint gatewayId, uint luminaireId = 0x00000000)
            : base(messageType, gatewayId, luminaireId)
        { }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象列表”执行操作
        /// </summary>
        /// <param name="messageId">消息ID的枚举值</param>
        /// <param name="parameterList">参数结构体对象列表</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, List<Parameter> parameterList)
        {
            return GetDatagram(messageId, parameterList);
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象”执行操作
        /// </summary>
        /// <param name="messageId">消息ID的枚举值</param>
        /// <param name="parameter">参数结构体对象</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, Parameter parameter)
        {
            return GetDatagram(messageId, parameter);
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和“参数值字节列表”执行操作
        /// </summary>
        /// <param name="messageId">消息ID的枚举值</param>
        /// <param name="type">参数的类型枚举值</param>
        /// <param name="value">参数值字节列表</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, ParameterType type, List<byte> value)
        {
            return GetOperateCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和byte类型的“参数值”执行操作
        /// </summary>
        /// <param name="messageId">消息ID的枚举值</param>
        /// <param name="type">参数的类型枚举值</param>
        /// <param name="value">byte类型的参数值</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, ParameterType type, byte value)
        {
            return GetOperateCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和byte数组类型的“参数值”执行操作
        /// </summary>
        /// <param name="messageId">消息ID的枚举值</param>
        /// <param name="type">参数的类型枚举值</param>
        /// <param name="value">byte数组类型的参数值</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, ParameterType type, byte[] value)
        {
            return GetOperateCommand(messageId,
                new Parameter(
                    type,
                    new List<byte>(value)
                )
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字符串类型的“参数值”执行操作
        /// </summary>
        /// <param name="messageId">消息ID的枚举值</param>
        /// <param name="type">参数的类型枚举值</param>
        /// <param name="value">字符串类型的参数值</param>
        /// <param name="isHex">该字符串是否是十六进制形式,默认为false。</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, ParameterType type, string value, bool isHex = false)
        {
            return GetOperateCommand(messageId,
                new Parameter(type, value, isHex)
            );
        }
    }
}