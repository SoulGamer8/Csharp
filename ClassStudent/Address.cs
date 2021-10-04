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
            Console.WriteLine("Country {0}\n District {1}\n City {2}\n Street {3}\n Housenumber {4}",
                this._country,this._district,this._city,this._street,this._housenumber);
        }
    }
}