using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiConference.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

namespace TiConference.Helper
{
    public class Data
    {
        public static IEnumerable<Station> GetAllStations()
        {
            using (StreamReader r = new StreamReader(Path.Combine(HttpContext.Current.Server.MapPath("/App_Data"), "data.json")))
            {
                string json = r.ReadToEnd();

                Rootobject items = JsonConvert.DeserializeObject<Rootobject>(json);
                var stations =  items.Stations.ToList();
                stations.Sort((s1, s2) => s1.name.CompareTo(s2.name));
                return stations;
            }
        }

        public static Station GetStationById(string id)
        {
            using (StreamReader r = new StreamReader(Path.Combine(HttpContext.Current.Server.MapPath("/App_Data"), "data.json")))
            {
                string json = r.ReadToEnd();

                Rootobject items = JsonConvert.DeserializeObject<Rootobject>(json);
                var stations = items.Stations.ToList();
                return stations.FirstOrDefault(s => s.id == id.Replace('_','.'));

            }
        }

    }
}