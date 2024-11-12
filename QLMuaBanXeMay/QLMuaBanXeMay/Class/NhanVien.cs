using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
   

    public class NhanVien
    {
        private int ccCDNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;
        private string diaChi;
        private string email;
        private string chucVu;

        public NhanVien(int ccCDNV, string tenNV, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, string email, string chucVu)
        {
            this.ccCDNV = ccCDNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.email = email;
            this.chucVu = chucVu;
        }

        public int CCCDNV
        {
            get { return ccCDNV; }
            set { ccCDNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
    }

}
