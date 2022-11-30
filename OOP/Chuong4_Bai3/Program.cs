using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(2.2,"red",true);

            Console.WriteLine(shape1.toString());

            Shape shape2 = new Rectangle(3,2,"blue",true);
            Console.WriteLine(shape2.toString());

            Shape shape3 = new Square(3,"yellow",true);
            Console.WriteLine(shape3.toString());
            Console.ReadKey();
        }
    }
}
