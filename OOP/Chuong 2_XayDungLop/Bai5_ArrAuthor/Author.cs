using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong2_Bai5
{
    public class Author
    {
        private string name;
        private string email;
        private char gender;
        
        public Author (string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public string getName()
        {
            return name;
        }     
        public void setName(string name)
        {
            this.name = name;
        }
        public string setEmail()
        {
            return email;
        }
        public void getEmail(string email)
        {
            this.email = email;
        }
        public char getGender()
        {
            return gender;
        }
        public void setGender(char gender)
        {
            this.gender = gender;
        }

    }
}
