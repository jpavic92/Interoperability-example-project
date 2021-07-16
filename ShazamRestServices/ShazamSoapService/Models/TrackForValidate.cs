using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ShazamSoapService.Models
{
    [DataContract]
    public class TrackForValidate
    {
        [DataMember(Order = 0)]
        public string Title { get; set; }

        [DataMember(Order = 1)]
        public string Subtitle { get; set; }

        [DataMember(Order = 2)]
        public string Url { get; set; }

        [DataMember(Order = 3)]
        public List<Artist> Artists { get; set; }

        public override string ToString()
        {
            return $"{Subtitle} - {Title}";
        }
    }
}