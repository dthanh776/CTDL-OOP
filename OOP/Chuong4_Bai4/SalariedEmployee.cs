using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class SalariedEmployee : Employee
    {
        private double commisionRate;
        private double grossSales;
        private double basic;

        public SalariedEmployee(double commisionRate, double grossSales, double basic, int empCode, string firstName, string lastName) : base(empCode, firstName, lastName)
        {
            this.commisionRate = commisionRate;
            this.grossSales = grossSales;
            this.basic = basic;
        }

        public SalariedEmployee()
        {

        }

        protected double CommisionRate
        {
            get
            {
                return commisionRate;
            }

            set
            {
                commisionRate = value;
            }
        }

        protected double GrossSales
        {
            get
            {
                return grossSales;
            }

            set
            {
                grossSales = value;
            }
        }

        protected double Basic
        {
            get
            {
                return basic;
            }

            set
            {
                basic = value;
            }
        }
        public override double pay()
        {          
            return Basic * CommisionRate * GrossSales ;
        }

        public override string toString()
        {
            return $"{"\nID nhan vien",-20}{EmpCode} {"\nHo",-20}{FirstName} {"\nTen",-20}{LastName} {"\nCommision Rate",-20}{CommisionRate}{"\nGrossSales",-20}{GrossSales}{"\nBasic",-20}{Basic}{"\nTien luong",-20}{pay()}";
        }
        

    }
}
