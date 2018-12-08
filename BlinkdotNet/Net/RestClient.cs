using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace BlinkdotNet.Net
{
    internal class RestClient : IRestClient
    {
        private const HttpCompletionOption StreamOption = HttpCompletionOption.ResponseHeadersRead;
        private readonly RestSharp.IRestClient _client;
        private readonly IRequestFactory _requestFactory;
        private readonly IResponseHandler _responseHandler;
        private readonly CancellationToken _cancellationToken;

        RestSharp.IRestClient IRestClient.BaseClient => _client;

        public RestClient(IRequestFactory requestFactory, IResponseHandler responseHandler,
            CancellationToken cancellationToken, RestSharp.IRestClient client)
        {
            _client = client;
            _requestFactory = requestFactory;
            _responseHandler = responseHandler;
            _cancellationToken = cancellationToken;
        }

        private void SetAuthenticator(BlinkAuth auth)
        {
            _client.Authenticator = new BlinkAuthenticator(auth);
        }

        public async Task<T> Get<T>(Uri uri, BlinkAuth auth)
        {
            SetAuthenticator(auth);
            return await Send<T>(uri, u => _requestFactory.CreateGet(u));
        }

        public async Task<T> Post<T, TBody>(Uri uri, TBody body, BlinkAuth auth)
        {
            SetAuthenticator(auth);
            return await Send<T>(uri, u => _requestFactory.CreatePost(u, body));
        }

        private async Task<T> Send<T>(Uri uri, Func<Uri, IRestRequest> requestAction)
        {
            var request = requestAction(uri);
            var response = _client.Execute(request);

            return await _responseHandler.Handle<T>(response);
        }
    }
}