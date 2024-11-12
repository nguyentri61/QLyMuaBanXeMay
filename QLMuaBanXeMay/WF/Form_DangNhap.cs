using QLMuaBanXeMay.Class;
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
    public partial class Form_DangNhap : Form
    {
        MY_DB my_db = new MY_DB();
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("KiemTraDangNhap", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TenTK", txt_taikhoan.Text);
                command.Parameters.AddWithValue("@MatKhau", txt_matkhau.Text);
                MY_DB.openConnection();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int cccdNV = reader.GetInt32(0);
                            string tenNV=reader.GetString(1);
                            DateTime ngaySinh = reader.GetDateTime(2);
                            string gioiTinh = reader.GetString(3);
                            string sdt=reader.GetString(4);
                            string diaChi = reader.GetString(5);
                            string email=reader.GetString(6);
                            string chucVu = reader.GetString(7);

                            if (chucVu != "Quản Lý")
                            {
                                DangNhap.username = txt_taikhoan.Text;
                                DangNhap.password = txt_matkhau.Text;
                                MY_DB.setConnectionNV();
                            }
                            else
                            {
                                MY_DB.setConnectionQL();
                            }

                            NhanVien nhanVien = new NhanVien(cccdNV,tenNV,ngaySinh,gioiTinh,sdt,diaChi,email,chucVu);
                            Form1 form1 = new Form1(nhanVien);
                            form1.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu nhập sai, vui lòng nhập lại");
                    }
                }
            }
            MY_DB.closeConnection();
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap.PerformClick();
            }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
