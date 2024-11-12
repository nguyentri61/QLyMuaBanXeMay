namespace QLMuaBanXeMay.WF
{
    partial class Form_ThemHoaDonLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_spXe = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoGioLam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.dgvThongTinHoaDonNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cCCDNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCoBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewThongTinCaNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLXePTDataSetThongTinCaNVXuatHD = new QLMuaBanXeMay.QLXePTDataSetThongTinCaNVXuatHD();
            this.qLXePTDataSetXuatHoaDon = new QLMuaBanXeMay.QLXePTDataSetXuatHoaDon();
            this.viewHoaDonLuongNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_HoaDonLuongNhanVienTableAdapter = new QLMuaBanXeMay.QLXePTDataSetXuatHoaDonTableAdapters.View_HoaDonLuongNhanVienTableAdapter();
            this.view_ThongTinCaNhanVienTableAdapter = new QLMuaBanXeMay.QLXePTDataSetThongTinCaNVXuatHDTableAdapters.View_ThongTinCaNhanVienTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox_spXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDonNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewThongTinCaNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetThongTinCaNVXuatHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetXuatHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonLuongNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayXuat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1266, 166);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(903, 44);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(299, 27);
            this.txtChucVu.TabIndex = 15;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(226, 94);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(299, 27);
            this.txtTenNV.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(226, 40);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(299, 27);
            this.txtMaNV.TabIndex = 10;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "MM/yyyy";
            this.dtpNgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(903, 91);
            this.dtpNgayXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(299, 27);
            this.dtpNgayXuat.TabIndex = 9;
            this.dtpNgayXuat.ValueChanged += new System.EventHandler(this.dtpNgayXuat_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(719, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Chức vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(42, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(42, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(719, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày xuất:";
            // 
            // groupBox_spXe
            // 
            this.groupBox_spXe.Controls.Add(this.txtTongTien);
            this.groupBox_spXe.Controls.Add(this.label9);
            this.groupBox_spXe.Controls.Add(this.txtLuongCoBan);
            this.groupBox_spXe.Controls.Add(this.label1);
            this.groupBox_spXe.Controls.Add(this.txtSoGioLam);
            this.groupBox_spXe.Controls.Add(this.label7);
            this.groupBox_spXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_spXe.Location = new System.Drawing.Point(32, 206);
            this.groupBox_spXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_spXe.Name = "groupBox_spXe";
            this.groupBox_spXe.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_spXe.Size = new System.Drawing.Size(1266, 129);
            this.groupBox_spXe.TabIndex = 55;
            this.groupBox_spXe.TabStop = false;
            this.groupBox_spXe.Text = "Thông tin hóa đơn";
            this.groupBox_spXe.Enter += new System.EventHandler(this.groupBox_spXe_Enter);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(1043, 66);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(191, 27);
            this.txtTongTien.TabIndex = 49;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(906, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tổng tiền:";
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(215, 71);
            this.txtLuongCoBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(191, 27);
            this.txtLuongCoBan.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Lương cơ bản:";
            // 
            // txtSoGioLam
            // 
            this.txtSoGioLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGioLam.Location = new System.Drawing.Point(640, 71);
            this.txtSoGioLam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoGioLam.Name = "txtSoGioLam";
            this.txtSoGioLam.Size = new System.Drawing.Size(191, 27);
            this.txtSoGioLam.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(454, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Số giờ làm:";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(550, 620);
            this.btnXuatHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(202, 56);
            this.btnXuatHoaDon.TabIndex = 56;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // dgvThongTinHoaDonNV
            // 
            this.dgvThongTinHoaDonNV.AllowUserToAddRows = false;
            this.dgvThongTinHoaDonNV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDonNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinHoaDonNV.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinHoaDonNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinHoaDonNV.ColumnHeadersHeight = 18;
            this.dgvThongTinHoaDonNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinHoaDonNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCCDNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.luongCoBanDataGridViewTextBoxColumn,
            this.tGBatDauDataGridViewTextBoxColumn,
            this.tGKetThucDataGridViewTextBoxColumn});
            this.dgvThongTinHoaDonNV.DataSource = this.viewThongTinCaNhanVienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinHoaDonNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTinHoaDonNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinHoaDonNV.Location = new System.Drawing.Point(32, 342);
            this.dgvThongTinHoaDonNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThongTinHoaDonNV.Name = "dgvThongTinHoaDonNV";
            this.dgvThongTinHoaDonNV.ReadOnly = true;
            this.dgvThongTinHoaDonNV.RowHeadersVisible = false;
            this.dgvThongTinHoaDonNV.RowHeadersWidth = 51;
            this.dgvThongTinHoaDonNV.RowTemplate.Height = 24;
            this.dgvThongTinHoaDonNV.Size = new System.Drawing.Size(1266, 270);
            this.dgvThongTinHoaDonNV.TabIndex = 57;
            this.dgvThongTinHoaDonNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDonNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinHoaDonNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinHoaDonNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinHoaDonNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinHoaDonNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDonNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinHoaDonNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongTinHoaDonNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinHoaDonNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinHoaDonNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDonNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinHoaDonNV.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvThongTinHoaDonNV.ThemeStyle.ReadOnly = true;
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinHoaDonNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinHoaDonNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinHoaDonNV_CellClick);
            // 
            // cCCDNVDataGridViewTextBoxColumn
            // 
            this.cCCDNVDataGridViewTextBoxColumn.DataPropertyName = "CCCDNV";
            this.cCCDNVDataGridViewTextBoxColumn.HeaderText = "CCCDNV";
            this.cCCDNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDNVDataGridViewTextBoxColumn.Name = "cCCDNVDataGridViewTextBoxColumn";
            this.cCCDNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luongCoBanDataGridViewTextBoxColumn
            // 
            this.luongCoBanDataGridViewTextBoxColumn.DataPropertyName = "LuongCoBan";
            this.luongCoBanDataGridViewTextBoxColumn.HeaderText = "LuongCoBan";
            this.luongCoBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongCoBanDataGridViewTextBoxColumn.Name = "luongCoBanDataGridViewTextBoxColumn";
            this.luongCoBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tGBatDauDataGridViewTextBoxColumn
            // 
            this.tGBatDauDataGridViewTextBoxColumn.DataPropertyName = "TGBatDau";
            this.tGBatDauDataGridViewTextBoxColumn.HeaderText = "TGBatDau";
            this.tGBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGBatDauDataGridViewTextBoxColumn.Name = "tGBatDauDataGridViewTextBoxColumn";
            this.tGBatDauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tGKetThucDataGridViewTextBoxColumn
            // 
            this.tGKetThucDataGridViewTextBoxColumn.DataPropertyName = "TGKetThuc";
            this.tGKetThucDataGridViewTextBoxColumn.HeaderText = "TGKetThuc";
            this.tGKetThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGKetThucDataGridViewTextBoxColumn.Name = "tGKetThucDataGridViewTextBoxColumn";
            this.tGKetThucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewThongTinCaNhanVienBindingSource
            // 
            this.viewThongTinCaNhanVienBindingSource.DataMember = "View_ThongTinCaNhanVien";
            this.viewThongTinCaNhanVienBindingSource.DataSource = this.qLXePTDataSetThongTinCaNVXuatHD;
            // 
            // qLXePTDataSetThongTinCaNVXuatHD
            // 
            this.qLXePTDataSetThongTinCaNVXuatHD.DataSetName = "QLXePTDataSetThongTinCaNVXuatHD";
            this.qLXePTDataSetThongTinCaNVXuatHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLXePTDataSetXuatHoaDon
            // 
            this.qLXePTDataSetXuatHoaDon.DataSetName = "QLXePTDataSetXuatHoaDon";
            this.qLXePTDataSetXuatHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewHoaDonLuongNhanVienBindingSource
            // 
            this.viewHoaDonLuongNhanVienBindingSource.DataMember = "View_HoaDonLuongNhanVien";
            this.viewHoaDonLuongNhanVienBindingSource.DataSource = this.qLXePTDataSetXuatHoaDon;
            // 
            // view_HoaDonLuongNhanVienTableAdapter
            // 
            this.view_HoaDonLuongNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // view_ThongTinCaNhanVienTableAdapter
            // 
            this.view_ThongTinCaNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ThemHoaDonLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 691);
            this.Controls.Add(this.dgvThongTinHoaDonNV);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_spXe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_ThemHoaDonLuong";
            this.Text = "Form_ThemHoaDonLuong";
            this.Load += new System.EventHandler(this.Form_ThemHoaDonLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_spXe.ResumeLayout(false);
            this.groupBox_spXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDonNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewThongTinCaNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetThongTinCaNVXuatHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetXuatHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonLuongNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_spXe;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoGioLam;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnXuatHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinHoaDonNV;
        private QLXePTDataSetXuatHoaDon qLXePTDataSetXuatHoaDon;
        private System.Windows.Forms.BindingSource viewHoaDonLuongNhanVienBindingSource;
        private QLXePTDataSetXuatHoaDonTableAdapters.View_HoaDonLuongNhanVienTableAdapter view_HoaDonLuongNhanVienTableAdapter;
        private QLXePTDataSetThongTinCaNVXuatHD qLXePTDataSetThongTinCaNVXuatHD;
        private System.Windows.Forms.BindingSource viewThongTinCaNhanVienBindingSource;
        private QLXePTDataSetThongTinCaNVXuatHDTableAdapters.View_ThongTinCaNhanVienTableAdapter view_ThongTinCaNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCoBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGKetThucDataGridViewTextBoxColumn;
    }
}