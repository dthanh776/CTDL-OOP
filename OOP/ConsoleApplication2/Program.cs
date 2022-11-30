using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SinhVien sv = new SinhVien();
            //Console.WriteLine(sv.toString());

            //SinhVien sv1 = new SinhVien();
            //sv1.HoTen = "XYZ";
            //sv1.Tuoi = 15;
            //sv1.DiemVan = 2;
            //sv1.DiemToan = 10;
            //Console.WriteLine(sv1.toString());

            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            SinhVien[] arrSV = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap sinh vien thu {i + 1}");
                arrSV[i] = new SinhVien();
                arrSV[i].Nhap();
            }

            Console.WriteLine("----Danh sach sinh vien----");
            Console.WriteLine($"{"Ho ten",-15} {"Tuoi",-15} {"Diem van",-15} {"Diem toan",-15} {"Diem trung binh",-15}");
            for (int i = 0; i < n; i++)
            {
                arrSV[i].Xuat();
            
            }
            Console.ReadKey();
        }
    }
}
