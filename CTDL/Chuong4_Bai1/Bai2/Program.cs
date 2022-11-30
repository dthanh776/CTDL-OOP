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

            Console.WriteLine("L1: ");
            LinkedList L1 = new LinkedList();
            InputList(L1, 3);
            L1.PrintList();

            Console.WriteLine("L2: ");
            LinkedList L2 = new LinkedList();
            InputList(L2, 4);
            L2.PrintList();

            // Cau a
            Console.WriteLine("L3: ");
            LinkedList L3 = Cau2a(L1, L2);
            L3.PrintList();

            //Cau b 
            Console.WriteLine("\nCau b");
            LinkedList L3b = Cau2b(L1, L2);
            Console.WriteLine("L3: ");
            L3b.PrintList();

            //Cau c
            Console.WriteLine("\nCau c");
            LinkedList L3c = Cau2c(L1, L2);
            Console.WriteLine("L3: ");
            L3c.PrintList();

            //Cau d
            Console.WriteLine("\nCau d");
            LinkedList L3d = Cau2d(L1, L2);
            Console.Write("L3: ");
            L3d.PrintList();

            // Hop cua 2 tap hop
            Console.WriteLine("\nHop cua 2 tap hop");
            LinkedList L3bs = HopCua2TapHop(L1, L2);
            L3bs.PrintList();

            //Cau e: kiem tra trung
            Console.WriteLine("\nCau e");
            if (Cau2e(L1, L2))
            {
                Console.WriteLine("Hai danh sach trung nhau");
            }
            else
            {
                Console.WriteLine("Hai danh sach khong trung nhau");
            }
            //Cau f: Xoa phan tu
            //Console.WriteLine("\nCau f");
            //Cau2f(L1, L2);
            //Console.Write("L1: ");
            //L1.PrintList();

            //Cau g: Xoa tat ca
            Console.WriteLine("\nCau g");
            Cau2g(L1, L2);
            Console.Write("L1: ");
            L1.PrintList();

            Console.ReadKey();
        }

        //Cau g: 
        static void Cau2g(LinkedList L1, LinkedList L2)
        {
            for (Node i = L1.First; i != null; i = i.Next)
            {
                if (i.Data > SoLonNhatL(L2))
                {
                    L1.RemoveValue(i.Data);
                }
            }
        }
        static int SoLonNhatL(LinkedList L)
        {
            int max = L.First.Data;
            for (Node i = L.First; i != null; i = i.Next)
            {
                if (i.Data >= max)
                {
                    max = i.Data;
                }
            }
            return max;
        }

        //Cau f:
        static void Cau2f(LinkedList L1, LinkedList L2)
        {
            int tong = TinhTong(L2);
            for (Node i = L1.First; i != null; i = i.Next)
            {
                if (i.Data > tong)
                {
                    L1.RemoveValue(i.Data);
                    break;
                }
            }
        }
        static int TinhTong(LinkedList L)
        {
            int tong = 0;
            for (Node i = L.First; i != null; i = i.Next)
            {
                tong += i.Data;
            }
            return tong;
        }

        //Cau e:
        static bool Cau2e(LinkedList L1, LinkedList L2)
        {
            if (L1.Count != L2.Count)
            {
                return false;
            }
            else
            {
                Node j = L2.First;

                for (Node p = L1.First, q = L2.First; p != null && q != null; p = p.Next, q = q.Next)
                {
                    if (p.Data != q.Data)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        // Hop cua 2 tap hop
        static LinkedList HopCua2TapHop(LinkedList L1, LinkedList L2)
        {
            LinkedList L3 = new LinkedList();
            L3 = L1;
            for (Node p = L2.First; p != null; p = p.Next)
            {
                if (L1.Find(p.Data) == null)
                {
                    L3.AddLast(p.Data);
                }
            }
            return L3;
        }

        //Cau d: 
        static LinkedList Cau2d(LinkedList L1, LinkedList L2)
        {
            LinkedList L3 = new LinkedList();
            int a = L1.Count, b = L2.Count;
            if (a <= b)
            {
                for (int i = 0; i < b - a; i++)
                {
                    L1.AddLast(0);
                }
            }
            else
            {
                for (int i = 0; i < a - b; i++)
                {
                    L2.AddLast(0);
                }
            }
            for (Node p = L1.First, q = L2.First; p != null && q != null; p = p.Next, q = q.Next)
            {
                L3.AddLast(p.Data + q.Data);
            }
            return L3;
        }

        //Cau c: Giao cua 2 tap hop
        static LinkedList Cau2c(LinkedList L1, LinkedList L2)
        {
            LinkedList L3 = new LinkedList();
            for (Node p = L1.First; p != null; p = p.Next)
            {
                if (L2.Find(p.Data) != null)
                {
                    L3.AddLast(p.Data);
                }
            }
            return L3;
        }

        //Cau b: Hieu cua 2 tap hop
        static LinkedList Cau2b(LinkedList L1, LinkedList L2)
        {
            LinkedList L3 = new LinkedList();
            for (Node p = L1.First; p != null; p = p.Next)
            {
                if (L2.Find(p.Data) == null)
                {
                    L3.AddLast(p.Data);
                }
            }
            return L3;
        }

        // Cau a: tao L3 (noi L2 vao sau L1)
        static LinkedList Cau2a(LinkedList L1, LinkedList L2)
        {
            LinkedList L3 = new LinkedList();
            L3.Count = L1.Count + L2.Count;
            L3.First = L1.First;
            L3.Last = L2.Last;
            L1.Last.Next = L2.First;
            return L3;
        }
        static void InputList(LinkedList L, int n)
        {
            Random rd = new Random();
            for (int i = 1; i <= n; i++)
            {
                L.AddFirst(rd.Next(1, 20));
            }
        }

    }
}
