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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnBillTool = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnBillBike = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnMotobike = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.uC_MainScreen = new QLMuaBanXeMay.UC_MainScreen();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSignOut);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnBillTool);
            this.panel3.Controls.Add(this.btnEmployee);
            this.panel3.Controls.Add(this.btnBillBike);
            this.panel3.Controls.Add(this.btnGuest);
            this.panel3.Controls.Add(this.btnMotobike);
            this.panel3.Controls.Add(this.btnTool);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 753);
            this.panel3.TabIndex = 0;
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
            this.panel4.Location = new System.Drawing.Point(26, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 83);
            this.panel4.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_users;
            this.btnUser.Location = new System.Drawing.Point(0, 635);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(199, 54);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "Tài khoản                           ";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnBillTool
            // 
            this.btnBillTool.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBillTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillTool.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills_tools;
            this.btnBillTool.Location = new System.Drawing.Point(0, 483);
            this.btnBillTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillTool.Name = "btnBillTool";
            this.btnBillTool.Size = new System.Drawing.Size(199, 54);
            this.btnBillTool.TabIndex = 11;
            this.btnBillTool.Text = "Quản lý hóa đơn phụ tùng";
            this.btnBillTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillTool.UseVisualStyleBackColor = true;
            this.btnBillTool.Click += new System.EventHandler(this.btnBillTool_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_employees;
            this.btnEmployee.Location = new System.Drawing.Point(0, 223);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(199, 54);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Quản lý nhân viên            ";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnBillBike
            // 
            this.btnBillBike.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBillBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillBike.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_bills;
            this.btnBillBike.Location = new System.Drawing.Point(0, 430);
            this.btnBillBike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillBike.Name = "btnBillBike";
            this.btnBillBike.Size = new System.Drawing.Size(199, 54);
            this.btnBillBike.TabIndex = 10;
            this.btnBillBike.Text = "Quản lý hóa đơn xe           ";
            this.btnBillBike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillBike.UseVisualStyleBackColor = true;
            this.btnBillBike.Click += new System.EventHandler(this.btnBillBike_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Image = global::QLMuaBanXeMay.Properties.Resources.form_main_guests;
            this.btnGuest.Location = new System.Drawing.Point(0, 274);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(199, 54);
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
            this.btnMotobike.Location = new System.Drawing.Point(0, 324);
            this.btnMotobike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMotobike.Name = "btnMotobike";
            this.btnMotobike.Size = new System.Drawing.Size(199, 54);
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
            this.btnTool.Location = new System.Drawing.Point(0, 377);
            this.btnTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(199, 54);
            this.btnTool.TabIndex = 9;
            this.btnTool.Text = "Quản lý phụ tùng                ";
            this.btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.uC_MainScreen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1282, 753);
            this.panel5.TabIndex = 1;
            // 
            // uC_MainScreen
            // 
            this.uC_MainScreen.Location = new System.Drawing.Point(0, 0);
            this.uC_MainScreen.Name = "uC_MainScreen";
            this.uC_MainScreen.Size = new System.Drawing.Size(1300, 800);
            this.uC_MainScreen.TabIndex = 0;
            this.uC_MainScreen.Load += new System.EventHandler(this.uC_MainScreen_Load);
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
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBillTool;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnBillBike;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnMotobike;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel5;
        private UC_MainScreen uC_MainScreen;
    }
}

