using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiConference.Models
{

    public class Rootobject
    {
        public Station[] Stations { get; set; }
    }

    public class Station
    {
        public string id { get; set; }
        public string name { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string departures { get; set; }
    }

}