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
    public partial class Form_ThemKhachHang : Form
    {
        private KhachHang kh;
        public Form_ThemKhachHang(KhachHang kh)
        {
            InitializeComponent();
            this.Kh = kh;
        }

        public KhachHang Kh { get => kh; set => kh = value; }

        private void Form_ThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                kh.CCCDKH = int.Parse(txtCCCD.Text);
                kh.TenKH = txtTenKH.Text;
                kh.NgaySinh = dtpNgaySinh.Value;
                kh.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
