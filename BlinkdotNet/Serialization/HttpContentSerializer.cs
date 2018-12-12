using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Serialization.Interfaces;

namespace BlinkdotNet.Serialization
{
    internal class HttpContentSerializer : IHttpContentSerializer
    {
        private readonly ISerializer _serializer;

        public HttpContentSerializer(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public async Task<T> Deserialize<T>(string content)
        {
            using (var stream = new MemoryStream(Encoding.Default.GetBytes(content))){
                var obj = _serializer.Deserialize<T>(stream);
                return obj;
            }
        }

        public HttpContent Serialize<T>(T obj)
        {
            var stream = _serializer.Serialize(obj);
            return stream;
        }
    }
}