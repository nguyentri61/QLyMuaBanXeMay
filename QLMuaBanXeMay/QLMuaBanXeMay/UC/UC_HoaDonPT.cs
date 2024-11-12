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
        Class.HoaDonPT hoaDonPT = new Class.HoaDonPT();
        public UC_HoaDonPT()
        {
            InitializeComponent();
            Load_GridView();
        }

        private void UC_HoaDonPT_Load(object sender, EventArgs e)
        {

        }
        private void Load_GridView()
        {
            gv_hdPT.DataSource = DAOHoaDonPT.LayThongTin();
        }
        private void gv_hdPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gv_hdPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv_hdPT.Rows[e.RowIndex];

                hoaDonPT.MaHDPT = Convert.ToInt32(row.Cells[0].Value);
                hoaDonPT.KhuyenMai = float.Parse(row.Cells[1].Value.ToString());
                hoaDonPT.TongTien = float.Parse(row.Cells[2].Value.ToString());
                hoaDonPT.CCCDKH = Convert.ToInt32(row.Cells[3].Value);
                hoaDonPT.CCCDNV = Convert.ToInt32(row.Cells[4].Value);
                hoaDonPT.PTTT = row.Cells[5].Value.ToString();
                hoaDonPT.NgayXuat = Convert.ToDateTime(row.Cells[6].Value);

                txt_maHd.Text = hoaDonPT.MaHDPT.ToString();
                txt_giamGia.Text = hoaDonPT.KhuyenMai.ToString();
                txt_thanhTien.Text = hoaDonPT.TongTien.ToString();
                txt_maKH.Text = hoaDonPT.CCCDKH.ToString();
                txt_maNV.Text = hoaDonPT.CCCDNV.ToString();
                dt_ngayBan.Value = hoaDonPT.NgayXuat;

            }
        }
    }
}
