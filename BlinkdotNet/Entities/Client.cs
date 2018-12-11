using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Entities
{
    public class Client
    {
        public int id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string name { get; set; }
        public string notify_sound { get; set; }
        public string client_type { get; set; }
        public string client_specifier { get; set; }
        public string notification_key { get; set; }
        public string aws_key { get; set; }
        public string os_version { get; set; }
        public string device_identifier { get; set; }
        public string app_version { get; set; }
        public string unique_id { get; set; }
        public string home { get; set; }
        public string ssid { get; set; }
        public string ssid_updated_at { get; set; }
        public int enabled_notifications { get; set; }
        public string client_options { get; set; }
        public int user_id { get; set; }
        public int account_id { get; set; }
    }
}
