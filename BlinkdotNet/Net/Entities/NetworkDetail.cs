using System;

namespace BlinkdotNet.Net.Entities
{
    public class NetworkDetail
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string name { get; set; }
        public string network_key { get; set; }
        public string description { get; set; }
        public string network_origin { get; set; }
        public string locale { get; set; }
        public string time_zone { get; set; }
        public bool dst { get; set; }
        public int ping_interval { get; set; }
        public string encryption_key { get; set; }
        public bool armed { get; set; }
        public bool autoarm_geo_enable { get; set; }
        public bool autoarm_time_enable { get; set; }
        public string lv_mode { get; set; }
        public int lfr_channel { get; set; }
        public string video_destination { get; set; }
        public int storage_used { get; set; }
        public int storage_total { get; set; }
        public int video_count { get; set; }
        public int video_history_count { get; set; }
        public string arm_string { get; set; }
        public bool busy { get; set; }
        public bool camera_error { get; set; }
        public bool sync_module_error { get; set; }
        public string feature_plan_id { get; set; }
        public int account_id { get; set; }
    }
}