using System;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Camera
    {
        [DataMember(Name ="camera_id")]
        public int CameraId { get; set; }

        [DataMember(Name ="created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime Updated { get; set; }

        [DataMember(Name ="wifi_strength")]
        public int WifiSingal { get; set; }

        [DataMember(Name ="lfr_strength")]
        public int LfrSignal { get; set; }

        [DataMember(Name ="battery_voltage")]
        public int BatteryVoltage { get; set; }

        [DataMember(Name ="temperature")]
        public int Temperature { get; set; }

        [DataMember(Name ="fw_version")]
        public string FirmwareVersion { get; set; }

        [DataMember(Name ="mac")]
        public string Mac { get; set; }

        [DataMember(Name ="ipv")]
        public string ipv { get; set; }

        [DataMember(Name ="ip_address")]
        public string IpAddress { get; set; }

        [DataMember(Name ="error_codes")]
        public int ErrorCodes { get; set; }

        [DataMember(Name ="battery_alert_status")]
        public bool? IsBatteryAlert { get; set; }

        [DataMember(Name ="temp_alert_status")]
        public bool? IsTempAlert { get; set; }

        [DataMember(Name ="ac_power")]
        public bool? IsAcPower { get; set; }

        [DataMember(Name ="light_sensor_ch0")]
        public int LightSensorChannel1 { get; set; }

        [DataMember(Name ="light_sensor_ch1")]
        public int LightSensorChannel2 { get; set; }

        [DataMember(Name ="light_sensor_data_valid")]
        public bool? IsLightSensorDataValid { get; set; }

        [DataMember(Name ="light_sensor_data_new")]
        public bool? IsLightSensorDataNew { get; set; }

        [DataMember(Name ="time_first_video")]
        public int TimeFirstVideo { get; set; }

        [DataMember(Name ="time_108_boot")]
        public int Time108Boot { get; set; }

        [DataMember(Name ="time_wlan_connect")]
        public int TimeWlanConnect { get; set; }

        [DataMember(Name ="time_dhcp_lease")]
        public int TimeDhcpLease { get; set; }

        [DataMember(Name ="time_dns_resolve")]
        public int TimeDnsResolve { get; set; }

        [DataMember(Name ="lfr_108_wakeups")]
        public int Lfr108Wakeups { get; set; }

        [DataMember(Name ="total_108_wakeups")]
        public int Total108Wakeups { get; set; }

        [DataMember(Name ="lfr_tb_wakeups")]
        public int LfrTbWakeups { get; set; }

        [DataMember(Name ="total_tb_wakeups")]
        public int TotalTbWakeups { get; set; }

        [DataMember(Name ="wifi_connect_failure_count")]
        public int WifiConnectFailures { get; set; }

        [DataMember(Name ="dhcp_failure_count")]
        public int DhcpFailures { get; set; }

        [DataMember(Name ="socket_failure_count")]
        public int SocketFailures { get; set; }

        [DataMember(Name ="dev_1")]
        public int Dev1 { get; set; }

        [DataMember(Name ="dev_2")]
        public int Dev2 { get; set; }

        [DataMember(Name ="dev_3")]
        public int Dev3 { get; set; }

        [DataMember(Name ="unit_number")]
        public int UnitNumber { get; set; }

        [DataMember(Name ="serial")]
        public string SerialNumber { get; set; }

        [DataMember(Name ="lifetime_count")]
        public int LifetimeCount { get; set; }

        [DataMember(Name ="lifetime_duration")]
        public int LifetimeDuration { get; set; }

        [DataMember(Name ="pir_rejections")]
        public int PirRejections { get; set; }

        [DataMember(Name ="sync_module_id")]
        public int SyncModuleId { get; set; }

        [DataMember(Name ="network_id")]
        public int NetworkId { get; set; }

        [DataMember(Name ="account_id")]
        public int AccountId { get; set; }

        [DataMember(Name ="id")]
        public int Id { get; set; }

        [DataMember(Name ="deleted_at")]
        public string DeletedAt { get; set; }

        [DataMember(Name ="camera_key")]
        public string CameraKey { get; set; }

        [DataMember(Name ="mac_address")]
        public string MacAddress { get; set; }

        [DataMember(Name ="thumbnail")]
        public string Thumbnail{ get; set; }

        [DataMember(Name ="name")]
        public string Name { get; set; }

        [DataMember(Name ="livevide_enabled")]
        public string LiveViewEnabled { get; set; }

        [DataMember(Name ="siren_enabled")]
        public bool? IsSirenEnabled { get; set; }

        [DataMember(Name ="siren_volume")]
        public string SirenVolume { get; set; }

        [DataMember(Name ="onboarded")]
        public bool? IsOnboarded { get; set; }

        [DataMember(Name ="motion_sensitivity")]
        public int MotionSensitivity { get; set; }

        [DataMember(Name="enabled")]
        public bool? IsEnabled { get; set; }

        [DataMember(Name ="alert_tone_enable")]
        public bool? IsAlertToneEnabled { get; set; }

        [DataMember(Name ="alert_tone_volume")]
        public int AlertToneVolume { get; set; }

        [DataMember(Name ="alert_repeat")]
        public string AlertRepeat { get; set; }

        [DataMember(Name ="alert_interval")]
        public int AlertInterval { get; set; }

        [DataMember(Name ="video_length")]
        public int VideoLength { get; set; }

        [DataMember(Name ="temp_alarm_enable")]
        public bool? IsTempAlarmEnabled { get; set; }

        [DataMember(Name ="temp_interval")]
        public int TempInterval { get; set; }

        [DataMember(Name ="temp_adjust")]
        public int TempAdjust { get; set; }

        [DataMember(Name ="temp_min")]
        public string TempMin { get; set; }

        [DataMember(Name ="temp_max")]
        public string TempMax { get; set; }

        [DataMember(Name ="temp_hysteresis")]
        public string TempHysteresis { get; set; }

        [DataMember(Name ="illuminator_enable")]
        public bool? IsIlluminatorEnabled { get; set; }

        [DataMember(Name ="illuminator_duration")]
        public int IlluminatorDuration { get; set; }

        [DataMember(Name ="illuminator_intesity")]
        public int IlluminatorIntensity { get; set; }

        [DataMember(Name ="battery_alarm_enable")]
        public bool? IsBatteryAlarmEnabled { get; set; }

        [DataMember(Name ="battery_voltage_interval")]
        public int BatteryVoltageInterval { get; set; }

        [DataMember(Name ="battery_voltage_threshold")]
        public int BatteryVoltageThreshold { get; set; }

        [DataMember(Name ="battery_voltage_hysteresis")]
        public int BatteryVoltageHysteresis { get; set; }

        [DataMember(Name ="last_battery_alert")]
        public string LastBatteryAlert { get; set; }

        [DataMember(Name ="batter_alert_count")]
        public int BatteryAlerts { get; set; }

        [DataMember(Name ="lfr_sync_interval")]
        public int LfrSyncInterval { get; set; }

        [DataMember(Name ="video_50_60hz")]
        public string VideoRate { get; set; }

        [DataMember(Name ="invert_image")]
        public bool? IsImageInverted { get; set; }

        [DataMember(Name ="flip_image")]
        public bool? IsImageFlipped { get; set; }

        [DataMember(Name = "record_audio_enable")]
        public bool? IsAudioRecordingEnabled { get; set; }

        [DataMember(Name ="clip_rate")]
        public int ClipRate { get; set; }

        [DataMember(Name ="liveview_rate")]
        public int LiveviewRate { get; set; }

        [DataMember(Name ="max_resolution")]
        public string MaxResolution { get; set; }

        [DataMember(Name ="auto_test")]
        public bool? AutoTest { get; set; }

        [DataMember(Name ="wifi_timeout")]
        public int WifiTimeout { get; set; }

        [DataMember(Name ="retry_count")]
        public int RetryCount { get; set; }

        [DataMember(Name ="status")]
        public string Status { get; set; }

        [DataMember(Name ="a1")]
        public bool? A1 { get; set; }

        [DataMember(Name ="last_temp_alert")]
        public string LastTempAlert { get; set; }

        [DataMember(Name ="temp_alert_count")]
        public int TempAlerts { get; set; }

        [DataMember(Name ="last_wifi_alert")]
        public string LastWifiAlert { get; set; }

        [DataMember(Name ="wifi_alert_count")]
        public int WifiAlerts { get; set; }

        [DataMember(Name ="last_lfr_alert")]
        public string LastLfrAlert { get; set; }

        [DataMember(Name ="lfr_alert_count")]
        public int LfrAlerts { get; set; }

        [DataMember(Name ="last_offline_alert")]
        public DateTime? LastOfflineAlert { get; set; }

        [DataMember(Name ="offline_alert_count")]
        public int OfflineAlerts { get; set; }

        [DataMember(Name ="temp_alert_state")]
        public string TempAlertState { get; set; }

        [DataMember(Name ="battery_state")]
        public string BatteryState { get; set; }

        [DataMember(Name ="battery_check_time")]
        public DateTime BatteryCheckTime { get; set; }

        [DataMember(Name ="motion_regions")]
        public int MotionRegions { get; set; }

        [DataMember(Name ="mfg_main_type")]
        public string MfgMainType { get; set; }

        [DataMember(Name ="mfg_main_range")]
        public int MfgMainRange { get; set; }

        [DataMember(Name ="mfg_mez_type")]
        public string MfgMezType { get; set; }

        [DataMember(Name = "mfg_mez_range")]
        public int MfgMezRange { get; set; }

        [DataMember(Name ="type")]
        public string Type { get; set; }
    }
}
