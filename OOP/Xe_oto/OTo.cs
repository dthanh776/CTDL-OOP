using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class OTo : Xe
    {
        private int soChoNgoi;
        private double trongTai;

        public OTo()
        {
            this.soChoNgoi = 0;
            this.trongTai = 0;
        }
        public OTo(int soChoNgoi, int trongTai, string nhanHieu, double gia, int namSX) : base(nhanHieu, gia, namSX)
        {
            this.SoChoNgoi = soChoNgoi;
            this.TrongTai = trongTai;
        }

        public int SoChoNgoi
        {
            get
            {
                return soChoNgoi;
            }

            set
            {
                soChoNgoi = value;
            }
        }

        public double TrongTai
        {
            get
            {
                return trongTai;
            }

            set
            {
                trongTai = value;
            }
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho ngoi: ");
            this.SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap trong tai: ");
            this.TrongTai = double.Parse(Console.ReadLine());
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{"So cho ngoi",-10}{"trong tai",-10}");
            Console.WriteLine($"{this.SoChoNgoi,-10}{this.TrongTai,-10}");
        }
    }


}
