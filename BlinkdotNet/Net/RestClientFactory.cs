using System;
using System.Net.Http;
using System.Threading;

namespace BlinkdotNet.Net
{
    internal sealed class RestClientFactory : IDisposable
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private readonly string _username;
        private readonly string _password;

        public RestClientFactory(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public IBlinkRestClient CreateUsa()
        {
            return CreateUsa(new Uri("https://rest.prod.immedia-semi.com"));
        }

        private IBlinkRestClient CreateUsa(Uri baseUri)
        {
            var serializer = new HttpContentSerializer(new NewtonSoftJsonSerializer());

            var restClient = new RestClient(
                new RequestFactory(),
                new ResponseHandler(serializer),
                _tokenSource.Token, 
                new RestSharp.RestClient(baseUri));

            return new BlinkRestClient(restClient,_username,_password);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
        }
    }
}