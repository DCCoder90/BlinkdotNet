using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace BlinkdotNet.Net
{
    internal class ResponseHandler : IResponseHandler
    {
        private readonly IHttpContentSerializer _serializer;

        public ResponseHandler(IHttpContentSerializer serializer)
        {
            _serializer = serializer;
        }

        public async Task<T> Handle<T>(IRestResponse response)
        {
            //if (response.StatusCode != HttpStatusCode.OK)
                return await _serializer.Deserialize<T>(response.Content);

            //TODO: Fix this
            throw new Exception("Error deserializing");
        }
    }
}