using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Net
{
    public class BlinkAuth
    {
        public BlinkAuth(string authKey)
        {
            authtoken = new Authtoken(){authtoken = authKey};
        }

        public BlinkAuth()
        {

        }

        public string AuthenticationToken{
            get{ return authtoken.authtoken; }
        }

        public Authtoken authtoken { get; set; }
        public Dictionary<string,Network> networks { get; set; }
        public Dictionary<string,string> region { get; set; }

        public class Authtoken
        {
            public string authtoken { get; set; }
            public string message { get; set; }
        }

        public class Network
        {
            public string name { get; set; }
            public bool onboarded { get; set; }
        }
    }
}