using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlinkdotNet.Net
{
    internal class NewtonSoftJsonSerializer : ISerializer
    {
        public T Deserialize<T>(Stream body)
        {
            using (var sr = new StreamReader(body)){
                var jsonText = sr.ReadToEnd();
                //TODO: Implement error handling
                    var myObject = JsonConvert.DeserializeObject<T>(jsonText);
                    return myObject;
            }
        }

        public HttpContent Serialize<T>(T obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}