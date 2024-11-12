using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using QLMuaBanXeMay.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        NhanVien user;
        int mavc=-1;
        public UC_ThanhToanXe()
        {
            InitializeComponent();
        }
        public UC_ThanhToanXe(XeMay xeMay, KhachHang khachHang, NhanVien user)
        {
            this.xeMay_tt = xeMay;
            this.khachHang_tt  = khachHang;
            this.user = user;
            InitializeComponent();
            try
            {
                txt_maXe.Text = xeMay.MaXe.ToString();
                txt_tenXe.Text = xeMay.TenXe.ToString();
                txt_donGia.Text = xeMay.DonGia.ToString();
                txt_loaiXe.Text = xeMay.LoaiXe.ToString();
                txt_mauSac.Text = xeMay.MauSac.ToString();
                txt_phanKhoi.Text = xeMay.PhanKhoi.ToString();
                txt_congSuat.Text = xeMay.CongSuat.ToString();
                txt_hangSX.Text = xeMay.HangSX.ToString();
                txt_namSX.Text = xeMay.NamSX.ToString();
            }
            catch {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            
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
            
            if (kh.ShowDialog() == DialogResult.OK)
            {
                khachHang_tt = kh.KhachHang1;
                UC_ThanhToanXe_Load(xeMay_tt, khachHang_tt);
                LoadCBB(khachHang_tt.CCCDKH);
            }
           
        }

        private void txt_cccdKH_TextChanged(object sender, EventArgs e)
        {
            txt_khuyenMai.Text = DAO.DAOHoaDonXe.LayThongTinKhuyenMai(Convert.ToInt32(txt_cccdKH.Text));
        }

        private void txt_khuyenMai_TextChanged(object sender, EventArgs e)
        {
            //float khuyenmai;
            //double thanhTien = float.Parse(txt_donGia.Text);
            //if (float.TryParse(txt_khuyenMai.Text, out khuyenmai))
            //{
            //    khuyenmai = (float)Math.Round(khuyenmai, 2);
            //    thanhTien = thanhTien - (thanhTien * khuyenmai);
            //}
            //thanhTien = Math.Ceiling(thanhTien);
            txt_thanhTien.Text = DAOHoaDonXe.TinhTienHoaDon(khachHang_tt.CCCDKH, xeMay_tt.MaXe, mavc);
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            try
            {
                Class.HoaDonXe hoaDonXe = new HoaDonXe();
                hoaDonXe.MaXe = Convert.ToInt32(txt_maXe.Text);
                hoaDonXe.KhuyenMai = (double)Math.Round(double.Parse(txt_khuyenMai.Text), 2, MidpointRounding.AwayFromZero);
                hoaDonXe.TongTien = float.Parse(txt_thanhTien.Text);
                hoaDonXe.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
                hoaDonXe.CCCDNV = user.CCCDNV;
                hoaDonXe.PTTT = cb_pttt.Text;
                hoaDonXe.NgayXuat = dt_ngayXuat.Value;
                if (cb_VC.SelectedItem != null)
                {
                    DAOVoucher.XoaVoucher(hoaDonXe.CCCDKH, Int32.Parse(cb_VC.SelectedValue.ToString()));
                }
                
                DAO.DAOHoaDonXe.ThemHoaDonXe(hoaDonXe);
                MessageBox.Show("Xuất hóa đơn thành công");

                
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn xe");
            }
            
        }
        private void LoadCBB(int cccd)
        {
            txt_giamgia.Text = string.Empty;
            txt_ggToida.Text = string.Empty;
            cb_VC.DataSource = null;
            DataTable voucherTable = DAOVoucher.LayThongTinVC(cccd);
            if (voucherTable.Rows.Count > 0)
            {
                // Gán DataTable vào ComboBox
                cb_VC.DataSource = voucherTable;  
                cb_VC.DisplayMember = "TenVC"; // Hiển thị tên voucher
                cb_VC.ValueMember = "MaVC";    // Giá trị là mã voucher
                
            }
            else
            {
                MessageBox.Show("Không có voucher nào cho khách hàng này.");
            }
            if (cb_VC.SelectedValue != null)
            {
                MessageBox.Show("Load:  "+cb_VC.SelectedValue.ToString());
                
                mavc = Int32.Parse(cb_VC.SelectedValue.ToString());
                txt_thanhTien.Text = DAOHoaDonXe.TinhTienHoaDon(khachHang_tt.CCCDKH, xeMay_tt.MaXe, mavc);
            }
        }
        private void UC_ThanhToanXe_Load(object sender, EventArgs e)
        {

        }

        private void cb_VC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_VC.SelectedItem != null)
            {
                DataRowView selectedVoucher = (DataRowView)cb_VC.SelectedItem;

                // Hiển thị giá trị và giảm giá của voucher trên TextBox
                txt_giamgia.Text = selectedVoucher["GiamGia"].ToString();
                txt_ggToida.Text = selectedVoucher["GiamGiaTD"].ToString();

            }
            
            if (cb_VC.SelectedValue != null)
            {
                if (Int32.TryParse(cb_VC.SelectedValue.ToString(), out mavc))
                {
                    txt_thanhTien.Text = DAOHoaDonXe.TinhTienHoaDon(khachHang_tt.CCCDKH, xeMay_tt.MaXe, mavc);
                }
                
            }

        }

        private void cb_VC_SelectedValueChanged(object sender, EventArgs e)
        {


        }
    }
}
