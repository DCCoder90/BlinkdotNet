namespace BlinkdotNet.Net.Entities
{
    public class Network
    {
        public string name { get; set; }
        public int wifi_strength { get; set; }
        public string status { get; set; }
        public bool armed { get; set; }
        public int notifications { get; set; }
        public int warning { get; set; }
        public bool enable_temp_alerts { get; set; }
        public string error_msg { get; set; }
    }
}