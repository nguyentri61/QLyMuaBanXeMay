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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_HoaDonLuong : UserControl
    {
        public HoaDonLuong hdl = new HoaDonLuong();
        public NhanVien nv = new NhanVien();
        public ChiTietHoaDonLuong cthdl = new ChiTietHoaDonLuong();
        public UC_HoaDonLuong()
        {
            InitializeComponent();
            Load_GridView();
        }
        private void Load_GridView()
        {

            dgvHoaDonLuong.DataSource = DAOHoaDonLuong.Load_ViewHDLuong();
        }

        private void dgvHoaDonLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDonLuong.Rows[e.RowIndex];

                    txtMaHD.Text = row.Cells[0].Value.ToString();
                    txtMaNV.Text = row.Cells[1].Value.ToString();
                    txtTenNV.Text = row.Cells[2].Value.ToString();
                    txtChucVu.Text = row.Cells[3].Value.ToString();
                    txtSoGioLam.Text = row.Cells[6].Value.ToString();
                    txtLuongCoBan.Text = row.Cells[7].Value.ToString();
                    txtTongTien.Text = row.Cells[8].Value.ToString();
                    dtpNgayXuat.Value = DateTime.Parse(row.Cells[9].Value.ToString());


                    cthdl.CCCDNV = int.Parse(txtMaNV.Text);
                    cthdl.ChucVu = txtChucVu.Text;
                    cthdl.TenNV = txtTenNV.Text;
                    cthdl.LuongCoBan = int.Parse(txtLuongCoBan.Text);
                    cthdl.TongTien = int.Parse(txtTongTien.Text);
                    cthdl.MaHDL = int.Parse(txtMaHD.Text);
                    cthdl.NgayXuat = dtpNgayXuat.Value;

                }
           
        }

        private void UC_HoaDonLuong_Load(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            Form_ChonNVThemLuong form = new Form_ChonNVThemLuong();

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.hdl = form.hdl;

                
                Form_ThemHoaDonLuong formThemHoaDon = new Form_ThemHoaDonLuong(hdl);
                if (formThemHoaDon.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật danh sách hóa đơn sau khi thêm thành công
                    this.hdl = formThemHoaDon.hdl;
                    DAOHoaDonLuong.ThemHoaDonluong(hdl);
                    Load_GridView();
                }
            }
        }

        private void btnTimMaHD_Click(object sender, EventArgs e)
        {
            string maHDL = txtTimMaHD.Text.Trim();

            if (string.IsNullOrEmpty(maHDL))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để tìm kiếm.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra đúng định dạng (chỉ nhập số)
            if (!Regex.IsMatch(maHDL, @"^[0-9]+$"))
            {
                MessageBox.Show("Định dạng mã hóa đơn không hợp lệ. Vui lòng nhập mã hợp lệ.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var result = DAOHoaDonLuong.TimHoaDonLuongTheoMaHDL(maHDL);

            if (result == null || result.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào với mã đã nhập.", "Không có kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDonLuong.DataSource = null; 
            }
            else
            {
                dgvHoaDonLuong.DataSource = result;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietHoaDonLuong form = new Form_ChiTietHoaDonLuong(cthdl);
            form.ShowDialog();
        }
    }
}
