using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Nguoi
    {
        string hoTen;
        int ngaySinh;

        Nguoi()
        {
            hoTen = "";
            ngaySinh = 0;
        }
        ~Nguoi()
        {

        }
        public Nguoi(string hoTen, int ngaySinh)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
        }
        public string getHoTen()
        {
            return hoTen;
        }
        public void setTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public int getNgaySinh()
        {
            return ngaySinh;
        }
        public void setNgaySinh (int ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }
        public string toString()
        {
            string str;
            str = $"Ho ten: {hoTen} - Ngay Sinh: {ngaySinh}";
            return str;
        }
    }
}
