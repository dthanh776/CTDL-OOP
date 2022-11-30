using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BuiDuyThanh
{
    struct NhanVien
    {
        public string maNhanVien;
        public string hoTen;
        public DateTime ngaySinh;
        public double luong;
    }
    class Program
    {

        static void Main(string[] args)
        {
            //a) Doc danh sach nhan vien tu file
            NhanVien[] arr = DocDSSV();

            //b) Xuat danh sach nhan vien
            XuatDSSV(arr);
            string key;

            // c) Sap xep Interchange 
            Console.WriteLine();
            Console.WriteLine("Sap xep InterchangeSort");
            InterchangeSort(arr);

            // d) Tim nhi phan
            Console.WriteLine();
            Console.WriteLine("Nhap vao ma nhan vien can tim: ");
            key = Console.ReadLine();
            int kq = TimNhiPhan(arr, key);
            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay {key}");
            }
            else
            {
                Console.WriteLine($"Tim thay {key} tai vi tri {kq}");
            }

            //e) Sap xep Selection Sort
            //Console.WriteLine();
            //Console.WriteLine("\nSap xep Selection Sort");
            //SelectionSort(arr);

            //f) Tim va sua nhan vien
            Console.WriteLine();
            Console.WriteLine("Nhap vao ma sinh vien can sua (sua nhan vien): ");
            key = Console.ReadLine();
            TimNhanVien(arr, key);

            //g) Xoa nhan vien
            Console.WriteLine();
            Console.WriteLine("Nhap vao ma sinh vien can xoa (xoa nhan vien): ");
            key = Console.ReadLine();
            XoaNhanVien(ref arr, key);
            Console.ReadKey();
        }
        // a) Doc danh sach nhan vien tu file
        static NhanVien[] DocDSSV()
        {
            NhanVien[] arr;
            int n = 0;
            using (StreamReader sr = new StreamReader("input2.txt"))
            {
                n = int.Parse(sr.ReadLine());
                arr = new NhanVien[n];
                for (int i = 0; i < n; i++)
                {
                    string[] t = sr.ReadLine().Split('#');
                    arr[i].maNhanVien = t[0];
                    arr[i].hoTen = t[1];
                    arr[i].ngaySinh = DateTime.ParseExact(t[2],"MM/dd/yyyy",null);
                    arr[i].luong = double.Parse(t[3]);
                }
            }

            return arr;
        }
        // b) Xuat danh sach nhan vien 
        static void XuatDSSV(NhanVien[] arr)
        {
            Console.WriteLine("So luong nhan vien la: " + arr.Length);
            Console.WriteLine($"{"Ma nv",-12}{"Ho ten",-12}{"Ngay sinh",-12}{"Luong",-12}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].maNhanVien,-12}{arr[i].hoTen,-12}{arr[i].ngaySinh.ToString("MM/dd/yyyy"),-12}{arr[i].luong,-12}");
            }
        }
        // Ham doi vi tri
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // c) Sap xep InterchageSort tang dan theo ma nhan vien
        static void InterchangeSort(NhanVien[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (String.Compare(arr[i].maNhanVien,arr[j].maNhanVien) == 1)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            XuatDSSV(arr);
        }

        // d) Tim nhi phan theo ma nhan vien
        static int TimNhiPhan(NhanVien[] arr, string key)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (right + left) / 2;
                if (arr[mid].maNhanVien == key)
                {
                    return mid;
                }
                else if (String.Compare(arr[mid].maNhanVien, key) == -1)
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
        // e) Sap xep Selection Sort theo danh sach giam dan theo thang sinh
        static void SelectionSort(NhanVien[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min].ngaySinh.Month < arr[j].ngaySinh.Month)
                    {
                        min = j;
                    }
                }
                Swap(ref arr[min], ref arr[i]);
            }
            XuatDSSV(arr);
        }

        //f) Tim nhan vien theo ma nhan vien (nhi phan) va SUA nhan vien do
        static void TimNhanVien (NhanVien[] arr, string key)
        {
            int kq = TimNhiPhan(arr, key);
            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay {key}, khong sua duoc {key}");
            }
            else
            {
                Console.WriteLine($"Tim thay {key} tai vi tri {kq}");
                Console.WriteLine("Nhap ten nhan vien can sua");
                arr[kq].hoTen = Console.ReadLine();
                XuatDSSV(arr);
            }     
        }

        //g) Tim nhan vien theo ma nhan vien (nhi phan) va XOA nhan vien do
        static void XoaNhanVien (ref NhanVien[] arr, string key)
        {
            int kq = TimNhiPhan(arr, key);
            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay {key}, khong xoa duoc {key}");
            }
            else
            {             
                for (int i = kq; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);                                
                XuatDSSV(arr);
            }
        }
    }
}



