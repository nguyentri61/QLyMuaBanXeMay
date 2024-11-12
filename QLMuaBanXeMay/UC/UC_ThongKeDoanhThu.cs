﻿using QLMuaBanXeMay.Class;
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

        private void btnTKTheoNV_Click(object sender, EventArgs e)
        {
            UC_ThongKeTheoNhanVien uc = new UC_ThongKeTheoNhanVien();
            panelDoanhThu.Controls.Clear();
            panelDoanhThu.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnTKTheoThang_Click(object sender, EventArgs e)
        {
            UC_ThongKeTheoThang uc = new UC_ThongKeTheoThang();
            panelDoanhThu.Controls.Clear();
            panelDoanhThu.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
