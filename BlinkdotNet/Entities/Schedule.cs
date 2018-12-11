using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Schedule
    {
        [DataMember(Name = "action")]
        public string Action { get; set; }

        [DataMember(Name = "devices")]
        public List<string> Devices { get; set; }

        [DataMember(Name = "dow")]
        public List<string> Dow { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "time")]
        public string Time { get; set; }
    }
}