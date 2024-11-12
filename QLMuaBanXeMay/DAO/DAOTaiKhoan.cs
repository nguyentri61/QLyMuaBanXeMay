using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.DAO
{
    internal class DAOTaiKhoan
    {
        public static void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            using (SqlCommand command = new SqlCommand("ThemTaiKhoan", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenTK", taiKhoan.TenTK);
                    command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                    command.Parameters.AddWithValue("@CCCDNV", taiKhoan.CCCDNV);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                }
                catch
                {
                    MessageBox.Show("Không tạo được tài khoản");
                }
            }
        }
        public static void SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            using (SqlCommand command = new SqlCommand("SuaTaiKhoan", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CCCDNV", taiKhoan.CCCDNV);
                    command.Parameters.AddWithValue("@TenTK", taiKhoan.TenTK);
                    command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ ex.Message);
                }
            }
        }
        public static void XoaTaiKhoan(int cccdNV)
        {
            using (SqlCommand command = new SqlCommand("XoaTaiKhoan", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CCCDNV", cccdNV);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
