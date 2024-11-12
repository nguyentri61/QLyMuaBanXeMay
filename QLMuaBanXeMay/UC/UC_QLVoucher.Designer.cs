namespace QLMuaBanXeMay.UC
{
    partial class UC_QLVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.qLXePTDataSetvoucher = new QLMuaBanXeMay.QLXePTDataSetvoucher();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voucherTableAdapter = new QLMuaBanXeMay.QLXePTDataSetvoucherTableAdapters.VoucherTableAdapter();
            this.gv_voucher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetvoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_voucher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Voucher";
            // 
            // qLXePTDataSetvoucher
            // 
            this.qLXePTDataSetvoucher.DataSetName = "QLXePTDataSetvoucher";
            this.qLXePTDataSetvoucher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataMember = "Voucher";
            this.voucherBindingSource.DataSource = this.qLXePTDataSetvoucher;
            // 
            // voucherTableAdapter
            // 
            this.voucherTableAdapter.ClearBeforeFill = true;
            // 
            // gv_voucher
            // 
            this.gv_voucher.AllowUserToAddRows = false;
            this.gv_voucher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gv_voucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_voucher.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_voucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_voucher.ColumnHeadersHeight = 29;
            this.gv_voucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_voucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVCDataGridViewTextBoxColumn,
            this.tenVCDataGridViewTextBoxColumn,
            this.giaTriDataGridViewTextBoxColumn,
            this.giamGiaDataGridViewTextBoxColumn,
            this.ngayHHDataGridViewTextBoxColumn,
            this.giamGiaTDDataGridViewTextBoxColumn});
            this.gv_voucher.DataSource = this.voucherBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_voucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_voucher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_voucher.Location = new System.Drawing.Point(26, 106);
            this.gv_voucher.Name = "gv_voucher";
            this.gv_voucher.ReadOnly = true;
            this.gv_voucher.RowHeadersVisible = false;
            this.gv_voucher.RowHeadersWidth = 51;
            this.gv_voucher.RowTemplate.Height = 24;
            this.gv_voucher.Size = new System.Drawing.Size(1242, 499);
            this.gv_voucher.TabIndex = 7;
            this.gv_voucher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_voucher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_voucher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_voucher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_voucher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_voucher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_voucher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_voucher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gv_voucher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_voucher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_voucher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_voucher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_voucher.ThemeStyle.HeaderStyle.Height = 29;
            this.gv_voucher.ThemeStyle.ReadOnly = true;
            this.gv_voucher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_voucher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_voucher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_voucher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_voucher.ThemeStyle.RowsStyle.Height = 24;
            this.gv_voucher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_voucher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maVCDataGridViewTextBoxColumn
            // 
            this.maVCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maVCDataGridViewTextBoxColumn.DataPropertyName = "MaVC";
            this.maVCDataGridViewTextBoxColumn.HeaderText = "Mã Voucher";
            this.maVCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maVCDataGridViewTextBoxColumn.Name = "maVCDataGridViewTextBoxColumn";
            this.maVCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenVCDataGridViewTextBoxColumn
            // 
            this.tenVCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenVCDataGridViewTextBoxColumn.DataPropertyName = "TenVC";
            this.tenVCDataGridViewTextBoxColumn.HeaderText = "Tên Voucher";
            this.tenVCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenVCDataGridViewTextBoxColumn.Name = "tenVCDataGridViewTextBoxColumn";
            this.tenVCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriDataGridViewTextBoxColumn
            // 
            this.giaTriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTriDataGridViewTextBoxColumn.DataPropertyName = "GiaTri";
            this.giaTriDataGridViewTextBoxColumn.HeaderText = "Giá Trị Cần Đạt";
            this.giaTriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriDataGridViewTextBoxColumn.Name = "giaTriDataGridViewTextBoxColumn";
            this.giaTriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giamGiaDataGridViewTextBoxColumn
            // 
            this.giamGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giamGiaDataGridViewTextBoxColumn.DataPropertyName = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.HeaderText = "Giá Trị Giảm Giá";
            this.giamGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giamGiaDataGridViewTextBoxColumn.Name = "giamGiaDataGridViewTextBoxColumn";
            this.giamGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayHHDataGridViewTextBoxColumn
            // 
            this.ngayHHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayHHDataGridViewTextBoxColumn.DataPropertyName = "NgayHH";
            this.ngayHHDataGridViewTextBoxColumn.HeaderText = "Ngày Hết Hạn";
            this.ngayHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHHDataGridViewTextBoxColumn.Name = "ngayHHDataGridViewTextBoxColumn";
            this.ngayHHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giamGiaTDDataGridViewTextBoxColumn
            // 
            this.giamGiaTDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giamGiaTDDataGridViewTextBoxColumn.DataPropertyName = "GiamGiaTD";
            this.giamGiaTDDataGridViewTextBoxColumn.HeaderText = "Giới Hạn Giảm Giá (%)";
            this.giamGiaTDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giamGiaTDDataGridViewTextBoxColumn.Name = "giamGiaTDDataGridViewTextBoxColumn";
            this.giamGiaTDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_them
            // 
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(1088, 629);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(180, 45);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // UC_QLVoucher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.gv_voucher);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLVoucher";
            this.Size = new System.Drawing.Size(1300, 800);
            ((System.ComponentModel.ISupportInitialize)(this.qLXePTDataSetvoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_voucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource voucherBindingSource;
        private QLXePTDataSetvoucher qLXePTDataSetvoucher;
        private QLXePTDataSetvoucherTableAdapters.VoucherTableAdapter voucherTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView gv_voucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGiaTDDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btn_them;
    }
}
