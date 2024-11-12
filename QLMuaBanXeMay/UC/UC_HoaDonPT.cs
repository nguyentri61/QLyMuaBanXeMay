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
    public partial class UC_HoaDonPT : UserControl
    {
        HoaDonPT hoaDonPT = new Class.HoaDonPT();
        NhanVien user;
        public UC_HoaDonPT(NhanVien user)
        {
            InitializeComponent();
            this.user = user;
            Load_GridView();           
        }
        private void Load_GridView()
        {
            gv_hdPT.DataSource = DAOHoaDonPT.Load_ViewHD();
        }
       

        private void gv_hdPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gv_hdPT.Rows[e.RowIndex];

                txt_maHd.Text = row.Cells[0].Value.ToString();
                dt_ngayBan.Value = Convert.ToDateTime(row.Cells[1].Value);
                txt_maNV.Text = row.Cells[2].Value.ToString();
                txt_tenNV.Text = row.Cells[3].Value.ToString();
                txt_maKH.Text = row.Cells[4].Value.ToString();
                txt_tenKH.Text = row.Cells[5].Value.ToString();
                txt_sdt.Text = row.Cells[6].Value.ToString();
                txt_diaChi.Text = row.Cells[7].Value.ToString();
                txt_giamGia.Text = row.Cells[8].Value.ToString();
                txt_thanhTien.Text = row.Cells[9].Value.ToString();

                gv_chiTietHD.DataSource = DAOHoaDonPT.Load_ViewChiTietHD(Convert.ToInt32(txt_maHd.Text));


            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string maHD = txt_timkiem.Text;
            gv_hdPT.DataSource = DAOHoaDonPT.LayThongTinTheoMaHDPT(maHD);
        }

        private void UC_HoaDonPT_Load(object sender, EventArgs e)
        {

        }
    }
}
