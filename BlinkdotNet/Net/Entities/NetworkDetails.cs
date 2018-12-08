using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Net.Entities
{
    public class NetworkDetails
    {
        public Dictionary<string, Network> summary { get; set; }
        public List<NetworkDetail> networks{ get; set; }
    }
}
