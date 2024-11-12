using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    

    public class LoaiKH
    {
        private int maLoai;
        private string tenLoai;
        private float ctCanDat;
        private float khuyenMai;

        public LoaiKH(int maLoai, string tenLoai, float ctCanDat, float khuyenMai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.ctCanDat = ctCanDat;
            this.khuyenMai = khuyenMai;
        }

        public int MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

        public float CTCanDat
        {
            get { return ctCanDat; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("CTCanDat must be greater than 0.");
                ctCanDat = value;
            }
        }

        public float KhuyenMai
        {
            get { return khuyenMai; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("KhuyenMai cannot be negative.");
                khuyenMai = value;
            }
        }
    }

}
