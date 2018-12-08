using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Net;

namespace BlinkdotNet.Net
{
    internal interface IBlinkRestClient
    {
        Task<T> Get<T>(string route);

        Task<T> Post<T, TBody>(string route, TBody body);

        Task<T> Send<T>(string route, Func<Uri, Task<T>> sendAction);
    }
}