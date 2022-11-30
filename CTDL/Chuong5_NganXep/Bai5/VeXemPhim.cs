using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai5_Chuong5
{
    class VeXemPhim
    {
        private int soGhe;
        private string ten;

        public VeXemPhim(int soGhe, string ten)
        {
            this.SoGhe = soGhe;
            this.Ten = ten;
        }
        public VeXemPhim(string soGhe, string ten)
        {
            this.SoGhe = int.Parse(soGhe);
            this.Ten = ten;
        }
        public VeXemPhim()
        {
            this.SoGhe = soGhe;
            this.Ten = ten;
        }

        public int SoGhe
        {
            get
            {
                return soGhe;
            }

            set
            {
                soGhe = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
        public string Print()
        {
            return $"{soGhe,-10}{ten,-10}";
        }
    }
}
