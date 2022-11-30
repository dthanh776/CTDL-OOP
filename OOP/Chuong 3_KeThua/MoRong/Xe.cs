using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Xe
    {
        private string nhanHieu;
        private double gia;
        private int namSanXuat;

        public Xe()
        {
            nhanHieu = "";
            gia = 0;
            namSanXuat = 0;
        }
        ~Xe() { }

        public Xe (string nhanHieu, double gia, int namSanXuat)
        {
            this.nhanHieu = nhanHieu;
            this.gia = gia;
            this.namSanXuat = namSanXuat;
        }       
        public string NhanHieu
        {
            get
            {
                return this.nhanHieu;
            }
            set
            {
                this.nhanHieu = value;
            }
        }
        public double Gia
        {
            get
            {
                return this.gia;
            }
            set
            {
                this.gia = value;
            }
        }
        public int NamSanXuat
        {
            get
            {
                return this.namSanXuat;
            }
            set
            {
                this.namSanXuat = value;
            }
        }

        public void Nhap()
        {
            Console.Write("Nhan hieu: ");
            NhanHieu = Console.ReadLine();
            Console.Write("Gia");
            Gia = int.Parse(Console.ReadLine());
            Console.Write("Nam san xuat");
            NamSanXuat = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Nhan hieu" + NhanHieu);
            Console.WriteLine("Gia" + Gia);
            Console.WriteLine("Nam san xuat" + NamSanXuat);
        }
    }

}
