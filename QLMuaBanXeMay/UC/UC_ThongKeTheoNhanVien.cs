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
    public partial class UC_ThongKeTheoNhanVien : UserControl
    {
        public UC_ThongKeTheoNhanVien()
        {
            InitializeComponent();
        }

        private void UC_ThongKeTheoNhanVien_Load(object sender, EventArgs e)
        {
            cbbThang.SelectedIndex = 0;
            ThongKeTheoNV();
        }

        private void ThongKeTheoNV()
        {
            int selectedMonth = int.Parse(cbbThang.SelectedItem.ToString());
            int selectedYear = DateTime.Now.Year;

            // Gọi phương thức từ DAOThongKe để lấy dữ liệu
            DataTable dt = DAOThongKe.ThongKeDoanhThuTheoNhanVien(selectedMonth, selectedYear);

            // Xóa dữ liệu và series cũ của biểu đồ
            chartTKTheoNV.Series.Clear();
            chartTKTheoNV.Titles.Clear();

            // Thêm tiêu đề cho biểu đồ
            chartTKTheoNV.Titles.Add("Doanh thu theo nhân viên tháng " + selectedMonth + "/" + selectedYear);

            // Tạo series mới cho biểu đồ
            Series series = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Column, // Đặt kiểu biểu đồ cột
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string employeeName = row["TenNV"].ToString();
                double revenue = Convert.ToDouble(row["TongDoanhThu"]);
                series.Points.AddXY(employeeName, revenue);
            }

            // Thêm series vào biểu đồ
            chartTKTheoNV.Series.Add(series);

            series.Color = Color.Blue;  // Đổi màu cho cột
            chartTKTheoNV.ChartAreas[0].AxisX.Title = "Nhân viên";  // Đặt tên cho trục X
            chartTKTheoNV.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";  // Đặt tên cho trục Y
            chartTKTheoNV.ChartAreas[0].AxisX.Interval = 1;  // Đảm bảo hiển thị tất cả tên nhân viên
            chartTKTheoNV.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKeTheoNV();
        }
    }
}
