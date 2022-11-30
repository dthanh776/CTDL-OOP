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
            MovablePoint movablePoint = new MovablePoint(2, 3, 4, 5);
            //movablePoint.moveDown();
            //movablePoint.moveUp();
            //movablePoint.moveRight();
            //movablePoint.moveLeft();

            Console.WriteLine(movablePoint.toString());
            Console.ReadKey();
        }
    }
}
