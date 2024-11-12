namespace QLMuaBanXeMay.WF
{
    partial class Form_ThongTinPhuTung
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txt_SLTon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_HangSX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenPT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ChatLieu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_MaPT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Confirm);
            this.groupBox2.Controls.Add(this.txt_SLTon);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_HangSX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_TenPT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_ChatLieu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_MaPT);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 299);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Phụ Tùng";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(532, 243);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(170, 38);
            this.btn_Confirm.TabIndex = 19;
            this.btn_Confirm.Text = "Xác nhận";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // txt_SLTon
            // 
            this.txt_SLTon.Location = new System.Drawing.Point(532, 170);
            this.txt_SLTon.Name = "txt_SLTon";
            this.txt_SLTon.Size = new System.Drawing.Size(195, 30);
            this.txt_SLTon.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(380, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Số Lượng Tồn";
            // 
            // txt_HangSX
            // 
            this.txt_HangSX.Location = new System.Drawing.Point(532, 105);
            this.txt_HangSX.Name = "txt_HangSX";
            this.txt_HangSX.Size = new System.Drawing.Size(195, 30);
            this.txt_HangSX.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(376, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hãng Sản Xuất";
            // 
            // txt_TenPT
            // 
            this.txt_TenPT.Location = new System.Drawing.Point(154, 104);
            this.txt_TenPT.Name = "txt_TenPT";
            this.txt_TenPT.Size = new System.Drawing.Size(195, 30);
            this.txt_TenPT.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tên Phụ Tùng";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(154, 173);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(195, 30);
            this.txt_DonGia.TabIndex = 5;
            this.txt_DonGia.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(58, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Đơn giá";
            // 
            // txt_ChatLieu
            // 
            this.txt_ChatLieu.Location = new System.Drawing.Point(532, 46);
            this.txt_ChatLieu.Name = "txt_ChatLieu";
            this.txt_ChatLieu.Size = new System.Drawing.Size(195, 30);
            this.txt_ChatLieu.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(421, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Chất Liệu";
            // 
            // txt_MaPT
            // 
            this.txt_MaPT.Location = new System.Drawing.Point(154, 46);
            this.txt_MaPT.Name = "txt_MaPT";
            this.txt_MaPT.Size = new System.Drawing.Size(195, 30);
            this.txt_MaPT.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(6, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã Phụ Tùng";
            // 
            // Form_ThongTinPhuTung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(783, 363);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_ThongTinPhuTung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThongTinPhuTung";
            this.Load += new System.EventHandler(this.Form_ThongTinPhuTung_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox txt_SLTon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_HangSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenPT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ChatLieu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_MaPT;
        private System.Windows.Forms.Label label16;
    }
}