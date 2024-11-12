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
    internal class DAONhanVien
    {
        public static void ThemNhanVien(NhanVien nhanVien)
        {
            using (SqlCommand command = new SqlCommand("ThemNhanVien", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CCCDNV", nhanVien.CCCDNV);
                    command.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                    command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                    command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                    command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                    command.Parameters.AddWithValue("@Email", nhanVien.Email);
                    command.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
        }


        public static DataTable LayThongTinNhanVien()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetNhanVienWithTaiKhoan()", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    MY_DB.closeConnection();

                    return dt;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }
        public static DataTable LayThongTinNhanVienCaLam()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetNhanVien()", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    MY_DB.closeConnection();

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public static DataTable LoadThongTinNhanVienCaLamHoaDon(int cccdNV)
        {
            MessageBox.Show(cccdNV.ToString());
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetThongTinCaNhanVien(@CCCDNV)", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@CCCDNV", cccdNV);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    MY_DB.closeConnection();

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public static void SuaNhanVien(NhanVien nhanVien)
        {
            using (SqlCommand command = new SqlCommand("SuaNhanVien", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CCCDNV", nhanVien.CCCDNV);
                    command.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                    command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                    command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                    command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                    command.Parameters.AddWithValue("@Email", nhanVien.Email);
                    command.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        /*public static void XoaNhanVien(int cccdNV)
        {
            using (SqlCommand command = new SqlCommand("XoaNhanVien", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CCCDNV", cccdNV);

                MY_DB.openConnection();
                command.ExecuteNonQuery();
                MY_DB.closeConnection();
            }
        }*/
        public static DataTable TimNhanVienTheoCCCD(int cccdKH)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetNhanVienByCCCDNV(@CCCDKH)", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@CCCDKH", cccdKH);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    MY_DB.closeConnection();

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }
    }
    
}
