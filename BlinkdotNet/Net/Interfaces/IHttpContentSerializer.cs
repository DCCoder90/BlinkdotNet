using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlinkdotNet.Net
{
    internal interface IHttpContentSerializer
    {
        Task<T> Deserialize<T>(string content);
        HttpContent Serialize<T>(T obj);
    }
}