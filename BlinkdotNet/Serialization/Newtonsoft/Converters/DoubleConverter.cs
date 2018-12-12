using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlinkdotNet.Serialization.Newtonsoft.Converters
{
    internal class DoubleConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jVal = serializer.Deserialize<JValue>(reader);
            switch (jVal.Type)
            {
                case JTokenType.Float:
                case JTokenType.Integer: return jVal.Value<double>();
                case JTokenType.String: return Parse(jVal.Value<string>());
                default: return 0.00;
            }
        }

        public override bool CanWrite => false;
        public override bool CanRead => true;

        private double Parse(string doubleString)
        {
            return double.TryParse(doubleString, out var d) ? d : 0.00;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsAssignableFrom(typeof(double));
        }
    }
}
