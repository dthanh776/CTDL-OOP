using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong2_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircle.NumOfMyPoint = 1000;
            MyCircle c1 = new MyCircle();
            Console.WriteLine("({0},{1}) - {2}", c1.Center.X, c1.Center.Y, c1.Radius);

            MyCircle c2 = new MyCircle(2,3,5);
            Console.WriteLine("({0},{1}) - {2}", c2.Center.X, c2.Center.Y, c2.Radius);

            MyCircle c3 = new MyCircle(new MyPoint(), 10);
            Console.WriteLine(c3.toString());

            Console.WriteLine("Khoang cach giua c1 va c2 la: {0: 0.00}", c1.Distance(c2));
            Console.WriteLine("Tong so duong tron da tao ra: {0}", MyCircle.NumOfMyPoint);
            Console.ReadKey();
        }
    }
}
