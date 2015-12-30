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
        ///     <para>“心跳包数据”和“心跳包响应”不需要此参数</para>
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
        public OperateAction(MessageType messageType, uint gatewayId = 0x00000000, uint luminaireId = 0x00000000)
            : base(messageType, gatewayId, luminaireId)
        { }

        /// <summary>
        /// 获取心跳包数据报文字节数组
        ///     <para>用于获取“心跳包数据”和“心跳包响应”字节数组</para>
        /// </summary>
        /// <returns></returns>
        public byte[] GetOperateCommand()
        {
            // 获取消息头对象
            MessageHead mh = new MessageHead(MessageType);

            // 返回消息报文字节数组
            return new Datagram(mh).GetDatagram();
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象”执行操作
        /// </summary>
        /// <param name="messageId">
        /// 消息ID
        ///     <para>UInt16类型，长度为2个字节</para>
        /// </param>
        /// <param name="parameter">参数结构体对象</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, Parameter parameter)
        {
            return GetOperateCommand(messageId,
                new List<Parameter> {
                    parameter
                }
            );
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象列表”执行操作
        /// </summary>
        /// <param name="messageId">
        /// 消息ID
        ///     <para>UInt16类型，长度为2个字节</para>
        /// </param>
        /// <param name="parameterList">参数结构体对象列表</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, List<Parameter> parameterList)
        {
            // 获取消息体对象
            MessageBody mb = new MessageBody(
                messageId,
                GatewayId,
                LuminaireId,
                parameterList);

            // 获取消息体字节数组
            byte[] msgBody = mb.GetBody();

            // 获取消息头对象
            MessageHead mh = new MessageHead(
                MessageType,
                Sequencer.Instance.SeqNumber++,
                (ushort)(msgBody.Length),
                Crc32.GetCrc32(msgBody));

            // 返回消息报文字节数组
            return new Datagram(mh, mb).GetDatagram();
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字符串类型的“参数值”执行操作
        /// </summary>
        /// <param name="messageId">
        /// 消息ID
        ///     <para>UInt16类型，长度为2个字节</para>
        /// </param>
        /// <param name="type">参数的类型枚举值</param>
        /// <param name="value">字符串类型的参数值</param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, ParameterType type, string value)
        {
            return GetOperateCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 获取响应数据报文字节数组
        ///     <para>用于获取“命令响应”和“事件和告警响应”字节数组</para>
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号
        ///     <para>uint类型，长度为4个字节</para>
        /// </param>
        /// <returns></returns>
        public byte[] GetOperateCommand(uint seqNumber)
        {
            // 获取消息头对象
            MessageHead mh = new MessageHead(MessageType);

            // 设置消息序号
            mh.SeqNumber = seqNumber;

            // 返回消息报文字节数组
            return new Datagram(mh).GetDatagram();
        }

        /// <summary>
        /// 获取命令执行结果数据报文字节数组
        ///     <para>用于获取“命令执行结果”字节数组</para>
        /// </summary>
        /// <param name="messageId">
        /// 消息ID
        ///     <para>UInt16类型，长度为2个字节</para>
        /// </param>
        /// <param name="errorCode">
        /// 错误代码
        ///     <para>uint类型，长度为4个字节</para>
        ///     <para>可选字段，对“命令结果”类型的消息有效。</para>
        /// </param>
        /// <param name="errorInfo">
        /// 错误信息
        ///     <para>string类型，长度可变</para>
        ///     <para>可选字段，对“命令结果”类型的消息有效。</para>
        /// </param>
        /// <returns></returns>
        public byte[] GetOperateCommand(MessageId messageId, uint errorCode, string errorInfo = null)
        {
            // 获取消息体对象
            MessageBody mb = new MessageBody(
                messageId,
                GatewayId,
                LuminaireId,
                errorCode,
                errorInfo);

            // 获取消息体字节数组
            byte[] msgBody = mb.GetBody();

            // 获取消息头对象
            MessageHead mh = new MessageHead(
                MessageType,
                Sequencer.Instance.SeqNumber++,
                (ushort)(msgBody.Length),
                Crc32.GetCrc32(msgBody));

            // 返回消息报文字节数组
            return new Datagram(mh, mb).GetDatagram();
        }
    }
}