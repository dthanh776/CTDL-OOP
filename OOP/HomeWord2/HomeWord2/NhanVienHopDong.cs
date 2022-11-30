using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord2
{
    class NhanVienHopDong:NhanVien
    {
        private double luongNgay;
        private double soNgay;

        public NhanVienHopDong(double luongNgay, double soNgay, Nguoi thongTinNhanVien) : base(thongTinNhanVien)
        {
            this.luongNgay = luongNgay;
            this.soNgay = soNgay;
        }
        ~NhanVienHopDong() { }

        public double LuongNgay
        {
            get { return luongNgay; }
            set { this.luongNgay = value; }
        }
        public double SoNgay
        {
            get { return soNgay; }
            set { this.soNgay = value; }
        }

        public override double TinhLuong()
        {
            return LuongNgay * SoNgay;
        }
        public override string toString()
        {
            string str = $"Ho ten: {ThongTinNhanVien.getHoTen(),-15} Dia chi: {ThongTinNhanVien.getDiaChi(),-15} Tinh luong: {TinhLuong()}";
            return str;
        }
    }
}
