using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShazamSoapService.Models
{
    public class Tracks
    {
        public List<TrackForValidate> tracks { get; set; }

        public Tracks()
        {
            tracks = new List<TrackForValidate>();
        }
    }
}