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
    public partial class DAOCaLam
    {
        public static DataTable LayThongTinCaLam()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetAllCaLam()", MY_DB.getConnection()))
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
        public static DataTable LayThongTinCTCaLam(int maca)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetChiTietCaLam(@MaCa)", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@MaCa", maca);
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

        internal static void ThemCa(CaLam caLam)
        {
            using (SqlCommand command = new SqlCommand("ThemCaLam", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TGBatDau", caLam.TGBatDau);
                    command.Parameters.AddWithValue("@TGKetThuc", caLam.TGKetThuc);
                    command.Parameters.AddWithValue("@CCCDQL", caLam.CCCDQL);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                    MessageBox.Show("Thêm ca làm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        internal static void ThemChiTietCa(ChiTietCaLam chiTietCaLam)
        {
            using (SqlCommand command = new SqlCommand("ThemChiTietCa", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@MaCa", chiTietCaLam.MaCa);
                    command.Parameters.AddWithValue("@CCCDNV", chiTietCaLam.CCDNV);
                    command.Parameters.AddWithValue("@GhiChu", chiTietCaLam.GhiChu);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                    MessageBox.Show("Thêm chi tiết ca làm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: 1 " + ex.Message);
                }
            }
        }
    }
}
