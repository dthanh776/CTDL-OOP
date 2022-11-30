using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord2
{
    class Date
    {
        private int ngay;
        private int thang;
        private int nam;

        public Date(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }
        ~Date() { }
        public Date()
        {
            this.ngay = 1;
            this.thang = 1;
            this.nam = 2000;
        }

        public int Ngay
        {
            get { return ngay; }
            set { this.ngay = value; }
        }
        public int Thang
        {
            get { return thang; }
            set { this.thang = value; }
        }
        public int Nam
        {
            get { return nam; }
            set { this.nam = value; }
        }

        public static bool operator ==(Date d1, Date d2)
        {
            return d1.Ngay.Equals(d2.Ngay) && d1.Thang.Equals(d2.Thang) && d1.Nam.Equals(d2.Nam);
        }
        public static bool operator !=(Date d1, Date d2)
        {
            return !(d1 == d2);
        }

        public string toString()
        {
            string str = $"Ngay: {Ngay,-5} Thang: {Thang,-5} Nam: {Nam,-5}";
            return str;
        }
    }
}
