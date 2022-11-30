using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SinhVien
    {
        private string hoTen;
        private int tuoi;
        private double diemVan;
        private double diemToan;
        private double diemTrungBinh;

        public SinhVien()
        {
            this.hoTen = "";
            this.tuoi = 0;
            this.diemVan = 0;
            this.diemToan = 0;
            this.diemTrungBinh = 0;

        }
        public SinhVien(string hoTen, int tuoi, double diemVan, double diemToan)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
        }
        public string HoTen 
            {
            get { return hoTen; }
            set { this.hoTen = value; }
            }
        public int Tuoi
        {
            get { return tuoi; }
            set { this.tuoi = value; }
        }
        public double DiemVan
        {
            get { return diemVan; }
            set { this.diemVan = value; }
        }
        public double DiemToan
        {
            get { return diemToan; }
            set { this.diemToan = value; }
        }

        public double DiemTrungBinh
        {
            get { return diemTrungBinh = (DiemVan + DiemToan) / 2; ; }
            set
            {
                this.diemTrungBinh = value;
            }
        }

        public void Nhap()
        {
            Console.Write(" \t-Nhap ho ten: ");
            this.HoTen = Console.ReadLine();
            do
            {
                Console.Write("\t-Nhap tuoi:  ");
                this.tuoi = int.Parse(Console.ReadLine());
            } while (this.Tuoi < 0 || this.Tuoi > 100 );
            do
            {
                Console.Write("\t-Nhap diem van: ");
                this.DiemVan = double.Parse(Console.ReadLine());
            } while (this.DiemVan < 0 || this.DiemVan > 10);
            do
            {
                Console.Write("\t-Nhap diem toan: ");
                this.DiemToan = double.Parse(Console.ReadLine());
            } while (this.DiemToan < 0 || this.DiemToan > 10);
        }

        public void Xuat()
        {
            Console.WriteLine($"{this.HoTen,-15} {this.Tuoi,-15} {this.DiemVan,-15} {this.DiemToan,-15} {this.DiemTrungBinh,-15}");
        }
    }
}
