using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShazamClient.Models
{
    [DataContract (Namespace = "http://schemas.datacontract.org/2004/07/ShazamRestServices.Models")]
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

        //[DataMember]
        //public Images Images { get; set; }

        public override string ToString()
        {
            return $"{Subtitle} - {Title}";
        }
    }
}
