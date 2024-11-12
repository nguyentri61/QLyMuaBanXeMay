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

namespace QLMuaBanXeMay.WF
{
    public partial class Form_ChiTietHoaDonLuong : Form
    {
        ChiTietHoaDonLuong cthdl = new ChiTietHoaDonLuong();
        public Form_ChiTietHoaDonLuong(ChiTietHoaDonLuong cthdl)
        {
            InitializeComponent();
            this.cthdl = cthdl;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form_ChiTietHoaDonLuong_Load(object sender, EventArgs e)
        {
            lbCCCD.Text = cthdl.CCCDNV.ToString();
            lbHoTen.Text = cthdl.TenNV.ToString();
            lbChucVu.Text = cthdl.ChucVu.ToString();
            lbMaHD.Text = cthdl.MaHDL.ToString();
            lbNgayXuat.Text = cthdl.NgayXuat.ToShortDateString();
            lbSoGioLam.Text = cthdl.SoGioLam.ToString();
            lbLuongCoBan.Text = cthdl.LuongCoBan.ToString();
            lbTongLuong.Text = cthdl.TongTien.ToString();
        }
    }
}
