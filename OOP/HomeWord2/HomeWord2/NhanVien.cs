using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord2
{
    abstract class NhanVien
    {
        private Nguoi thongTinNhanVien;

        protected NhanVien(Nguoi thongTinNhanVien)
        {
            this.thongTinNhanVien = thongTinNhanVien;
        }

        public Nguoi ThongTinNhanVien
        {
            get { return thongTinNhanVien; }
            set { this.thongTinNhanVien = value; }
        }
        public abstract double TinhLuong();

        public abstract string toString();

    }
}
