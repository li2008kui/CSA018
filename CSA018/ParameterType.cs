namespace ThisCoder.CSA018
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
        /// 表示 <see cref="CSA018.ResourceType"/> 资源类型。
        /// <para>参数值最大字节数：2。</para>
        /// <para>温度 <see cref="ResourceType.Temperature"/> 为：“01”。</para>
        /// <para>湿度 <see cref="ResourceType.Humidity"/> 为：“02”。</para>
        /// <para>电流 <see cref="ResourceType.Current"/> 为：“03”。</para>
        /// <para>电压 <see cref="ResourceType.Voltage"/> 为：“04”。</para>
        /// <para>亮度 <see cref="ResourceType.Luminance"/> 为：“05”。</para>
        /// <para>环境亮度 <see cref="ResourceType.Brightness"/> 为：“06”。</para>
        /// <para>是否有人 <see cref="ResourceType.是否有人"/> 为：“07”。</para>
        /// <para>以下为厂商自定义资源类型值：</para>
        /// <para>灯具好坏 <see cref="ResourceType.灯具好坏"/> 为：“10”。</para>
        /// <para>功率 <see cref="ResourceType.Power"/> 为：“11”。</para>
        /// <para>功率因素 <see cref="ResourceType.PowerFactor"/> 为：“12”。</para>
        /// <para>电能 <see cref="ResourceType.Energy"/> 为：“13”。</para>
        /// <para>是否在线 <see cref="ResourceType.是否在线"/> 为：“14”。</para>
        /// <para>经度 <see cref="ResourceType.Longitude"/> 为：“15”。</para>
        /// <para>纬度 <see cref="ResourceType.Latitude"/> 为：“16”。</para>
        /// <para>海拔 <see cref="ResourceType.Altitude"/> 为：“17”。</para>
        /// <para>移动传感器是否存在 <see cref="ResourceType.移动传感器是否存在"/> 为：“18”。</para>
        /// <para>运行时间 <see cref="ResourceType.RunTime"/> 为：“19”。</para>
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
        SerialNumber = 0x0031,

        /// <summary>
        /// RSA密钥。
        /// <para>该密钥为私钥。</para>
        /// <para>参数值最大字节数：128。</para>
        /// <para>使用base64转码的密钥。</para>
        /// </summary>
        RSAKey = 0x0040,

        /// <summary>
        /// DES密钥。
        /// <para>该密钥使用RSA公钥进行加密。</para>
        /// <para>参数值最大字节数：128。</para>
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
        /// 设备种类。
        /// <para>参数值最大字节数：2。</para>
        /// <para>网关：“01”。</para>
        /// <para>灯具：“02”。</para>
        /// <para>其他：“03”。</para>
        /// <para>所有：“00”。</para>
        /// </summary>
        DeviceCategory = 0x0060,

        /// <summary>
        /// 设备类型。
        /// <para>参数值最大字节数：2。</para>
        /// <para>根据 <see cref="DeviceCategory"/> 进行复用。</para>
        /// <para>当 <see cref="DeviceCategory"/> 为“01”时：</para>
        /// <para>A型网关：“01”。</para>
        /// <para>B型网关：“02”。</para>
        /// <para>...</para>
        /// <para>当 <see cref="DeviceCategory"/> 为“02”时：</para>
        /// <para>A型灯具：“01”。</para>
        /// <para>B型灯具：“02”。</para>
        /// <para>...</para>
        /// </summary>
        DeviceType = 0x0061,

        /// <summary>
        /// 设备名称。
        /// </summary>
        DeviceName = 0x0062,

        /// <summary>
        /// 设备描述。
        /// </summary>
        Description = 0x0063,

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
        /// <para>单位：秒钟。</para>
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
        /// 按星期重复。
        /// <para>用十六进制的字符串表示，使用时直接转换为二进制形式，从低位到高位分别表示周一到周日，最高位表示启用或禁用。</para>
        /// <para>如：16进制字符串"81"->2进制0x10000001表示每周1执行。</para>
        /// <para>16进制字符串"9F"->2进制0x10011111表示每个工作日执行。</para>
        /// <para>16进制字符串"D5"->2进制0x11010101表示每周1、3、5和周日执行。</para>
        /// <para>16进制字符串"E0"->2进制0x11100000表示每个周末执行。</para>
        /// <para>16进制字符串"FF"->2进制0x11111111表示每天执行。</para>
        /// <para>16进制字符串"80"->2进制0x10000000表示只执行一次。</para>
        /// </summary>
        WeekRepeat = 0x006E,

        /// <summary>
        /// 编号。
        /// </summary>
        Number = 0x006F,

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

        /// <summary>
        /// 表示 <see cref="CSA018.ResourceType2"/> 资源类型2。
        /// <para>移动传感器 <see cref="ResourceType2.移动传感器"/> 为：“01”</para>
        /// <para>移动传感器 <see cref="ResourceType2.亮度传感器"/> 为：“02”</para>
        /// <para>移动传感器 <see cref="ResourceType2.经纬度"/> 为：“03”</para>
        /// <para>移动传感器 <see cref="ResourceType2.电参数"/> 为：“04”</para>
        /// </summary>
        ResourceType2 = 0x0080,
        #endregion
    }
}