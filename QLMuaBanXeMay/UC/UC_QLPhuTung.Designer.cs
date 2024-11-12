namespace QLMuaBanXeMay
{
    partial class UC_QLPhuTung
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
            this.ThonTingroupBox = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.txt_HangSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoLuongTon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TenPhuTung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ChatLieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaPhuTung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gird_groupbox = new System.Windows.Forms.GroupBox();
            this.PhuTung_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuTungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLMuaBanXeMayDataSet1 = new QLMuaBanXeMay.QLMuaBanXeMayDataSet1();
            this.phuTungTableAdapter = new QLMuaBanXeMay.QLMuaBanXeMayDataSet1TableAdapters.PhuTungTableAdapter();
            this.grBox_Congcu = new System.Windows.Forms.GroupBox();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ThonTingroupBox.SuspendLayout();
            this.gird_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTung_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuTungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet1)).BeginInit();
            this.grBox_Congcu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThonTingroupBox
            // 
            this.ThonTingroupBox.Controls.Add(this.btn_Add);
            this.ThonTingroupBox.Controls.Add(this.btn_Update);
            this.ThonTingroupBox.Controls.Add(this.btn_xuat);
            this.ThonTingroupBox.Controls.Add(this.txt_HangSX);
            this.ThonTingroupBox.Controls.Add(this.label8);
            this.ThonTingroupBox.Controls.Add(this.txt_SoLuongTon);
            this.ThonTingroupBox.Controls.Add(this.label9);
            this.ThonTingroupBox.Controls.Add(this.txt_TenPhuTung);
            this.ThonTingroupBox.Controls.Add(this.label5);
            this.ThonTingroupBox.Controls.Add(this.txt_DonGia);
            this.ThonTingroupBox.Controls.Add(this.label4);
            this.ThonTingroupBox.Controls.Add(this.txt_ChatLieu);
            this.ThonTingroupBox.Controls.Add(this.label3);
            this.ThonTingroupBox.Controls.Add(this.txt_MaPhuTung);
            this.ThonTingroupBox.Controls.Add(this.label2);
            this.ThonTingroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThonTingroupBox.Location = new System.Drawing.Point(83, 70);
            this.ThonTingroupBox.Name = "ThonTingroupBox";
            this.ThonTingroupBox.Size = new System.Drawing.Size(1135, 224);
            this.ThonTingroupBox.TabIndex = 9;
            this.ThonTingroupBox.TabStop = false;
            this.ThonTingroupBox.Text = "Thông tin phụ tùng";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(721, 157);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 38);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Thêm vào ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(519, 157);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(170, 38);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(910, 157);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(170, 38);
            this.btn_xuat.TabIndex = 18;
            this.btn_xuat.Text = "Xuất hóa đơn";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.capnhat_btn_Click);
            // 
            // txt_HangSX
            // 
            this.txt_HangSX.Location = new System.Drawing.Point(519, 94);
            this.txt_HangSX.Name = "txt_HangSX";
            this.txt_HangSX.Size = new System.Drawing.Size(195, 30);
            this.txt_HangSX.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(367, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hãng Sản Xuất";
            // 
            // txt_SoLuongTon
            // 
            this.txt_SoLuongTon.Location = new System.Drawing.Point(885, 91);
            this.txt_SoLuongTon.Name = "txt_SoLuongTon";
            this.txt_SoLuongTon.Size = new System.Drawing.Size(195, 30);
            this.txt_SoLuongTon.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(737, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số Lượng Tồn";
            // 
            // txt_TenPhuTung
            // 
            this.txt_TenPhuTung.Location = new System.Drawing.Point(519, 43);
            this.txt_TenPhuTung.Name = "txt_TenPhuTung";
            this.txt_TenPhuTung.Size = new System.Drawing.Size(195, 30);
            this.txt_TenPhuTung.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(375, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Phụ Tùng";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(885, 43);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(195, 30);
            this.txt_DonGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(799, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            // 
            // txt_ChatLieu
            // 
            this.txt_ChatLieu.Location = new System.Drawing.Point(143, 96);
            this.txt_ChatLieu.Name = "txt_ChatLieu";
            this.txt_ChatLieu.Size = new System.Drawing.Size(195, 30);
            this.txt_ChatLieu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chất Liệu";
            // 
            // txt_MaPhuTung
            // 
            this.txt_MaPhuTung.Location = new System.Drawing.Point(143, 43);
            this.txt_MaPhuTung.Name = "txt_MaPhuTung";
            this.txt_MaPhuTung.Size = new System.Drawing.Size(195, 30);
            this.txt_MaPhuTung.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phụ Tùng";
            // 
            // gird_groupbox
            // 
            this.gird_groupbox.Controls.Add(this.PhuTung_GridView);
            this.gird_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gird_groupbox.Location = new System.Drawing.Point(83, 300);
            this.gird_groupbox.Name = "gird_groupbox";
            this.gird_groupbox.Size = new System.Drawing.Size(1135, 285);
            this.gird_groupbox.TabIndex = 8;
            this.gird_groupbox.TabStop = false;
            this.gird_groupbox.Text = "Danh sách phụ tùng";
            // 
            // PhuTung_GridView
            // 
            this.PhuTung_GridView.AllowUserToAddRows = false;
            this.PhuTung_GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PhuTung_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PhuTung_GridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhuTung_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhuTung_GridView.ColumnHeadersHeight = 22;
            this.PhuTung_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhuTung_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.TenPT,
            this.DonGia,
            this.ChatLieu,
            this.HangSX,
            this.SoLuongTon});
            this.PhuTung_GridView.DataSource = this.phuTungBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhuTung_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhuTung_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhuTung_GridView.Location = new System.Drawing.Point(11, 29);
            this.PhuTung_GridView.Name = "PhuTung_GridView";
            this.PhuTung_GridView.ReadOnly = true;
            this.PhuTung_GridView.RowHeadersVisible = false;
            this.PhuTung_GridView.RowHeadersWidth = 51;
            this.PhuTung_GridView.RowTemplate.Height = 24;
            this.PhuTung_GridView.Size = new System.Drawing.Size(1118, 234);
            this.PhuTung_GridView.TabIndex = 0;
            this.PhuTung_GridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PhuTung_GridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhuTung_GridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhuTung_GridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhuTung_GridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhuTung_GridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PhuTung_GridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhuTung_GridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhuTung_GridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhuTung_GridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PhuTung_GridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhuTung_GridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhuTung_GridView.ThemeStyle.HeaderStyle.Height = 22;
            this.PhuTung_GridView.ThemeStyle.ReadOnly = true;
            this.PhuTung_GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PhuTung_GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhuTung_GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PhuTung_GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhuTung_GridView.ThemeStyle.RowsStyle.Height = 24;
            this.PhuTung_GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhuTung_GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhuTung_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhuTung_GridView_CellClick);
            // 
            // MaPT
            // 
            this.MaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPT.DataPropertyName = "MaPT";
            this.MaPT.FillWeight = 137F;
            this.MaPT.HeaderText = "Mã Phụ Tùng";
            this.MaPT.MinimumWidth = 6;
            this.MaPT.Name = "MaPT";
            this.MaPT.ReadOnly = true;
            // 
            // TenPT
            // 
            this.TenPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPT.DataPropertyName = "TenPT";
            this.TenPT.FillWeight = 135F;
            this.TenPT.HeaderText = "Tên Phụ Tùng";
            this.TenPT.MinimumWidth = 6;
            this.TenPT.Name = "TenPT";
            this.TenPT.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 135F;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ChatLieu
            // 
            this.ChatLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChatLieu.DataPropertyName = "ChatLieu";
            this.ChatLieu.FillWeight = 70.68937F;
            this.ChatLieu.HeaderText = "Chất Liệu";
            this.ChatLieu.MinimumWidth = 6;
            this.ChatLieu.Name = "ChatLieu";
            this.ChatLieu.ReadOnly = true;
            // 
            // HangSX
            // 
            this.HangSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HangSX.DataPropertyName = "HangSX";
            this.HangSX.FillWeight = 70.68937F;
            this.HangSX.HeaderText = "Hãng Sản Xuất";
            this.HangSX.MinimumWidth = 6;
            this.HangSX.Name = "HangSX";
            this.HangSX.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.FillWeight = 70.68937F;
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // phuTungBindingSource
            // 
            this.phuTungBindingSource.DataMember = "PhuTung";
            this.phuTungBindingSource.DataSource = this.qLMuaBanXeMayDataSet1;
            // 
            // qLMuaBanXeMayDataSet1
            // 
            this.qLMuaBanXeMayDataSet1.DataSetName = "QLMuaBanXeMayDataSet1";
            this.qLMuaBanXeMayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phuTungTableAdapter
            // 
            this.phuTungTableAdapter.ClearBeforeFill = true;
            // 
            // grBox_Congcu
            // 
            this.grBox_Congcu.Controls.Add(this.btn_them);
            this.grBox_Congcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_Congcu.Location = new System.Drawing.Point(602, 610);
            this.grBox_Congcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBox_Congcu.Name = "grBox_Congcu";
            this.grBox_Congcu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBox_Congcu.Size = new System.Drawing.Size(616, 88);
            this.grBox_Congcu.TabIndex = 25;
            this.grBox_Congcu.TabStop = false;
            this.grBox_Congcu.Text = "Công cụ";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(250, 28);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(122, 43);
            this.btn_them.TabIndex = 55;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.ThemBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(74, 610);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(505, 88);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên phụ tùng";
            // 
            // btn_search
            // 
            this.btn_search.Animated = true;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(351, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(122, 43);
            this.btn_search.TabIndex = 54;
            this.btn_search.Text = "Tìm";
            this.btn_search.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(14, 34);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(307, 36);
            this.txt_search.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Quản Lý Phụ Tùng";
            // 
            // UC_QLPhuTung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grBox_Congcu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ThonTingroupBox);
            this.Controls.Add(this.gird_groupbox);
            this.Name = "UC_QLPhuTung";
            this.Size = new System.Drawing.Size(1300, 800);
            this.Load += new System.EventHandler(this.UC_QLPhuTung_Load);
            this.ThonTingroupBox.ResumeLayout(false);
            this.ThonTingroupBox.PerformLayout();
            this.gird_groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhuTung_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuTungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeMayDataSet1)).EndInit();
            this.grBox_Congcu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ThonTingroupBox;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.TextBox txt_HangSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SoLuongTon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TenPhuTung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ChatLieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaPhuTung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gird_groupbox;
        private Guna.UI2.WinForms.Guna2DataGridView PhuTung_GridView;
        private System.Windows.Forms.BindingSource phuTungBindingSource;
        private QLMuaBanXeMayDataSet1 qLMuaBanXeMayDataSet1;
        private QLMuaBanXeMayDataSet1TableAdapters.PhuTungTableAdapter phuTungTableAdapter;
        private System.Windows.Forms.GroupBox grBox_Congcu;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.Button btn_Add;
    }
}
