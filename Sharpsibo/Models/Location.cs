using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sharpsibo.Models
{
    public class Location
    {
        public string name { get; set; }
        public string country { get; set; }
        public string id { get; set; }
        [JsonIgnore]
        public string Latitude { get; set; }
        [JsonIgnore]
        public string Longitude { get; set; }
        public string[] latlon
        {
            get { return new string[] { Latitude, Longitude }; }
        }
    }
}
