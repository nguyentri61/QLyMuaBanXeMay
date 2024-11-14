using LiveCharts.Wpf;
using LiveCharts;
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
using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThongKeLoiNhuan : UserControl
    {
        public UC_ThongKeLoiNhuan()
        {
            InitializeComponent();
            UC_ThongKeLoiNhuan_LoadBD();

        }
        private void UC_ThongKeLoiNhuan_LoadBD()
        {
            DataTable chartData = DAOThongKe.getChartData(Convert.ToDateTime(dtpStartDate.Value),Convert.ToDateTime(dtpEndate.Value));
            var months = new List<string>();
            var revenueData = new ChartValues<double>();
            var salaryCostData = new ChartValues<double>();
            foreach (DataRow row in chartData.Rows)
            {
                string monthLabel = $"{row["Nam"]}-{row["Thang"]}";

                double revenue = row["TongDoanhThu"] == DBNull.Value ? 0 : Convert.ToDouble(row["TongDoanhThu"]);
                double salaryCost = row["TongChiPhiLuong"] == DBNull.Value ? 0 : Convert.ToDouble(row["TongChiPhiLuong"]);

                months.Add(monthLabel);
                revenueData.Add(revenue);
                salaryCostData.Add(salaryCost);
            }


            var revenueSeries = new LineSeries
                {
                    Title = "Doanh Thu",
                    Values = revenueData,
                    Stroke = System.Windows.Media.Brushes.Green,
                    Fill = System.Windows.Media.Brushes.Transparent
                };


                var salaryCostSeries = new LineSeries
                {
                    Title = "Chi Phí Lương",
                    Values = salaryCostData,
                    Stroke = System.Windows.Media.Brushes.Blue,
                    Fill = System.Windows.Media.Brushes.Transparent
                };


                cartesianChart1.Series.Clear();
                cartesianChart1.Series.Add(revenueSeries);
                cartesianChart1.Series.Add(salaryCostSeries);


                var axisX = new Axis
                {
                    Title = "Tháng",
                    Labels = months.ToArray()
                };

                var axisY = new Axis
                {
                    Title = "Giá trị",
                    LabelFormatter = value => value.ToString("C0")
                };

                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisX.Add(axisX);

                cartesianChart1.AxisY.Clear();
                cartesianChart1.AxisY.Add(axisY);


        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            UC_ThongKeLoiNhuan_LoadBD();
        }

        private void dtpEndate_ValueChanged(object sender, EventArgs e)
        {
            UC_ThongKeLoiNhuan_LoadBD();
        }

        private void UC_ThongKeLoiNhuan_Load(object sender, EventArgs e)
        {

        }
    }
}
