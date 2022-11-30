using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tham so mac dinh");
            Address address = new Address("Viet Nam", "TP.HCM", "TP.Thu Duc", "Vo Van Ngan");
            Student student = new Student(address);
            Console.WriteLine(student.toString());
            Console.WriteLine();


            Console.WriteLine("Tham so truyen vao");
            Address address1 = new Address("Viet Nam","TP.HCM","TP.Thu Duc","Vo Van Ngan");

            Student student1 = new Student("Duy Thanh",19,7,address1);
            Console.WriteLine(student1.toString());
            Console.ReadKey();
        }
    }
}
