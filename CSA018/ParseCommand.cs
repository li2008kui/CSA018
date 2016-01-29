using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息报文处理委托。
    /// </summary>
    /// <param name="sender">消息命令类。</param>
    /// <param name="e"><see cref="DatagramEventArgs"/>类型，消息报文事件参数。</param>
    public delegate void DatagramProcessHandler(object sender, DatagramEventArgs e);

    /// <summary>
    /// 解析消息命令类。
    /// </summary>
    public class ParseCommand
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
        /// 通过默认构造方法初始化解析消息命令类实例。
        /// </summary>
        /// <param name="dataArray">消息报文字节数组。</param>
        /// <param name="isTcpOrUdp">报文承载方式是否是TCP或UDP，默认为false。</param>
        /// <param name="isCheckCrc">是否校验CRC。</param>
        public ParseCommand(byte[] dataArray, bool isTcpOrUdp = false, bool isCheckCrc = true)
        {
            datagramEventArgs = new DatagramEventArgs(
                dataArray,
                isTcpOrUdp: IsTcpOrUdp,
                isCheckCrc: IsCheckCrc);

            DatagramList = datagramEventArgs.DatagramList;
            IsTcpOrUdp = isTcpOrUdp;
            IsCheckCrc = isCheckCrc;
        }

        /// <summary>
        /// 通过默认构造方法初始化解析消息命令类实例。
        /// </summary>
        /// <param name="dataArray">消息报文字节数组。</param>
        /// <param name="desKey">
        /// DES 密钥。
        /// <para>该密钥运算模式采用 ECB 模式。</para>
        /// </param>
        /// <param name="isTcpOrUdp">报文承载方式是否是TCP或UDP，默认为false。</param>
        /// <param name="isCheckCrc">是否校验CRC。</param>
        public ParseCommand(byte[] dataArray, byte[] desKey, bool isTcpOrUdp = false, bool isCheckCrc = true)
        {
            if (desKey == null)
            {
                throw new ArgumentNullException(nameof(desKey), $"{typeof(DES)} 密钥不能为空。");
            }

            if (desKey.Length != 8)
            {
                throw new ArgumentNullException(nameof(desKey), $"{typeof(DES)} 密钥长度不正确。");
            }

            datagramEventArgs = new DatagramEventArgs(dataArray, desKey, IsTcpOrUdp, IsCheckCrc);
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