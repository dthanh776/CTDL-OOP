using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong4_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach");
            LinkedList L = new LinkedList();
            InputList(L, 10);
            L.PrintList();

            //Cau a: Them phan tu vao cuoi danh sach
            Console.WriteLine("\nThem phan tu vao cuoi");
            L.AddLast(17);
            L.PrintList();

            //Cau c: liet ke so nguyen to
            XuatSNT(L);

            //Cau d: Tinh trung binh cong
            Console.WriteLine($"\nTrung binh cong cua danh sach la: {TrungBinhCong(L)}");

            //Cau e: Dem so lan xuat hien
            Console.Write("Nhap so nguyen: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nSo lan lap cua {key} la {SoLanXuatHien(L, key)}");

            //Cau f: Tim so chinh phuong cuoi cung
            Console.WriteLine($"\nSo chinh phuong cuoi cung trong mang la {SoChinhPhuongCuoiCung(L)}");

            //Cau g: Tim va tra ve
            int k = 0;
            do
            {
                Console.Write("k = ");
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k >= L.Count);
            Console.WriteLine("Node o vi tri " + k + " la " + TimTraVe(L, k));

            //Cau h: Tim phan tu co gia tri nho nhat

            //Cau j: Them phan tu khong trung
            ThemKhongTrung(L);

            //Cau k: Xoa k phan tu dau danh sach
            XoaK_PhanTuDau(L);

            //Cau l: Xoa phan tu co gia tri = x
            //Remove value
            Console.Write("\nNhap vao tu khoa can xoa: ");
            int value = int.Parse(Console.ReadLine());
            L.RemoveValue(value);
            L.PrintList();

            //Cau m: Xoa phan tu sau phan tu q trong danh sach
            Console.Write("Nhap vao khoa can xoa sau: ");
            key = int.Parse(Console.ReadLine());
            Node pre = L.Find(key);
            L.RemoveAfter(pre);
            L.PrintList();

            //Cau n: Xoa phan tu lap lai
            Console.WriteLine("Xoa phan tu lap lai");
            XoaPhanTuTrung(L);
            L.PrintList();

            //Cau o: Sap xep tang dan InterchangeSort
            L.InterchangeSort();

            //Cau p: them phan tu vao danh sach tang dan
            int data = int.Parse(Console.ReadLine());
            ThemTang(L, data);
            L.PrintList();

            //Cau q: Cap nhat so hoan thien thanh 0

            Console.ReadKey();
        }
        //Cau q: Cap nhat so hoan thien thanh 0


        //Cau p: tham phan tu vao danh sach tang dan
        static void ThemTang (LinkedList L, int data)
        {
            if (data < L.First.Data)
            {
                L.AddFirst(data);
            }
            else if (data > L.Last.Data)
            {
                {
                    L.AddLast(data);
                }
            }
            else
            {
                Node pNew = new Node(data);
                for (Node p = L.First; p.Next != null; p = p.Next)
                {
                    if (data <= p.Next.Data)
                    {
                        pNew.Next = p.Next;
                        p.Next = pNew;
                        L.Count++;
                        break;
                    }
                }
            }
        }

        //Cau o: Sap xep tang dan InterchangeSort

        //Cau n: Xoa phan tu lap lai
        static void XoaPhanTuTrung(LinkedList L)
        {
            for (Node p = L.First; p != null; p = p.Next)
            {
                for (Node q = p; q.Next != null;)
                {
                    if (p.Data == q.Next.Data)
                    {
                        L.RemoveAfter(q);
                    }
                    else
                    {
                        q = q.Next;
                    }
                }
            }
        }

        //Cau m: Xoa phan tu sau phan tu q trong danh sach
        //RemoveAfter->LinkedList

        //Cau l: Xoa phan tu co gia tri = x
        //Remove value->LinkedList

        //Cau k: Xoa k phan tu dau danh sach
        static void XoaK_PhanTuDau(LinkedList L)
        {
            int k = 0;
            do
            {
                Console.Write("Nhap k: ");
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k > L.Count);
            for (int i = 0; i < k; i++)
            {
                L.RemoveFirst();
            }
            Console.WriteLine("Danh sach sau khi xoa");
            L.PrintList();

        }
        //Cai j: Them phan tu khong trung
        static void ThemKhongTrung(LinkedList L)
        {
            int num;
            do
            {
                Console.Write("Nhap phan tu them vao");
                num = int.Parse(Console.ReadLine());
            } while (L.Find(num) != null);
            L.AddLast(num);

        }
        //Cau i: Them phan tu vao sau phan tu q
        //Add after

        //Cau h: Tim phan tu co gia tri nho nhat
        //static int Min(LinkedList L)
        //{
        //    int min = 0;
        //    if ()
        //    {

        //    }
        //    return min;
        //}

        //Cau g: Tim va tra ve
        static int TimTraVe(LinkedList L, int k)
        {
            int i = 0;
            int kq = 0;
            for (Node p = L.First; p != null && i <= k; p = p.Next, i++)
            {
                kq = p.Data;
            }
            return kq;
        }

        //Cau f: Tim so chinh phuong cuoi cung
        static int SoChinhPhuongCuoiCung(LinkedList L)
        {
            int count = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (KiemTraSCP(p.Data))
                {
                    count = p.Data;
                }
            }
            return count;
        }

        //Kiem tra so chinh phuong
        static bool KiemTraSCP(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i * i == n)
                {
                    return true;
                }
            }
            return false;
        }

        //Cau e: Dem so lan xuat hien
        static int SoLanXuatHien(LinkedList L, int key)
        {
            int count = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (key == p.Data)
                {
                    count++;
                }
            }
            return count;
        }
        //Cau d: Tinh trung binh cong cua cac phan tu
        static double TrungBinhCong(LinkedList L)
        {
            double tbc = 0.0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                tbc += p.Data;
            }
            return tbc / L.Count;
        }
        //Cau c: Liet ke so nguyen to
        static void XuatSNT(LinkedList L)
        {
            Console.WriteLine("\nXuat danh sach so nguyen to");
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (KTSNT(p.Data) == true)
                {
                    Console.Write($"{p.Data,-5}");
                }
            }
            Console.WriteLine();
        }
        //Kiem tra so nguyen to
        static bool KTSNT(int a)
        {
            int dem = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    dem++;
                }
            }
            return dem == 2;
        }
        static void InputList(LinkedList L, int n)
        {
            Random rd = new Random();
            for (int i = 1; i <= n; i++)
            {
                L.AddFirst(rd.Next(1, 10));
            }
        }

    }
}
