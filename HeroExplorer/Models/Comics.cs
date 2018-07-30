using Newtonsoft.Json;
using System.Collections.Generic;

namespace HeroExplorer.Models
{
    public class Comics
    {
        [JsonProperty("available")]
        public long Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionUri { get; set; }

        [JsonProperty("items")]
        public List<ComicsItem> Items { get; set; }

        [JsonProperty("returned")]
        public long Returned { get; set; }
    }
}