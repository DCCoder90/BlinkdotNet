using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class AuthenticationBody
    {
        [DataMember(Name ="password")]
        public string Password{ get; set; }

        [DataMember(Name ="client_specifier")]
        public string ClientSpecifier{ get; set; }

        [DataMember(Name ="email")]
        public string Email { get; set; }

        public AuthenticationBody(string username, string pass, string client)
        {
            Password = pass;
            Email = username;
            ClientSpecifier = client;
        }

    }
}
