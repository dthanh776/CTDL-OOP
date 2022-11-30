using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai5
{
    class Phim
    {
        private string tenPhim, theLoai, tenDaoDien, tenNam, tenNu;
        private int namSX;

        public Phim(string tenPhim, string theLoai, string tenDaoDien, string tenNam, string tenNu, string namSX)
        {
            this.tenPhim = tenPhim;
            this.theLoai = theLoai;
            this.tenDaoDien = tenDaoDien;
            this.tenNam = tenNam;
            this.tenNu = tenNu;
            int.TryParse(namSX, out this.namSX);
        }
        public string Print()
        {
            return $"{tenPhim, -10}{theLoai,-10}{tenDaoDien,-10}{tenNam,-10}{tenNu,-10}{namSX,-10}";
        }
        public string TenPhim
        {
            get
            {
                return tenPhim;
            }

            set
            {
                tenPhim = value;
            }
        }

        public string TheLoai
        {
            get
            {
                return theLoai;
            }

            set
            {
                theLoai = value;
            }
        }

        public string TenDaoDien
        {
            get
            {
                return tenDaoDien;
            }

            set
            {
                tenDaoDien = value;
            }
        }

        public string TenNam
        {
            get
            {
                return tenNam;
            }

            set
            {
                tenNam = value;
            }
        }

        public string TenNu
        {
            get
            {
                return tenNu;
            }

            set
            {
                tenNu = value;
            }
        }

        public int NamSX
        {
            get
            {
                return namSX;
            }

            set
            {
                namSX = value;
            }
        }

    }
}
