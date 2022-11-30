using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord2
{
    class Nguoi
    {
        private string hoTen;
        private string diaChi;
        private Date ngaySinh;

        public Nguoi(string hoTen, string diaChi, Date ngaySinh)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }
        ~Nguoi() { }
        public string getHoTen()
        {
            return hoTen;
        }
        public Date getNgaySinh()
        {
            return ngaySinh;
        }
        public string getDiaChi()
        {
            return diaChi;
        }
        public void setHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public void setDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
        public string toString()
        {
            string str = $"Ho ten: {getHoTen(),-15} Dia chi: {getDiaChi(),-15} Ngay sinh--{getNgaySinh().toString(),-15}";
            return str;
        }
    }
}
