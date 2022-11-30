using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1,"Thanh","Duy",1000);
            employee.upToSalary(10);
            Console.WriteLine(employee.toString());
            Console.ReadKey();
        }
    }
}
