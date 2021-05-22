using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public class JsonPolicyDeserialilzer
    {
        public JsonPolicyDeserialilzer()
        {
        }

        public Policy GetDeserializePolicy(string json)
        {
            return JsonConvert.DeserializeObject<Policy>(json, new StringEnumConverter());
        }
    }
}
