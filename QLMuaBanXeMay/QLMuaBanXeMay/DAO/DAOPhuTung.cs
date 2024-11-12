using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.DAO
{
    public partial class DAOPhuTung
    {
        public static void ThemPhuTung(PhuTung phuTung)
        {
            using (SqlCommand command = new SqlCommand("ThemPhuTung", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaPT", phuTung.MaPT);
                command.Parameters.AddWithValue("@TenPT", phuTung.TenPT);
                command.Parameters.AddWithValue("@DonGia", phuTung.DonGia);
                command.Parameters.AddWithValue("@ChatLieu", phuTung.ChatLieu);
                command.Parameters.AddWithValue("@HangSX", phuTung.HangSX);
                command.Parameters.AddWithValue("@SoLuongTon", phuTung.SoLuongTon);
                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }    
        }
        public static void XoaPhuTung(int MaPT)
        {
            using (SqlCommand command = new SqlCommand("XoaPhuTung", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaPT", MaPT);

                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }
        }
        public static void CapNhatPhuTung(PhuTung phuTung)
        {
            using (SqlCommand command = new SqlCommand("SuaPhuTung", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaPT", phuTung.MaPT);
                command.Parameters.AddWithValue("@TenPT", phuTung.TenPT);
                command.Parameters.AddWithValue("@DonGia", phuTung.DonGia);
                command.Parameters.AddWithValue("@ChatLieu", phuTung.ChatLieu);
                command.Parameters.AddWithValue("@HangSX", phuTung.HangSX);
                command.Parameters.AddWithValue("@SoLuongTon", phuTung.SoLuongTon);
                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }
        }
        public static DataTable LayThongTin()
        {
            using (SqlCommand command = new SqlCommand("Select * From PhuTung", MY_DB.getConnection()))
            {
                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }    
        }
        public static DataTable LayThongTinTheoTen(string TenPT)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM PhuTung WHERE TenPT LIKE @TenPT", MY_DB.getConnection()))
            {
                MY_DB.openConnection();
                command.Parameters.AddWithValue("@TenPT", "%" + TenPT + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }
    }
}
