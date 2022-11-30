/*
 Ho ten:
 Mon thi:
 Ngay thi:
 */
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
            LinkedList L = new LinkedList();
            // Goi ham cau 2a:
            L = InputList(5);

            // Goi ham cau 2b:
            OutputList(L);

            Console.ReadKey();
        }
        /// <summary>
        /// Cau 2b: Xuat danh sach so nguyen vua nhap
        /// </summary>
        /// <param name="L"></param>
        static void OutputList (LinkedList L)
        {
            Console.Write("Danh sach so nguyen");
            L.PrintList();
        }
        /// <summary>
        /// Cau 2a: Nhap danh sach n so nguyen
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static LinkedList InputList(int n)
        {
            LinkedList L = new LinkedList();
            int soPT = 0;
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Nhap phan tu: ");
                    soPT = int.Parse(Console.ReadLine());
                } while (soPT < 10 || soPT > 99);
                L.AddFirst(soPT);
            }
            return L;
        }
    }
}
