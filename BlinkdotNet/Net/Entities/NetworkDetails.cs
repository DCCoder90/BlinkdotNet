using System.Collections.Generic;
using System.Text;
using BlinkdotNet.Entities;

namespace BlinkdotNet.Net.Entities
{
    internal class NetworkDetails
    {
        public Dictionary<string, Network> summary { get; set; }
        public List<NetworkDetail> networks{ get; set; }
    }
}
