using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlinkdotNet.Serialization.Newtonsoft.Converters
{
    internal class BoolConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, 
            JsonSerializer serializer)
        {
            var jVal = serializer.Deserialize<JValue>(reader);

            switch (jVal.Type)
            {
                case JTokenType.Integer: return ParseInt(jVal.Value<int>());
                case JTokenType.Boolean: return jVal.Value<bool>();
                case JTokenType.String: return ParseString(jVal.Value<string>());
                default: return false;
            }

        }

        private static bool ParseInt(int boolInt)
        {
            if (boolInt == 1)
                return true;
            return false;
        }

        private static bool ParseString(string boolString)
        {
            switch (boolString.ToLower())
            {
                case "1":
                case "y":
                case "true":
                    return true;

                case "0":
                case "n":
                case "false":
                    return false;

                default: return false;
            }
        }

        public override bool CanConvert(Type type)
        {
            if (type.IsAssignableFrom(typeof(bool)) || type == typeof(string))
                return true;

            return false;
        }

        public override bool CanWrite => false;
        public override bool CanRead => true;
    }
}
