namespace ThisCoder.CSA018
{
    /// <summary>
    /// 错误代码。
    /// <para>uint类型，长度为4个字节。</para>
    /// </summary>
    public enum ErrorCode : uint
    {
        #region 系统保留(0000~0099和9999)
        /// <summary>
        /// 成功。
        /// </summary>
        Succeed = 0x30303030,

        /// <summary>
        /// 消息解析错误。
        /// </summary>
        MessageParseError = 0x30303031,

        /// <summary>
        /// 校验和错误。
        /// </summary>
        ChecksumError = 0x30303032,

        /// <summary>
        /// 消息ID未定义。
        /// </summary>
        MessageIdUndefined = 0x30303033,

        /// <summary>
        /// 命令暂时不能执行。
        /// </summary>
        NotExecuted = 0x30303034,

        /// <summary>
        /// 参数个数错误。
        /// </summary>
        ParameterCountError = 0x30303035,

        /// <summary>
        /// 参数格式错误。
        /// </summary>
        ParameterFormatError = 0x30303036,

        /// <summary>
        /// 参数范围错误。
        /// </summary>
        ParameterScopeError = 0x30303037,

        /// <summary>
        /// 参数类型未定义。
        /// </summary>
        ParameterTypeUndefined = 0x30303038,

        /// <summary>
        /// 未知错误。
        /// </summary>
        Unknown = 0x39393939,
        #endregion

        #region 厂商自定义(0100~9998)
        /// <summary>
        /// 不支持该消息类型。
        /// </summary>
        NotSupportedMessageType = 0x30313030,

        /// <summary>
        /// 网关ID不存在。
        /// </summary>
        NoExistsGatewayId = 0x30313031,

        /// <summary>
        /// 序列号不存在。
        /// </summary>
        NoExistsSerialNumber = 0x30313032,

        /// <summary>
        /// 安全验证码错误。
        /// </summary>
        AccessCodeError = 0x30313033,

        /// <summary>
        /// 网关尚未完成初始化。
        /// </summary>
        NoInitialized = 0x30313034,

        /// <summary>
        /// 网关尚未完成入网控制。
        /// </summary>
        NoAuthorized = 0x30313035,

        /// <summary>
        /// 网关已经完成入网控制。
        /// <para>无需重复进行入网控制操作。</para>
        /// </summary>
        IsAuthorized = 0x30313036,

        /// <summary>
        /// 网关不在线。
        /// </summary>
        Offline = 0x30313037,

        /// <summary>
        /// 命令超时。
        /// </summary>
        CommandTimeout = 0x30313038,
        #endregion
    }
}