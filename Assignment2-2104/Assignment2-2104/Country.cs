using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2104
{
    public class Country
    {
        public string CountryName { get; set; }
        public string Capital { get; set; }

        public Country(string countryName, string capital)
        {
            CountryName = countryName;
            Capital = capital;
        }
    }
}
