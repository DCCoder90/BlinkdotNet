using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Entities
{
    public class VideoInformation
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string camera_name { get; set; }
        public string description { get; set; }
        public int length { get; set; }
        public int size { get; set; }
        public int upload_time { get; set; }
        public DateTime viewed { get; set; }
        public bool locked { get; set; }
        public bool ready { get; set; }
        public string encryption { get; set; }
        public string encryption_key { get; set; }
        public string storage_location { get; set; }
        public string thumbnail { get; set; }
        public string address { get; set; }
        public int account_id { get; set; }
        public int network_id { get; set; }
        public int camera_id { get; set; }
        public string event_id { get; set; }
        public bool partial { get; set; }
        public string network_name { get; set; }
        public string time_zone { get; set; }
    }
}
