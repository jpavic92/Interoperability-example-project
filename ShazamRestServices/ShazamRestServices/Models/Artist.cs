﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShazamRestServices.Models
{
    [DataContract]
    public class Artist
    {
        [DataMember(Order = 0)]
        public string Id { get; set; }

        [DataMember(Order = 1)]
        public string Name { get; set; }

        public string Adamid { get; set; }

        public string Avatar { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
