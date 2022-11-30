using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            ReadListStudent(L, "input.txt");
            L.PrintList();

            //Cau 3c
            Cau3c(L);

            //Cau 3d

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write("Nhap ma sv can tim: ");
            //string maSV = Console.ReadLine();
            //Student st = new Student(maSV); // truyen thieu tham so
            //if (L.First(st) != null)
            //{
            //    Console.WriteLine("Tim thay!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Khong tim thay");
            //}

            //Tim va xoa
            TimXoa(L);
            L.PrintList();

            //Tim va sua
            TimSua(L);
            L.PrintList();

            Console.ReadKey();
        }
        //Tim va sua
        static void TimSua(LinkedList L)
        {
            Console.Write("Nhap ma sv can sua: ");
            string maSV = Console.ReadLine();
            Student st = new Student(maSV);
            Node p = L.Find(st);
            if (p != null)
            {
                Console.Write("Cap nhap diem moi: ");
                p.Data.Score = double.Parse(Console.ReadLine());
                L.PrintList();
            }
            else
            {
                Console.WriteLine("Khong sua duoc");
            }
        }
        // Tim va xoa
        static void TimXoa(LinkedList L)
        {
            Console.Write("Nhap ma sv can tim: ");
            string maSV = Console.ReadLine();
            Student st = new Student(maSV);
            Node p = L.Find(st);
            if (p != null)
            {
                L.RemoveValue(st);
            }
            else
            {
                Console.WriteLine("Khong xoa duoc");
            }
        }

        static void Cau3c(LinkedList L)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Danh sach co sv co dtb >= 5");
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (p.Data.Score >= 5)
                {
                    Console.WriteLine(p.Data.Xuat());
                }
            }
        }

        static void ReadListStudent(LinkedList L, string path)
        {
            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    while (sR.Peek() != -1)
                    {
                        string[] t = sR.ReadLine().Split('#');
                        Student st = new Student(t[0], t[1], t[2], t[3], t[4]);
                        L.AddLast(st);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not open file!!!");
                throw;
            }
        }
    }
}
