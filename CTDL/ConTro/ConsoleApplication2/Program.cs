using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach");
            LinkedList L = new LinkedList();
            InputList(L, 10);
            L.PrintList();
            //Them cuoi
            Console.WriteLine("\nThem phan tu cuoi");
            L.AddLast(100);
            L.PrintList();

            //Xoa dau
            Console.WriteLine("\nXoa phan tu dau");
            L.RemoveFirst();
            L.PrintList();

            // Xoa cuoi
            Console.WriteLine("\nXoa phan tu cuoi");
            L.RemoveLast();
            L.PrintList();

            //Xoa sau tai vi tri
            //Console.Write("Nhap vao khoa can xoa sau: ");
            //int key = int.Parse(Console.ReadLine());
            //Node pre = L.Find(key);
            //L.RemoveAfter(pre);
            //L.PrintList();

            // Xoa chinh no
            //Console.Write("\nNhap vao tu khoa can xoa: ");
            //int value = int.Parse(Console.ReadLine());
            //L.RemoveValue(value);
            //L.PrintList();

            //Xoa toan bo
            //Console.WriteLine("\nXoa toan bo");
            //L.RemoveAll();
            //L.PrintList();

            //Sap xep tang dan
            Console.WriteLine("\nSap xep InterchangeSort");
            L.InterchangeSort();

            Console.WriteLine("\nSap xep SeletionSort");
            L.SelectionSort();

            Console.WriteLine("\nSap xep BubleSort");
            L.BubbleSort();

            // Them tai vi tri sau bat ky
            //Console.Write("Nhap vao khoa can them sau: ");
            //int key = int.Parse(Console.ReadLine());
            //Node pre = L.Find(key);
            //L.AddAfter(pre, 200);
            //L.PrintList();

            Console.ReadKey();
        }
        static void InputList(LinkedList L, int n)
        {
            Random rd = new Random();
            for (int i = 1; i <= n; i++)
            {
                L.AddFirst(rd.Next(1, 100));
            }
        }

    }
}
