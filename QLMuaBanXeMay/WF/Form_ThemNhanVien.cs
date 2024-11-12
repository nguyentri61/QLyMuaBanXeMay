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
    public partial class Form_ThemNhanVien : Form
    {
        private NhanVien nv;
        private TaiKhoan tk;

        public NhanVien Nv { get => nv; set => nv = value; }
        public TaiKhoan Tk { get => tk; set => tk = value; }

        public Form_ThemNhanVien(NhanVien nv, TaiKhoan tk)
        {
            InitializeComponent();
            this.Nv = nv;
            this.Tk = tk;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Nv.CCCDNV = int.Parse(txtCCCD.Text);
                Nv.TenNV = txtTenNV.Text;
                Nv.NgaySinh = dtpNgaySinh.Value;
                Nv.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                Nv.SDT = txtSDT.Text;
                Nv.DiaChi = txtDiaChi.Text;
                Nv.Email = txtEmail.Text;
                Nv.ChucVu = cbbChucVu.SelectedItem.ToString();

                Tk.TenTK = txtTenTK.Text;
                Tk.MatKhau = txtMatKhau.Text;
                Tk.CCCDNV = Nv.CCCDNV;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
            
        }

        private void Form_ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
