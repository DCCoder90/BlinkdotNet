using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Programs
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "network_id")]
        public int NetworkId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "schedule")]
        public List<Schedule> Schedules { get; set; }

        [DataMember(Name = "format")]
        public string Format { get; set; }
    }
}
