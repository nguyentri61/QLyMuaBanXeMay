using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using QLMuaBanXeMay.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThanhToanPT : UserControl
    {

        int maHDPT;
        int maVC = -1;
        Class.KhachHang khachHang_tt = new KhachHang();
        NhanVien user;
        List<ChiTietHD_PT> ListHDPT = new List<ChiTietHD_PT>();
        public UC_ThanhToanPT()
        {
            
        }
        public UC_ThanhToanPT(List<ChiTietHD_PT> listHDPT, KhachHang khachHang, NhanVien user)
        {
            InitializeComponent();
            ListHDPT = listHDPT;
            this.user = user;
            dataGridViewPT.DataSource = null; 
            dataGridViewPT.DataSource = listHDPT;
            dataGridViewPT.Columns[0].Visible = false;
        }
        

        private void UC_ThanhToanPT_Load(KhachHang khachHang)
        {
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
                UC_ThanhToanPT_Load(khachHang_tt);
            }
            LoadCBB(khachHang_tt.CCCDKH);

        }

        private void txt_cccdKH_TextChanged(object sender, EventArgs e)
        {
            txt_khuyenMai.Text = DAO.DAOHoaDonPT.LayThongTinKhuyenMai(Convert.ToInt32(txt_cccdKH.Text));
           
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            DAOVoucher.XoaVoucher(maHDPT,maVC);
            DAOHoaDonPT.SuaTongTienHDPT(maHDPT, txt_thanhTien.Text,cb_pttt.Text);
            
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
            Class.HoaDonPT hoaDonPT = new HoaDonPT();
            hoaDonPT.KhuyenMai = (double)Math.Round(double.Parse(txt_khuyenMai.Text), 2, MidpointRounding.AwayFromZero);
            hoaDonPT.TongTien = 10;
            hoaDonPT.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
            hoaDonPT.CCCDNV = user.CCCDNV;
            hoaDonPT.PTTT = cb_pttt.Text;
            hoaDonPT.NgayXuat = dt_ngayXuat.Value;
            if(cb_VC.DataSource != null)
            {
                maVC = Int32.Parse(cb_VC.SelectedValue.ToString());
            }
            
            //DAOVoucher.XoaVoucher(hoaDonPT.CCCDKH, maVC);
            maHDPT = DAO.DAOHoaDonPT.ThemHoaDonPT(hoaDonPT);

            foreach (ChiTietHD_PT chiTietHDPT in ListHDPT)
            {
                chiTietHDPT.MaHDPT = maHDPT;
                DAO.DAOHoaDonPT.ThemChiTietHDPT(chiTietHDPT);

            }
            txt_thanhTien.Text = DAOHoaDonPT.TinhTienHoaDon(maHDPT, maVC);
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
                if (Int32.TryParse(cb_VC.SelectedValue.ToString(), out maVC))
                {
                    txt_thanhTien.Text = DAOHoaDonPT.TinhTienHoaDon(maHDPT, maVC);
                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
