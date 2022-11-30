using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class OTo:Xe
    {
        private int soChoNgoi;
        private double vanTai;

        public OTo():base()
        {
            soChoNgoi = 0;
            vanTai = 0;
        }
        public OTo(string nhanHieu, double gia, int namSanXuat, int soChoNgoi, double vanTai):base(nhanHieu, gia, namSanXuat)
        {
            this.soChoNgoi = soChoNgoi;
            this.vanTai = vanTai;
        }

        public int SoChoNgoi
        {
            get
            {
                return this.soChoNgoi;
            }
            set
            {
                this.soChoNgoi = value;
            }
        }
        public double VanTai
        {
            get
            {
                return this.vanTai;
            }
            set
            {
                this.vanTai = value;
            }
        }

        public new void Nhap()
        {
            base.Nhap();
            SoChoNgoi = int.Parse(Console.ReadLine());
            VanTai = double.Parse(Console.ReadLine());
        }

        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi: " + SoChoNgoi);
            Console.WriteLine("Van tai" + VanTai);
        }

    }

}
