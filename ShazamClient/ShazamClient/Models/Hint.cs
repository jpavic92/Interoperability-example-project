using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamClient.Models
{
    public class Hint
    {
        [JsonProperty("term")]
        public string Term { get; set; }
    }
}
