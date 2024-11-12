using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using QLMuaBanXeMay.UC;
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

namespace QLMuaBanXeMay.WF
{
    public partial class Form_ThongTinKH : Form
    {
        private KhachHang khachHang1 = new KhachHang();
        Class.PhuTung phuTung1 = new PhuTung();
        public KhachHang KhachHang1 { get => khachHang1; set => khachHang1 = value; }
        bool check=false;
        public Form_ThongTinKH(KhachHang khachHang)
        {
            InitializeComponent();
            Load_GridView();
            khachHang1 = khachHang;
        }
        private void Load_GridView()
        {
            dg_kh.DataSource = DAOThongTinKH.LayThongTin();
        }
        /*private void Form_ThongTinKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLMuaBanXeMayDataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLMuaBanXeMayDataSet2.KhachHang);

        }*/


        private void btn_chonKH_Click(object sender, EventArgs e)
        {
            if (check)
            {
                this.DialogResult = DialogResult.OK; // Thiết lập kết quả đối thoại
                this.Close(); // Đóng Form2
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại khách hàng");
            }

        }

        private void dg_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dg_kh.Rows[e.RowIndex];

                KhachHang1.CCCDKH = Convert.ToInt32(row.Cells[0].Value);
                KhachHang1.TenKH = row.Cells[1].Value.ToString();
                KhachHang1.NgaySinh = Convert.ToDateTime(row.Cells[2].Value);
                KhachHang1.GioiTinh = row.Cells[3].Value.ToString();
                KhachHang1.SDT = row.Cells[4].Value.ToString();
                KhachHang1.DiaChi = row.Cells[5].Value.ToString();
                KhachHang1.Email = row.Cells[6].Value.ToString();
                KhachHang1.MaLoai = Convert.ToInt32(row.Cells[7].Value);
                KhachHang1.TongChiTieu = float.Parse(row.Cells[8].Value.ToString());
                check = true;

            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            khachHang1 = new KhachHang();
            Form_ThemKhachHang form = new Form_ThemKhachHang(khachHang1);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Nhận giá trị từ Form2
                khachHang1 = form.Kh;
                DAOKhachHang.ThemKhachHang(khachHang1);
                Load_GridView();
            }
        }
    }
}
