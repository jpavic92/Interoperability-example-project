using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShazamClient.Models
{
    class Root
    {
        [JsonProperty("tracks")]
        public Tracks Tracks { get; set; }

        [JsonProperty("artists")]
        public Artists Artists { get; set; }
    }
}
