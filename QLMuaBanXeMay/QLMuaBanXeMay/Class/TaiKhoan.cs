using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
   

    public class TaiKhoan
    {
        private int maTK;
        private string tenTK;
        private string matKhau;
        private int ccCDNV;

        public TaiKhoan(int maTK, string tenTK, string matKhau, int ccCDNV)
        {
            this.maTK = maTK;
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.ccCDNV = ccCDNV;
        }

        public int MaTK
        {
            get { return maTK; }
            set { maTK = value; }
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
