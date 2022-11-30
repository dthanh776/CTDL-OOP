using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<DonThuc> L1 = new LinkedList<DonThuc>();
            NhapDaThuc(L1, 3);
            Console.WriteLine("Da thuc thu 1: ");
            XuatDaThuc(L1);

            // Cau c: Tinh dao ham cua 2 da thuc
            TinhDaoHam(L1);
            Console.WriteLine("Dao ham da thuc thu 1: ");
            XuatDaThuc(L1);

            //Cau d: Tinh gia tri cua da thuc
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri cua da thuc: " + TinhGiaTri(L1, x));

            LinkedList<DonThuc> L2 = new LinkedList<DonThuc>();
            NhapDaThuc(L2, 3);
            Console.WriteLine("Da thuc thu 2: ");
            XuatDaThuc(L2);

            // Cau c: Tinh dao ham cua 2 da thuc
            TinhDaoHam(L2);
            Console.WriteLine("Dao ham da thuc thu 2: ");
            XuatDaThuc(L2);

            // Cau e: Tao danh sach F3 tu tong cua F1 va F2.
            LinkedList<DonThuc> L3 = new LinkedList<DonThuc>();
            XuatDaThuc(L3);
            
            Console.ReadKey();
        }
        // Cua f: Tao danh sach F3 tu tich cua F1 va F2
        // Cau e: Tao danh sach F3 tu tong cua F1 va F2
        static LinkedList<DonThuc> TaoF3Tong(LinkedList<DonThuc> L1, LinkedList<DonThuc> L2)
        {
            LinkedList<DonThuc> L3 = new LinkedList<DonThuc>();
            int maxSoMu = Math.Max(L1.First.Value.SoMu, L2.First.Value.SoMu);
            for (int i = maxSoMu; i >= 0; i++)
            {
                LinkedListNode<DonThuc> p = Find_SoMu(L1, i);
                LinkedListNode<DonThuc> q = Find_SoMu(L2, i);
                DonThuc dt = new DonThuc();

                if (p != null)
                {
                    if (q != null)
                    {
                        dt.HeSo = q.Value.HeSo + p.Value.HeSo;
                        dt.SoMu = i;
                        L3.AddLast(dt);
                    }
                    else // q == null
                    {
                        L3.AddLast(p.Value);
                    }
                }
                else // p == null
                {
                    if (q != null)
                    {
                        L3.AddLast(q.Value);
                    }
                }
            }
            return L3;
        }

        static LinkedListNode<DonThuc> Find_SoMu(LinkedList<DonThuc> L, int soMu)
        {
            for (LinkedListNode<DonThuc> p = L.First; p != null; p = p.Next)
            {
                if (soMu == p.Value.SoMu)
                {
                    return p;
                }
            }
            return null;
        }
            // Cau d: Tinh gia tri cua da thuc theo x (x nhap)
            static double TinhGiaTri(LinkedList<DonThuc> L, int x)
        {
            double tong = 0;
            for (LinkedListNode<DonThuc> p = L.First; p != null; p = p.Next)
            {
                tong = tong + p.Value.HeSo * Math.Pow(x, p.Value.SoMu);
            }
            return tong;
        }
        // Cau c: Tinh dao ham cua 2 da thuc
        static void TinhDaoHam(LinkedList<DonThuc> L)
        {
            for (LinkedListNode<DonThuc> p = L.First; p != null; p = p.Next)
            {
                p.Value.HeSo = p.Value.HeSo * p.Value.SoMu;
                p.Value.SoMu = p.Value.SoMu - 1;
                 
                if (p.Value.HeSo == 0)
                {
                    L.Remove(p.Value);
                }
            }
        }
        // Cau b: in 2 da thuc
        static void XuatDaThuc(LinkedList<DonThuc> L)
        {
            for (LinkedListNode<DonThuc> p = L.First; p != null; p = p.Next)
            {
                if (p == L.First)
                {
                    p.Value.Print();
                }
                else
                {
                    Console.Write(" + ");
                    p.Value.Print();
                }
            }
            Console.WriteLine("\n");
        }
        // Cau a: Nhap da thuc
        static void NhapDaThuc(LinkedList<DonThuc> L, int n)
        {
            for (int i = 0; i < n; i++)
            {
                DonThuc dt = new DonThuc();
                do
                {
                    Console.Write($"\t- Nhap he so cho don thuc thu {i + 1}: ");
                    dt.HeSo = double.Parse(Console.ReadLine());
                } while (dt.HeSo == 0);
                Console.Write($"\t- Nhap so mu cho don thuc thu {i + 1}: ");
                dt.SoMu = int.Parse(Console.ReadLine());
                L.AddLast(dt);
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
