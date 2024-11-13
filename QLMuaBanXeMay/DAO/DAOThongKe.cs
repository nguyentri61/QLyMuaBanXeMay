﻿using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Claims;

namespace QLMuaBanXeMay.DAO
{
    public class DAOThongKe
    {
        public static DataTable ThongKeDoanhThuTheoNhanVien(int month, int year)
        {

            using (SqlCommand command = new SqlCommand("SELECT * FROM ThongKeDoanhThuTheoNhanVien(@Month, @Year)", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", year);
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

        public static DataTable ThongKeDoanhThuTheoThang(int year)
        {

            using (SqlCommand command = new SqlCommand("SELECT * FROM ThongKeTongDoanhThuTheoThang(@Year)", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.Parameters.AddWithValue("@Year", year);
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
        public static DataTable getChartData(DateTime startDate, DateTime endDate)
        {
            using (SqlCommand command = new SqlCommand("tinhToanLoiNhuanDoanhThu", MY_DB.getConnection()))
            {
                try
                {
                    MY_DB.openConnection();
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
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
