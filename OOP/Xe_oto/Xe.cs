using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Xe
    {
        private string nhanHieu;
        private double gia;
        private int namSX;

        public Xe()
        {
            this.nhanHieu = "";
            this.gia = 0;
            this.namSX = 0;
        }
        public Xe(string nhanHieu, double gia, int namSX)
        {
            this.nhanHieu = nhanHieu;
            this.gia = gia;
            this.namSX = namSX;
        }
        public string NhanHieu
        {
            get
            {
                return nhanHieu;
            }

            set
            {
                nhanHieu = value;
            }
        }

        public double Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public int NamSX
        {
            get
            {
                return namSX;
            }

            set
            {
                namSX = value;
            }
        }
        public void Nhap()
        {
            Console.Write("Nhap nhan hieu: ");
            this.nhanHieu = Console.ReadLine();
            Console.Write("Nhap gia: ");
            this.gia = double.Parse(Console.ReadLine());
            Console.Write("Nhap namsx: ");
            this.namSX = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{"nhan hieu",-10}{"gia",-10}{"Nam SX",-10}");
            Console.WriteLine($"{this.NhanHieu,-10}{this.Gia,-10}{this.NamSX,-10}");
        }
    }
}
