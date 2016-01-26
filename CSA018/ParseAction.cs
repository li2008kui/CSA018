using System.Collections.Generic;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息报文处理委托。
    /// </summary>
    /// <param name="sender">动作行为类。</param>
    /// <param name="e"><see cref="DatagramEventArgs"/>类型，消息报文事件参数。</param>
    public delegate void DatagramProcessHandler(object sender, DatagramEventArgs e);

    /// <summary>
    /// 解析消息动作行为类。
    /// </summary>
    public class ParseAction
    {
        /// <summary>
        /// 获取消息报文对象列表。
        /// </summary>
        public List<Datagram> DatagramList { get; }

        /// <summary>
        /// 获取或设置报文承载方式是否是TCP或UDP，默认为false。
        /// </summary>
        public bool IsTcpOrUdp { get; set; }

        /// <summary>
        /// 获取或设置是否校验CRC。
        /// </summary>
        public bool IsCheckCrc { get; set; } = true;

        /// <summary>
        /// 消息报文事件参数
        /// </summary>
        private DatagramEventArgs datagramEventArgs;

        /// <summary>
        /// 通过默认构造方法初始化解析消息动作行为类。
        /// </summary>
        /// <param name="dataArray">消息报文字节数组。</param>
        /// <param name="isTcpOrUdp">报文承载方式是否是TCP或UDP，默认为false。</param>
        /// <param name="isCheckCrc">是否校验CRC。</param>
        public ParseAction(byte[] dataArray, bool isTcpOrUdp = false, bool isCheckCrc = true)
        {
            datagramEventArgs = new DatagramEventArgs(dataArray, IsTcpOrUdp, IsCheckCrc);

            DatagramList = datagramEventArgs.DatagramList;
            IsTcpOrUdp = isTcpOrUdp;
            IsCheckCrc = isCheckCrc;
        }

        /// <summary>
        /// 消息报文处理事件。
        /// </summary>
        public event DatagramProcessHandler DatagramProcess;

        /// <summary>
        /// 触发消息报文的处理事件。
        /// </summary>
        public void OnDatagramProcess()
        {
            DatagramProcess?.Invoke(this, datagramEventArgs);
        }
    }
}