using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BlinkdotNet.Serialization.Newtonsoft.Converters;
using Newtonsoft.Json;

namespace BlinkdotNet.Serialization.Newtonsoft
{
    internal static class NetworksoftSerializerFactory
    {
        public static NewtonSoftJsonSerializer Create()
        {
            return new NewtonSoftJsonSerializer(CreateSerializer());
        }

        private static JsonSerializer CreateSerializer()
        {
            return JsonSerializer.Create(new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.DateTime,
                NullValueHandling = NullValueHandling.Ignore,
                Culture = CultureInfo.InvariantCulture,
                Converters = new List<JsonConverter>(){
                    new DoubleConverter(),
                    new IntegerConverter(),
                    new BoolConverter()
                }
                
            });
        }
    }
}
