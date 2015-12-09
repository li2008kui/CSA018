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
        SettingLampDimmingPlan = 0x1206,

        /// <summary>
        /// 设置触发告警阈值
        /// </summary>
        SettingTriggerAlarmThreshold = 0x1207,

        /// <summary>
        /// 实时开/关灯和调整亮度
        /// </summary>
        RealTimeControlLamp = 0x1208,

        /// <summary>
        /// 实时查询灯具状态
        /// </summary>
        RealTimeQueryLampStatus = 0x1209,

        /// <summary>
        /// 设置灯具数据采集周期
        /// </summary>
        SettingLampDataCollectionPeriod = 0x120A,

        /// <summary>
        /// 设置灯具分组
        /// </summary>
        SettingLampGroup = 0x120B,

        /// <summary>
        /// 删除灯具分组
        /// </summary>
        RemoveLampGroup = 0x120C,

        /// <summary>
        /// 设置灯具场景
        /// </summary>
        SettingLampScene = 0x120D,

        /// <summary>
        /// 删除灯具场景
        /// </summary>
        RemoveLampScene = 0x120E,

        /// <summary>
        /// 设置灯具运行模式
        ///     <para>自动或手动</para>
        /// </summary>
        SettingRunningMode = 0x120F,

        /// <summary>
        /// 要求上传灯具日志
        /// </summary>
        RequireReportLampLog = 0x1210,

        /// <summary>
        /// 灯具恢复出厂状态
        /// </summary>
        LampFactoryReset = 0x1211,

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
        LampRestart = 0x2200,

        /// <summary>
        /// 灯具临界告警消除
        /// </summary>
        LampThresholdEliminateAlarm = 0x2202,

        /// <summary>
        /// 灯具临界告警
        /// </summary>
        LampThresholdAlarm = 0x2302,

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
        LampRunExceptionAlarm = 0x2304,

        /// <summary>
        /// 灯具未按控制设定工作告警消除
        /// </summary>
        LampRunExceptionEliminateAlarm = 0x2204,

        /// <summary>
        /// 灯具防盗告警
        /// </summary>
        LampBurglarAlarm = 0x2305,
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