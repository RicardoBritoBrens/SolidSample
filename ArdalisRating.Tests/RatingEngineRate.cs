using Newtonsoft.Json;
using System;
using System.IO;
using Xunit;

namespace ArdalisRating.Tests
{
    public class RatingEngineRate
    {
        [Fact]
        public void RetunsDefaultPolicyFromEmptyJsonString()
        {
            var inputJson = "{}";
            var serializer = new JsonPolicyDeserialilzer();
            var result = serializer.GetDeserializePolicy(inputJson);
            var policy = new Policy();
            Assert.Equal(result, policy);
        }
    }
}
