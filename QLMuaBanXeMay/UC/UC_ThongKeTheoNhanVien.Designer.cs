namespace QLMuaBanXeMay.UC
{
    partial class UC_ThongKeTheoNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartTKTheoNV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLoadDuLieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatFile = new Guna.UI2.WinForms.Guna2Button();
            this.qLXePTDataSetDTTheoNV = new QLMuaBanXeMay.QLXePTDataSetDTTheoNV();
            this.thongKeDoanhThuTheoNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeDoanhThuTheoNhanVienTableAdapter = new QLMuaBanXeMay.QLXePTDataSetDTTheoNVTableAdapters.ThongKeDoanhThuTheoNhanVienTableAdapter();
            this.cCCDNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDoanhThuXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDoanhThuPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDoanhThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongGiaoDichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriMaxXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriMaxPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriMinXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriMinPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKTheoNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetDTTheoNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDoanhThuTheoNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbThang.ItemHeight = 30;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(40, 94);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(108, 36);
            this.cbbThang.TabIndex = 6;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(40, 51);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(108, 24);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Chọn Tháng:";
            // 
            // chartTKTheoNV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTKTheoNV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKTheoNV.Legends.Add(legend1);
            this.chartTKTheoNV.Location = new System.Drawing.Point(177, 23);
            this.chartTKTheoNV.Name = "chartTKTheoNV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTKTheoNV.Series.Add(series1);
            this.chartTKTheoNV.Size = new System.Drawing.Size(1083, 447);
            this.chartTKTheoNV.TabIndex = 5;
            this.chartTKTheoNV.Text = "chart1";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.ColumnHeadersHeight = 35;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCCDNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.tongDoanhThuXeDataGridViewTextBoxColumn,
            this.tongDoanhThuPTDataGridViewTextBoxColumn,
            this.tongDoanhThuDataGridViewTextBoxColumn,
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn,
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn,
            this.soLuongGiaoDichDataGridViewTextBoxColumn,
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn,
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn,
            this.giaTriMaxXeDataGridViewTextBoxColumn,
            this.giaTriMaxPTDataGridViewTextBoxColumn,
            this.giaTriMinXeDataGridViewTextBoxColumn,
            this.giaTriMinPTDataGridViewTextBoxColumn});
            this.dgvThongKe.DataSource = this.thongKeDoanhThuTheoNhanVienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.Location = new System.Drawing.Point(40, 495);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1220, 182);
            this.dgvThongKe.TabIndex = 8;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongKe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvThongKe.ThemeStyle.ReadOnly = true;
            this.dgvThongKe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongKe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongKe_CellContentClick);
            // 
            // cbbNam
            // 
            this.cbbNam.AutoCompleteCustomSource.AddRange(new string[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNam.ItemHeight = 30;
            this.cbbNam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbbNam.Location = new System.Drawing.Point(40, 192);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(108, 36);
            this.cbbNam.TabIndex = 11;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 151);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(93, 24);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Chọn Năm:";
            // 
            // btnLoadDuLieu
            // 
            this.btnLoadDuLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadDuLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadDuLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadDuLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadDuLieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadDuLieu.ForeColor = System.Drawing.Color.White;
            this.btnLoadDuLieu.Location = new System.Drawing.Point(40, 274);
            this.btnLoadDuLieu.Name = "btnLoadDuLieu";
            this.btnLoadDuLieu.Size = new System.Drawing.Size(108, 45);
            this.btnLoadDuLieu.TabIndex = 13;
            this.btnLoadDuLieu.Text = "Load dữ liệu";
            this.btnLoadDuLieu.Click += new System.EventHandler(this.btnLoadDuLieu_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(40, 360);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(108, 45);
            this.btnXuatFile.TabIndex = 14;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // qLXePTDataSetDTTheoNV
            // 
            this.qLXePTDataSetDTTheoNV.DataSetName = "QLXePTDataSetDTTheoNV";
            this.qLXePTDataSetDTTheoNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeDoanhThuTheoNhanVienBindingSource
            // 
            this.thongKeDoanhThuTheoNhanVienBindingSource.DataMember = "ThongKeDoanhThuTheoNhanVien";
            this.thongKeDoanhThuTheoNhanVienBindingSource.DataSource = this.qLXePTDataSetDTTheoNV;
            // 
            // thongKeDoanhThuTheoNhanVienTableAdapter
            // 
            this.thongKeDoanhThuTheoNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // cCCDNVDataGridViewTextBoxColumn
            // 
            this.cCCDNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cCCDNVDataGridViewTextBoxColumn.DataPropertyName = "CCCDNV";
            this.cCCDNVDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDNVDataGridViewTextBoxColumn.Name = "cCCDNVDataGridViewTextBoxColumn";
            this.cCCDNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongDoanhThuXeDataGridViewTextBoxColumn
            // 
            this.tongDoanhThuXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongDoanhThuXeDataGridViewTextBoxColumn.DataPropertyName = "TongDoanhThuXe";
            this.tongDoanhThuXeDataGridViewTextBoxColumn.HeaderText = "TongDoanhThuXe";
            this.tongDoanhThuXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongDoanhThuXeDataGridViewTextBoxColumn.Name = "tongDoanhThuXeDataGridViewTextBoxColumn";
            this.tongDoanhThuXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongDoanhThuPTDataGridViewTextBoxColumn
            // 
            this.tongDoanhThuPTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongDoanhThuPTDataGridViewTextBoxColumn.DataPropertyName = "TongDoanhThuPT";
            this.tongDoanhThuPTDataGridViewTextBoxColumn.HeaderText = "TongDoanhThuPT";
            this.tongDoanhThuPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongDoanhThuPTDataGridViewTextBoxColumn.Name = "tongDoanhThuPTDataGridViewTextBoxColumn";
            this.tongDoanhThuPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongDoanhThuDataGridViewTextBoxColumn
            // 
            this.tongDoanhThuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongDoanhThuDataGridViewTextBoxColumn.DataPropertyName = "TongDoanhThu";
            this.tongDoanhThuDataGridViewTextBoxColumn.HeaderText = "Tổng doanh thu";
            this.tongDoanhThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongDoanhThuDataGridViewTextBoxColumn.Name = "tongDoanhThuDataGridViewTextBoxColumn";
            this.tongDoanhThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongGiaoDichXeDataGridViewTextBoxColumn
            // 
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn.DataPropertyName = "SoLuongGiaoDichXe";
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn.HeaderText = "SoLuongGiaoDichXe";
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn.Name = "soLuongGiaoDichXeDataGridViewTextBoxColumn";
            this.soLuongGiaoDichXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongGiaoDichPTDataGridViewTextBoxColumn
            // 
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn.DataPropertyName = "SoLuongGiaoDichPT";
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn.HeaderText = "SoLuongGiaoDichPT";
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn.Name = "soLuongGiaoDichPTDataGridViewTextBoxColumn";
            this.soLuongGiaoDichPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongGiaoDichDataGridViewTextBoxColumn
            // 
            this.soLuongGiaoDichDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "SoLuongGiaoDich";
            this.soLuongGiaoDichDataGridViewTextBoxColumn.HeaderText = "SoLuongGiaoDich";
            this.soLuongGiaoDichDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongGiaoDichDataGridViewTextBoxColumn.Name = "soLuongGiaoDichDataGridViewTextBoxColumn";
            this.soLuongGiaoDichDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriTrungBinhXeDataGridViewTextBoxColumn
            // 
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn.DataPropertyName = "GiaTriTrungBinhXe";
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn.HeaderText = "GiaTriTrungBinhXe";
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn.Name = "giaTriTrungBinhXeDataGridViewTextBoxColumn";
            this.giaTriTrungBinhXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriTrungBinhPTDataGridViewTextBoxColumn
            // 
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn.DataPropertyName = "GiaTriTrungBinhPT";
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn.HeaderText = "GiaTriTrungBinhPT";
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn.Name = "giaTriTrungBinhPTDataGridViewTextBoxColumn";
            this.giaTriTrungBinhPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriMaxXeDataGridViewTextBoxColumn
            // 
            this.giaTriMaxXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriMaxXeDataGridViewTextBoxColumn.DataPropertyName = "GiaTriMaxXe";
            this.giaTriMaxXeDataGridViewTextBoxColumn.HeaderText = "GiaTriMaxXe";
            this.giaTriMaxXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriMaxXeDataGridViewTextBoxColumn.Name = "giaTriMaxXeDataGridViewTextBoxColumn";
            this.giaTriMaxXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriMaxPTDataGridViewTextBoxColumn
            // 
            this.giaTriMaxPTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriMaxPTDataGridViewTextBoxColumn.DataPropertyName = "GiaTriMaxPT";
            this.giaTriMaxPTDataGridViewTextBoxColumn.HeaderText = "GiaTriMaxPT";
            this.giaTriMaxPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriMaxPTDataGridViewTextBoxColumn.Name = "giaTriMaxPTDataGridViewTextBoxColumn";
            this.giaTriMaxPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriMinXeDataGridViewTextBoxColumn
            // 
            this.giaTriMinXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriMinXeDataGridViewTextBoxColumn.DataPropertyName = "GiaTriMinXe";
            this.giaTriMinXeDataGridViewTextBoxColumn.HeaderText = "GiaTriMinXe";
            this.giaTriMinXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriMinXeDataGridViewTextBoxColumn.Name = "giaTriMinXeDataGridViewTextBoxColumn";
            this.giaTriMinXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriMinPTDataGridViewTextBoxColumn
            // 
            this.giaTriMinPTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriMinPTDataGridViewTextBoxColumn.DataPropertyName = "GiaTriMinPT";
            this.giaTriMinPTDataGridViewTextBoxColumn.HeaderText = "GiaTriMinPT";
            this.giaTriMinPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriMinPTDataGridViewTextBoxColumn.Name = "giaTriMinPTDataGridViewTextBoxColumn";
            this.giaTriMinPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UC_ThongKeTheoNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnLoadDuLieu);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.chartTKTheoNV);
            this.Name = "UC_ThongKeTheoNhanVien";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_ThongKeTheoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKTheoNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetDTTheoNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDoanhThuTheoNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbbThang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKTheoNV;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongKe;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnLoadDuLieu;
        private Guna.UI2.WinForms.Guna2Button btnXuatFile;
        private System.Windows.Forms.BindingSource thongKeDoanhThuTheoNhanVienBindingSource;
        private QLXePTDataSetDTTheoNV qLXePTDataSetDTTheoNV;
        private QLXePTDataSetDTTheoNVTableAdapters.ThongKeDoanhThuTheoNhanVienTableAdapter thongKeDoanhThuTheoNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDoanhThuXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDoanhThuPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDoanhThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongGiaoDichXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongGiaoDichPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongGiaoDichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriTrungBinhXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriTrungBinhPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriMaxXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriMaxPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriMinXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriMinPTDataGridViewTextBoxColumn;
    }
}
