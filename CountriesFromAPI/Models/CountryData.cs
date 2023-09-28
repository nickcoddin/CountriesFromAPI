using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesFromAPI.Models
{
    public class CountryData
    {
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string[] LatLng { get; set; }
        public double Area { get; set; }
        public long Population { get; set; }
    }
}
