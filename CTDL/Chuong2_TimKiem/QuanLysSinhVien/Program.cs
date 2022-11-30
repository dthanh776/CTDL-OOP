using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLysSinhVien
{
    struct SinhVien
    {
        public string maSinhVien;
        public string hoTen;
        public DateTime ngaySinh;
        public int soLuongMonHoc;
        public MonHoc[] arrMH;
    }
    struct MonHoc
    {
        public string maMon;
        public string tenMon;
        public int soTinChi;
        public int diem;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int sinhVien = int.Parse(Console.ReadLine());

            SinhVien[] arr = new SinhVien[sinhVien];

            NhapSinhVien(arr);
            Console.WriteLine();
            XuatSinhVien(arr);
            Console.ReadKey();
        }

        static void NhapSinhVien (SinhVien[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"\nNhap sinh vien thu {i + 1}");
                do
                {
                    Console.Write("Nhap ma sinh vien: ");
                    arr[i].maSinhVien = Console.ReadLine();
                } while (arr[i].maSinhVien.Length < 11 || arr[i].maSinhVien.Length > 11);

                    Console.Write("Nhap ten sinh vien: ");
                    arr[i].hoTen = Console.ReadLine();

                    Console.Write("Nhap ngay sinh: ");
                    arr[i].ngaySinh = DateTime.Parse(Console.ReadLine());

                    Console.Write("Nhap so luong mon hoc: ");
                    arr[i].soLuongMonHoc = int.Parse(Console.ReadLine());

                arr[i].arrMH = new MonHoc[arr[i].soLuongMonHoc];
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine($"\nNhap mon hoc thu {j + 1}");

                    Console.Write("Nhap ma mon hoc: ");
                    arr[i].arrMH[j].maMon = Console.ReadLine();

                    Console.Write("Nhap ten mon hoc: ");
                    arr[i].arrMH[j].tenMon = Console.ReadLine();

                    Console.Write("Nhap so tin chi: ");
                    arr[i].arrMH[j].soTinChi =int.Parse(Console.ReadLine());

                    Console.Write("Nhap diem: ");
                    arr[i].arrMH[j].diem = int.Parse(Console.ReadLine());
                }
                }
        } 
        static void XuatSinhVien (SinhVien[] arr)
        {
            int dem = 0;
            double dtb = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("MaSV: " + arr[i].maSinhVien);
                Console.WriteLine("Ho ten: " + arr[i].hoTen);
                Console.WriteLine("Ngay sinh" + arr[i].ngaySinh);

                for (int j = 0; j < arr[i].soLuongMonHoc; j++)
                {
                    dem++;
                    Console.WriteLine($"{"Ma mon",-10}  {"Ten mon",-10}  {"Tin chi",-10}  {"Diem trung binh",-10}");
                    Console.WriteLine($"{arr[i].arrMH[j].maMon,-12} {arr[i].arrMH[j].tenMon,-12} {arr[i].arrMH[j].soTinChi,-12} {dtb = arr[i].arrMH[j].diem / dem}");
                }

            }
        }


    }
}
