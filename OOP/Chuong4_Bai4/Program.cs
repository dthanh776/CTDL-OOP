using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------HourlyEmployee-----------");
            Employee emp1 = new HourlyEmployee(1, 2, 999, "Duy", "Thanh");
            Console.WriteLine(emp1.toString());

            Console.WriteLine("\n-----------SalariedEmployee-----------");
            Employee emp2 = new SalariedEmployee(2, 2, 2, 888, "Thanh", "Duy");
            Console.WriteLine(emp2.toString());

            Console.ReadKey();
        }
    }
}
