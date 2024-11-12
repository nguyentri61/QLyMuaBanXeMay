using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThongKeTheoThang : UserControl
    {
        public UC_ThongKeTheoThang()
        {
            InitializeComponent();
        }

        private void UC_ThongKeTheoThang_Load(object sender, EventArgs e)
        {
            cbbNam.SelectedItem = 2024;
            ThongKeTheoThang(2024);
        }

        private void ThongKeTheoThang(int selectedYear)
        {

            DataTable dt = DAOThongKe.ThongKeDoanhThuTheoThang(selectedYear);

            // Clear existing series and titles
            chartThongKeTheoThang.Series.Clear();
            chartThongKeTheoThang.Titles.Clear();

            // Add title to the chart
            chartThongKeTheoThang.Titles.Add("Tổng doanh thu theo tháng năm " + selectedYear);

            // Create a new series for the column chart
            Series series = new Series("TongDoanhThu");
            series.ChartType = SeriesChartType.Column;  // Set the chart type to Column

            // Populate the chart with data
            for (int month = 1; month <= 12; month++)
            {
                // Tìm kiếm doanh thu cho tháng này
                DataRow[] monthData = dt.Select("Thang = " + month);

                double totalRevenue = 0;
                if (monthData.Length > 0)
                {
                    totalRevenue = Convert.ToDouble(monthData[0]["TongDoanhThu"]);
                }

                // Thêm điểm dữ liệu cho tháng này, nếu không có doanh thu, gán 0
                series.Points.AddXY("Tháng " + month, totalRevenue);
            }

            // Add the series to the chart
            chartThongKeTheoThang.Series.Add(series);

            // Customize the chart appearance
            series.Color = Color.Blue; // Change the color of the columns
            chartThongKeTheoThang.ChartAreas[0].AxisX.Title = "Tháng";  // Label the X-axis
            chartThongKeTheoThang.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";  // Label the Y-axis
            chartThongKeTheoThang.ChartAreas[0].AxisX.Interval = 1;  // Ensure all months are shown on the axis
            chartThongKeTheoThang.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";  // Format Y-axis as currency
 
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = Convert.ToInt32(cbbNam.SelectedItem);

            ThongKeTheoThang(selectedYear);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
