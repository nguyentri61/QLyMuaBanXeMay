using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class ChiTietHoaDonLuong
    {
        private int maHDL;
        private int cCCDQL;
        private int cCCDNV;
        private string tenNV;
        private string chucVu;
        private double soGioLam;
        private DateTime ngayXuat;
        private int luongCoBan;
        private decimal tongTien;


        public ChiTietHoaDonLuong() { }

        public ChiTietHoaDonLuong(int maHDL, int cCCDNV, string tenNV, string chucVu, double soGioLam, DateTime ngayXuat, int luongCoBan, decimal tongTien)
        {
            this.MaHDL = maHDL;
            this.CCCDNV = cCCDNV;
            this.TenNV = tenNV;
            this.ChucVu = chucVu;
            this.SoGioLam = soGioLam;
            this.NgayXuat = ngayXuat;
            this.TongTien = tongTien;
            this.LuongCoBan = luongCoBan;
        }

        public int MaHDL { get => maHDL; set => maHDL = value; }
        public int CCCDQL { get => cCCDQL; set => cCCDQL = value; }
        public int CCCDNV { get => cCCDNV; set => cCCDNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double SoGioLam { get => soGioLam; set => soGioLam = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public int LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}
