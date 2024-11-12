using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThanhToanPT : UserControl
    {

        Class.PhuTung phuTung_tt = new PhuTung();
        Class.KhachHang khachHang_tt = new KhachHang();
       
        public UC_ThanhToanPT()
        {
            InitializeComponent();
        }
        public UC_ThanhToanPT(PhuTung phuTung, KhachHang khachHang)
        {
            phuTung_tt = phuTung;
            khachHang_tt = khachHang;
            InitializeComponent();
            this.txt_maPT.Text = phuTung.MaPT.ToString();
            this.txt_tenPT.Text = phuTung.TenPT.ToString();
            this.txt_donGia.Text = phuTung.DonGia.ToString();
            this.txt_hangSX.Text = phuTung.HangSX.ToString();
            this.txt_chatLieu.Text = phuTung.ChatLieu.ToString();
            this.txt_soLuong.Text = "1";

        }
        

        private void UC_ThanhToanPT_Load(PhuTung phuTung, KhachHang khachHang)
        {
            /*InitializeComponent();*/
            this.txt_maPT.Text = phuTung.MaPT.ToString();
            this.txt_tenPT.Text = phuTung.TenPT.ToString();
            this.txt_donGia.Text = phuTung.DonGia.ToString();
            this.txt_hangSX.Text = phuTung.HangSX.ToString();
            this.txt_chatLieu.Text = phuTung.ChatLieu.ToString();
            this.txt_soLuong.Text = "1";

            this.txt_cccdKH.Text = khachHang.CCCDKH.ToString();
            this.txt_ten.Text = khachHang.TenKH.ToString();
            this.dt_ngaySinh.Value = khachHang.NgaySinh;
            this.txt_gioiTinh.Text = khachHang.GioiTinh.ToString();
            this.txt_sdt.Text = khachHang.SDT.ToString();
            this.txt_diaChi.Text = khachHang.DiaChi.ToString();
            this.txt_email.Text = khachHang.Email.ToString();
        }

        private void btn_chonKH_Click(object sender, EventArgs e)
        {
            Form_ThongTinKH kh = new Form_ThongTinKH(khachHang_tt);
            khachHang_tt = kh.KhachHang1;

            if (kh.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(khachHang_tt.TenKH.ToString());
                UC_ThanhToanPT_Load(phuTung_tt, khachHang_tt);
            }
                
        }

        private void txt_cccdKH_TextChanged(object sender, EventArgs e)
        {
            txt_khuyenMai.Text = DAO.DAOHoaDonPT.LayThongTinKhuyenMai(Convert.ToInt32(txt_cccdKH.Text));
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            Class.HoaDonPT hoaDonPT = new HoaDonPT();
            hoaDonPT.MaHDPT = Convert.ToInt32(txt_maHD.Text);
            hoaDonPT.KhuyenMai = float.Parse(txt_khuyenMai.Text);
            hoaDonPT.TongTien = float.Parse(txt_thanhTien.Text);
            hoaDonPT.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
            hoaDonPT.CCCDNV = 123456789;
            hoaDonPT.PTTT = cb_pttt.Text;
            hoaDonPT.NgayXuat = dt_ngayXuat.Value;

            DAO.DAOHoaDonPT.ThemHoaDonPT(hoaDonPT);
            

            Class.ChiTietHD_PT chiTietHD_PT = new ChiTietHD_PT();
            chiTietHD_PT.MaHDPT = Convert.ToInt32(txt_maHD.Text);
            chiTietHD_PT.MaPT = Convert.ToInt32(txt_maPT.Text);
            chiTietHD_PT.SoLuong = Convert.ToInt32(txt_soLuong.Text);
            chiTietHD_PT.DonGia = float.Parse(txt_donGia.Text);

            DAO.DAOHoaDonPT.ThemChiTietHDPT(chiTietHD_PT);

            MessageBox.Show("Done");



        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            int soluong;
            float khuyenmai;
            float thanhTien = 0;
            if (int.TryParse(txt_soLuong.Text, out soluong))
            {
                int donGia = Convert.ToInt32(txt_donGia.Text);
                thanhTien = soluong * donGia;
                
            }
            if(float.TryParse(txt_khuyenMai.Text, out khuyenmai))
            {
                thanhTien = thanhTien - (thanhTien * khuyenmai);
            }    
            
            txt_thanhTien.Text = thanhTien.ToString();

        }
    }
}
