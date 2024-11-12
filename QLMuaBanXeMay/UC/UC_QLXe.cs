using QLMuaBanXeMay.Class;
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
using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.UC;

namespace QLMuaBanXeMay
{
    public partial class UC_QLXe : UserControl
    {

        XeMay xeMay = new XeMay();
        KhachHang khachHang = new KhachHang();
        NhanVien user = new NhanVien();
        bool check = false;
        public UC_QLXe(NhanVien user)
        {
            InitializeComponent();
            this.user = user;
            loadRole();
            Load_GridView();         
        }
        private void Load_GridView()
        {
            Xe_GridView.DataSource = DAOXeMay.LayThongTin(user.ChucVu);
        }
        private void loadRole()
        {
            if (user.ChucVu == "Quản Lý")
            {
                xuathoadon_btn.Visible = false;
            }
            else if (user.ChucVu == "Bán Hàng")
            {
                btn_Update.Visible = false;
                grBox_Congcu.Visible = false;
            }
        }

        private void Xe_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check = true;
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = Xe_GridView.Rows[e.RowIndex];

                // Lấy giá trị từ các cột
                xeMay.MaXe = Convert.ToInt32(row.Cells["MaXe"].Value);
                xeMay.TenXe = row.Cells["TenXe"].Value.ToString(); // hoặc row.Cells[0].Value.ToString()
                xeMay.DonGia = double.Parse(row.Cells["DonGia"].Value.ToString());
                xeMay.LoaiXe = row.Cells["LoaiXe"].Value.ToString();
                xeMay.MauSac = row.Cells["MauSac"].Value.ToString();
                xeMay.PhanKhoi = Convert.ToInt32(row.Cells["PhanKhoi"].Value);
                xeMay.CongSuat = double.Parse(row.Cells["CongSuat"].Value.ToString());
                xeMay.HangSX = row.Cells["HangSX"].Value.ToString();
                xeMay.NamSX = Convert.ToInt32(row.Cells["NamSX"].Value);
                xeMay.TinhTrang = row.Cells["TinhTrang"].Value.ToString();
                // Hiển thị giá trị (hoặc xử lý theo yêu cầu)
                txt_MaXe.Text = xeMay.MaXe.ToString();
                txt_TenXe.Text = xeMay.TenXe.ToString();
                txt_DonGia.Text = xeMay.DonGia.ToString();
                txt_LoaiXe.Text = xeMay.LoaiXe.ToString();  
                txt_MauSac.Text= xeMay.MauSac.ToString();   
                txt_PhanKhoi.Text=xeMay.PhanKhoi.ToString();
                txt_CongSuat.Text=xeMay.CongSuat.ToString();
                txt_HangSX.Text= xeMay.HangSX.ToString();   
                txt_NamSX.Text= xeMay.NamSX.ToString();
                txt_TinhTrang.Text=xeMay.TinhTrang.ToString();

            }

        }

        private void capnhat_btn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string timkiem=txt_search.Text;
            Xe_GridView.DataSource = DAOXeMay.LayThongTinTheoTen(timkiem);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            xeMay = new XeMay();
            Form_ThongTinXe form = new Form_ThongTinXe(xeMay);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Nhận giá trị từ Form2
                    xeMay = form.Xe;
                    DAOXeMay.ThemXe(xeMay);
                    Load_GridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            xeMay.MaXe = Convert.ToInt32(txt_MaXe.Text);
            xeMay.TenXe = txt_TenXe.Text.ToString(); // hoặc row.Cells[0].Value.ToString()
            xeMay.DonGia = double.Parse(txt_DonGia.Text);
            xeMay.LoaiXe = txt_LoaiXe.Text.ToString();
            xeMay.MauSac = txt_MauSac.Text.ToString();
            xeMay.PhanKhoi = Convert.ToInt32(txt_PhanKhoi.Text);
            xeMay.CongSuat = double.Parse(txt_CongSuat.Text);
            xeMay.HangSX = txt_HangSX.Text;
            xeMay.NamSX = Convert.ToInt32(txt_NamSX.Text);
            xeMay.TinhTrang = txt_TinhTrang.Text;
            DAOXeMay.SuaXe(xeMay);
            Load_GridView();
        }

        private void xuathoadon_btn_Click(object sender, EventArgs e)
        {
            if (check)
            {
                UC_ThanhToanXe uc = new UC_ThanhToanXe(xeMay, khachHang, user);
                this.Controls.Clear();
                this.Controls.Add(uc);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe");
            }
        }

        private void UC_QLXe_Load(object sender, EventArgs e)
        {

        }
    }
}
