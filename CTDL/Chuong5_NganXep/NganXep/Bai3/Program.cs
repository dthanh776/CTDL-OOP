using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "10 2 / 3 + 7 4 - *";
            Stack<int> list = new Stack<int>();
            Console.WriteLine(HauTo(a));
            Console.ReadKey();
          
        }
        static double HauTo(string s)
        {
            Stack<double> stack = new Stack<double>();
            string[] t = s.Split(' ');
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == "+")
                {
                    double x1 = stack.Pop();
                    double x2 = stack.Pop();
                    stack.Push(x2 + x1);
                }
                else if (t[i] == "-")
                {
                    double x1 = stack.Pop();
                    double x2 = stack.Pop();
                    stack.Push(x2 - x1);
                }
                else if (t[i] == "*")
                {
                    double x1 = stack.Pop();
                    double x2 = stack.Pop();
                    stack.Push(x2 * x1);
                }
                else if (t[i] == "/")
                {
                    double x1 = stack.Pop();
                    double x2 = stack.Pop();
                    stack.Push(x2 / x1);
                }
                else
                {
                    stack.Push(Convert.ToDouble(t[i]));
                }
            }
            return stack.Peek();
        }
    }
}
