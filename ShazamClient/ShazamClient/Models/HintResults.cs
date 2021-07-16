using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamClient.Models
{
    public class HintResults
    {
        [JsonProperty("hints")]
        public List<Hint> Hints { get; set; }
    }
}
