using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.UC;
using QLMuaBanXeMay.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay
{
    public partial class Form1 : Form
    {
        NhanVien NhanVien;
        public Form1(NhanVien nhanvien)
        {
            InitializeComponent();
            NhanVien=nhanvien;
            loadRole();
        }
        private void loadRole()
        {
            
            if (NhanVien.ChucVu=="Bán Hàng")
            {
                btnBillTool.Visible = false;
                btnTool.Visible = false;
                btn_QLVoucher.Visible = false;
                
                btnEmployee.Visible = false;
            }else if(NhanVien.ChucVu== "Kỹ Thuật")
            {
                btnBillBike.Visible = false;
                btnMotobike.Visible = false;
                btnEmployee.Visible = false;
                btn_QLVoucher.Visible= false;
            }
            
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UC_QLThongTinNhanVien uc = new UC_QLThongTinNhanVien(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            UC_QLThongTinKH uc = new UC_QLThongTinKH(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnMotobike_Click(object sender, EventArgs e)
        {
            UC_QLXe uc = new UC_QLXe(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            UC_QLPhuTung uc = new UC_QLPhuTung(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnBillBike_Click(object sender, EventArgs e)
        {
            
            UC_HoaDonXee uc = new UC_HoaDonXee(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            
        }

        private void btnBillTool_Click(object sender, EventArgs e)
        {
            UC_HoaDonPT uc = new UC_HoaDonPT(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.Show();
            this.Close();

        }

        private void uC_MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            UC_ThongKeDoanhThu uc = new UC_ThongKeDoanhThu();
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btn_calam_Click(object sender, EventArgs e)
        {
            UC_PhanCa uc = new UC_PhanCa(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btn_QLVoucher_Click(object sender, EventArgs e)
        {
            UC_QLVoucher uc = new UC_QLVoucher(NhanVien);
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoaDonLuong_Click(object sender, EventArgs e)
        {
            UC_HoaDonLuong uc = new UC_HoaDonLuong();
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
