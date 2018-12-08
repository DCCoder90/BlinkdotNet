using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace BlinkdotNet.Net
{
    internal interface ISerializer
    {
        T Deserialize<T>(Stream body);
        HttpContent Serialize<T>(T obj);
    }
}