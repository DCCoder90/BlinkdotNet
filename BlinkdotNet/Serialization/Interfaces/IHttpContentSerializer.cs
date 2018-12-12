using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlinkdotNet.Serialization.Interfaces
{
    internal interface IHttpContentSerializer
    {
        Task<T> Deserialize<T>(string content);
        HttpContent Serialize<T>(T obj);
    }
}