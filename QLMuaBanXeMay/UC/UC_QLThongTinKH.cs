using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
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
    public partial class UC_QLThongTinKH : UserControl
    {
        KhachHang kh;
        NhanVien user;
        public UC_QLThongTinKH(NhanVien user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();        
        }

        private void LoadData()
        {
            dgv_ThongTinKH.DataSource = DAOKhachHang.LayDanhSachKhachHang();
        }

        /*private void btnThem_Click(object sender, EventArgs e)
        {
            kh = new KhachHang();
            Form_ThemKhachHang form = new Form_ThemKhachHang(kh);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Nhận giá trị từ Form2
                kh = form.Kh;
                DAOKhachHang.ThemKhachHang(kh);
                LoadData();
            }
        }*/
        private void clearTextBox()
        {
            txtCCCD.Clear();
            txtTenKH.Clear();
            txtEmail.Clear();
            txtGioiTinh.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.ResetText();
            txtMaLoai.Clear();
            txtTongChiTieu.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                khachHang.CCCDKH = int.Parse(txtCCCD.Text);
                khachHang.TenKH = txtTenKH.Text;
                khachHang.NgaySinh = dtpNgaySinh.Value;
                khachHang.GioiTinh = txtGioiTinh.Text;
                khachHang.SDT = txtSDT.Text;
                khachHang.DiaChi = txtDiaChi.Text;
                khachHang.Email = txtEmail.Text;
                khachHang.MaLoai = int.Parse(txtMaLoai.Text);
                khachHang.TongChiTieu = float.Parse(txtTongChiTieu.Text);

                DAOKhachHang.SuaKhachHang(khachHang);
                LoadData();
                clearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

       /* private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int cccdKH = int.Parse(txtCCCD.Text);
                DAOKhachHang.XoaKhachHang(cccdKH);
                LoadData();
                clearTextBox();
                MessageBox.Show("Xóa khách hàng thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }*/

        private void btnTim_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_TimCCCD.Text);
            dgv_ThongTinKH.DataSource = DAOKhachHang.TimKhachHangTheoCCCD(id);
        }

        private void UC_QLThongTinKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_ThongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgv_ThongTinKH.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox
                txtCCCD.Text = row.Cells["CCCDKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtTongChiTieu.Text = row.Cells["TongChiTieu"].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
