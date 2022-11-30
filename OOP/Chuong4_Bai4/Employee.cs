using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public abstract class Employee
    {
        private int empCode;
        private string firstName;
        private string lastName;

        protected int EmpCode
        {
            get
            {
                return empCode;
            }

            set
            {
                empCode = value;
            }
        }

        protected string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        protected string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public Employee(int empCode, string firstName, string lastName)
        {
            this.EmpCode = empCode;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Employee() { }
        public abstract double pay();

        //public abstract string toString();
        public virtual string toString()
        {
              return $"{"ID nhan vien: "}{EmpCode,-10} {"Ho: "}{FirstName,-10} {"Ten: "}{LastName,-10}";
        }

    }
}
