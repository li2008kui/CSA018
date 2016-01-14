namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息报文处理委托。
    /// </summary>
    /// <param name="sender">动作行为类。</param>
    /// <param name="e">消息报文事件参数。</param>
    public delegate void DatagramProcessHandler(object sender, DatagramEventArgs e);

    /// <summary>
    /// 解析消息动作行为类。
    /// </summary>
    public class ParseAction
    {
        /// <summary>
        /// 通过默认构造方法初始化解析消息动作行为类。
        /// </summary>
        public ParseAction() { }

        /// <summary>
        /// 消息报文处理事件。
        /// </summary>
        public event DatagramProcessHandler DatagramProcess;

        /// <summary>
        /// 触发消息报文的处理事件。
        /// </summary>
        /// <param name="e">消息报文事件参数。</param>
        public virtual void OnDatagramProcess(DatagramEventArgs e)
        {
            if (DatagramProcess != null)
            {
                DatagramProcess(this, e);
            }
        }

        /// <summary>
        /// 触发消息报文的处理事件
        /// </summary>
        /// <param name="cmd">命令字节数组。</param>
        public virtual void OnDatagramProcess(byte[] cmd)
        {
            OnDatagramProcess(new DatagramEventArgs(cmd));
        }
    }
}