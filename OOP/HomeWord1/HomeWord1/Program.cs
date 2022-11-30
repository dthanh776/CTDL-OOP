using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tham so mac dinh");
            Rectangle rec = new Rectangle();
            Console.WriteLine(rec.toString());

            Console.WriteLine("Tham so truyen vao");
            Rectangle rec1 = new Rectangle(5,6);          
            Console.WriteLine(rec1.toString());

            Console.ReadKey();
        }
    }
}
