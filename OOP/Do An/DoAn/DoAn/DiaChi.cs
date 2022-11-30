using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class DiaChi
    {
        private string soNha;
        private string tenDuong;
        private string quan;
        public DiaChi(string soNha = null, string tenDuong = null, string quan = null)
        {
            this.soNha = soNha;
            this.tenDuong = tenDuong;
            this.quan = quan;
        }
        public string SoNha
        {
            get
            {
                return soNha;
            }
            set
            {
                soNha = value;
            }
        }
        public string TenDuong
        {
            get
            {
                return tenDuong;
            }
            set
            {
                tenDuong = value;
            }
        }
        public string Quan
        {
            get
            {
                return quan;
            }
            set
            {
                quan = value;
            }
        }
        public string toString()
        {
            return $"{soNha}/{TenDuong}/{Quan}";
            
        }
    }
}
