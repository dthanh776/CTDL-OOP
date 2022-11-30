using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord2
{
    class Program
    {
        static void Main(string[] args)
        {
            Nguoi nguoi = new Nguoi("Thanh", "Vo Van Ngan", new Date(2, 2, 2022));
            Console.WriteLine(nguoi.toString());
            Date d1 = new Date(4, 4, 2004);
            Date d2 = new Date(4, 4, 2004);
            Console.WriteLine(d1 == d2);

            Console.WriteLine();

            NhanVienBienChe nhanVienBienChe = new NhanVienBienChe(2000000, 2, new Nguoi("Thanh Bien Che", "Le Van Viet", new Date(1, 1, 2021)));
            Console.WriteLine("Tinh luong bien che: " + nhanVienBienChe.TinhLuong());
            Console.WriteLine(nhanVienBienChe.toString());

            Console.WriteLine();

            NhanVienHopDong nhanVienHopDong = new NhanVienHopDong(3000000, 15, new Nguoi("Thanh Hop Dong", "La Xuan Oai", new Date(3, 3, 2023)));
            Console.WriteLine("Tinh luong hop dong: " + nhanVienHopDong.TinhLuong());
            Console.WriteLine(nhanVienHopDong.toString());

            Console.WriteLine();

            NhanVien nhanVien1 = new NhanVienBienChe(2000000, 2, new Nguoi("Thanh Bien Che", "Le Van Viet", new Date(1, 1, 2021)));
            Console.WriteLine("Da hinh dong tinh luong bien che: "+nhanVien1.TinhLuong());

            NhanVien nhanVien2 = new NhanVienHopDong(3000000, 15, new Nguoi("Thanh Hop Dong", "La Xuan Oai", new Date(3, 3, 2023)));
            Console.WriteLine("Da hinh dong tinh luong hop dong: " + nhanVien2.TinhLuong());
            Console.ReadKey();
        }
    }
}
