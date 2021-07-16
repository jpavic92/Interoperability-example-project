using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShazamClient.Models
{
    [DataContract (Namespace = "http://schemas.datacontract.org/2004/07/ShazamRestServices.Models")]
    public class Artist
    {
        [JsonProperty("id")]
        [DataMember(Order = 0)]
        public string Id { get; set; }

        [JsonProperty("name")]
        [DataMember(Order = 1)]
        public string Name { get; set; }

        [JsonProperty("adamid")]
        public string Adamid { get; set; }

        [JsonProperty("hits")]
        public List<Hit> Hits { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
