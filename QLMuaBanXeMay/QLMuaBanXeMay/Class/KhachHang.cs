using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
   

    public class KhachHang
    {
        private int ccCDKH;
        private string tenKH;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;
        private string diaChi;
        private string email;
        private int maLoai;
        private float tongChiTieu;
        public KhachHang() { }

        public KhachHang(int ccCDKH, string tenKH, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, string email, int maLoai, float tongChiTieu)
        {
            this.ccCDKH = ccCDKH;
            this.tenKH = tenKH;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.email = email;
            this.maLoai = maLoai;
            this.tongChiTieu = tongChiTieu;
        }

        public int CCCDKH
        {
            get { return ccCDKH; }
            set { ccCDKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
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

        public int MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        public float TongChiTieu
        {
            get { return tongChiTieu; }
            set { tongChiTieu = value; }
        }

    }

}
