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
    public partial class UC_PhanCa : UserControl
    {
        NhanVien nhanVien= new NhanVien();
        ChiTietCaLam chiTietCaLam = new ChiTietCaLam();
        CaLam caLam = new CaLam();
        int maca=0;
        public UC_PhanCa(NhanVien nhanVien)
        {   this.nhanVien = nhanVien;
            InitializeComponent();
            Load_GridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_PhanCa_Load(object sender, EventArgs e)
        {
            
        }

        private void Load_GridView()
        {
            gv_Calam.DataSource = DAOCaLam.LayThongTinCaLam();
        }
        private void Load_CTGridView()
        {
            gv_ctca.DataSource =DAOCaLam.LayThongTinCTCaLam(maca);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form_ChonThoiGian ctg = new Form_ChonThoiGian(caLam);
            
            if (ctg.ShowDialog() == DialogResult.OK)
            {
                this.caLam = ctg.calam;
                caLam.CCCDQL=nhanVien.CCCDNV;
                DAOCaLam.ThemCa(caLam);
                Load_GridView();
            }
        }

        private void gv_Calam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số hàng (row index) được click
            int rowIndex = e.RowIndex;

            // Lấy dữ liệu từ tất cả các cột của hàng đó
            maca = int.Parse(gv_Calam.Rows[rowIndex].Cells[0].Value.ToString());
            Load_CTGridView();

        }

        private void btnaddnv_Click(object sender, EventArgs e)
        {
            if (maca == 0)
            {
                MessageBox.Show("Vui lòng chọn ca");
            }

            else
            {
                Form_ChonNV form = new Form_ChonNV();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.chiTietCaLam = form.chiTietCaLam;
                    chiTietCaLam.MaCa = maca;
                    DAOCaLam.ThemChiTietCa(chiTietCaLam);
                    Load_CTGridView();
                }
            }
        }
    }
}
