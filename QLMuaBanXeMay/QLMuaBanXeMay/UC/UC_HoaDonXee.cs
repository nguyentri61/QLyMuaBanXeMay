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
    public partial class UC_HoaDonXee : UserControl
    {
        public UC_HoaDonXee()
        {
            InitializeComponent();
        }

        private void UC_HoaDonXee_Load(object sender, EventArgs e)
        {

        }
        public UC_HoaDonXee(int maXe)
        {
            InitializeComponent();
            this.txt_maXe.Text = maXe.ToString();
            
        }

        private void groupBox_spXe_Enter(object sender, EventArgs e)
        {

        }
    }
}
