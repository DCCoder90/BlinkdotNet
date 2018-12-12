using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using BlinkdotNet.Serialization.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlinkdotNet.Serialization.Newtonsoft
{
    internal class NewtonSoftJsonSerializer : ISerializer
    {
        private readonly JsonSerializer _serializer;

        public NewtonSoftJsonSerializer(JsonSerializer serializer)
        {
            _serializer = serializer;
        }

        public T Deserialize<T>(Stream body)
        {
            using (var streamReader = new StreamReader(body))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return _serializer.Deserialize<T>(jsonReader);
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