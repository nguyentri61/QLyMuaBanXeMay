using QLMuaBanXeMay.Class;

using QLMuaBanXeMay.UC;

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

namespace QLMuaBanXeMay
{
    public partial class UC_QLPhuTung : UserControl
    {


        Class.PhuTung phuTung = new PhuTung();
        Class.KhachHang khachHang = new KhachHang();
        public UC_QLPhuTung()
        {
            InitializeComponent();
            Load_GridView();
            
        }
        private void Load_GridView()
        {
            PhuTung_GridView.DataSource= DAOPhuTung.LayThongTin();
        }


        private void PhuTung_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = PhuTung_GridView.Rows[e.RowIndex];
               
                // Lấy giá trị từ các cột
                phuTung.MaPT = Convert.ToInt32(row.Cells["MaPT"].Value);
                phuTung.TenPT = row.Cells["TenPT"].Value.ToString(); // hoặc row.Cells[0].Value.ToString()
                phuTung.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString()); 
                phuTung.ChatLieu = row.Cells["ChatLieu"].Value.ToString();
                phuTung.HangSX = row.Cells["HangSX"].Value.ToString();
                phuTung.SoLuongTon = Convert.ToInt32(row.Cells["SoLuongTon"].Value);

                // Hiển thị giá trị (hoặc xử lý theo yêu cầu)
                txt_MaPhuTung.Text = phuTung.MaPT.ToString();
                txt_TenPhuTung.Text =phuTung.TenPT.ToString();  
                txt_DonGia.Text=phuTung.DonGia.ToString();
                txt_ChatLieu.Text=phuTung.ChatLieu.ToString();
                txt_HangSX.Text = phuTung.HangSX.ToString();
                txt_SoLuongTon.Text= phuTung.SoLuongTon.ToString();
                
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string timkiem= txt_search.Text;
            PhuTung_GridView.DataSource = DAOPhuTung.LayThongTinTheoTen(timkiem);
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            phuTung = new PhuTung();
            Form_ThongTinPhuTung form = new Form_ThongTinPhuTung(phuTung);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Nhận giá trị từ Form2
                phuTung = form.PhuTung;
                DAOPhuTung.ThemPhuTung(phuTung);
                Load_GridView();

            }

        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            phuTung.MaPT = Convert.ToInt32(txt_MaPhuTung.Text);
            phuTung.TenPT = txt_TenPhuTung.Text; // hoặc row.Cells[0].Value.ToString()
            phuTung.DonGia = float.Parse(txt_DonGia.Text);
            phuTung.ChatLieu = txt_ChatLieu.Text;
            phuTung.HangSX = txt_HangSX.Text;
            phuTung.SoLuongTon = Convert.ToInt32(txt_SoLuongTon.Text);
            DAOPhuTung.CapNhatPhuTung(phuTung);
            Load_GridView();
        }

        private void capnhat_btn_Click(object sender, EventArgs e)
        {
            UC_ThanhToanPT uc = new UC_ThanhToanPT(phuTung, khachHang);
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void PhuTung_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
