using System.Collections.Generic;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 创建消息动作行为类。
    /// </summary>
    public class CreateAction
    {
        /// <summary>
        /// 消息类型。
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// 网关ID。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </summary>
        public uint GatewayId { get; set; }

        /// <summary>
        /// 灯具ID。
        ///     <para>uint类型，长度为4个字节。</para>
        ///     <para>0x00000000为保留地址，对于只需下发到网关的命令可以使用该地址。</para>
        ///     <para>0x00000001~0xFFFFFF00分别对应入网的单灯的具体地址。</para>
        ///     <para>0xFFFFFF01~0xFFFFFF20分别对应回路地址1～32路的地址。</para>
        ///     <para>0xFFFFFF21~0xFFFFFF40分别对应组地址(组号)1～32。</para>
        ///     <para>0xFFFFFF41~0xFFFFFFFE为保留地址。</para>
        ///     <para>0xFFFFFFFF为广播地址，命令将下发到指定网关下的所有灯具设备。</para>
        /// </summary>
        public uint LuminaireId { get; set; }

        /// <summary>
        /// 通过默认构造方法初始化消息动作行为类。
        /// </summary>
        public CreateAction() { }

        /// <summary>
        /// 通过消息类型、网关ID和灯具ID初始化消息动作行为类。
        /// </summary>
        /// <param name="messageType">消息类型。</param>
        /// <param name="gatewayId">
        /// 网关ID。
        ///     <para>uint类型，长度为4个字节。</para>
        ///     <para>“心跳包数据”和“心跳包响应”不需要此参数。</para>
        /// </param>
        /// <param name="luminaireId">
        /// 灯具ID。
        ///     <para>uint类型，长度为4个字节。</para>
        ///     <para>0x00000000为保留地址，对于只需下发到网关的命令可以使用该地址。</para>
        ///     <para>0x00000001~0xFFFFFF00分别对应入网的单灯的具体地址。</para>
        ///     <para>0xFFFFFF01~0xFFFFFF20分别对应回路地址1～32路的地址。</para>
        ///     <para>0xFFFFFF21~0xFFFFFF40分别对应组地址(组号)1～32。</para>
        ///     <para>0xFFFFFF41~0xFFFFFFFE为保留地址。</para>
        ///     <para>0xFFFFFFFF为广播地址，命令将下发到指定网关下的所有灯具设备。</para>
        /// </param>
        public CreateAction(MessageType messageType, uint gatewayId = 0x00000000, uint luminaireId = 0x00000000)
        {
            MessageType = messageType;
            GatewayId = gatewayId;
            LuminaireId = luminaireId;
        }

        /// <summary>
        /// 获取“心跳包数据”报文字节命令。
        /// </summary>
        /// <returns></returns>
        public byte GetHeartbeatDataCommand()
        {
            return 0xFF;
        }

        /// <summary>
        /// 获取“心跳包响应”报文字节命令。
        /// </summary>
        /// <returns></returns>
        public byte GetHeartbeatResponseCommand()
        {
            return 0xFE;
        }

        /// <summary>
        /// 获取“响应”报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <returns></returns>
        public byte[] GetResponseCommand(uint seqNumber)
        {
            // 获取消息头对象。
            MessageHead mh = new MessageHead(MessageType, seqNumber);

            // 返回消息报文字节数组。
            return new Datagram(mh).GetDatagram();
        }

        /// <summary>
        /// 获取“事件和告警响应”响应报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <returns></returns>
        public byte[] GetEventResponseCommand(uint seqNumber)
        {
            return GetResponseCommand(seqNumber);
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字符串类型的“参数值”获取“请求”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字符串类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetRequestCommand(MessageId messageId, ParameterType type, string value)
        {
            return GetRequestCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字节数组类型的“参数值”获取“请求”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字节数组类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetRequestCommand(MessageId messageId, ParameterType type, byte[] value)
        {
            return GetRequestCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字节类型的“参数值”获取“请求”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字节类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetRequestCommand(MessageId messageId, ParameterType type, byte value)
        {
            return GetRequestCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象”获取“请求”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameter">参数结构体对象。</param>
        /// <returns></returns>
        public byte[] GetRequestCommand(MessageId messageId, Parameter parameter)
        {
            return GetRequestCommand(messageId,
                new List<Parameter> {
                    parameter
                }
            );
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象列表”获取“请求”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameterList">参数结构体对象列表。</param>
        /// <returns></returns>
        public byte[] GetRequestCommand(MessageId messageId, List<Parameter> parameterList)
        {
            return GetOperateCommand(messageId, parameterList);
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字符串类型的“参数值”获取“事件或告警”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字符串类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetEventCommand(MessageId messageId, ParameterType type, string value)
        {
            return GetEventCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字节数组类型的“参数值”获取“事件或告警”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字节数组类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetEventCommand(MessageId messageId, ParameterType type, byte[] value)
        {
            return GetEventCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”、“参数类型”和字节类型的“参数值”获取“事件或告警”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字节类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetEventCommand(MessageId messageId, ParameterType type, byte value)
        {
            return GetEventCommand(messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象”获取“事件或告警”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameter">参数结构体对象。</param>
        /// <returns></returns>
        public byte[] GetEventCommand(MessageId messageId, Parameter parameter)
        {
            return GetEventCommand(messageId,
                new List<Parameter> {
                    parameter
                }
            );
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象列表”获取“事件或告警”报文字节数组命令。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameterList">参数结构体对象列表。</param>
        /// <returns></returns>
        public byte[] GetEventCommand(MessageId messageId, List<Parameter> parameterList)
        {
            return GetOperateCommand(messageId, parameterList);
        }

        /// <summary>
        /// 通过“消息序号”、“消息ID”、“参数类型”和字符串类型的“参数值”获取“结果”报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字符串类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetResultCommand(uint seqNumber, MessageId messageId, ParameterType type, string value)
        {
            return GetResultCommand(seqNumber, messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息序号”、“消息ID”、“参数类型”和字节数组类型的“参数值”获取“结果”报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字节数组类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetResultCommand(uint seqNumber, MessageId messageId, ParameterType type, byte[] value)
        {
            return GetResultCommand(seqNumber, messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息序号”、“消息ID”、“参数类型”和字节类型的“参数值”获取“结果”报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="type">参数的类型枚举值。</param>
        /// <param name="value">字节类型的参数值。</param>
        /// <returns></returns>
        public byte[] GetResultCommand(uint seqNumber, MessageId messageId, ParameterType type, byte value)
        {
            return GetResultCommand(seqNumber, messageId,
                new Parameter(type, value)
            );
        }

        /// <summary>
        /// 通过“消息序号”、“消息ID”和“参数结构体对象”获取“结果”报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameter">参数结构体对象。</param>
        /// <returns></returns>
        public byte[] GetResultCommand(uint seqNumber, MessageId messageId, Parameter parameter)
        {
            return GetResultCommand(seqNumber, messageId,
                new List<Parameter> {
                    parameter
                }
            );
        }

        /// <summary>
        /// 通过“消息序号”、“消息ID”和“参数结构体对象列表”获取“结果”报文字节数组命令。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameterList">参数结构体对象列表。</param>
        /// <returns></returns>
        public byte[] GetResultCommand(uint seqNumber, MessageId messageId, List<Parameter> parameterList)
        {
            return GetOperateCommand(seqNumber, messageId, parameterList);
        }

        /// <summary>
        /// 通过“消息ID”和“参数结构体对象列表”执行操作。
        /// </summary>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameterList">参数结构体对象列表。</param>
        /// <returns></returns>
        private byte[] GetOperateCommand(MessageId messageId, List<Parameter> parameterList)
        {
            // 获取消息体对象。
            MessageBody mb = new MessageBody(
                messageId,
                GatewayId,
                LuminaireId,
                parameterList);

            // 获取消息体字节数组。
            byte[] msgBody = mb.GetBody();

            // 获取消息头对象。
            MessageHead mh = new MessageHead(
                MessageType,
                (ushort)(msgBody.Length),
                Crc32.GetCrc32(msgBody));

            // 返回消息报文字节数组。
            return new Datagram(mh, mb).GetDatagram();
        }

        /// <summary>
        /// 通过“消息序号”、“消息ID”和“参数结构体对象列表”执行操作，该命令用于结果类型的消息。
        /// </summary>
        /// <param name="seqNumber">
        /// 消息序号。
        ///     <para>uint类型，长度为4个字节。</para>
        /// </param>
        /// <param name="messageId">
        /// 消息ID。
        ///     <para>UInt16类型，长度为2个字节。</para>
        /// </param>
        /// <param name="parameterList">参数结构体对象列表。</param>
        /// <returns></returns>
        private byte[] GetOperateCommand(uint seqNumber, MessageId messageId, List<Parameter> parameterList)
        {
            // 获取消息体对象。
            MessageBody mb = new MessageBody(
                messageId,
                GatewayId,
                LuminaireId,
                parameterList);

            // 获取消息体字节数组。
            byte[] msgBody = mb.GetBody();

            // 获取消息头对象。
            MessageHead mh = new MessageHead(
                MessageType,
                seqNumber,
                (ushort)(msgBody.Length),
                Crc32.GetCrc32(msgBody));

            // 返回消息报文字节数组。
            return new Datagram(mh, mb).GetDatagram();
        }
    }
}