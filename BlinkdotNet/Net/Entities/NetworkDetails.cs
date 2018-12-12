using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BlinkdotNet.Entities;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class NetworkDetails
    {
        [DataMember(Name ="summary")]
        public Dictionary<string, Network> Summary { get; set; }

        [DataMember(Name ="networks")]
        public List<NetworkDetail> Networks{ get; set; }
    }
}
