using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
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

namespace QLMuaBanXeMay.UC
{
    public partial class UC_QLVoucher : UserControl
    {
        Voucher voucher;
        NhanVien user;
        public UC_QLVoucher(NhanVien user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();
        }
        private void LoadData()
        {
            gv_voucher.DataSource = DAOVoucher.Load_ViewVC();
            gv_voucher.Refresh();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            voucher = new Voucher();
            Form_ThemVoucher form = new Form_ThemVoucher(voucher);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Nhận giá trị từ Form2
                    voucher = form.vc;
                    DAOVoucher.ThemVoucher(voucher);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }
    }
}
