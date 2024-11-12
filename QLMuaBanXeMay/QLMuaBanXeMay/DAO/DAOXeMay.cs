using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QLMuaBanXeMay.DAO
{
    public partial class DAOXeMay
    {
        public static DataTable LayThongTin()
        {
            using (SqlCommand command = new SqlCommand("Select * From XeMay", MY_DB.getConnection()))
            {
                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

        internal static object LayThongTinTheoTen(string TenXe)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM XeMay WHERE TenXe LIKE @TenXe", MY_DB.getConnection()))
            {
                MY_DB.openConnection();
                command.Parameters.AddWithValue("@TenXe", "%" + TenXe + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

        internal static void SuaXe(XeMay xe)
        {
            using (SqlCommand command = new SqlCommand("SuaXe", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaXe", xe.MaXe);
                command.Parameters.AddWithValue("@TenXe", xe.TenXe);
                command.Parameters.AddWithValue("@DonGia", xe.DonGia);
                command.Parameters.AddWithValue("@LoaiXe", xe.LoaiXe);
                command.Parameters.AddWithValue("@MauSac", xe.MauSac);
                command.Parameters.AddWithValue("@PhanKhoi", xe.PhanKhoi);
                command.Parameters.AddWithValue("@CongSuat", xe.CongSuat);
                command.Parameters.AddWithValue("@HangSX", xe.HangSX);
                command.Parameters.AddWithValue("@NamSX", xe.NamSX);
                command.Parameters.AddWithValue("@TinhTrang", xe.TinhTrang);
                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }
        }

        internal static void ThemXe(XeMay xe)
        {
            using (SqlCommand command = new SqlCommand("ThemXe", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaXe", xe.MaXe);
                command.Parameters.AddWithValue("@TenXe", xe.TenXe);
                command.Parameters.AddWithValue("@DonGia", xe.DonGia);
                command.Parameters.AddWithValue("@LoaiXe", xe.LoaiXe);
                command.Parameters.AddWithValue("@MauSac", xe.MauSac);
                command.Parameters.AddWithValue("@PhanKhoi", xe.PhanKhoi);
                command.Parameters.AddWithValue("@CongSuat", xe.CongSuat);
                command.Parameters.AddWithValue("@HangSX", xe.HangSX);
                command.Parameters.AddWithValue("@NamSX", xe.NamSX);
                command.Parameters.AddWithValue("@TinhTrang", xe.TinhTrang);
                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }
        }
    }
}
