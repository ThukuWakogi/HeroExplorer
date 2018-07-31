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
        public string Type { get; set; }

        //private TypeEnum TypeEnumConvert(string value)
        //{
        //    TypeEnum returningTypeNum;
        //    if (value == "cover") return TypeEnum.Cover;
        //    else  return TypeEnum.InteriorStory;
        //}
    }
}