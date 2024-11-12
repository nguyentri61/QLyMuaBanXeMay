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
    public class DAOHoaDonLuong
    {
        public static DataTable Load_ViewHDLuong()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetAllHoaDonLuong()", MY_DB.getConnection()))
            {
                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

        public static void ThemHoaDonluong(HoaDonLuong hoaDonLuong)
        {
            using (SqlCommand command = new SqlCommand("AddHoaDonLuong", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SoGioLam", hoaDonLuong.SoGioLam);
                    command.Parameters.AddWithValue("@NgayXuat", hoaDonLuong.NgayXuat);
                    command.Parameters.AddWithValue("@TongTien", hoaDonLuong.TongTien);
                    command.Parameters.AddWithValue("@CCCDNV", hoaDonLuong.CCCDNV);
                    command.Parameters.AddWithValue("@CCCDQL", 101);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();

                    MessageBox.Show("Xuất hóa đơn lương thành công");
                }
                catch (Exception ex)
                {
                    // Thông báo lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public static DataTable TimHoaDonLuongTheoMaHDL(string maHDL)
        {
            using (SqlCommand command = new SqlCommand("SELECT* FROM GetThongTinHoaDonLuongTheoMaHDL(@maHDL);", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@maHDL", "%" + maHDL + "%");
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
        public static DataTable LoadCaLamViecTheoNgay(int cccdNV, DateTime ngayXuat)
        {
            MessageBox.Show(ngayXuat.ToString());
            using (SqlCommand command = new SqlCommand("SELECT* FROM LoadCaLamViecTheoThang(@cccdNV,@ngayXuat);", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@cccdNV", cccdNV);

                    command.Parameters.AddWithValue("@ngayXuat",ngayXuat);

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
        public static DataTable LoadCaLamViecTheoNgayVaTongSoGio(int cccdNV, DateTime ngayXuat)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.LoadCaLamViecTheoThang(@CCCDNV, @NgayXuat);", MY_DB.getConnection()))
            {
                command.Parameters.AddWithValue("@CCCDNV", cccdNV);
                command.Parameters.AddWithValue("@NgayXuat", ngayXuat);

                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

    }
}
