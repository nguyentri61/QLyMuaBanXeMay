using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
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
    public partial class Form_ChonNVThemLuong : Form
    {
        public NhanVien nv = new NhanVien();
        public HoaDonLuong hdl = new HoaDonLuong();
        public Form_ChonNVThemLuong()
        {
            InitializeComponent();
        }

        private void Form_ChonNVThemLuong_Load(object sender, EventArgs e)
        {
            dgvChonNVLuong.DataSource = DAONhanVien.LayThongTinNhanVienCaLam();

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (hdl.CCCDNV.ToString() != null)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void dgvChonNVLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            hdl.CCCDNV = int.Parse(dgvChonNVLuong.Rows[rowIndex].Cells[0].Value.ToString());
        }
    }
}
