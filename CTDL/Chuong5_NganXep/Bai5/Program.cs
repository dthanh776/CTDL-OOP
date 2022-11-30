using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace Bai5_Chuong5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> A=DocA(@"D:\Bai5\A.txt");
            Queue<int> B=DocB(@"D:\Bai5\B.txt");
            LinkedList<VeXemPhim> C=DocC(@"D:\Bai5\C.txt");
            int chonCN = 0;
            do
            {
                Console.Clear();
                Menu();
                Console.Write("Ban chon chuc nang so");
                int.TryParse(Console.ReadLine(), out chonCN);
                switch (chonCN)
                {
                    case 1:
                        XuatA(A);
                        break;
                    case 2:
                        XuatB(B);
                        break;
                    case 3:
                        XuatC(C);
                        break;
                    case 4:
                        LaySoB(B);
                        break;
                    case 5:
                        MuaVe(A, B, C);
                        break;
                    case 6:
                        HuyVe(C, A);
                        break;
                    default:
                        Console.WriteLine("Ban da chon thoat chuong trinh");
                        break;
                }
                Console.ReadKey();
            } while (chonCN>=1&&chonCN<=6);
        }
        static void LaySoB(Queue<int>B)
        {
            if(B.Count==0)
            {
                B.Enqueue(1);
            }
            else
            {
                B.Enqueue(B.Last() + 1);
                Console.WriteLine("Lay so thanh cong");
            }
            GhiB(B, @"D:\Bai5\B.txt");

        }
        static void Menu()
        {
            Console.WriteLine("****************MENU**************");
            Console.WriteLine("\t1.Xem danh sach ghe trong");
            Console.WriteLine("\t2.Xem danh cho mua ve");
            Console.WriteLine("\t3.Xem danh ve");
            Console.WriteLine("\t4.Lay so cho mua ve");
            Console.WriteLine("\t5.Mua ve");
            Console.WriteLine("\t6.Huy ve");
            Console.WriteLine("\t7.Thoat");
            Console.WriteLine("***********************************");

        }
        static void HuyVe(LinkedList<VeXemPhim>C,LinkedList<int>A)
        {
            VeXemPhim ve = new VeXemPhim();
            
                Console.WriteLine("Nhap so ghe can huy ve: ");
                ve.SoGhe = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten: ");
                ve.Ten = Console.ReadLine();
           
           
            for (LinkedListNode<VeXemPhim> p = C.First; p != null; p = p.Next)
            {
                if(p.Value.SoGhe==ve.SoGhe&&p.Value.Ten==ve.Ten)
                {
                    C.Remove(p.Value);
                    GhiC(C, @"D:\Bai5\C.txt");
                    A.AddLast(ve.SoGhe);
                    GhiA(A, @"D:\Bai5\A.txt");
                    return;
                }
                
            }
            Console.WriteLine("Thong tin sai, khong the huy");
           
        }
        static void MuaVe(LinkedList<int>A, Queue<int>B,LinkedList<VeXemPhim>C)
        {
            int soGhe = 0;
            string ten = null;
            if(A.First!=null&&B.Count!=0)
            {
                do
                {
                    Console.Write("\tChon ghe ngoi:");
                    soGhe = int.Parse(Console.ReadLine());
                } while (A.Find(soGhe)==null);
                Console.Write("\tNhap ten: ");
                ten = Console.ReadLine();
                B.Dequeue();
                GhiB(B, @"D:\Bai5\B.txt");
                A.Remove(soGhe);        
                GhiA(A, @"D:\Bai5\A.txt");
                C.AddLast(new VeXemPhim(soGhe, ten));
                GhiC(C, @"D:\Bai5\C.txt");
            }
            else
            {
                Console.WriteLine("Het ghe trong hoac co nguoi cho mua");
            }
        }
        static void XuatB(Queue<int> B)
        {
            if (B.Count == 0)
            {
                Console.WriteLine("Khong co ai dang cho mua ve!!!");
            }
            else
            {
                Console.WriteLine("Danh sach cho mua ve hien co: ");
                foreach (var item in B)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }
        static void XuatC(LinkedList<VeXemPhim> C)
        {
          if(C.Count==0)
            {
                Console.WriteLine("Danh sach ve rong!!!");
            }
          else
            {
                Console.WriteLine("Danh sach ve hien co: ");
                for (LinkedListNode<VeXemPhim> p = C.First; p != null; p = p.Next)
                {
                    Console.Write(p.Value.Print());
                }
            }
        }
        static void XuatA(LinkedList<int> A)
        {
            if(A.Count==0)
            {
                Console.WriteLine("Khong co gh Trong trong rap !!!");
            }
            else
            {
                Console.WriteLine("Danh sach ghi con trong hien co");
                for (LinkedListNode<int> p = A.First; p != null; p = p.Next)
                {
                    Console.Write(p.Value+" ");
                }
                Console.WriteLine();
            }
        }
        static void GhiC(LinkedList<VeXemPhim> C, string path)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter(path))
                {
                    for (LinkedListNode<VeXemPhim> p = C.First; p != null; p = p.Next)
                    {
                        sW.WriteLine($"{p.Value.SoGhe}#{p.Value.Ten}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ghi file B that bai" + ex.Message);
            }
        }
        static void GhiB(Queue<int> B, string path)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter(path))
                {
                    foreach (var item in B)
                    {
                        sW.WriteLine(item);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ghi file B that bai" + ex.Message);
            }
        }
        static void GhiA(LinkedList<int> A,string path)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter(path))
                {
                    for(LinkedListNode<int>p = A.First;p!=null;p=p.Next)
                    {
                        sW.WriteLine(p.Value);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ghi file A that bai"+ex.Message);
            }
        }
        static LinkedList<VeXemPhim> DocC(string path)
        {
            LinkedList<VeXemPhim> C = new LinkedList<VeXemPhim>();
            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    while (sR.Peek() != -1)
                    {
                        string[] t = sR.ReadLine().Split('#');
                        C.AddLast(new VeXemPhim(t[0],t[1]));
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Mo file C that bai" + ex.Message);
            }
            return C;
        }
        static Queue<int> DocB(string path)
        {
            Queue<int> B = new Queue<int>();
            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    while (sR.Peek() != -1)
                    {
                        B.Enqueue(int.Parse(sR.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Mo file B.txt that bai" + ex.Message);
            }
            return B;
        }
        static LinkedList<int>DocA(string path)
        {
            LinkedList<int> A = new LinkedList<int>();
            try
            {
             using(StreamReader sR = new StreamReader(path))
                {
                    while(sR.Peek()!=-1)
                    {
                        A.AddLast(int.Parse(sR.ReadLine()));
                    }
                }   
            }
            catch (Exception ex)
            {

                Console.WriteLine("Mo file A.txt that bai"+ex.Message);
            }
            return A;
        }

    }
}
