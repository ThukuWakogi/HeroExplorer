using Newtonsoft.Json;
using System.Collections.Generic;

namespace HeroExplorer.Models
{
    public class CharacterDataContainer
    {
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public List<Character> Characters { get; set; }
    }
}