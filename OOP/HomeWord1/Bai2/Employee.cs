using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private int salary;

        public Employee()
        {
            this.id = 1;
            this.firstName = "Duy";
            this.lastName = "Thanh";
            this.salary = 100000;
        }
        ~Employee() { }

        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public int getId()
        {
            return this.id;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public string getFullName()
        {
            return this.getLastName() + this.getFirstName();
        }
        public int getSalary()
        {
            return this.salary;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public int getAnnualSalary()
        {
            return this.getSalary() * 12;
        }

        public void upToSalary(int percent)
        {
            this.salary = getSalary() + (getSalary() * percent) / 100;
        }
        public string toString()
        {
            string str = "";
            str = $"{"Full name: " + this.getFullName() + "\n" + "Luong thang:  " + this.getSalary() + "\n" +  "Luong nhan hang nam: " + this.getAnnualSalary() + "\n"}";
            return str;
        }
    }
}
