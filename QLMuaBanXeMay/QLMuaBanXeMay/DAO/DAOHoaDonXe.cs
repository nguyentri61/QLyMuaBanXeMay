using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.DAO
{
    public partial  class DAOHoaDonXe
    {
        public static String LayThongTinKhuyenMai(int cccd)
        {

            using (SqlCommand command = new SqlCommand("SELECT dbo.LayKhuyenMaiTuCCCD(@cccd)", MY_DB.getConnection()))
            {
                command.Parameters.AddWithValue("@cccd", cccd);
                MY_DB.openConnection();
                string khuyenmai = command.ExecuteScalar().ToString();

                MY_DB.closeConnection();

                return khuyenmai;

            }


        }

        internal static void ThemHoaDonXe(HoaDonXe hoaDonXe)
        {
            using (SqlCommand command = new SqlCommand("ThemHoaDonXe", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaHDXe", hoaDonXe.MaHDXe);
                command.Parameters.AddWithValue("@MaXe", hoaDonXe.MaXe);
                command.Parameters.AddWithValue("@KhuyenMai", hoaDonXe.KhuyenMai);
                command.Parameters.AddWithValue("@TongTien", hoaDonXe.TongTien);
                command.Parameters.AddWithValue("@CCCDKH", hoaDonXe.CCCDKH);
                command.Parameters.AddWithValue("@CCCDNV", hoaDonXe.CCCDNV);
                command.Parameters.AddWithValue("@PTTT", hoaDonXe.PTTT);
                command.Parameters.AddWithValue("@NgayXuat", hoaDonXe.NgayXuat);
                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }
        }
    }
}
