namespace ThisCoder.CSA018
{
    /// <summary>
    /// 消息ID枚举
    /// </summary>
    public enum MessageId : ushort
    {
        #region 配置命令
        /// <summary>
        /// 配置命令
        /// </summary>
        ConfigurationCommand = 0x1001,
        #endregion

        #region 操作维护
        /// <summary>
        /// 操作维护
        /// </summary>
        OperationMaintenance = 0x1002,
        #endregion

        #region 控制命令
        /// <summary>
        /// 设置默认开灯时间
        /// </summary>
        SettingDefaultTurnOnTime = 0x1201,

        /// <summary>
        /// 设置默认关灯时间
        /// </summary>
        SettingDefaultTurnOffTime = 1202,

        /// <summary>
        /// 设置默认调整亮度时间
        /// </summary>
        SettingDefaultAdjustBrightnessTime = 0x1203,

        /// <summary>
        /// 设置计划开灯时间
        /// </summary>
        SettingPlanTurnOnTime = 0x1204,

        /// <summary>
        /// 设置计划关灯时间
        /// </summary>
        SettingPlanTurnOffTime = 0x1205,

        /// <summary>
        /// 设置灯具调光计划
        /// </summary>
        SettingLuminaireDimmingPlan = 0x1206,

        /// <summary>
        /// 设置触发告警阈值
        /// </summary>
        SettingTriggerAlarmThreshold = 0x1207,

        /// <summary>
        /// 实时开/关灯和调整亮度
        /// </summary>
        RealTimeControlLuminaire = 0x1208,

        /// <summary>
        /// 实时查询灯具状态
        /// </summary>
        RealTimeQueryLuminaireStatus = 0x1209,

        /// <summary>
        /// 设置灯具数据采集周期
        /// </summary>
        SettingLuminaireDataCollectionPeriod = 0x120A,

        /// <summary>
        /// 设置灯具分组
        /// </summary>
        SettingLuminaireGroup = 0x120B,

        /// <summary>
        /// 删除灯具分组
        /// </summary>
        RemoveLuminaireGroup = 0x120C,

        /// <summary>
        /// 设置灯具场景
        /// </summary>
        SettingLuminaireScene = 0x120D,

        /// <summary>
        /// 删除灯具场景
        /// </summary>
        RemoveLuminaireScene = 0x120E,

        /// <summary>
        /// 设置灯具运行模式
        ///     <para>自动或手动</para>
        /// </summary>
        SettingRunningMode = 0x120F,

        /// <summary>
        /// 要求上传灯具日志
        /// </summary>
        RequireReportLuminaireLog = 0x1210,

        /// <summary>
        /// 灯具恢复出厂状态
        /// </summary>
        LuminaireFactoryReset = 0x1211,

        /// <summary>
        /// 更新RSA密钥
        /// </summary>
        UpdateRSAKey = 0x1212,

        /// <summary>
        /// 更新AES密钥
        /// </summary>
        UpdateAESKey = 0x1213,

        /// <summary>
        /// 同步时间
        /// </summary>
        SynchronizeTime = 0x1214,

        /// <summary>
        /// 设置通信故障下灯具默认亮度
        /// </summary>
        SettingCommunicationFailureDefaultBrightness = 0x1215,

        /// <summary>
        /// 设置灯具默认上电亮度
        /// </summary>
        SettingPowerOnDefaultBrightness = 0x1216,

        /// <summary>
        /// 接入认证请求
        /// </summary>
        AccessAuthenticationRequest = 0x1300,

        #region 厂商自定义
        /// <summary>
        /// 启用或禁用功能。
        ///     <para>防盗。</para>
        ///     <para>移动传感器。</para>
        ///     <para>亮度传感器。</para>
        ///     <para>天气状况。</para>
        ///     <para>交通量。</para>
        ///     <para>经纬度。</para>
        ///     <para>光衰补偿。</para>
        /// </summary>
        SettingEnableFunction = 0x1400,

        /// <summary>
        /// 设置移动传感器参数。
        ///     <para>启动后所影响灯具的GPS联动半径，单位：米。</para>
        ///     <para>启动所需要的感应数目，单位：个。</para>
        ///     <para>启动后灯具的亮度。</para>
        ///     <para>启动后灯具变化的保持时间，单位：分钟。</para>
        ///     <para>灵敏度。</para>
        ///     <para>数字滤波参数。</para>
        /// </summary>
        SettingMoveSensorParameter = 0x1401,

        /// <summary>
        /// 设置亮度传感器参数。
        ///     <para>启动后所影响灯具的GPS联动半径，单位：米。</para>
        ///     <para>启动所需要的感应数目，单位：个。</para>
        ///     <para>白天黑夜临界值。</para>
        /// </summary>
        SettingLightSensorParameter = 0x1402,

        /// <summary>
        /// 设置ZigBee无线网络参数。
        ///     <para>无线频点，即ZigBee无线通信的信道，取值范围：[01,16]。</para>
        ///     <para>其他参数待定。</para>
        /// </summary>
        SettingZigBeeParameter = 0x1403,

        /// <summary>
        /// 设置光衰补偿参数
        /// </summary>
        SettingAttenuationCompensationParameter = 0x1404,
        #endregion
        #endregion

        #region 数据采集
        /// <summary>
        /// 数据采集
        /// </summary>
        DataCollection = 0x2101,
        #endregion

        #region 事件列表
        /// <summary>
        /// 灯具重新启动
        /// </summary>
        LuminaireRestart = 0x2200,

        /// <summary>
        /// 灯具临界告警消除
        /// </summary>
        LuminaireThresholdEliminateAlarm = 0x2202,

        /// <summary>
        /// 灯具临界告警
        /// </summary>
        LuminaireThresholdAlarm = 0x2302,

        /// <summary>
        /// 网关与灯具通信故障告警
        /// </summary>
        CommunicationFailureAlarm = 0x2303,

        /// <summary>
        /// 网关与灯具通信故障告警消除
        /// </summary>
        CommunicationFailureEliminateAlarm = 0x2203,

        /// <summary>
        /// 灯具未按控制设定工作告警
        /// </summary>
        LuminaireRunExceptionAlarm = 0x2304,

        /// <summary>
        /// 灯具未按控制设定工作告警消除
        /// </summary>
        LuminaireRunExceptionEliminateAlarm = 0x2204,

        /// <summary>
        /// 灯具防盗告警
        /// </summary>
        LuminaireBurglarAlarm = 0x2305,
        #endregion

        #region 远程升级
        /// <summary>
        /// 远程升级
        /// </summary>
        RemoteUpgrade = 0x1100,

        /// <summary>
        /// 请求第N段文件
        /// </summary>
        RequestNthSegmentFile = 0x1101
        #endregion
    }
}