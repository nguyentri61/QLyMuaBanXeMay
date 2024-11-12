using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dgvThongTinHoaDonNV.DataSource = DAONhanVien.LoadThongTinNhanVienCaLamHoaDon(hdl.CCCDNV);
            LoadGrid();
        }

        private void LoadGrid()
        {
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            txtLuongCoBan.Text = string.Empty;
            txtSoGioLam.Text = string.Empty;
            txtTongTien.Text = string.Empty;
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
            txtLuongCoBan.Text = row.Cells[3].Value.ToString();
            double tongGio = TongSoGio();
            txtSoGioLam.Text = tongGio.ToString("F2");
            double tongtien = tongGio * Int32.Parse(txtLuongCoBan.Text);
            txtTongTien.Text = tongtien.ToString("F2");
        }
        private void dgvThongTinHoaDonNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private double TongSoGio()
        {
            double tongSoGio = 0;

            foreach (DataGridViewRow row in dgvThongTinHoaDonNV.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[5].Value != null) // Kiểm tra các giá trị không null
                {
                    DateTime thoiGianBatDau = Convert.ToDateTime(row.Cells[4].Value);
                    DateTime thoiGianKetThuc = Convert.ToDateTime(row.Cells[5].Value);

                    TimeSpan khoangThoiGian = thoiGianKetThuc - thoiGianBatDau;
                    tongSoGio += khoangThoiGian.TotalHours;
                }
            }

            return tongSoGio;
        }


        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan soGioLam = TimeSpan.Parse(txtSoGioLam.Text);
                double sgl = soGioLam.TotalHours;
                hdl.NgayXuat = dtpNgayXuat.Value;
                hdl.SoGioLam = sgl;
                hdl.TongTien = int.Parse(txtTongTien.Text);
                hdl.CCCDNV = hdl.CCCDNV;

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
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_spXe_Enter(object sender, EventArgs e)
        {

        }
    }
}
