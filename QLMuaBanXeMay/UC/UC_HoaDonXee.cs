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

namespace QLMuaBanXeMay.UC
{
    public partial class UC_HoaDonXee : UserControl
    {
        NhanVien user;
        public UC_HoaDonXee(NhanVien user)
        {
            InitializeComponent();
            this.user = user;
            Load_GridView();
        }

        private void UC_HoaDonXee_Load(object sender, EventArgs e)
        {

        }
        public UC_HoaDonXee(int maXe)
        {
            InitializeComponent();
            this.txt_maXe.Text = maXe.ToString();
            
        }
        private void Load_GridView()
        {
            gv_hdXe.DataSource = DAOHoaDonXe.Load_ViewHD();
        }

        private void groupBox_spXe_Enter(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gv_hdXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gv_hdXe.Rows[e.RowIndex];

                txt_maHD.Text = row.Cells[0].Value.ToString();
                txt_ngayBan.Value = Convert.ToDateTime(row.Cells[1].Value);
                txt_maNV.Text = row.Cells[2].Value.ToString();
                txt_tenNV.Text = row.Cells[3].Value.ToString();
                txt_maKH.Text = row.Cells[4].Value.ToString();
                txt_tenKH.Text = row.Cells[5].Value.ToString();
                txt_SDT.Text = row.Cells[6].Value.ToString();
                txt_diaChi.Text = row.Cells[7].Value.ToString();
                txt_maXe.Text = row.Cells[8].Value.ToString();
                txt_loaiXe.Text = row.Cells[9].Value.ToString();
                txt_tenXe.Text = row.Cells[10].Value.ToString();
                txt_giamGia.Text = row.Cells[11].Value.ToString();
                txt_donGia.Text = row.Cells[12].Value.ToString();
                txt_thanhTien.Text = row.Cells[13].Value.ToString();
            }    
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maHD = txt_timkiem.Text;
            gv_hdXe.DataSource = DAOHoaDonXe.LayThongTinTheoMaHDXe(maHD);
        }
    }
}
