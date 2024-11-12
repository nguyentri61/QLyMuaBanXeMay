using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
   

    public class TaiKhoan
    {
        private string tenTK;
        private string matKhau;
        private int ccCDNV;

        public TaiKhoan() { }
        public TaiKhoan(string tenTK, string matKhau, int ccCDNV)
        {
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.ccCDNV = ccCDNV;
        }

        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public int CCCDNV
        {
            get { return ccCDNV; }
            set { ccCDNV = value; }
        }

    }

}
