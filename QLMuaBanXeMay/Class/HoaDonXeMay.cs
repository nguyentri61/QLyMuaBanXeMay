using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    

    public class HoaDonXe
    {
        private int maHDXe;
        private int maXe;
        private double khuyenMai;
        private double tongTien;
        private int ccCDKH;
        private int ccCDNV;
        private string pTTT;
        private DateTime ngayXuat;

        public HoaDonXe() { }

        public HoaDonXe(int maHDXe, int maXe, double khuyenMai, double tongTien, int ccCDKH, int ccCDNV, string pTTT, DateTime ngayXuat)
        {
            this.maHDXe = maHDXe;
            this.maXe = maXe;
            this.khuyenMai = khuyenMai;
            this.tongTien = tongTien;
            this.ccCDKH = ccCDKH;
            this.ccCDNV = ccCDNV;
            this.pTTT = pTTT;
            this.ngayXuat = ngayXuat;
        }

        public int MaHDXe
        {
            get { return maHDXe; }
            set { maHDXe = value; }
        }

        public int MaXe
        {
            get { return maXe; }
            set { maXe = value; }
        }

        public double KhuyenMai
        {
            get { return khuyenMai; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("KhuyenMai cannot be negative.");
                khuyenMai = value;
            }
        }

        public double TongTien
        {
            get { return tongTien; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("TongTien must be greater than 0.");
                tongTien = value;
            }
        }

        public int CCCDKH
        {
            get { return ccCDKH; }
            set { ccCDKH = value; }
        }

        public int CCCDNV
        {
            get { return ccCDNV; }
            set { ccCDNV = value; }
        }

        public string PTTT
        {
            get { return pTTT; }
            set { pTTT = value; }
        }

        public DateTime NgayXuat
        {
            get { return ngayXuat; }
            set { ngayXuat = value; }
        }

    }

}
