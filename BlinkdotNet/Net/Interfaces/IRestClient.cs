using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlinkdotNet.Net
{
    internal interface IRestClient
    {
        Task<T> Get<T>(Uri uri, BlinkAuth auth);

        Task<T> Post<T, TBody>(Uri uri, TBody body, BlinkAuth auth);

        RestSharp.IRestClient BaseClient{ get; }
    }
}