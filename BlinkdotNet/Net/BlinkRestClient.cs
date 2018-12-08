using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Net;
using BlinkdotNet.Net.Entities;
using RestSharp;

namespace BlinkdotNet.Net
{
    internal class BlinkRestClient : IBlinkRestClient
    {
        private readonly IRestClient _client;
        private BlinkAuth _auth;

        public BlinkRestClient(IRestClient client, string username, string password)
        {
            _client = client;
            Authenticate(username,password);
        }

        public void Authenticate(string username, string password)
        {
            var request = new RestRequest("login", Method.POST);
            var authBody = new AuthenticationBody(username,password, "iPhone 9.2 | 2.2 | 222");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(authBody);
            var response = _client.BaseClient.Execute<BlinkAuth>(request);

            _auth = response.Data;
            _client.BaseClient.BaseUrl = new Uri("https://rest-"+_auth.region.First().Key+".immedia-semi.com");
        }

        public async Task<T> Get<T>(string route)
        {
            return await Send(route, u => _client.Get<T>(u,_auth));
        }

        public async Task<T> Post<T, TBody>(string route, TBody body)
        {
            return await Send(route, u => _client.Post<T, TBody>(u, body, _auth));
        }

        public async Task<T> Send<T>(string route, Func<Uri, Task<T>> sendAction)
        {
            var response = await sendAction(new Uri(route,UriKind.Relative));
            return response;
        }
    }
}