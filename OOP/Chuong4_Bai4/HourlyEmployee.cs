using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class HourlyEmployee : Employee
    {
        private double rate;
        private double workingHours;

        public HourlyEmployee(double rate, double workingHours, int empCode, string firstName, string lastName) : base(empCode, firstName, lastName)
        {
            this.rate = rate;
            this.workingHours = workingHours;
        }
        public HourlyEmployee() { }

        protected double Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }

        protected double WorkingHours
        {
            get
            {
                return workingHours;
            }

            set
            {
                workingHours = value;
            }
        }

        public override double pay()
        {
            return Rate * WorkingHours;
        }

        public override string toString()
        {
            return $"{"\nID nhan vien",-20}{EmpCode} {"\nHo",-20}{FirstName} {"\nTen",-20}{LastName} {"\nRate",-20}{Rate}{"\nWorking Hours",-20}{WorkingHours}{"\nTien luong",-20}{pay()}";
        }
    }
}
