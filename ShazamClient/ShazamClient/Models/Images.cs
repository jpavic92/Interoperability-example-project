using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShazamClient.Models
{
    [DataContract (Namespace = "http://schemas.datacontract.org/2004/07/ShazamRestServices.Models")]
    public class Images
    {
        [JsonProperty("background")]
        [DataMember]
        public string Background { get; set; }
    }
}
