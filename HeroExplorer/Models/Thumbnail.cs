using Newtonsoft.Json;

namespace HeroExplorer.Models
{
    public class Thumbnail
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }
}