namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息类型枚举
    /// </summary>
    public enum MessageType : byte
    {
        /// <summary>
        /// 命令请求
        /// </summary>
        Request = 0x01,

        /// <summary>
        /// 命令响应
        /// </summary>
        Response = 0x02,

        /// <summary>
        /// 事件和告警
        /// </summary>
        Event = 0x03,

        /// <summary>
        /// 事件和告警响应
        /// </summary>
        EventResp = 0x04,

        /// <summary>
        /// 命令结果
        /// </summary>
        Result = 0x05
    }
}