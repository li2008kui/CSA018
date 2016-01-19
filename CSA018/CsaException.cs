using System;
using System.Runtime.Serialization;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 发生非致命应用程序错误时引发的自定义异常。
    /// </summary>
    [Serializable]
    public class CsaException : ApplicationException
    {
        /// <summary>
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </summary>
        public ErrorCode Code { get; private set; }

        /// <summary>
        /// 初始化 AirException 类的新实例。
        /// </summary>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(ErrorCode code = ErrorCode.Succeed)
            : base()
        {
            Code = code;
        }

        /// <summary>
        /// 使用指定错误消息初始化 AirException 类的新实例。
        /// </summary>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(string message, ErrorCode code = ErrorCode.Succeed)
            : base(message)
        {
            Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the AirException class with
        /// serialized data.
        /// </summary>
        /// <param name="info">保存序列化对象数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(SerializationInfo info, StreamingContext context, ErrorCode code = ErrorCode.Succeed)
            : base(info, context)
        {
            Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the AirException class with
        /// a specified error message and a reference to the inner exception that is
        /// the cause of this exception.
        /// </summary>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <param name="innerException">导致当前异常的异常。如果 innerException 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。</param>
        /// <param name="code">
        /// 错误代码。
        /// <para><see cref="ErrorCode"/>类型，长度为4个字节。</para>
        /// </param>
        public CsaException(string message, Exception innerException, ErrorCode code = ErrorCode.Succeed)
            : base(message, innerException)
        {
            Code = code;
        }
    }
}