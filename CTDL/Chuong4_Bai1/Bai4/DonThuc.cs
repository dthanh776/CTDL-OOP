using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class DonThuc
    {
        private double heSo;
        private int soMu;
        public double HeSo
        {
            get
            {
                return heSo;
            }

            set
            {
                heSo = value;
            }
        }

        public int SoMu
        {
            get
            {
                return soMu;
            }

            set
            {
                soMu = value;
            }
        }

        public void Print()
        {
            if (soMu == 0)
            {
                Console.Write(heSo);
            }
            else
            {
                Console.Write(heSo + "x^" + soMu);
            }
        }
    }
}
