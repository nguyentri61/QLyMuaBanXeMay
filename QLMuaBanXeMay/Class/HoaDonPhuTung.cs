using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{

    public class HoaDonPT
    {
        private int maHDPT;
        private double khuyenMai;
        private double tongTien;
        private int ccCDKH;
        private int ccCDNV;
        private string pTTT;
        private DateTime ngayXuat;

        public HoaDonPT() { }
        public HoaDonPT(int maHDPT, double khuyenMai, double tongTien, int ccCDKH, int ccCDNV, string pTTT, DateTime ngayXuat)
        {
            this.maHDPT = maHDPT;
            this.khuyenMai = khuyenMai;
            this.tongTien = tongTien;
            this.ccCDKH = ccCDKH;
            this.ccCDNV = ccCDNV;
            this.pTTT = pTTT;
            this.ngayXuat = ngayXuat;
        }

        public int MaHDPT
        {
            get { return maHDPT; }
            set { maHDPT = value; }
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
                if (value < 0)
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
