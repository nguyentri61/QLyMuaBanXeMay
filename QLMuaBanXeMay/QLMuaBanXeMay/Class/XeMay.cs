using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class XeMay
    {
        private int maXe; 
        private string tenXe; 
        private float donGia; 
        private string loaiXe; 
        private string mauSac; 
        private int phanKhoi; 
        private float congSuat; 
        private string hangSX; 
        private int namSX; 
        private string tinhTrang; 

        
        public int MaXe
        {
            get { return maXe; }
            set { maXe = value; }
        }

        public string TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set
            {
                if (value > 0) 
                    donGia = value;
                else
                    throw new ArgumentException("Đơn giá phải lớn hơn 0");
            }
        }

        public string LoaiXe
        {
            get { return loaiXe; }
            set { loaiXe = value; }
        }

        public string MauSac
        {
            get { return mauSac; }
            set { mauSac = value; }
        }

        public int PhanKhoi
        {
            get { return phanKhoi; }
            set { phanKhoi = value; }
        }

        public float CongSuat
        {
            get { return congSuat; }
            set { congSuat = value; }
        }

        public string HangSX
        {
            get { return hangSX; }
            set { hangSX = value; }
        }

        public int NamSX
        {
            get { return namSX; }
            set { namSX = value; }
        }

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

     
        public XeMay(int maXe, string tenXe, float donGia, string loaiXe, string mauSac,
                      int phanKhoi, float congSuat, string hangSX, int namSX, string tinhTrang)
        {
            MaXe = maXe;
            TenXe = tenXe;
            DonGia = donGia;
            LoaiXe = loaiXe;
            MauSac = mauSac;
            PhanKhoi = phanKhoi;
            CongSuat = congSuat;
            HangSX = hangSX;
            NamSX = namSX;
            TinhTrang = tinhTrang;
        }
        public XeMay() { }
    }

}
