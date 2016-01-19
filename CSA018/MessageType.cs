namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息类型枚举。
    /// </summary>
    public enum MessageType : byte
    {
        /// <summary>
        /// 命令请求。
        /// <para>服务器 &lt;--&gt; 网关。</para>
        /// </summary>
        Command = 0x01,

        /// <summary>
        /// 命令响应。
        /// <para>服务器 &lt;--&gt; 网关。</para>
        /// <para>该类型的命令没有消息体。</para>
        /// </summary>
        CommandACK = 0x02,

        /// <summary>
        /// 事件和告警。
        /// <para>服务器 &lt;-- 网关。</para>
        /// </summary>
        Event = 0x03,

        /// <summary>
        /// 事件和告警响应。
        /// <para>服务器 --&gt; 网关。</para>
        /// <para>该类型的命令没有消息体。</para>
        /// </summary>
        EventACK = 0x04,

        /// <summary>
        /// 命令结果。
        /// <para>服务器 &lt;--&gt; 网关。</para>
        /// <para>备注：该类型的消息中，消息体的参数部分未按照“参数类型”、“参数值”和“参数结束符”的形式定义，</para>
        /// <para>而只是将“错误代码”和“错误信息”直接放到消息体中。</para>
        /// </summary>
        CommandResult = 0x05,

        /// <summary>
        /// 心跳包数据。
        /// <para>服务器 &lt;--&gt; 网关。</para>
        /// <para>该枚举值无实际意义，但可用其值直接表示报文数据。</para>
        /// </summary>
        HeartbeatData = 0xFF,

        /// <summary>
        /// 心跳包响应。
        /// <para>服务器 &lt;--&gt; 网关。</para>
        /// <para>该枚举值无实际意义，但可用其值直接表示报文数据。</para>
        /// </summary>
        HeartbeatResponse = 0xFE,
    }
}