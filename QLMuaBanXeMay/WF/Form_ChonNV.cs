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
    public partial class Form_ChonNV : Form
    {
        public ChiTietCaLam chiTietCaLam = new ChiTietCaLam();  
        public Form_ChonNV()
        {
            InitializeComponent();
        }

        private void Form_ChonNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLXePTDataSet2.NhanVien' table. You can move, or remove it, as needed.
            gv_nhanvien.DataSource = DAONhanVien.LayThongTinNhanVienCaLam();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            chiTietCaLam.GhiChu=txtGhiChu.Text;
            if (chiTietCaLam.CCDNV != null) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
            
        }

        private void gv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số hàng (row index) được click
            int rowIndex = e.RowIndex;

            // Lấy dữ liệu từ tất cả các cột của hàng đó
            chiTietCaLam.CCDNV = int.Parse(gv_nhanvien.Rows[rowIndex].Cells[0].Value.ToString());

        }
    }
}
