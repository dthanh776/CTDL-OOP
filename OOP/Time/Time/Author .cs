using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author()
        {

        }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string getName
        {
            get { return name; }
        }
        public string getEmail
        {
            get { return email; }
        }
        public char getGender
        {
            get { return gender; }
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public bool CheckGender()
        { 
            return this.gender == 'm' || this.gender == 'f' || this.gender == 'u' ;
        }
        public bool CheckEmail()
        {
            return this.email != "@" ;
        }
        public void print()
        {
            this.name;
        }

    }
}
