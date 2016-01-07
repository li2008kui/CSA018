namespace ThisCoder.CSA018
{
    /// <summary>
    /// 资源类型枚举。
    ///     <para>该枚举使用时需要将值转换成2个字节的字符串形式。</para>
    /// </summary>
    public enum ResourceType : byte
    {
        #region 系统保留
        /// <summary>
        /// 温度。
        ///     <para>灯具控制器的温度。</para>
        ///     <para>单位：华氏度（非CSA标准委员会规范）。</para>
        ///     <para>摄氏度和华氏度的换算公式如下：</para>
        ///     <para>℃＝5/9 * (℉－32)</para>
        ///     <para>℉＝℃ * 9/5 ＋ 32</para>
        /// </summary>
        Temperature = 01,

        /// <summary>
        /// 湿度。
        ///     <para>湿度传感器检测到的环境湿度。</para>
        ///     <para>取值范围：[0,100]。</para>
        /// </summary>
        Humidity = 02,

        /// <summary>
        /// 电流。
        ///     <para>灯具控制器的输出电流。</para>
        ///     <para>单位：A（非CSA标准委员会规范）。</para>
        /// </summary>
        Current = 03,

        /// <summary>
        /// 电压。
        ///     <para>灯具控制器的输出电压。</para>
        ///     <para>单位：V（非CSA标准委员会规范）。</para>
        /// </summary>
        Voltage = 04,

        /// <summary>
        /// 亮度
        ///     <para>灯具的亮度，有时也称照度。</para>
        ///     <para>取值范围：[0,100]。</para>
        /// </summary>
        Luminance = 05,

        /// <summary>
        /// 环境亮度。
        ///     <para>亮度传感器检测到的环境亮度。</para>
        ///     <para>取值范围：[0,100]。</para>
        /// </summary>
        Brightness = 06,

        /// <summary>
        /// 是否有人。
        ///     <para>红外传感器检测到环境中是否有人或其他生物。</para>
        ///     <para>01表示有人，02表示无人（非CSA标准委员会规范）。</para>
        /// </summary>
        是否有人 = 07,
        #endregion

        #region 厂商自定义
        /// <summary>
        /// 灯具好坏。
        ///     <para>01表示正常，02表示损坏。</para>
        /// </summary>
        灯具好坏 = 10,

        /// <summary>
        /// 功率。
        ///     <para>灯具的视在功率。</para>
        /// </summary>
        Power = 11,

        /// <summary>
        /// 功率因素。
        /// </summary>
        PowerFactor = 12,

        /// <summary>
        /// 电能。
        ///     <para>灯具消耗的电量。</para>
        /// </summary>
        Energy = 13,

        /// <summary>
        /// 是否在线。
        ///     <para>灯具可能产生通信故障。</para>
        /// </summary>
        是否在线 = 14,

        /// <summary>
        /// 经度。
        /// </summary>
        Longitude = 15,

        /// <summary>
        /// 纬度。
        /// </summary>
        Latitude = 16,

        /// <summary>
        /// 海拔。
        /// </summary>
        Altitude = 17,

        /// <summary>
        /// 移动传感器是否存在。
        /// </summary>
        移动传感器是否存在 = 18,

        /// <summary>
        /// 频点。
        ///     <para>ZigBee无线通信的信道。</para>
        ///     <para>取值范围：[01,16]。</para>
        /// </summary>
        FrequencyPoint = 19,
        #endregion
    }
}