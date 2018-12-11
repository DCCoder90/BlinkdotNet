using System.Runtime.Serialization;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Network
    {
        [DataMember(Name ="name")]
        public string Name { get; set; }

        [DataMember(Name ="wifi_strength")]
        public int WifiSignal { get; set; }

        [DataMember(Name ="status")]
        public string Status { get; set; }

        [DataMember(Name ="armed")]
        public bool IsArmed { get; set; }

        [DataMember(Name ="notifications")]
        public int Notifications { get; set; }

        [DataMember(Name ="warning")]
        public int Warning { get; set; }

        [DataMember(Name ="enable_temp_alerts")]
        public bool IsTempAlertsEnabled { get; set; }

        [DataMember(Name ="error_msg")]
        public string ErrorMessage { get; set; }
    }
}