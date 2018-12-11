using System.Runtime.Serialization;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Regions
    {
        [DataMember(Name = "us")]
        public Region Usa { get; set; }

        [DataMember(Name = "eu")]
        public Region Eu { get; set; }

        [DataMember(Name = "sg")]
        public Region Sg { get; set; }
    }
}