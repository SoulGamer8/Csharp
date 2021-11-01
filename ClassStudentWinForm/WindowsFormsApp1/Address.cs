using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Address
    {
        public string Country { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string Housenumber { get; private set; }



        public Address(string country, string district, string city, string street, string housenumber)
        {
            Country = country;
            District = district;
            City = city;
            Street = street;
            Housenumber = housenumber;
        }

        public void GetInfo()
        {
            Console.WriteLine("Country {0}\nDistrict {1}\nCity {2}\nStreet {3}\nHousenumber {4}",
                Country, District, City, Street, Housenumber);
        }
    }
}
