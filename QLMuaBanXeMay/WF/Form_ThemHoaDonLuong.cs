using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.WF
{
    public partial class Form_ThemHoaDonLuong : Form
    {
        public HoaDonLuong hdl = new HoaDonLuong();
        public Form_ThemHoaDonLuong(HoaDonLuong hdl)
        {
            InitializeComponent();
            this.hdl = hdl;
        }

        private void Form_ThemHoaDonLuong_Load(object sender, EventArgs e)
        {
            //dgvThongTinHoaDonNV.DataSource = DAONhanVien.LoadThongTinNhanVienCaLamHoaDon(hdl.CCCDNV);
            //LoadGrid();
        }

        private void LoadGrid()
        {
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            if (dgvThongTinHoaDonNV.Rows.Count > 0)
            {
                Loadtxt();
            }    
                
        }
        private void Loadtxt()
        {
            DataGridViewRow row = dgvThongTinHoaDonNV.Rows[0];

            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtChucVu.Text = row.Cells[2].Value.ToString();

        }
        private void dgvThongTinHoaDonNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                hdl.CCCDNV=int.Parse(txtMaNV.Text);
                hdl.SoGioLam = double.Parse(dgthongTinTongHopLuongNV.Rows[0].Cells["TongGioLam"].Value.ToString());
               
                hdl.TongTien = decimal.Parse(dgthongTinTongHopLuongNV.Rows[0].Cells["TienLuong"].Value.ToString());
                hdl.NgayXuat = dtpNgayXuat.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }


        }

        private void dtpNgayXuat_ValueChanged(object sender, EventArgs e)
        {
            dgvThongTinHoaDonNV.DataSource = DAOHoaDonLuong.LoadCaLamViecTheoNgayVaTongSoGio(hdl.CCCDNV, dtpNgayXuat.Value);
            LoadGrid();
            loadThongTinTongHopLuong();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_spXe_Enter(object sender, EventArgs e)
        {

        }
        private void loadThongTinTongHopLuong()
        {
            try
            {
                dgthongTinTongHopLuongNV.DataSource = DAOHoaDonLuong.LoadThongTinTongHop(hdl.CCCDNV, dtpNgayXuat.Value.Month, dtpNgayXuat.Value.Year);

            }
            catch
            {

            }
        }

    }
}
