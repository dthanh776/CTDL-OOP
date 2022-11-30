using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_bai4
{
    class BienLai:KhachHang
    {
        private double chiSoCu;
        private double chiSoMoi;
        private int soKhachHang;
        private KhachHang[] khachHang;
        public BienLai()
        {
            chiSoCu = 0;
            chiSoMoi = 0;
            soKhachHang = 0;
            khachHang = null;
        }
        ~BienLai() { }
        public BienLai(double chiSoCu, double chiSoMoi, int soKhachHang, KhachHang[]khachHang)
        {
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
            this.soKhachHang = soKhachHang;
            this.khachHang = khachHang;
        }
        public double ChiSoCu
        {
            get { return this.chiSoCu; }
            set { this.chiSoCu = value; }
        }
        public double ChiSoMoi
        {
            get { return this.chiSoMoi; }
            set { this.chiSoMoi = value; }
        }
        public int SoKhachHang
        {
            get { return this.soKhachHang; }
            set { this.soKhachHang = value; }
        }

        public void Nhap()
        {
            do
            {
                Console.Write("Nhap chi so cu: ");
                chiSoCu = int.Parse(Console.ReadLine());
                Console.Write("Nhap chi so moi: ");
                ChiSoMoi = double.Parse(Console.ReadLine());
            } while (this.chiSoCu > this.chiSoMoi);

            Console.Write("So luong khach hang: ");
            SoKhachHang = int.Parse(Console.ReadLine());
            khachHang = new KhachHang[SoKhachHang];
            for (int i = 0; i < SoKhachHang; i++)
            {
                khachHang[i] = new KhachHang();
                khachHang[i].Nhap();
            }
        }
        public double SoTienPhaiTra()
        {
            return (chiSoMoi - chiSoCu) * 750;
        }
        public string print()
        {
            return $"{ChiSoCu,-15} {chiSoMoi,-15} {SoTienPhaiTra(),-15}";
        }
        public void Xuat()
        {
            Console.WriteLine("Hoa don tien dien: ");
            Console.WriteLine($"{"Chu ho", 15} {"So nha",15} {"So cong to",15}");
            for (int i = 0; i < SoKhachHang; i++)
            {
                Console.WriteLine(khachHang[i].Xuat());
            }
            Console.WriteLine(print());
            Console.WriteLine("--------------------");
        }
    }
}
