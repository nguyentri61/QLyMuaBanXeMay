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
    
    public partial class Form_ThemVoucher : Form
    {
        Voucher voucher = new Voucher();
        public Form_ThemVoucher(Voucher voucher)
        {
            InitializeComponent();
            this.vc = voucher;
        }
        public Voucher vc { get => voucher; set => voucher = value; }
        private void btn_them_Click(object sender, EventArgs e)
        {
            voucher.TenVC = txt_tenVC.Text;
            voucher.Giatri = double.Parse(txt_gtCanDat.Text);
            voucher.Giamgia = double.Parse(txt_gtGiamGia.Text);
            voucher.NgayHH = dt_ngayHH.Value;
            voucher.GgToida = double.Parse(txt_ghToiDa.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
