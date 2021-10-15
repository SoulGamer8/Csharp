using System;

namespace ClassStudent
{
    class Address
    {
        private string _country  { get; set; }
        private string _district { get; set; }
        private string _city { get; set; }
        private string _street { get; set; }
        private string _housenumber { get; set; }
        
        public Address(string country,string district,string city,string street,string housenumber) 
        {
            _country = country;
            _district = district;
            _city = city;
            _street = street;
            _housenumber = housenumber;
        }

        public void GetInfo()
        {
            Console.WriteLine("Country {0}\nDistrict {1}\nCity {2}\nStreet {3}\nHousenumber {4}",
                this._country,this._district,this._city,this._street,this._housenumber);
        }
    }
}