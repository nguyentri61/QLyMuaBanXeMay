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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox_spXe = new System.Windows.Forms.GroupBox();
            this.dgthongTinTongHopLuongNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDonNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewThongTinCaNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetThongTinCaNVXuatHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetXuatHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonLuongNhanVienBindingSource)).BeginInit();
            this.groupBox_spXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgthongTinTongHopLuongNV)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 133);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(803, 35);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(266, 27);
            this.txtChucVu.TabIndex = 15;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(201, 75);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(266, 27);
            this.txtTenNV.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(201, 32);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(266, 27);
            this.txtMaNV.TabIndex = 10;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "MM/yyyy";
            this.dtpNgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(803, 73);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.ShowUpDown = true;
            this.dtpNgayXuat.Size = new System.Drawing.Size(266, 27);
            this.dtpNgayXuat.TabIndex = 9;
            this.dtpNgayXuat.ValueChanged += new System.EventHandler(this.dtpNgayXuat_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(639, 35);
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
            this.label6.Location = new System.Drawing.Point(37, 82);
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
            this.label5.Location = new System.Drawing.Point(37, 42);
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
            this.label4.Location = new System.Drawing.Point(639, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tháng tính lương:";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(489, 562);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(180, 45);
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
            this.dgvThongTinHoaDonNV.Location = new System.Drawing.Point(28, 151);
            this.dgvThongTinHoaDonNV.Name = "dgvThongTinHoaDonNV";
            this.dgvThongTinHoaDonNV.ReadOnly = true;
            this.dgvThongTinHoaDonNV.RowHeadersVisible = false;
            this.dgvThongTinHoaDonNV.RowHeadersWidth = 51;
            this.dgvThongTinHoaDonNV.RowTemplate.Height = 24;
            this.dgvThongTinHoaDonNV.Size = new System.Drawing.Size(1125, 216);
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
            // groupBox_spXe
            // 
            this.groupBox_spXe.Controls.Add(this.dgthongTinTongHopLuongNV);
            this.groupBox_spXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_spXe.Location = new System.Drawing.Point(28, 373);
            this.groupBox_spXe.Name = "groupBox_spXe";
            this.groupBox_spXe.Size = new System.Drawing.Size(1125, 183);
            this.groupBox_spXe.TabIndex = 58;
            this.groupBox_spXe.TabStop = false;
            this.groupBox_spXe.Text = "Thông tin lương nhân viên";
            // 
            // dgthongTinTongHopLuongNV
            // 
            this.dgthongTinTongHopLuongNV.AllowUserToAddRows = false;
            this.dgthongTinTongHopLuongNV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgthongTinTongHopLuongNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgthongTinTongHopLuongNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgthongTinTongHopLuongNV.ColumnHeadersHeight = 18;
            this.dgthongTinTongHopLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgthongTinTongHopLuongNV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgthongTinTongHopLuongNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgthongTinTongHopLuongNV.Location = new System.Drawing.Point(0, 27);
            this.dgthongTinTongHopLuongNV.Name = "dgthongTinTongHopLuongNV";
            this.dgthongTinTongHopLuongNV.ReadOnly = true;
            this.dgthongTinTongHopLuongNV.RowHeadersVisible = false;
            this.dgthongTinTongHopLuongNV.RowHeadersWidth = 51;
            this.dgthongTinTongHopLuongNV.RowTemplate.Height = 24;
            this.dgthongTinTongHopLuongNV.Size = new System.Drawing.Size(1125, 156);
            this.dgthongTinTongHopLuongNV.TabIndex = 58;
            this.dgthongTinTongHopLuongNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgthongTinTongHopLuongNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgthongTinTongHopLuongNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgthongTinTongHopLuongNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgthongTinTongHopLuongNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgthongTinTongHopLuongNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgthongTinTongHopLuongNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgthongTinTongHopLuongNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgthongTinTongHopLuongNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgthongTinTongHopLuongNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgthongTinTongHopLuongNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgthongTinTongHopLuongNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgthongTinTongHopLuongNV.ThemeStyle.HeaderStyle.Height = 18;
            this.dgthongTinTongHopLuongNV.ThemeStyle.ReadOnly = true;
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.Height = 24;
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgthongTinTongHopLuongNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Form_ThemHoaDonLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.groupBox_spXe);
            this.Controls.Add(this.dgvThongTinHoaDonNV);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ThemHoaDonLuong";
            this.Text = "Form_ThemHoaDonLuong";
            this.Load += new System.EventHandler(this.Form_ThemHoaDonLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDonNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewThongTinCaNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetThongTinCaNVXuatHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetXuatHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHoaDonLuongNhanVienBindingSource)).EndInit();
            this.groupBox_spXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgthongTinTongHopLuongNV)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_spXe;
        private Guna.UI2.WinForms.Guna2DataGridView dgthongTinTongHopLuongNV;
    }
}