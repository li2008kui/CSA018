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
        /// </summary>
        Temperature = 01,

        /// <summary>
        /// 湿度
        ///     <para>湿度传感器检测到的环境湿度。</para>
        /// </summary>
        Humidity = 02,

        /// <summary>
        /// 电流
        ///     <para>灯具控制器的输出电流。</para>
        /// </summary>
        Current = 03,

        /// <summary>
        /// 电压
        ///     <para>灯具控制器的输出电压。</para>
        /// </summary>
        Voltage = 04,

        /// <summary>
        /// 亮度
        ///     <para>灯具的亮度，有时也称照度。</para>
        /// </summary>
        Luminance = 05,

        /// <summary>
        /// 环境亮度
        ///     <para>亮度传感器检测到的环境亮度。</para>
        /// </summary>
        Brightness = 06,

        /// <summary>
        /// 是否有人
        ///     <para>红外传感器检测到环境中是否有人或其他生物。</para>
        /// </summary>
        是否有人 = 07,
        #endregion

        #region 厂商自定义

        #endregion
    }
}