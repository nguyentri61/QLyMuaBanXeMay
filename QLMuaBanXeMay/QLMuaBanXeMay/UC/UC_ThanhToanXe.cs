using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThanhToanXe : UserControl
    {
        Class.XeMay xeMay_tt = new XeMay();
        Class.KhachHang khachHang_tt = new KhachHang();
        public UC_ThanhToanXe()
        {
            InitializeComponent();
        }
        public UC_ThanhToanXe(XeMay xeMay, KhachHang khachHang)
        {
            this.xeMay_tt = xeMay;
            this.khachHang_tt  = khachHang;
            InitializeComponent();
            txt_maXe.Text = xeMay.MaXe.ToString();
            txt_tenXe.Text = xeMay.TenXe.ToString();
            txt_donGia.Text = xeMay.DonGia.ToString();
            txt_loaiXe.Text = xeMay.LoaiXe.ToString();
            txt_mauSac.Text = xeMay.MauSac.ToString();
            txt_phanKhoi.Text = xeMay.PhanKhoi.ToString();
            txt_congSuat.Text = xeMay.CongSuat.ToString();
            txt_hangSX.Text = xeMay.HangSX.ToString();
            txt_namSX.Text = xeMay.NamSX.ToString();
            //Thêm check tình trạng
        }
        

        private void UC_ThanhToanXe_Load(XeMay xeMay, KhachHang khachHang)
        {
            /*InitializeComponent();*/
            txt_maXe.Text = xeMay.MaXe.ToString();
            txt_tenXe.Text = xeMay.TenXe.ToString();
            txt_donGia.Text = xeMay.DonGia.ToString();
            txt_loaiXe.Text = xeMay.LoaiXe.ToString();
            txt_mauSac.Text = xeMay.MauSac.ToString();
            txt_phanKhoi.Text = xeMay.PhanKhoi.ToString();
            txt_congSuat.Text = xeMay.CongSuat.ToString();
            txt_hangSX.Text = xeMay.HangSX.ToString();
            txt_namSX.Text = xeMay.NamSX.ToString();

            this.txt_cccdKH.Text = khachHang.CCCDKH.ToString();
            this.txt_ten.Text = khachHang.TenKH.ToString();
            this.dt_ngaySinh.Value = khachHang.NgaySinh;
            this.txt_gioiTinh.Text = khachHang.GioiTinh.ToString();
            this.txt_sdt.Text = khachHang.SDT.ToString();
            this.txt_diaChi.Text = khachHang.DiaChi.ToString();
            this.txt_email.Text = khachHang.Email.ToString();
        }

        private void btn_chonKH_Click(object sender, EventArgs e)
        {
            Form_ThongTinKH kh = new Form_ThongTinKH(khachHang_tt);
            khachHang_tt = kh.KhachHang1;

            if (kh.ShowDialog() == DialogResult.OK)
            {
                UC_ThanhToanXe_Load(xeMay_tt, khachHang_tt);
            }
        }

        private void txt_cccdKH_TextChanged(object sender, EventArgs e)
        {
            txt_khuyenMai.Text = DAO.DAOHoaDonXe.LayThongTinKhuyenMai(Convert.ToInt32(txt_cccdKH.Text));
        }

        private void txt_khuyenMai_TextChanged(object sender, EventArgs e)
        {
            int soluong;
            float khuyenmai;
            float thanhTien = Convert.ToInt32(txt_donGia.Text);
            if (float.TryParse(txt_khuyenMai.Text, out khuyenmai))
            {
                thanhTien = thanhTien - (thanhTien * khuyenmai);
            }

            txt_thanhTien.Text = thanhTien.ToString();
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            Class.HoaDonXe hoaDonXe = new HoaDonXe();
            hoaDonXe.MaHDXe = Convert.ToInt32(txt_maHD.Text);
            hoaDonXe.MaXe = Convert.ToInt32(txt_maXe.Text);
            hoaDonXe.KhuyenMai = float.Parse(txt_khuyenMai.Text);
            hoaDonXe.TongTien = float.Parse(txt_thanhTien.Text);
            hoaDonXe.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
            hoaDonXe.CCCDNV = 123456789;
            hoaDonXe.PTTT = cb_pttt.Text;
            hoaDonXe.NgayXuat = dt_ngayXuat.Value;

            DAO.DAOHoaDonXe.ThemHoaDonXe(hoaDonXe);


            MessageBox.Show("Done");
        }
    }
}
