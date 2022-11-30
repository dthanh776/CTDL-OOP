using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Address
    {
        private string country;
        private string city;
        private string district;
        private string street;

        public Address() { }
        ~Address() { }

        public Address( string country, string city, string district, string street)
        {
            this.country = country;
            this.city = city;
            this.district = district;
            this.street = street;
        }
        public string getCountry()
        {
            return this.country;
        }
        public string getCity()
        {
            return this.city;
        }
        public string getDistrict()
        {
            return this.district;
        }
        public string getStreet()
        {
            return this.street;
        }

        public string toString()
        {
            string str = "";
            str = $"{"Quoc gia: "+ this.getCountry() + "\n" + "Thanh pho: "+ this.getCity() + "\n" + "Quan: "+ this.getDistrict() + "\n" +"Duong: "+ this.getStreet()}";
            return str;
        }
    }
}
