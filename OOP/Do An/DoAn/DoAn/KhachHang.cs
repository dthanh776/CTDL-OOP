using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    abstract class KhachHang
    {
        private string hoTen;
        private DiaChi diaChi;
        private DateTime ngayCapTK;
        private float soTienGui;
   
        public KhachHang(string hoTen, DiaChi diaChi, DateTime ngayCapTK, float soTienGui)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngayCapTK = ngayCapTK;
            this.soTienGui = soTienGui;
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        public DiaChi DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public DateTime NgayCapTK
        {
            get
            {
                return ngayCapTK;
            }
            set
            {
                ngayCapTK = value;
            }
        }
        public float SoTienGui
        {
            get
            {
                return soTienGui;
            }
            set
            {
                soTienGui = value;
            }
        }
        public virtual string XuatThongTin()
        {
            return $"Ho ten: {HoTen,-15}" +
                $"Dia chi: {DiaChi.toString(),-15} " +
                $"Ngay cap: {NgayCapTK.ToString("yyyy/MM/dd"),-15} " +
                $"So tien gui: {SoTienGui:#,#,#} \n";
        }

        public abstract double TienLai();
    }
}
