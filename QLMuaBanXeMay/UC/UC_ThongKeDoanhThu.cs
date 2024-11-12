using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThongKeDoanhThu : UserControl
    {
        public UC_ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelDoanhThu.Controls.Clear();
            panelDoanhThu.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnTKTheoNV_Click(object sender, EventArgs e)
        {
            UC_ThongKeTheoNhanVien uc = new UC_ThongKeTheoNhanVien();
            addUC(uc);
        }

        private void btnTKTheoThang_Click(object sender, EventArgs e)
        {
            UC_ThongKeTheoThang uc = new UC_ThongKeTheoThang();
            addUC(uc);
        }

        private void panelDoanhThu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
