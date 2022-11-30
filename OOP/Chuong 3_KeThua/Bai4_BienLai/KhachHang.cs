using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_bai4
{
    public class KhachHang
    {
        private string hoTen;
        private string soNha;
        private double maSoCongTo;

        public KhachHang()
        {
            hoTen = "";
            soNha = "";
            maSoCongTo = 0;
        }
        ~KhachHang() { }
        public KhachHang(string hoTen, string soNha, double maSoCongTo)
        {
            this.hoTen = hoTen;
            this.soNha = soNha;
            this.maSoCongTo = maSoCongTo;
        }

        public string HoTen
        {
            get { return hoTen; }
            set { this.hoTen = value; }
        }
        public string SoNha
        {
            get { return soNha; }
            set { this.soNha = value; }
        }
        public double MaSoCongTo
        {
            get { return maSoCongTo; }
            set { this.maSoCongTo = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so nha: ");
            soNha = Console.ReadLine();
            Console.Write("Nhap so cong to: ");
            maSoCongTo = double.Parse(Console.ReadLine());
        }
        public string Xuat()
        {
            return $"{HoTen,-15} {SoNha,-15} {MaSoCongTo,-15}";
        }

    }
}
