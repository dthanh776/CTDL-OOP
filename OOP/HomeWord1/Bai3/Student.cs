using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Student
    {
        private string name;
        private int age;
        private double score;
        private Address address;

        public Student(Address address)
        {
            this.name = "thanh";
            this.age = 11;
            this.score = 10;
            this.address = address;
        }
        ~Student() { }
        public Student(string name, int age, double score, Address address)
        {
            this.name = name;
            this.age = age;
            this.score = score;
            this.address = address;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Score { get => score; set => score = value; }
        public Address Address { get => address; set => address = value; }

        public string getRating()
        {
            if (this.score >= 8)
            {
                return "good";
            }
            else if (this.score >= 5 || this.score < 8)
            {
                return "medium";
            }
            else
            {
                return "bad";
            }
        }
        public string toString()
        {
            string str = "";
            str = $"{"Ten: " + this.Name + "\n" + "Tuoi: " +this.Age + "\n" + "Diem: " + this.Score + "\n" +"Dia Chi: "+ "\n" + this.address.toString() + "Xep loai: "+ this.getRating()}";
            return str;
        }
    }
}
