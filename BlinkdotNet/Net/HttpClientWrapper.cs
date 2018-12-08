using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlinkdotNet.Net
{
    internal class HttpClientWrapper : IHttpClient
    {
        private readonly HttpClient _client;

        public HttpClientWrapper(HttpClient client)
        {
            _client = client;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption option,
            CancellationToken token)
        {
            return await _client.SendAsync(request, option, token);
        }
    }
}