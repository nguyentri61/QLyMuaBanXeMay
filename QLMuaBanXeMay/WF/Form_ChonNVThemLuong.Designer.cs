namespace QLMuaBanXeMay.WF
{
    partial class Form_ChonNVThemLuong
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
            this.dgvChonNVLuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnChon = new Guna.UI2.WinForms.Guna2Button();
            this.qLXePTDataSetChonNVLuong = new QLMuaBanXeMay.QLXePTDataSetChonNVLuong();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLMuaBanXeMay.QLXePTDataSetChonNVLuongTableAdapters.NhanVienTableAdapter();
            this.cCCDNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCoBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonNVLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetChonNVLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChonNVLuong
            // 
            this.dgvChonNVLuong.AllowUserToAddRows = false;
            this.dgvChonNVLuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChonNVLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChonNVLuong.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChonNVLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChonNVLuong.ColumnHeadersHeight = 24;
            this.dgvChonNVLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChonNVLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCCDNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.luongCoBanDataGridViewTextBoxColumn});
            this.dgvChonNVLuong.DataSource = this.nhanVienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChonNVLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChonNVLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChonNVLuong.Location = new System.Drawing.Point(59, 24);
            this.dgvChonNVLuong.Name = "dgvChonNVLuong";
            this.dgvChonNVLuong.ReadOnly = true;
            this.dgvChonNVLuong.RowHeadersVisible = false;
            this.dgvChonNVLuong.RowHeadersWidth = 51;
            this.dgvChonNVLuong.RowTemplate.Height = 24;
            this.dgvChonNVLuong.Size = new System.Drawing.Size(1017, 164);
            this.dgvChonNVLuong.TabIndex = 1;
            this.dgvChonNVLuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChonNVLuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChonNVLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChonNVLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChonNVLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChonNVLuong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChonNVLuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChonNVLuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChonNVLuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChonNVLuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChonNVLuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChonNVLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChonNVLuong.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvChonNVLuong.ThemeStyle.ReadOnly = true;
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChonNVLuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChonNVLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonNVLuong_CellClick);
            // 
            // btnChon
            // 
            this.btnChon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(896, 221);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(180, 45);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // qLXePTDataSetChonNVLuong
            // 
            this.qLXePTDataSetChonNVLuong.DataSetName = "QLXePTDataSetChonNVLuong";
            this.qLXePTDataSetChonNVLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLXePTDataSetChonNVLuong;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form_ChonNVThemLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 287);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvChonNVLuong);
            this.Name = "Form_ChonNVThemLuong";
            this.Text = "Form_ChonNVThemLuong";
            this.Load += new System.EventHandler(this.Form_ChonNVThemLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonNVLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetChonNVLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvChonNVLuong;
        private Guna.UI2.WinForms.Guna2Button btnChon;
        private QLXePTDataSetChonNVLuong qLXePTDataSetChonNVLuong;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLXePTDataSetChonNVLuongTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCoBanDataGridViewTextBoxColumn;
    }
}