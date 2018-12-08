using System;
using System.Collections.Generic;
using System.Net.Http;
using RestSharp;

namespace BlinkdotNet.Net
{
    internal class RequestFactory : IRequestFactory
    {
        public RequestFactory() { 
        }

        public IRestRequest CreateGet(Uri uri) => Create(Method.GET, uri);

        public IRestRequest CreatePost<T>(Uri uri, T body)
        {
            var request = Create(Method.POST, uri);
            request.AddJsonBody(body);
            return request;
        }

        private static IRestRequest Create(Method method, Uri uri)
        {
            var request = new RestRequest(uri,method);
            return request;
        }
    }
}