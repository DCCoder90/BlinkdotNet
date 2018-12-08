using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet
{
    public class NetworkCollection
    {
        public Dictionary<string,Network> Networks{ get; set; }
    }

    public class Network
    {
        public string Name{ get; set; }
        public bool Onboarded{ get; set; }
    }
}
