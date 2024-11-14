namespace QLMuaBanXeMay.UC
{
    partial class UC_ThongKeLoiNhuan
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.BackColor = System.Drawing.Color.Aquamarine;
            this.cartesianChart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartesianChart1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cartesianChart1.Location = new System.Drawing.Point(6, 47);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1294, 656);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biểu đồ thống kê doanh thu - lợi nhuận - chi phí xe, phụ tùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ tháng";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(901, 9);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowUpDown = true;
            this.dtpStartDate.Size = new System.Drawing.Size(84, 22);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Value = new System.DateTime(2024, 1, 1, 19, 38, 0, 0);

            this.dtpStartDate.Value = new System.DateTime(2024, 1, 1, 20, 42, 0, 0);

            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1021, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "đến tháng";
            // 
            // dtpEndate
            // 
            this.dtpEndate.CustomFormat = "MM/yyyy";
            this.dtpEndate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndate.Location = new System.Drawing.Point(1095, 9);
            this.dtpEndate.Name = "dtpEndate";
            this.dtpEndate.ShowUpDown = true;
            this.dtpEndate.Size = new System.Drawing.Size(84, 22);
            this.dtpEndate.TabIndex = 7;
            this.dtpEndate.ValueChanged += new System.EventHandler(this.dtpEndate_ValueChanged);
            // 
            // UC_ThongKeLoiNhuan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtpEndate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "UC_ThongKeLoiNhuan";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_ThongKeLoiNhuan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndate;
    }
}
