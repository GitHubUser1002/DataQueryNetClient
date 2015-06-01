using System;
using Newtonsoft.Json;

namespace Entities.Finance
{
    public class OptionChainLink
    {
        [JsonProperty("s")]
        public string Symbol { get; set; }
        public double Strike { get; set; }
        [JsonProperty("p")]
        public double? Price { get; set; }
        [JsonProperty("c")]
        public double? Change { get; set; }
        [JsonProperty("b")]
        public double? Bid { get; set; }
        [JsonProperty("a")]
        public double? Ask { get; set; }
        [JsonProperty("vol")]
        public int? Volume { get; set; }
        [JsonProperty("oi")]
        public int? OpenInterest { get; set; }
        public DateTime Expiry { get; set; }
        public string Type { get; set; }
    }
}
