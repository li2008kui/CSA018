﻿namespace ThisCoder.CSA018
{
    /// <summary>
    /// 参数类型枚举。
    /// </summary>
    public enum ParameterType : ushort
    {
        #region 配置命令参数
        /// <summary>
        /// 网关ID。
        /// <para>参数值最大字节数：10。</para>
        /// <para>用十进制的数字表示，由服务器分配。</para>
        /// <para>十进制范围为1～4294967295(2^32-1)。</para>
        /// <para>十六进制形式范围为0x00000001~0xffffffff。</para>
        /// </summary>
        GatewayId = 0x0001,

        /// <summary>
        /// 服务器IP地址。
        /// <para>参数值最大字节数：16。</para>
        /// <para>也可以使用域名的方式。</para>
        /// </summary>
        ServerIP = 0x0002,

        /// <summary>
        /// 服务器端口号。
        /// <para>参数值最大字节数：4。</para>
        /// </summary>
        ServerPort = 0x0003,

        /// <summary>
        /// 通信协议。
        /// <para>参数值最大字节数：1。</para>
        /// <para>“1”：UDP。</para>
        /// <para>“2”：TCP。</para>
        /// </summary>
        Protocol = 0x0004,

        /// <summary>
        /// 日志级别。
        /// <para>参数值最大字节数：1。</para>
        /// <para>“1”：Debug。</para>
        /// <para>“2”：Error。</para>
        /// </summary>
        LogLevel = 0x0005,

        /// <summary>
        /// 日志类别。
        /// <para>参数值最大字节数：32。</para>
        /// <para>“COMM” ：通信传输的日志类别。</para>
        /// <para>“APP” ：应用层的日志类别。</para>
        /// <para>灯具厂商可以自己定义日志类别。</para>
        /// </summary>
        LogCategory = 0x0006,

        /// <summary>
        /// 命令响应时间。
        /// <para>参数值最大字节数：4。，</para>
        /// <para>命令响应的最大时间，单位为秒。</para>
        /// </summary>
        CommandACKTimeout = 0x0007,

        /// <summary>
        /// 命令重试次数。
        /// <para>参数值最大字节数：2。</para>
        /// <para>接收不到命令响应或者命令发送失败以后重发的次数。</para>
        /// </summary>
        CommandRetryTimes = 0x0008,

        /// <summary>
        /// 命令结果时间。
        /// <para>参数值最大字节数：4。</para>
        /// <para>等待命令执行结果的最大时间，单位为秒。</para>
        /// </summary>
        CommandResultTimeout = 0x0009,

        /// <summary>
        /// 事件响应时间。
        /// <para>参数值最大字节数：4，</para>
        /// <para>事件的最大响应时间，单位为秒。</para>
        /// </summary>
        EventACKTimeout = 0x00A,

        /// <summary>
        /// 事件重试次数。
        /// <para>参数值最大字节数：2。</para>
        /// <para>接受不到事件响应或者事件发送失败后重发的次数。</para>
        /// </summary>
        EventRetryTimes = 0x00B,

        /// <summary>
        /// 链路空闲时间。
        /// <para>参数值最大字节数：4。</para>
        /// <para>通讯链路上发送心跳包的空闲时间，单位为秒。</para>
        /// </summary>
        LinkIdleTime = 0x000C,

        /// <summary>
        /// 心跳包响应超时时间。
        /// <para>参数值最大字节数：4。</para>
        /// <para>心跳包响应超时时间。</para>
        /// </summary>
        HeartbeatACKTimeout = 0x000D,

        /// <summary>
        /// 心跳包重试次数。
        /// <para>参数值最大字节数：2。</para>
        /// <para>收不到心跳包响应重发的次数-100。</para>
        /// </summary>
        HeatBeatRetryTimes = 0x000E,

        /// <summary>
        /// 网关所管理的灯具ID。
        /// <para>参数值最大字节数：10。</para>
        /// <para>网关所管理的灯具ID，用十进制的数字表示，由服务器分配，范围为0x00000001~0xffffff00。</para>
        /// <para>这个参数在命令中可以包含一个或者多个。</para>
        /// </summary>
        LuminaireId = 0x000F,
        #endregion

        #region 操作维护命令参数
        /// <summary>
        /// 操作维护信息。
        /// <para>参数值最大字节数：128。</para>
        /// <para>操作维护的信息。</para>
        /// </summary>
        MaintainanceInfo = 0x0011,
        #endregion

        #region 控制命令参数
        /// <summary>
        /// 时间。
        /// <para>参数值最大字节数：2。</para>
        /// <para>使用24时的HHmm表示。</para>
        /// </summary>
        Time = 0x0020,

        /// <summary>
        /// 照度。
        /// <para>参数值最大字节数：3。</para>
        /// <para>亮度值，使用十进制表示，00-100。</para>
        /// </summary>
        Brightness = 0x0021,

        /// <summary>
        /// 开始日期。
        /// <para>参数值最大字节数：8。</para>
        /// <para>开始日期，yyyyMMdd。</para>
        /// </summary>
        BeginDate = 0x0022,

        /// <summary>
        /// 结束日期。
        /// <para>参数值最大字节数：8。</para>
        /// <para>结束日期，yyyyMMdd。</para>
        /// </summary>
        EndDate = 0x0023,

        /// <summary>
        /// 资源值。
        /// <para>参数值最大字节数：5。</para>
        /// <para>资源数值。</para>
        /// </summary>
        ResourceValue = 0x0024,

        /// <summary>
        /// 门限值。
        /// <para>参数值最大字节数：8。</para>
        /// <para>阈值范围。</para>
        /// </summary>
        ThresholdValue = 0x0026,

        /// <summary>
        /// 资源类型。
        /// <para>参数值最大字节数：2。</para>
        /// <para>温度：“01”。</para>
        /// <para>湿度：“02”。</para>
        /// <para>电流：“03”。</para>
        /// <para>电压：“04”。</para>
        /// <para>亮度：“05”。</para>
        /// <para>环境亮度：“06”。</para>
        /// <para>是否有人：“07”。</para>
        /// <para>所有：“00”。</para>
        /// </summary>
        ResourceType = 0x0025,

        /// <summary>
        /// 运行模式。
        /// <para>参数值最大字节数：2。</para>
        /// <para>0x01：自动运行模式。</para>
        /// <para>0x02：手工模式。</para>
        /// </summary>
        OperationMode = 0x0027,

        /// <summary>
        /// 延时。
        /// <para>参数值最大字节数：5。</para>
        /// <para>延迟的时间（秒为单位）。</para>
        /// </summary>
        DelayTime = 0x0028,

        /// <summary>
        /// 采集周期。
        /// <para>采集周期（分钟为单位）。</para>
        /// </summary>
        Interval = 0x0029,

        /// <summary>
        /// 分组组号。
        /// <para>参数值最大字节数：2。</para>
        /// <para>组号（1~32）。</para>
        /// </summary>
        Group = 0x002A,

        /// <summary>
        /// 调光场景。
        /// <para>参数值最大字节数：2。</para>
        /// <para>场景值。</para>
        /// </summary>
        Scene = 0x002B,

        /// <summary>
        /// 访问码。
        /// <para>参数值最大字节数：16。</para>
        /// <para>安全认证码。</para>
        /// </summary>
        AccessCode = 0x0030,

        /// <summary>
        /// 序列码。
        /// <para>参数值最大字节数：32。</para>
        /// <para>灯具的序列号。</para>
        /// </summary>
        SerialNumer = 0x0031,

        /// <summary>
        /// RSA对称密钥。
        /// <para>参数值最大字节数：64。</para>
        /// <para>使用base64转码的密钥。</para>
        /// </summary>
        RSAKey = 0x0040,

        /// <summary>
        /// DES密钥。
        /// <para>参数值最大字节数：64。</para>
        /// <para>使用base64转码的密钥。</para>
        /// </summary>
        DESKey = 0x0041,

        /// <summary>
        /// 系统时间。
        /// <para>参数值最大字节数：14。</para>
        /// <para>yyyyMMddHHmmss。</para>
        /// </summary>
        SystemTime = 0x0042,

        /// <summary>
        /// 文件大小。
        /// <para>参数值最大字节数：5。</para>
        /// <para>升级文件的大小。</para>
        /// </summary>
        FileSize = 0x0050,

        /// <summary>
        /// 文件段大小。
        /// <para>参数值最大字节数：2。</para>
        /// <para>每段文件大小。</para>
        /// </summary>
        SegmentSize = 0x0051,

        /// <summary>
        /// 段的数量。
        /// <para>参数值最大字节数：2。</para>
        /// <para>总段数。</para>
        /// </summary>
        SegmentCount = 0x0052,
        #endregion

        #region 厂商自定义参数
        /// <summary>
        /// 设备名称。
        /// </summary>
        DeviceName = 0x0062,

        /// <summary>
        /// 设备类型。
        /// </summary>
        DeviceType = 0x0063,

        /// <summary>
        /// 负载功率。
        /// </summary>
        LoadPower = 0x0064,

        /// <summary>
        /// 半径。
        /// <para>单位：米。</para>
        /// </summary>
        Radius = 0x0066,

        /// <summary>
        /// 数量。
        /// <para>单位：个。</para>
        /// </summary>
        Quantity = 0x0067,

        /// <summary>
        /// 持续时间。
        /// <para>单位：分钟。</para>
        /// </summary>
        Duration = 0x0068,

        /// <summary>
        /// 灵敏度。
        /// </summary>
        Sensitivity = 0x0069,

        /// <summary>
        /// 数字滤波参数。
        /// </summary>
        DigitFilterParameter = 0x006A,

        /// <summary>
        /// 白天黑夜临界值。
        /// </summary>
        DayNightThreshold = 0x006B,

        /// <summary>
        /// 频点。
        /// <para>ZigBee无线通信的信道。</para>
        /// <para>取值范围：[01,16]。</para>
        /// </summary>
        FrequencyPoint = 0x006C,

        /// <summary>
        /// 小时。
        /// </summary>
        Hour = 0x006D,

        /// <summary>
        /// 防盗。
        /// </summary>
        SwitchBurglarAlarm = 0x0070,

        /// <summary>
        /// 移动传感器。
        /// </summary>
        SwitchMoveSensor = 0x0071,

        /// <summary>
        /// 亮度传感器。
        /// </summary>
        SwitchLightSensor = 0x0072,

        /// <summary>
        /// 天气状况。
        /// </summary>
        SwitchWeather = 0x0073,

        /// <summary>
        /// 交通量。
        /// </summary>
        SwitchTrafficFlow = 0x0074,

        /// <summary>
        /// 经纬度。
        /// </summary>
        SwitchLongitudeLatitude = 0x0075,

        /// <summary>
        /// 光衰补偿。
        /// </summary>
        SwitchAttenuationCompensation = 0x0076,
        #endregion
    }
}