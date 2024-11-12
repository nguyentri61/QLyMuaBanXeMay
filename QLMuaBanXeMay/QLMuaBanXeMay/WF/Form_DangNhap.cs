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
                            string chucVu = reader.GetString(3);
                            Form1 form1 = new Form1(chucVu);
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
    }
}
