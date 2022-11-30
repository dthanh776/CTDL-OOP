using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Phim> L = new LinkedList<Phim>();
            DocFile(L, @"E:\CTDL\InputBai5.txt");
            XuatPhim(L);

            //Cau b, c: Tim ten phim cap nhap the loai phim
            //Cauc(L, @"E:\CTDL\InputCauC.txt", "BFG");
            //XuatPhim(L);

            ////Cau d: Nhap ten nam dien vien, ghi danh sach phim cua nam dien vien
            //Caud(L, @"E:\CTDL\InputCauD.txt", "Loi");
            //XuatPhim(L);

            //Cau e: Thong ke so luong va thong tin cua cac bo phim cho moi dao dien, ghi file rieng
            Caue(L);

            Console.ReadKey();
        }
        //Cau e: Thong ke so luong va thong tin cua cac bo phim cho moi dao dien, ghi file rieng
        static void Caue(LinkedList<Phim> L)
        {
            for (LinkedListNode<Phim> p = L.First; p != null; p = p.Next)
            {
                using (StreamWriter sw = new StreamWriter(@"E:\" + p.Value.TenDaoDien + ".txt", true))
                {
                    sw.WriteLine(p.Value.Print());
                }
            }
        }

        //Cau d: Nhap ten nam dien vien, ghi danh sach phim cua nam dien vien
        static void Caud(LinkedList<Phim> L, string path, string key)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (LinkedListNode<Phim> p = L.First; p != null; p = p.Next)
                    {
                        if (p.Value.TenNam == key)
                        {
                            sw.WriteLine($"{p.Value.TenPhim}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not open file!!!");
                throw;
            }
        }

        //Cau b, c: Tim ten phim cap nhap the loai phim
        static void Cauc(LinkedList<Phim> L, string path, string key)
        {
            // Tim va cap nhat
            for (LinkedListNode<Phim> p = L.First; p != null; p = p.Next)
            {
                if (p.Value.TenPhim == key)
                {
                    Console.Write("Nhap the loai moi: ");
                    p.Value.TheLoai = Console.ReadLine();
                }
            }
            //Ghi file
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (LinkedListNode<Phim> p = L.First; p != null; p = p.Next)
                    {
                        sw.WriteLine($"{p.Value.TenPhim}#{p.Value.TheLoai}#{p.Value.TenDaoDien}#{p.Value.TenNam}#{p.Value.TenNu}");

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not open file!!!");
                throw;
            }
        }

        static void XuatPhim(LinkedList<Phim> L)
        {
            for (LinkedListNode<Phim> p = L.First; p != null; p = p.Next)
            {
                Console.WriteLine(p.Value.Print());
            }
            Console.WriteLine();
        }
        static void DocFile(LinkedList<Phim> L, string path)
        {
            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    while (sR.Peek() != -1)
                    {
                        string[] t = sR.ReadLine().Split('#');
                        Phim phim = new Phim(t[0], t[1], t[2], t[3], t[4], t[5]);
                        L.AddLast(phim);
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
