using Newtonsoft.Json;

namespace HeroExplorer.Models
{
    public class StoriesItem
    {
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }
}