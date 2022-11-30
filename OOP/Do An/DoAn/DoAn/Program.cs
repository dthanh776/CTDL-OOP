using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so luong khach hang
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Nhap so luong khach hang: ");
            Console.ForegroundColor = ConsoleColor.White;
            int n = int.Parse(Console.ReadLine());
            KhachHang[] khachHang = new KhachHang[n];

            //goi ham nhap thong tin khach hang
            Nhap(khachHang);

            //goi ham xuat thong tin khach hang
            Xuat(khachHang);

            //goi ham so luong co ky han
            SoLuongCoKyHan(khachHang);

            //goi ham so luong khong ky han
            SoLuongKhongKyHan(khachHang);

            //goi ham tim kiem
            TimKiem(khachHang);

            //dung man hinh
            Console.ReadKey();
        }
        //ham nhap thong tin
        static void Nhap(KhachHang[] khachHang)
        {
            for (int i = 0; i < khachHang.Length; i++)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Nhap thong tin khach hang");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nNhap ho ten: ");
                Console.ForegroundColor = ConsoleColor.White;
                string hoten = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Nhap so nha: ");
                Console.ForegroundColor = ConsoleColor.White;
                string soNha = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Nhap ten duong: ");
                Console.ForegroundColor = ConsoleColor.White;
                string tenDuong = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Nhap quan: ");
                Console.ForegroundColor = ConsoleColor.White;
                string quan = Console.ReadLine();
                int ngay, thang, nam;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap ngay cap: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    ngay = int.Parse(Console.ReadLine());
                } while (ngay > 31 || ngay < 1);
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap thang cap: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    thang = int.Parse(Console.ReadLine());
                } while (thang < 1 || thang > 12);
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap nam cap: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    nam = int.Parse(Console.ReadLine());
                } while (nam <= DateTime.Now.Year - 100 || nam >= DateTime.Now.Year);
                DateTime ngayCapTK = new DateTime(nam, thang, ngay);

                float soTienGui;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap so tien ban muon gui: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    soTienGui = float.Parse(Console.ReadLine());
                } while (soTienGui < 0);

                int check;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("1: Gui co ky han \t 2: Gui khong ky han ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap loai gui tien ban muon: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    check = int.Parse(Console.ReadLine());
                } while (check != 1 && check != 2);

                if (check == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ban da chon gui CO ky han");
                    float laiXuat;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Nhap lai xuat co ky han: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        laiXuat = float.Parse(Console.ReadLine());
                    } while (laiXuat < 0 || laiXuat > 100);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap so thang can gui: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int soThang = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap ngay dao han: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int ngayDaoHan = int.Parse(Console.ReadLine());
                    khachHang[i] = new CoKyHan(laiXuat, soThang, ngayDaoHan, hoten, new DiaChi(soNha, tenDuong, quan), ngayCapTK, soTienGui);
                }
                if (check == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ban da chon gui KHONG ky han");
                    float laiXuat;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Nhap lai xuat khong ky han: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        laiXuat = float.Parse(Console.ReadLine());
                    } while (laiXuat < 0 || laiXuat > 100);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Nhap tien thuong: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    float tienThuong = float.Parse(Console.ReadLine());
                    khachHang[i] = new KhongKyHan(laiXuat, tienThuong, hoten, new DiaChi(soNha, tenDuong, quan), ngayCapTK, soTienGui);
                }
            }
        }
        //ham xuat thong tin
        static void Xuat(KhachHang[] khacHang)
        {
            Console.Clear();
            for (int i = 0; i < khacHang.Length; i++)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Xuat thong tin khach hang");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(khacHang[i].XuatThongTin());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.Write("*************************");
                Console.Write("******************************");
                Console.WriteLine();
            }
        }
        //ham hien thi so luong KHONG ky han
        static void SoLuongKhongKyHan(KhachHang[] khachHang)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("So luong KHONG ky han la: " + KhongKyHan.SoLuongKhongKyHan);
          
        }
        //ham hien thi so luong CO ky han
        static void SoLuongCoKyHan(KhachHang[] khachHang)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("So luong CO ky han la: " + CoKyHan.SoLuongCoKyHan);
            
        }
        //ham tim kiem
        static void TimKiem(KhachHang[] khachHang)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("******************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nNhap ten ban muon tin kiem: ");
            Console.ForegroundColor = ConsoleColor.White;
            string ten = Console.ReadLine();

            bool check = false;
            for (int i = 0; i < khachHang.Length; i++)
            {
                if (khachHang[i].HoTen == ten)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("******************************");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Tim thay: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ten);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("******************************");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Thong tin cua: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ten);
                    Console.WriteLine(khachHang[i].XuatThongTin());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("******************************");
                    Console.WriteLine();
                    check = true;
                }
            }
            if (check == false)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Khong tim thay: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(ten);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("******************************");
                Console.WriteLine();
            }
        }
    }
}
