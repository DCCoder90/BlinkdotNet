using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Net.Entities
{
    internal class AuthenticationBody
    {
        public string password{ get; set; }
        public string client_specifier{ get; set; }
        public string email { get; set; }

        public AuthenticationBody(string username, string pass, string client)
        {
            password = pass;
            email = username;
            client_specifier = client;
        }

    }
}
