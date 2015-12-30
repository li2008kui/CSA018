namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息报文处理委托
    /// </summary>
    /// <param name="sender">动作行为类</param>
    /// <param name="e">消息报文事件参数</param>
    public delegate void DatagramProcessHandler(object sender, DatagramEventArgs e);

    /// <summary>
    /// 动作行为抽象基类
    ///     <para>只能通过OperateAction操作动作行为类创建实例对象</para>
    /// </summary>
    public abstract class CsaAction
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// 网关ID
        ///     <para>uint类型，长度为4个字节</para>
        /// </summary>
        public uint GatewayId { get; set; }

        /// <summary>
        /// 灯具ID
        ///     <para>uint类型，长度为4个字节</para>
        ///     <para>0x00000000为保留地址，对于只需下发到网关的命令可以使用该地址，</para>
        ///     <para>0x00000001~0xFFFFFF00分别对应入网的单灯的具体地址，</para>
        ///     <para>0xFFFFFF01~0xFFFFFF20分别对应回路地址1～32路的地址，</para>
        ///     <para>0xFFFFFF21~0xFFFFFF40分别对应组地址(组号)1～32，</para>
        ///     <para>0xFFFFFF41~0xFFFFFFFE为保留地址，</para>
        ///     <para>0xFFFFFFFF为广播地址，命令将下发到指定网关下的所有灯具设备。</para>
        /// </summary>
        public uint LuminaireId { get; set; }

        /// <summary>
        /// 通过消息类型、网关ID和灯具ID初始化动作行为类
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
        protected CsaAction(MessageType messageType, uint gatewayId = 0x00000000, uint luminaireId = 0x00000000)
        {
            MessageType = messageType;
            GatewayId = gatewayId;
            LuminaireId = luminaireId;
        }

        /// <summary>
        /// 消息报文处理事件
        /// </summary>
        public event DatagramProcessHandler DatagramProcess;

        /// <summary>
        /// 触发消息报文的处理事件
        /// </summary>
        /// <param name="e">消息报文事件参数</param>
        public virtual void OnDatagramProcess(DatagramEventArgs e)
        {
            if (DatagramProcess != null)
            {
                DatagramProcess(this, e);
            }
        }
    }
}