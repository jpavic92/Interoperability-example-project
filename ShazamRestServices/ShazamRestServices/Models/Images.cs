using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShazamRestServices.Models
{
    [DataContract]
    public class Images
    { 
        [DataMember]
        public string Background { get; set; }
    }
}
