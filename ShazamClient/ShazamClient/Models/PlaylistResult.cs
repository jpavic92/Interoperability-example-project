using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamClient.Models
{
    public class PlaylistResult
    {
        [JsonProperty("tracks")]
        public List<PlaylistTrack> Tracks { get; set; }
    }

    public class PlaylistTrack
    {
        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("artists")]
        public List<Artist> Artists { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
