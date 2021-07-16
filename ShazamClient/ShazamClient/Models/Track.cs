using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml;
using System.Runtime.Serialization;

namespace ShazamClient.Models
{
    [DataContract (Namespace = "http://schemas.datacontract.org/2004/07/ShazamRestServices.Models")]
    public class Track
    {
        [JsonProperty("layout")]
        [DataMember]
        public string Layout { get; set; }

        [JsonProperty("type")]
        [DataMember]
        public string Type { get; set; }

        [JsonProperty("key")]
        [DataMember]
        public string Key { get; set; }

        [JsonProperty("title")]
        [DataMember]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        [DataMember]
        public string Subtitle { get; set; }

        [JsonProperty("artists")]
        [DataMember]
        public List<Artist> Artists { get; set; }

        [JsonProperty("url")]
        [DataMember]
        public string Url { get; set; }

        [JsonProperty("images")]
        [DataMember]
        public Images Images { get; set; }

        public override string ToString()
        {
            return $"{Subtitle} - {Title}";
        }

    }
}
