using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Region
    {
        [DataMember(Name = "dns")]
        public string Dns { get; set; }

        [DataMember(Name = "friendly_name")]
        public string Name { get; set; }

        [DataMember(Name ="registration")]
        public bool Registration { get; set; }
    }
}
