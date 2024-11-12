namespace QLMuaBanXeMay.UC
{
    partial class UC_PhanCa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_Calam = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLXePTDataSet = new QLMuaBanXeMay.QLXePTDataSet();
            this.caLamViecTableAdapter = new QLMuaBanXeMay.QLXePTDataSetTableAdapters.CaLamViecTableAdapter();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddnv = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gv_ctca = new Guna.UI2.WinForms.Guna2DataGridView();
            this.viewChiTietCaLamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLXePTDataSet1 = new QLMuaBanXeMay.QLXePTDataSet1();
            this.view_ChiTietCaLamTableAdapter = new QLMuaBanXeMay.QLXePTDataSet1TableAdapters.View_ChiTietCaLamTableAdapter();
            this.qLXePTDataSet3 = new QLMuaBanXeMay.QLXePTDataSet3();
            this.viewChiTietCaLamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_ChiTietCaLamTableAdapter1 = new QLMuaBanXeMay.QLXePTDataSet3TableAdapters.View_ChiTietCaLamTableAdapter();
            this.maCaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Calam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caLamViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietCaLamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietCaLamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHÂN CA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_Calam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 267);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ca Làm";
            // 
            // gv_Calam
            // 
            this.gv_Calam.AllowUserToAddRows = false;
            this.gv_Calam.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gv_Calam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Calam.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Calam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_Calam.ColumnHeadersHeight = 30;
            this.gv_Calam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_Calam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCaDataGridViewTextBoxColumn,
            this.tGBatDauDataGridViewTextBoxColumn,
            this.tGKetThucDataGridViewTextBoxColumn});
            this.gv_Calam.DataSource = this.caLamViecBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Calam.DefaultCellStyle = dataGridViewCellStyle9;
            this.gv_Calam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Calam.Location = new System.Drawing.Point(15, 34);
            this.gv_Calam.Name = "gv_Calam";
            this.gv_Calam.ReadOnly = true;
            this.gv_Calam.RowHeadersVisible = false;
            this.gv_Calam.RowHeadersWidth = 51;
            this.gv_Calam.RowTemplate.Height = 24;
            this.gv_Calam.Size = new System.Drawing.Size(1151, 227);
            this.gv_Calam.TabIndex = 49;
            this.gv_Calam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Calam.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_Calam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_Calam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_Calam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_Calam.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_Calam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Calam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gv_Calam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_Calam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Calam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Calam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_Calam.ThemeStyle.HeaderStyle.Height = 30;
            this.gv_Calam.ThemeStyle.ReadOnly = true;
            this.gv_Calam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_Calam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_Calam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Calam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_Calam.ThemeStyle.RowsStyle.Height = 24;
            this.gv_Calam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_Calam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_Calam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Calam_CellClick);
            // 
            // maCaDataGridViewTextBoxColumn
            // 
            this.maCaDataGridViewTextBoxColumn.DataPropertyName = "MaCa";
            this.maCaDataGridViewTextBoxColumn.FillWeight = 62.03208F;
            this.maCaDataGridViewTextBoxColumn.HeaderText = "Mã Ca";
            this.maCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCaDataGridViewTextBoxColumn.Name = "maCaDataGridViewTextBoxColumn";
            this.maCaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tGBatDauDataGridViewTextBoxColumn
            // 
            this.tGBatDauDataGridViewTextBoxColumn.DataPropertyName = "TGBatDau";
            this.tGBatDauDataGridViewTextBoxColumn.FillWeight = 62.03208F;
            this.tGBatDauDataGridViewTextBoxColumn.HeaderText = "Thời gian bắt đầu";
            this.tGBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGBatDauDataGridViewTextBoxColumn.Name = "tGBatDauDataGridViewTextBoxColumn";
            this.tGBatDauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tGKetThucDataGridViewTextBoxColumn
            // 
            this.tGKetThucDataGridViewTextBoxColumn.DataPropertyName = "TGKetThuc";
            this.tGKetThucDataGridViewTextBoxColumn.FillWeight = 62.03208F;
            this.tGKetThucDataGridViewTextBoxColumn.HeaderText = "Thời gian kết thúc";
            this.tGKetThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGKetThucDataGridViewTextBoxColumn.Name = "tGKetThucDataGridViewTextBoxColumn";
            this.tGKetThucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caLamViecBindingSource
            // 
            this.caLamViecBindingSource.DataMember = "CaLamViec";
            this.caLamViecBindingSource.DataSource = this.qLXePTDataSet;
            // 
            // qLXePTDataSet
            // 
            this.qLXePTDataSet.DataSetName = "QLXePTDataSet";
            this.qLXePTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // caLamViecTableAdapter
            // 
            this.caLamViecTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(1090, 696);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(122, 43);
            this.btn_Them.TabIndex = 56;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnaddnv
            // 
            this.btnaddnv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnaddnv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddnv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddnv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnaddnv.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnv.ForeColor = System.Drawing.Color.Black;
            this.btnaddnv.Location = new System.Drawing.Point(818, 696);
            this.btnaddnv.Name = "btnaddnv";
            this.btnaddnv.Size = new System.Drawing.Size(225, 43);
            this.btnaddnv.TabIndex = 57;
            this.btnaddnv.Text = "Thêm Nhân Viên Vào Ca";
            this.btnaddnv.Click += new System.EventHandler(this.btnaddnv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gv_ctca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(63, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1179, 293);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Ca";
            // 
            // gv_ctca
            // 
            this.gv_ctca.AllowUserToAddRows = false;
            this.gv_ctca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gv_ctca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gv_ctca.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_ctca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gv_ctca.ColumnHeadersHeight = 31;
            this.gv_ctca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_ctca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCaDataGridViewTextBoxColumn1,
            this.cCCDNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.GhiChu});
            this.gv_ctca.DataSource = this.viewChiTietCaLamBindingSource1;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_ctca.DefaultCellStyle = dataGridViewCellStyle12;
            this.gv_ctca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_ctca.Location = new System.Drawing.Point(15, 33);
            this.gv_ctca.Name = "gv_ctca";
            this.gv_ctca.ReadOnly = true;
            this.gv_ctca.RowHeadersVisible = false;
            this.gv_ctca.RowHeadersWidth = 51;
            this.gv_ctca.RowTemplate.Height = 24;
            this.gv_ctca.Size = new System.Drawing.Size(1118, 240);
            this.gv_ctca.TabIndex = 0;
            this.gv_ctca.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_ctca.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_ctca.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_ctca.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_ctca.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_ctca.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_ctca.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_ctca.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gv_ctca.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_ctca.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_ctca.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_ctca.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_ctca.ThemeStyle.HeaderStyle.Height = 31;
            this.gv_ctca.ThemeStyle.ReadOnly = true;
            this.gv_ctca.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_ctca.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_ctca.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_ctca.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_ctca.ThemeStyle.RowsStyle.Height = 24;
            this.gv_ctca.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_ctca.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // viewChiTietCaLamBindingSource
            // 
            this.viewChiTietCaLamBindingSource.DataMember = "View_ChiTietCaLam";
            this.viewChiTietCaLamBindingSource.DataSource = this.qLXePTDataSet1;
            // 
            // qLXePTDataSet1
            // 
            this.qLXePTDataSet1.DataSetName = "QLXePTDataSet1";
            this.qLXePTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ChiTietCaLamTableAdapter
            // 
            this.view_ChiTietCaLamTableAdapter.ClearBeforeFill = true;
            // 
            // qLXePTDataSet3
            // 
            this.qLXePTDataSet3.DataSetName = "QLXePTDataSet3";
            this.qLXePTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewChiTietCaLamBindingSource1
            // 
            this.viewChiTietCaLamBindingSource1.DataMember = "View_ChiTietCaLam";
            this.viewChiTietCaLamBindingSource1.DataSource = this.qLXePTDataSet3;
            // 
            // view_ChiTietCaLamTableAdapter1
            // 
            this.view_ChiTietCaLamTableAdapter1.ClearBeforeFill = true;
            // 
            // maCaDataGridViewTextBoxColumn1
            // 
            this.maCaDataGridViewTextBoxColumn1.DataPropertyName = "MaCa";
            this.maCaDataGridViewTextBoxColumn1.HeaderText = "Mã Ca";
            this.maCaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maCaDataGridViewTextBoxColumn1.Name = "maCaDataGridViewTextBoxColumn1";
            this.maCaDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức Vụ";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // UC_PhanCa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnaddnv);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_PhanCa";
            this.Size = new System.Drawing.Size(1300, 800);
            this.Load += new System.EventHandler(this.UC_PhanCa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Calam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caLamViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietCaLamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChiTietCaLamBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gv_Calam;
        private System.Windows.Forms.BindingSource caLamViecBindingSource;
        private QLXePTDataSet qLXePTDataSet;
        private QLXePTDataSetTableAdapters.CaLamViecTableAdapter caLamViecTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGKetThucDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnaddnv;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView gv_ctca;
        private System.Windows.Forms.BindingSource viewChiTietCaLamBindingSource;
        private QLXePTDataSet1 qLXePTDataSet1;
        private QLXePTDataSet1TableAdapters.View_ChiTietCaLamTableAdapter view_ChiTietCaLamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.BindingSource viewChiTietCaLamBindingSource1;
        private QLXePTDataSet3 qLXePTDataSet3;
        private QLXePTDataSet3TableAdapters.View_ChiTietCaLamTableAdapter view_ChiTietCaLamTableAdapter1;
    }
}
