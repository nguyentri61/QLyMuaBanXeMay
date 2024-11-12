namespace QLMuaBanXeMay.WF
{
    partial class Form_ThemVoucher
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
            this.dt_ngayHH = new System.Windows.Forms.DateTimePicker();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ghToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gtGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gtCanDat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenVC = new Guna.UI2.WinForms.Guna2TextBox();
            this.tenTK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dt_ngayHH
            // 
            this.dt_ngayHH.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayHH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayHH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayHH.Location = new System.Drawing.Point(321, 224);
            this.dt_ngayHH.Name = "dt_ngayHH";
            this.dt_ngayHH.Size = new System.Drawing.Size(239, 27);
            this.dt_ngayHH.TabIndex = 99;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(519, 374);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(128, 46);
            this.btn_them.TabIndex = 98;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ghToiDa
            // 
            this.txt_ghToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ghToiDa.DefaultText = "";
            this.txt_ghToiDa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ghToiDa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ghToiDa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ghToiDa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ghToiDa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ghToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ghToiDa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ghToiDa.Location = new System.Drawing.Point(321, 275);
            this.txt_ghToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ghToiDa.Name = "txt_ghToiDa";
            this.txt_ghToiDa.PasswordChar = '\0';
            this.txt_ghToiDa.PlaceholderText = "";
            this.txt_ghToiDa.SelectedText = "";
            this.txt_ghToiDa.Size = new System.Drawing.Size(239, 36);
            this.txt_ghToiDa.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 96;
            this.label4.Text = "Giới Hạn Tối Đa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 95;
            this.label3.Text = "Ngày Hết Hạn:";
            // 
            // txt_gtGiamGia
            // 
            this.txt_gtGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gtGiamGia.DefaultText = "";
            this.txt_gtGiamGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gtGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gtGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gtGiamGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gtGiamGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gtGiamGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_gtGiamGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gtGiamGia.Location = new System.Drawing.Point(321, 151);
            this.txt_gtGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gtGiamGia.Name = "txt_gtGiamGia";
            this.txt_gtGiamGia.PasswordChar = '\0';
            this.txt_gtGiamGia.PlaceholderText = "";
            this.txt_gtGiamGia.SelectedText = "";
            this.txt_gtGiamGia.Size = new System.Drawing.Size(239, 36);
            this.txt_gtGiamGia.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 93;
            this.label2.Text = "Giá trị giảm giá:";
            // 
            // txt_gtCanDat
            // 
            this.txt_gtCanDat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gtCanDat.DefaultText = "";
            this.txt_gtCanDat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gtCanDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gtCanDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gtCanDat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gtCanDat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gtCanDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_gtCanDat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gtCanDat.Location = new System.Drawing.Point(321, 89);
            this.txt_gtCanDat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gtCanDat.Name = "txt_gtCanDat";
            this.txt_gtCanDat.PasswordChar = '\0';
            this.txt_gtCanDat.PlaceholderText = "";
            this.txt_gtCanDat.SelectedText = "";
            this.txt_gtCanDat.Size = new System.Drawing.Size(239, 36);
            this.txt_gtCanDat.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Giá trị cần đạt:";
            // 
            // txt_tenVC
            // 
            this.txt_tenVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenVC.DefaultText = "";
            this.txt_tenVC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenVC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenVC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenVC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenVC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenVC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenVC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenVC.Location = new System.Drawing.Point(321, 31);
            this.txt_tenVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenVC.Name = "txt_tenVC";
            this.txt_tenVC.PasswordChar = '\0';
            this.txt_tenVC.PlaceholderText = "";
            this.txt_tenVC.SelectedText = "";
            this.txt_tenVC.Size = new System.Drawing.Size(239, 36);
            this.txt_tenVC.TabIndex = 90;
            // 
            // tenTK
            // 
            this.tenTK.AutoSize = true;
            this.tenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTK.Location = new System.Drawing.Point(153, 43);
            this.tenTK.Name = "tenTK";
            this.tenTK.Size = new System.Drawing.Size(127, 24);
            this.tenTK.TabIndex = 89;
            this.tenTK.Text = "Tên Voucher:";
            // 
            // Form_ThemVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_ngayHH);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ghToiDa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_gtGiamGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_gtCanDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenVC);
            this.Controls.Add(this.tenTK);
            this.Name = "Form_ThemVoucher";
            this.Text = "Form_ThemVoucher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_ngayHH;
        private System.Windows.Forms.Button btn_them;
        private Guna.UI2.WinForms.Guna2TextBox txt_ghToiDa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_gtGiamGia;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_gtCanDat;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenVC;
        private System.Windows.Forms.Label tenTK;
    }
}