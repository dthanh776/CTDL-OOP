using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Display();
            q.EnQueue(10);
            q.EnQueue(15);
            q.EnQueue(20);
            q.Display();

            Console.WriteLine("Phan tu dau queue: " + q.Peek());

            Console.WriteLine("So bi xoa: " + q.DeQueue());

            q.Display();
            Console.ReadKey();
        }
    }
}
