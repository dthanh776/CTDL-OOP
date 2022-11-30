using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class HangHoa
    {
        private string maHang;
        private string tenHang;
        private int soLuong;
        private int donGia;

        public string MaHang
        {
            get
            {
                return maHang;
            }

            set
            {
                maHang = value;
            }
        }

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public HangHoa(string maHang, string tenHang, int soLuong, int donGia)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }
        public HangHoa(string maHang, string tenHang, string soLuong, string donGia)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.SoLuong = int.Parse(soLuong);
            this.DonGia = int.Parse(donGia);
        }
        public void Print()
        {
            Console.WriteLine($"{maHang,-10}{tenHang,-10}{maHang,-10}{donGia,-10}");
        }
    }
}
