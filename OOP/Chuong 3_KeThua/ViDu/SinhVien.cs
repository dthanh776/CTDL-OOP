using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class SinhVien : Nguoi
    {
        int maSo;

        public SinhVien(int maSo, string hoTen, int ngaySinh):base(hoTen,ngaySinh)
        {
            this.maSo = maSo;
        }
        public int getMaSo()
        {
            return maSo;
        }
        public void setMaSo(int maSo)
        {
            this.maSo = maSo;
        }
        //public int getNgaySinh()
        //{
        //    return this.ngaySinh;
        //}
        //public void setNgaySinh(int ngaySinh)
        //{
        //    this.ngaySinh = ngaySinh;
        //}
        //public string getHoTen()
        //{
        //    return this.hoTen;
        //}
        //public void setHoTen(string hoTen)
        //{
        //    this.hoTen = hoTen;
        //}
        public new string toString()
        {
            string str;
            str = $"Ma so: {maSo} - Ho ten: {base.getHoTen()} - Ngay sinh: {base.getNgaySinh()}";
            return str;
        }
    }
}
