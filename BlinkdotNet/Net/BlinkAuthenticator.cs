using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;

namespace BlinkdotNet.Net
{
    internal class BlinkAuthenticator : IAuthenticator
    {
        private string _authToken{ get; }

        public BlinkAuthenticator(BlinkAuth authtoken)
        {
            _authToken = authtoken.AuthenticationToken;
        }

        public void Authenticate(RestSharp.IRestClient client, IRestRequest request)
        {
            request.AddHeader("TOKEN_AUTH", _authToken);
            request.AddHeader("Host", "prod.immedia-semi.com");
        }
    }
}
