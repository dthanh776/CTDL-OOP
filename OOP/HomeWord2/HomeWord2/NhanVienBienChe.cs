using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord2
{
    class NhanVienBienChe:NhanVien
    {
        private double luongCB;
        private double heSo;

        public NhanVienBienChe(double luongCB, double heSo, Nguoi thongTinNhanVien):base(thongTinNhanVien)
        {
            this.luongCB = luongCB;
            this.heSo = heSo;
        }
        ~NhanVienBienChe() { }

        public double LuongCB
        {
            get { return luongCB; }
            set { this.luongCB = value; }
        }
        public double HeSo
        {
            get { return heSo; }
            set { this.heSo = value; }
        }

        public override double TinhLuong()
        {
            return HeSo * LuongCB;
        }
        public override string toString()
        {
            string str = $"Ho ten: {ThongTinNhanVien.getHoTen(),-15} Dia chi: {ThongTinNhanVien.getDiaChi(),-15} Tinh luong: {TinhLuong()}";
            return str;
        }
    }
}
