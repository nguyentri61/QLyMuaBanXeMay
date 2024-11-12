using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class HoaDonLuong
    {
        private int maHDL;
        private int cCCDQL;
        private int cCCDNV;
        private double soGioLam;
        private DateTime ngayXuat;
        private decimal tongTien;

        public HoaDonLuong() { }

        public HoaDonLuong(int maHDL, int cCCDQL ,int cCCDNV, double soGioLam, DateTime ngayXuat, decimal tongTien)
        {
            this.MaHDL = maHDL;
            this.cCCDQL = cCCDNV;
            this.CCCDNV = cCCDNV;
            this.SoGioLam = soGioLam;
            this.NgayXuat = ngayXuat;
            this.TongTien = tongTien;
        }

        public int MaHDL { get => maHDL; set => maHDL = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public int CCCDQL { get => cCCDQL; set => cCCDQL = value; }
        public int CCCDNV { get => cCCDNV; set => cCCDNV = value; }
        public double SoGioLam { get => soGioLam; set => soGioLam = value; }
    }
}
