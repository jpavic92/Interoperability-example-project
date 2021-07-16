using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShazamClient.Models
{
    public class Hit
    {
        [JsonProperty("track")]
        public Track Track { get; set; }

        [JsonProperty("artist")]
        public Artist Artist { get; set; }
    }
}
