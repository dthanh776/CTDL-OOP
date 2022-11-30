using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            string a = Console.ReadLine();
            Console.WriteLine(KiemTra(a));

            Console.ReadKey();
        }
        static bool KiemTra(string a)
        {
            Stack s = new Stack();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '{' || a[i] == '(' || a[i] == '[')
                {
                    s.Push(a[i]);
                }

                if (a[i] == '}' || a[i] == ')' || a[i] == ']')
                {
                    if (s.Top == null)
                    {
                        return false;
                    }
                    if (a[i] == ')' && s.Pop() != '(')
                    {
                        return false;
                    }
                    if (a[i] == '}' && s.Pop() != '{')
                    {
                        return false;
                    }
                    if (a[i] == ']' && s.Pop() != '[')
                    {
                        return false;
                    }
                }
            }
            if (s.Top == null)
            {
                return true;
            }
            return false;
        }
    }
}
