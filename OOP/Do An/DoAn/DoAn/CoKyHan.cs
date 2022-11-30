using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class CoKyHan : KhachHang
    {
        private float laiXuat;
        private double soThang;
        private int ngayDaoHan;
        private static int soLuongCoKyHan = 0;

        public CoKyHan(float laiXuat, double soThang, int ngayDaoHan, string hoTen, DiaChi diaChi, DateTime ngayCapTK, float soTienGui) : base(hoTen, diaChi, ngayCapTK, soTienGui)
        {
            this.laiXuat = laiXuat;
            this.soThang = soThang;
            this.ngayDaoHan = ngayDaoHan;
            soLuongCoKyHan++;
        }
        public float LaiXuat
        {
            get
            {
                return laiXuat;
            }
            set
            {
                laiXuat = value;
            }
        }
        public double SoThang
        {
            get
            {
                return soThang;
            }
            set
            {
                soThang = value;
            }
        }
        public int NgayDaoHan
        {
            get
            {
                return ngayDaoHan;
            }
            set
            {
                ngayDaoHan = value;
            }
        }
        public static int SoLuongCoKyHan
        {
            get
            {
                return soLuongCoKyHan;
            }
            set
            {
                soLuongCoKyHan = value;
            }
        }
        public override double TienLai()
        {
            return SoTienGui * LaiXuat / 100 * SoThang;
        }
        public override string XuatThongTin()
        {
            double tongTien = SoTienGui + TienLai();
            return $"{base.XuatThongTin(),-15}" +
                $"Lai xuat: {LaiXuat + "%",-13}" +
                $"So thang: {SoThang,-15}" +
                $"Ngay dao han: {NgayDaoHan,-15}" +
                $"Tien lai: {TienLai():#,#,#}\n" +
                $"So tien nhan duoc: {tongTien:#,#,#}";
        }
    }
}
