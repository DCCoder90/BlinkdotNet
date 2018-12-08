using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace BlinkdotNet.Net
{
    internal interface IResponseHandler
    {
        Task<T> Handle<T>(IRestResponse response);
    }
}