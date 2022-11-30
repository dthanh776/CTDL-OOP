using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private Address address;
        private static int countOfPerson;

        public Person(string firstName, string lastName, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public static int CountOfPerson
        {
            get
            {
                return countOfPerson;
            }

            set
            {
                countOfPerson = value;
            }
        }
        public string toString()
        {
            string str = $"FirstName {this.firstName,-5} - LastName {this.lastName,-5} - Address {address.toString(),-5}";
            return str;
        }

    }
}
