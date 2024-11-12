namespace QLMuaBanXeMay.UC
{
    partial class UC_ThongKeDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.btnTKTheoNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKTheoThang = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnTKTheoThang);
            this.panel1.Controls.Add(this.btnTKTheoNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 43);
            this.panel1.TabIndex = 0;
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoanhThu.Location = new System.Drawing.Point(0, 43);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(1300, 757);
            this.panelDoanhThu.TabIndex = 1;
            // 
            // btnTKTheoNV
            // 
            this.btnTKTheoNV.Animated = true;
            this.btnTKTheoNV.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTKTheoNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKTheoNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKTheoNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKTheoNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKTheoNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKTheoNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTKTheoNV.ForeColor = System.Drawing.Color.White;
            this.btnTKTheoNV.Location = new System.Drawing.Point(3, 0);
            this.btnTKTheoNV.Name = "btnTKTheoNV";
            this.btnTKTheoNV.Size = new System.Drawing.Size(203, 43);
            this.btnTKTheoNV.TabIndex = 0;
            this.btnTKTheoNV.Text = "Thống kê theo Nhân Viên";
            this.btnTKTheoNV.Click += new System.EventHandler(this.btnTKTheoNV_Click);
            // 
            // btnTKTheoThang
            // 
            this.btnTKTheoThang.Animated = true;
            this.btnTKTheoThang.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTKTheoThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKTheoThang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKTheoThang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKTheoThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKTheoThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKTheoThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTKTheoThang.ForeColor = System.Drawing.Color.White;
            this.btnTKTheoThang.Location = new System.Drawing.Point(207, 0);
            this.btnTKTheoThang.Name = "btnTKTheoThang";
            this.btnTKTheoThang.Size = new System.Drawing.Size(180, 43);
            this.btnTKTheoThang.TabIndex = 1;
            this.btnTKTheoThang.Text = "Thống kê theo tháng";
            this.btnTKTheoThang.Click += new System.EventHandler(this.btnTKTheoThang_Click);
            // 
            // UC_ThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDoanhThu);
            this.Controls.Add(this.panel1);
            this.Name = "UC_ThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1300, 800);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTKTheoNV;
        private System.Windows.Forms.Panel panelDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnTKTheoThang;
    }
}
