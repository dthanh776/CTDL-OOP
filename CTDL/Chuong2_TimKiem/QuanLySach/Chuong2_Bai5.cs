using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySach
{
 struct Sach
    {
        public string maSach;
        public string tuaSach;
        public int namXuatBan;
        public int gia;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sach: ");
            int n = int.Parse(Console.ReadLine());

            Sach[] arr = new Sach[n];

            NhapSach(arr);
            Console.WriteLine();
            XuatSach(arr);

            Console.Write("Nhap vao sach can tim: ");
            string keySach = Console.ReadLine();

            TimTuaSach(arr, keySach);
            XuatSach(arr);

            XoaSach(ref arr,keySach);
            Console.ReadKey();
        }
        static void NhapSach (Sach[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Nhap sach thu: {i+1}" );
                do
                {
                    Console.Write("Nhap ma sach: ");
                    arr[i].maSach = Console.ReadLine();
                } while (arr[i].maSach.Length > 6 );

                do
                {
                    Console.Write("Nhap tua sach: ");
                    arr[i].tuaSach = Console.ReadLine();
                } while (arr[i].maSach.Length > 30);

                do
                {
                    Console.Write("Nhap nam: ");
                    arr[i].namXuatBan = int.Parse(Console.ReadLine());
                } while (arr[i].namXuatBan < 1900);

                do
                {
                    Console.Write("Nhap gia: ");
                    arr[i].gia = int.Parse(Console.ReadLine());
                } while (arr[i].gia > 999999);

            }          
        }
        
        static void XuatSach (Sach[] arr)
        {
            Console.WriteLine($"{"Ma sach", -10}  {"Tua sach" , -10}  {"Nam xuat ban",-10}  {"Gia sach",-10}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].maSach, -12} {arr[i].tuaSach, -12} {arr[i].namXuatBan, -12} {arr[i].gia , -12}");              
            }
        }

        static void TimTuaSach(Sach[] arr, string tuaSach)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].tuaSach == tuaSach)
                {
                    dem++;
                    Console.Write($"Sach tim duoc tai vi tri {i} \t");

                    Console.Write("\nNhap gia can sua: ");
                    arr[i].gia = int.Parse(Console.ReadLine());             
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Ko tim thay");
            }
        }

        static int TimMaSach(Sach[] arr, string maSach)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid].maSach == maSach)
                {
                    return mid;
                }
                else if (String.Compare(arr[mid].maSach,maSach) == -1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        static void XoaSach (ref Sach[]arr, string maSach)
        {
            int kq = TimMaSach(arr, maSach);
            if (kq == -1)
            {
                Console.WriteLine("Khong xoa duoc");
            }
            else
            {
                for (int i = kq; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }
        }

    }
}
