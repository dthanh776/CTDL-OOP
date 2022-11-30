using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    public class Staff
    {
        private string school;
        private double salary;
        private string name;
        private string address;

        ~Staff() { }

        public Staff(string school, double salary, string name, string address)
        {
            this.school = school;
            this.salary = salary;
            this.name = name;
            this.address = address;
        }

        public string School { get => school; set => school = value; }
        public double Salary { get => salary; set => salary = value; }

    }
}
