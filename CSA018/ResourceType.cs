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
        /// 湿度
        ///     <para>湿度传感器检测到的环境湿度。</para>
        ///     <para>取值范围：[0,100]。</para>
        /// </summary>
        Humidity = 02,

        /// <summary>
        /// 电流
        ///     <para>灯具控制器的输出电流。</para>
        ///     <para>单位：A（非CSA标准委员会规范）。</para>
        /// </summary>
        Current = 03,

        /// <summary>
        /// 电压
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
        /// 环境亮度
        ///     <para>亮度传感器检测到的环境亮度。</para>
        ///     <para>取值范围：[0,100]。</para>
        /// </summary>
        Brightness = 06,

        /// <summary>
        /// 是否有人
        ///     <para>红外传感器检测到环境中是否有人或其他生物。</para>
        ///     <para>01表示有人，02表示无人（非CSA标准委员会规范）。</para>
        /// </summary>
        是否有人 = 07,
        #endregion

        #region 厂商自定义

        #endregion
    }
}