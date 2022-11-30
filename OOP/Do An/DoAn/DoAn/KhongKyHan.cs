using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class KhongKyHan : KhachHang
    {
        private float laiXuat;
        private float tienThuong;
        private static int soLuongKhongKyHan = 0;

        public KhongKyHan(float laiXuat, float tienThuong, string hoTen, DiaChi diaChi, DateTime ngayCapTK, float soTienGui) : base(hoTen, diaChi, ngayCapTK, soTienGui)
        {
            this.laiXuat = laiXuat;
            this.tienThuong = tienThuong;
            soLuongKhongKyHan++;
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
        public float TienThuong
        {
            get
            {
                return tienThuong;
            }
            set
            {
                tienThuong = value;
            }
        }
        public static int SoLuongKhongKyHan
        {
            get
            {
                return soLuongKhongKyHan;
            }
            set
            {
                soLuongKhongKyHan = value;
            }
        }
        public override double TienLai()
        {
            return TienThuong + SoTienGui * LaiXuat / 100;
        }
        public override string XuatThongTin()
        {
            double tongTien = SoTienGui + TienLai();
            return $"{base.XuatThongTin(),-15}" +
                $"Lai xuat: {LaiXuat + "%",-13}" +
                $"Tien Thuong: {TienThuong,-12}" +
                $"Tien lai: {TienLai():#,#,#}\n" +
                $"So tien nhan duoc: {tongTien:#,#,#}";



        }
    }
}
