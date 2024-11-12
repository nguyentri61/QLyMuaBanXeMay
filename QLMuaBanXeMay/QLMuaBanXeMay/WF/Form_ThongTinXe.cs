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
    public partial class Form_ThongTinXe : Form
    {
        XeMay xeMay = new XeMay();
        public Form_ThongTinXe(XeMay xeMay)
        {
            this.Xe = xeMay; 
            InitializeComponent();
        }

        public XeMay Xe { get => xeMay; set => xeMay = value; }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            xeMay.MaXe = Convert.ToInt32(txt_MaXe.Text);
            xeMay.TenXe = txt_TenXe.Text.ToString(); // hoặc row.Cells[0].Value.ToString()
            xeMay.DonGia = float.Parse(txt_DonGia.Text);
            xeMay.LoaiXe = txt_LoaiXe.Text.ToString();
            xeMay.MauSac = txt_MauSac.Text.ToString();
            xeMay.PhanKhoi = Convert.ToInt32(txt_PhanKhoi.Text);
            xeMay.CongSuat = float.Parse(txt_CongSuat.Text);
            xeMay.HangSX = txt_HangSX.Text;
            xeMay.NamSX = Convert.ToInt32(txt_NamSX.Text);
            xeMay.TinhTrang = txt_TinhTrang.Text;

            this.DialogResult = DialogResult.OK; // Thiết lập kết quả đối thoại
            this.Close(); // Đóng Form2
        }
    }
}
