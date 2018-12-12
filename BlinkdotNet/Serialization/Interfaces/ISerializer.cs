using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace BlinkdotNet.Serialization.Interfaces
{
    internal interface ISerializer
    {
        T Deserialize<T>(Stream body);
        HttpContent Serialize<T>(T obj);
    }
}