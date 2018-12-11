using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class SensorInformation
    {
        [DataMember(Name = "lfr")]
        public int lfr { get; set; }

        [DataMember(Name = "wifi")]
        public int WifiSignal { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime LastUpdate { get; set; }

        [DataMember(Name = "temp")]
        public int Temperature { get; set; }

        [DataMember(Name = "battery")]
        public int BatteryLevel { get; set; }
    }
}
