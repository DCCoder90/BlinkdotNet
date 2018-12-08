using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlinkdotNet.Net
{
    internal interface IHttpClient
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption option,
            CancellationToken token);
    }
}