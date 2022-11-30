using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    public class Address
    {
        private string street;
        private string ward;
        private string city;

        public Address(string street, string ward, string city)
        {
            this.street = street;
            this.ward = ward;
            this.city = city;
        }
        public string toString()
        {
            string str = $"Street {street,-5} - Ward {ward,-5} - City {city,-5}";
            return str;
        }
    }
}
