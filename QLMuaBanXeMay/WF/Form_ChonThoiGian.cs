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
    public partial class Form_ChonThoiGian : Form
    {
        public CaLam calam =new CaLam();
        public Form_ChonThoiGian(CaLam caLam)
        {
            this.calam = caLam;
            InitializeComponent();
        }
        public Form_ChonThoiGian()
        {
            InitializeComponent();
        }
        

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            calam.TGBatDau = new DateTime(
                dateTimePicker.Value.Year,
                dateTimePicker.Value.Month,
                dateTimePicker.Value.Day,
                int.Parse(txt_giobd.Text),
                int.Parse(txt_phutbd.Text),
                0
                );
            calam.TGKetThuc = new DateTime(
                dateTimePicker.Value.Year,
                dateTimePicker.Value.Month,
                dateTimePicker.Value.Day,
                int.Parse(txt_giokt.Text),
                int.Parse(txt_phutkt.Text),
                0
                );
            this.DialogResult = DialogResult.OK; 
            this.Close();  
        }
    }
}
