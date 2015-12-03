namespace ThisCoder.CSA018
{
    /// <summary>
    /// 错误代码
    /// </summary>
    public enum ErrorCode : uint
    {
        #region 系统保留(0~99和9999)
        /// <summary>
        /// 成功
        /// </summary>
        Succeed = 0,

        /// <summary>
        /// 消息解析错误
        /// </summary>
        MessageParseError = 1,

        /// <summary>
        /// 校验和错误
        /// </summary>
        ChecksumError = 2,

        /// <summary>
        /// 消息ID未定义
        /// </summary>
        MessageIdUndefined = 3,

        /// <summary>
        /// 命令暂时不能执行
        /// </summary>
        NotExecuted = 4,

        /// <summary>
        /// 参数个数错误
        /// </summary>
        ParameterCountError = 5,

        /// <summary>
        /// 参数格式错误
        /// </summary>
        ParameterFormatError = 6,

        /// <summary>
        /// 参数范围错误
        /// </summary>
        ParameterScopeError = 7,

        /// <summary>
        /// 参数类型未定义
        /// </summary>
        ParameterTypeUndefined = 8,

        /// <summary>
        /// 未知错误
        /// </summary>
        Unknown = 9999,
        #endregion

        #region 厂商自定义(100~9998)

        #endregion
    }
}