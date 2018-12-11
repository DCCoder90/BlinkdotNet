using System;
using System.Runtime.Serialization;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class NetworkDetail
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime Updated { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "network_key")]
        public string NetworkKey { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "network_origin")]
        public string Origin { get; set; }

        [DataMember(Name = "locale")]
        public string Locale { get; set; }

        [DataMember(Name = "time_zone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "dst")]
        public bool ObservesDaylightSavingsTime { get; set; }

        [DataMember(Name = "ping_interval")]
        public int Ping { get; set; }

        [DataMember(Name = "encryption_key")]
        public string EncryptionKey { get; set; }

        [DataMember(Name = "armed")]
        public bool IsArmed { get; set; }

        [DataMember(Name = "autoarm_geo_enable")]
        public bool IsAutoArmGeoEnabled { get; set; }

        [DataMember(Name = "autoarm_time_enable")]
        public bool IsAutoArmTimeEnabled { get; set; }

        [DataMember(Name = "lv_mode")]
        public string lv_mode { get; set; }

        [DataMember(Name = "lfr_channel")]
        public int lfr_channel { get; set; }

        [DataMember(Name = "video_destination")]
        public string VideoLocation { get; set; }

        [DataMember(Name = "storage_used")]
        public int CurrentStorageUsed { get; set; }

        [DataMember(Name = "storage_total")]
        public int StorageTotal { get; set; }

        [DataMember(Name = "video_count")]
        public int TotalVideos { get; set; }

        [DataMember(Name = "video_history_count")]
        public int TotalVideoHistory { get; set; }

        [DataMember(Name = "arm_string")]
        public string arm_string { get; set; }

        [DataMember(Name = "busy")]
        public bool IsBusy { get; set; }

        [DataMember(Name = "camera_error")]
        public bool IsCameraErrored { get; set; }

        [DataMember(Name = "sync_module_error")]
        public bool IsSyncModuleErrored { get; set; }

        [DataMember(Name = "feature_plan_id")]
        public string feature_plan_id { get; set; }

        [DataMember(Name = "account_id")]
        public int AccountId { get; set; }
    }
}