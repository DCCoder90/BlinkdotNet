using System;
using System.Collections.Generic;
using System.Net.Http;
using RestSharp;

namespace BlinkdotNet.Net
{
    internal interface IRequestFactory
    {
        IRestRequest CreateGet(Uri uri);
        IRestRequest CreatePost<T>(Uri uri, T body);
    }
}