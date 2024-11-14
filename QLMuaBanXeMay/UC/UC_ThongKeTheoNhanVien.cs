using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        }

        private void DisplayChart(DataTable dt)
        {
            int selectedMonth = int.Parse(cbbThang.SelectedItem.ToString());
            int selectedYear = DateTime.Now.Year; // Hoặc lấy năm từ một ComboBox khác nếu có

            // Gọi phương thức từ DAOThongKe để lấy dữ liệu
            

            // Xóa dữ liệu và series cũ của biểu đồ
            chartTKTheoNV.Series.Clear();
            chartTKTheoNV.Titles.Clear();

            // Thêm tiêu đề cho biểu đồ
            chartTKTheoNV.Titles.Add($"Doanh thu và số lượng hóa đơn theo nhân viên tháng {selectedMonth}/{selectedYear}");

            // Tạo series mới cho biểu đồ doanh thu
            Series seriesDoanhThu = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Column, // Đặt kiểu biểu đồ cột
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                Color = Color.Blue // Màu cho cột doanh thu
            };

            // Tạo series mới cho biểu đồ số lượng hóa đơn
            Series seriesSoLuongHD = new Series("SoLuongHD")
            {
                ChartType = SeriesChartType.Column, // Đặt kiểu biểu đồ cột
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                Color = Color.Orange // Màu cho cột số lượng hóa đơn
            };

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string employeeName = row["TenNV"].ToString();
                double revenue = Convert.ToDouble(row["TongDoanhThu"]);
                int quantity = Convert.ToInt32(row["SoLuongGiaoDich"]); // Lấy số lượng hóa đơn

                // Thêm dữ liệu vào series doanh thu
                seriesDoanhThu.Points.AddXY(employeeName, revenue);

                // Thêm dữ liệu vào series số lượng hóa đơn
                seriesSoLuongHD.Points.AddXY(employeeName, quantity);
            }

            // Thêm series vào biểu đồ
            chartTKTheoNV.Series.Add(seriesDoanhThu);
            chartTKTheoNV.Series.Add(seriesSoLuongHD);

            // Đặt tên cho các trục
            chartTKTheoNV.ChartAreas[0].AxisX.Title = "Nhân viên";  // Đặt tên cho trục X
            chartTKTheoNV.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";  // Đặt tên cho trục Y cho doanh thu
            chartTKTheoNV.ChartAreas[0].AxisY2.Title = "Số lượng hóa đơn"; // Đặt tên cho trục Y2 cho số lượng hóa đơn

            // Đặt trục Y2 cho series số lượng hóa đơn
            seriesSoLuongHD.YAxisType = AxisType.Secondary;

            // Đảm bảo hiển thị tất cả tên nhân viên
            chartTKTheoNV.ChartAreas[0].AxisX.Interval = 1;
            chartTKTheoNV.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}"; // Định dạng hiển thị cho trục Y doanh thu
            chartTKTheoNV.ChartAreas[0].AxisY2.LabelStyle.Format = "{0:N0}"; // Định dạng hiển thị cho trục Y số lượng hóa đơn

            // Tùy chỉnh kích thước biểu đồ để hiển thị đầy đủ tên nhân viên
            chartTKTheoNV.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Đặt góc nghiêng cho nhãn trục X
            chartTKTheoNV.ChartAreas[0].RecalculateAxesScale(); // Tính toán lại tỷ lệ trục
        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadDuLieu_Click(object sender, EventArgs e)
        {
            int month = int.Parse(cbbThang.SelectedItem.ToString());
            int year = int.Parse(cbbNam.SelectedItem.ToString());

            DataTable dt = DAOThongKe.ThongKeDoanhThuTheoNhanVien(month, year);
            dgvThongKe.DataSource = dt;

            // Hiển thị dữ liệu biểu đồ
            DisplayChart(dt);
        }

        private void ExportToCSV(DataGridView dgv, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
            {
                // Ghi tiêu đề cột
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    writer.Write($"\"{dgv.Columns[i].HeaderText}\"");
                    if (i < dgv.Columns.Count - 1) writer.Write(";"); // Sử dụng dấu chấm phẩy
                }
                writer.WriteLine();

                // Ghi từng hàng dữ liệu
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            var cellValue = row.Cells[i].Value?.ToString() ?? string.Empty;

                            // Kiểm tra và định dạng giá trị là số lớn thành chuỗi
                            if (decimal.TryParse(cellValue, out decimal _))
                            {
                                cellValue = $"=\"{cellValue}\"";  // Thêm công thức ="value" để giữ định dạng số
                            }
                            else
                            {
                                cellValue = $"\"{cellValue.Replace("\"", "\"\"")}\"";
                            }

                            writer.Write(cellValue);

                            if (i < dgv.Columns.Count - 1) writer.Write(";");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save data to CSV"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dgvThongKe, saveFileDialog.FileName);
                MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
