using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShazamClient.Models
{
    class Tracks
    {
        [JsonProperty("hits")]
        public List<Hit> Hits { get; set; }
    }
}
