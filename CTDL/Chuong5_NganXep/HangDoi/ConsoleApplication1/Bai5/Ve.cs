using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai5
{
    class Ve
    {
        private int soGhe;
        private string ten;

        public Ve(int soGhe, string ten)
        {
            this.SoGhe = soGhe;
            this.Ten = ten;
        }
        public Ve(string soGhe, string ten)
        {
            this.SoGhe = int.Parse(soGhe);
            this.Ten = ten;
        }

        public Ve()
        {
            this.SoGhe = 0;
            this.Ten = null;
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
