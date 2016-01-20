using System;
using System.Collections.Generic;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息报文事件参数类。
    /// </summary>
    public class DatagramEventArgs : EventArgs
    {
        /// <summary>
        /// 消息报文对象列表。
        /// </summary>
        public List<Datagram> DatagramList { get; private set; }

        /// <summary>
        /// 初始化 DatagramEventArgs 类的新实例。
        /// </summary>
        private DatagramEventArgs() : base() { }

        /// <summary>
        /// 通过报文字节数组初始化 DatagramEventArgs 类的新实例。
        /// </summary>
        /// <param name="dataArray">消息报文字节数组。</param>
        /// <param name="isTcpOrUdp">报文承载方式是否是TCP或UDP，默认为false。</param>
        /// <param name="isCheckCrc">是否校验CRC。</param>
        public DatagramEventArgs(byte[] dataArray, bool isTcpOrUdp = false, bool isCheckCrc = true)
            : base()
        {
            DatagramList = Datagram.GetDatagramList(dataArray, isTcpOrUdp, isCheckCrc);
        }
    }
}