using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace QLMuaBanXeMay.DAO
{
    public partial class DAOXeMay
    {
        public static DataTable LayThongTin(string chucvu)
        {
            string sql;
            if (chucvu == "Bán Hàng") 
            {
                MessageBox.Show("11111");
                sql = "SELECT * FROM dbo.GetAllXeBanHang()";
            }
            else 
            { 
                sql = "SELECT * FROM dbo.GetAllXeMay()";
            }
            using (SqlCommand command = new SqlCommand(sql, MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    MessageBox.Show(sql);
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

        internal static object LayThongTinTheoTen(string TenXe)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetXeMayByTenXe(@TenXe)", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@TenXe", TenXe.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    MY_DB.closeConnection();

                    return dt;
                }
                catch (Exception ex)    
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                    return null;
                }
            }
        }

        internal static void SuaXe(XeMay xe)
        {
            using (SqlCommand command = new SqlCommand("SuaXe", MY_DB.getConnection()))
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
        }

        internal static void ThemXe(XeMay xe)
        {
            using (SqlCommand command = new SqlCommand("ThemXe", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

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
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
        }
    }
}
