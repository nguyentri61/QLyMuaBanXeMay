namespace QLMuaBanXeMay.WF
{
    partial class Form_ChonThoiGian
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_giobd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phutbd = new System.Windows.Forms.TextBox();
            this.txt_phutkt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_giokt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(285, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian bắt đầu: ";
            // 
            // txt_giobd
            // 
            this.txt_giobd.Location = new System.Drawing.Point(228, 102);
            this.txt_giobd.Name = "txt_giobd";
            this.txt_giobd.Size = new System.Drawing.Size(42, 22);
            this.txt_giobd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = ": ";
            // 
            // txt_phutbd
            // 
            this.txt_phutbd.Location = new System.Drawing.Point(285, 102);
            this.txt_phutbd.Name = "txt_phutbd";
            this.txt_phutbd.Size = new System.Drawing.Size(42, 22);
            this.txt_phutbd.TabIndex = 4;
            // 
            // txt_phutkt
            // 
            this.txt_phutkt.Location = new System.Drawing.Point(641, 102);
            this.txt_phutkt.Name = "txt_phutkt";
            this.txt_phutkt.Size = new System.Drawing.Size(42, 22);
            this.txt_phutkt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = ": ";
            // 
            // txt_giokt
            // 
            this.txt_giokt.Location = new System.Drawing.Point(584, 102);
            this.txt_giokt.Name = "txt_giokt";
            this.txt_giokt.Size = new System.Drawing.Size(42, 22);
            this.txt_giokt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời gian kết thúc: ";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Location = new System.Drawing.Point(335, 152);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(122, 43);
            this.btn_Luu.TabIndex = 57;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // Form_ChonThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 220);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_phutkt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_giokt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phutbd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_giobd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Form_ChonThoiGian";
            this.Text = "Form_ChonThoiGian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_giobd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phutbd;
        private System.Windows.Forms.TextBox txt_phutkt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_giokt;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
    }
}