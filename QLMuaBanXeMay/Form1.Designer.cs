namespace QLMuaBanXeMay
{
    partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnMotobike = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnBillBike = new System.Windows.Forms.Button();
            this.btnBillTool = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btn_calam = new System.Windows.Forms.Button();
            this.btn_QLVoucher = new System.Windows.Forms.Button();
            this.btnHoaDonLuong = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.btnSignOut);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 753);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnGuest);
            this.flowLayoutPanel1.Controls.Add(this.btnMotobike);
            this.flowLayoutPanel1.Controls.Add(this.btnTool);
            this.flowLayoutPanel1.Controls.Add(this.btnBillBike);
            this.flowLayoutPanel1.Controls.Add(this.btnBillTool);
            this.flowLayoutPanel1.Controls.Add(this.btnThongKe);
            this.flowLayoutPanel1.Controls.Add(this.btn_calam);
            this.flowLayoutPanel1.Controls.Add(this.btn_QLVoucher);
            this.flowLayoutPanel1.Controls.Add(this.btnHoaDonLuong);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 575);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_employees;
            this.btnEmployee.Location = new System.Drawing.Point(3, 2);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(187, 54);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Quản lý nhân viên            ";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_guests;
            this.btnGuest.Location = new System.Drawing.Point(3, 60);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(187, 54);
            this.btnGuest.TabIndex = 7;
            this.btnGuest.Text = "Quản lý khách hàng         ";
            this.btnGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnMotobike
            // 
            this.btnMotobike.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMotobike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotobike.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_motobikes;
            this.btnMotobike.Location = new System.Drawing.Point(3, 118);
            this.btnMotobike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMotobike.Name = "btnMotobike";
            this.btnMotobike.Size = new System.Drawing.Size(187, 54);
            this.btnMotobike.TabIndex = 8;
            this.btnMotobike.Text = "Quản lý xe máy                  ";
            this.btnMotobike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotobike.UseVisualStyleBackColor = true;
            this.btnMotobike.Click += new System.EventHandler(this.btnMotobike_Click);
            // 
            // btnTool
            // 
            this.btnTool.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_tools;
            this.btnTool.Location = new System.Drawing.Point(3, 176);
            this.btnTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(187, 54);
            this.btnTool.TabIndex = 9;
            this.btnTool.Text = "Quản lý phụ tùng                ";
            this.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnBillBike
            // 
            this.btnBillBike.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBillBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillBike.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills;
            this.btnBillBike.Location = new System.Drawing.Point(3, 234);
            this.btnBillBike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillBike.Name = "btnBillBike";
            this.btnBillBike.Size = new System.Drawing.Size(187, 54);
            this.btnBillBike.TabIndex = 10;
            this.btnBillBike.Text = "Quản lý hóa đơn xe           ";
            this.btnBillBike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillBike.UseVisualStyleBackColor = true;
            this.btnBillBike.Click += new System.EventHandler(this.btnBillBike_Click);
            // 
            // btnBillTool
            // 
            this.btnBillTool.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBillTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillTool.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills_tools;
            this.btnBillTool.Location = new System.Drawing.Point(3, 292);
            this.btnBillTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillTool.Name = "btnBillTool";
            this.btnBillTool.Size = new System.Drawing.Size(187, 54);
            this.btnBillTool.TabIndex = 11;
            this.btnBillTool.Text = "Quản lý hóa đơn phụ tùng";
            this.btnBillTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillTool.UseVisualStyleBackColor = true;
            this.btnBillTool.Click += new System.EventHandler(this.btnBillTool_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills_tools;
            this.btnThongKe.Location = new System.Drawing.Point(3, 350);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(187, 54);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống kê doanh thu";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btn_calam
            // 
            this.btn_calam.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_calam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calam.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills_tools;
            this.btn_calam.Location = new System.Drawing.Point(3, 408);
            this.btn_calam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calam.Name = "btn_calam";
            this.btn_calam.Size = new System.Drawing.Size(187, 54);
            this.btn_calam.TabIndex = 14;
            this.btn_calam.Text = "Quản lý ca làm việc";
            this.btn_calam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_calam.UseVisualStyleBackColor = true;
            this.btn_calam.Click += new System.EventHandler(this.btn_calam_Click);
            // 
            // btn_QLVoucher
            // 
            this.btn_QLVoucher.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_QLVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLVoucher.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills_tools;
            this.btn_QLVoucher.Location = new System.Drawing.Point(3, 466);
            this.btn_QLVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLVoucher.Name = "btn_QLVoucher";
            this.btn_QLVoucher.Size = new System.Drawing.Size(187, 50);
            this.btn_QLVoucher.TabIndex = 15;
            this.btn_QLVoucher.Text = "Quản lý Voucher";
            this.btn_QLVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLVoucher.UseVisualStyleBackColor = true;
            this.btn_QLVoucher.Click += new System.EventHandler(this.btn_QLVoucher_Click);
            // 
            // btnHoaDonLuong
            // 
            this.btnHoaDonLuong.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDonLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonLuong.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills_tools;
            this.btnHoaDonLuong.Location = new System.Drawing.Point(3, 520);
            this.btnHoaDonLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoaDonLuong.Name = "btnHoaDonLuong";
            this.btnHoaDonLuong.Size = new System.Drawing.Size(187, 54);
            this.btnHoaDonLuong.TabIndex = 16;
            this.btnHoaDonLuong.Text = "Quản lý hóa đơn lương";
            this.btnHoaDonLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDonLuong.UseVisualStyleBackColor = true;
            this.btnHoaDonLuong.Click += new System.EventHandler(this.btnHoaDonLuong_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_signout;
            this.btnSignOut.Location = new System.Drawing.Point(0, 688);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(199, 54);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Đăng xuất                             ";
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QLMuaBanXeMay.Properties.Resources.form_main_login;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(56, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 91);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1282, 753);
            this.panel5.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnMotobike;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnBillBike;
        private System.Windows.Forms.Button btnBillTool;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btn_calam;
        private System.Windows.Forms.Button btn_QLVoucher;
        private System.Windows.Forms.Button btnHoaDonLuong;
    }
}

