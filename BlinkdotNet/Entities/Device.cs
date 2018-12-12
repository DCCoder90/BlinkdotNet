using System;
using System.Runtime.Serialization;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Device
    {
        [DataMember(Name ="device_type")]
        public string DeviceType { get; set; }

        [DataMember(Name ="device_id")]
        public int DeviceId { get; set; }

        [DataMember(Name ="type")]
        public string Type { get; set; }

        [DataMember(Name ="updated_at")]
        public DateTime Updated { get; set; }

        [DataMember(Name ="name")]
        public string Name { get; set; }

        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; set; }

        [DataMember(Name ="active")]
        public bool Active { get; set; }

        [DataMember(Name ="notifications")]
        public int Notifications { get; set; }

        [DataMember(Name ="warning")]
        public int Warning { get; set; }

        [DataMember(Name ="error_msg")]
        public string ErrorMessage { get; set; }

        [DataMember(Name ="status")]
        public string Status { get; set; }

        [DataMember(Name ="enabled")]
        public bool Enabled { get; set; }

        [DataMember(Name ="armed")]
        public bool Armed { get; set; }

        [DataMember(Name ="errors")]
        public int Errors { get; set; }

        [DataMember(Name = "wifi_strength")]
        public int WifiStrength { get; set; }

        [DataMember(Name ="lfr_strength")]
        public int LfrStrength { get; set; }

        [DataMember(Name ="temp")]
        public int Temperature { get; set; }

        [DataMember(Name ="battery")]
        public int Battery { get; set; }

        [DataMember(Name ="battery_state")]
        public string BatteryState { get; set; }

        [DataMember(Name ="usage_rate")]
        public bool UseageRate { get; set; }

        [DataMember(Name ="last_hb")]
        public DateTime? LastHb { get; set; }
    }
}