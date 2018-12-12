using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlinkdotNet.Serialization.Newtonsoft.Converters
{
    internal class IntegerConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jVal = serializer.Deserialize<JValue>(reader);
            switch (jVal.Type)
            {
                case JTokenType.Float: return Convert.ToInt32(jVal.Value<double>());
                case JTokenType.String: return Convert.ToInt32(jVal.Value<string>());
                case JTokenType.Integer: return jVal.Value<int>();
                default: throw new FormatException();
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsAssignableFrom(typeof(int));
        }

        public override bool CanWrite => false;
        public override bool CanRead => true;
    }
}
