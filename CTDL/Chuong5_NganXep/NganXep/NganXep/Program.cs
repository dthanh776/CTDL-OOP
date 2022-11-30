using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NganXep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack s = new Stack();
            //s.Push(12);
            //s.Push(11);
            //s.Push(10);
            //s.Print();
            //Console.WriteLine("Dinh cua stack la: " + s.Peek());
            //Console.WriteLine("Xoa node: " + s.Pop());
            //s.Print();

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            ChuyenCoSo(n);

            Console.ReadKey();
        }

        static void ChuyenCoSo(int n)
        {
            Stack s = new Stack();
            while (n > 0)
            {
                s.Push(n % 2);
                n = n / 2;
            }
            s.Print();
        }
    }
}
