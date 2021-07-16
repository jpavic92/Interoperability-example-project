using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamClient.Models
{
    class Artists
    {
        [JsonProperty("hits")]
        public List<Hit> Hits { get; set; }
    }
}
