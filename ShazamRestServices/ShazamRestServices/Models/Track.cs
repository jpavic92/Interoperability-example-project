using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShazamRestServices.Models
{
    [DataContract]
    public class Track
    {
        [DataMember (Order = 0)]
        public string Layout { get; set; }

        [DataMember(Order = 1)]
        public string Type { get; set; }

        [DataMember(Order = 2)]
        public string Key { get; set; }

        [DataMember(Order = 3)]
        public string Title { get; set; }

        [DataMember(Order = 4)]
        public string Subtitle { get; set; }

        [DataMember(Order = 5)]
        public List<Artist> Artists { get; set; }

        [DataMember(Order = 6)]
        public string Url { get; set; }

        [DataMember(Order = 7)]
        public Images Images { get; set; }

        public override string ToString()
        {
            return $"{Subtitle} - {Title}";
        }
    }
}
