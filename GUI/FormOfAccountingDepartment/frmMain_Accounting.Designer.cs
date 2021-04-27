namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    partial class frmMain_Accounting
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msiSatisticSoldBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.msiStatisticBill = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStaticRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlExcute = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSatisticSoldBook,
            this.msiStatisticBill,
            this.msiStaticRevenue});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiSatisticSoldBook
            // 
            this.msiSatisticSoldBook.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.msiSatisticSoldBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.msiSatisticSoldBook.Name = "msiSatisticSoldBook";
            this.msiSatisticSoldBook.Size = new System.Drawing.Size(163, 26);
            this.msiSatisticSoldBook.Text = "Thống kê sách bán ra";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Theo từng ngày",
            "Theo từng tháng ",
            "Theo từng năm\t\t"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // msiStatisticBill
            // 
            this.msiStatisticBill.BackColor = System.Drawing.Color.Khaki;
            this.msiStatisticBill.Checked = true;
            this.msiStatisticBill.CheckOnClick = true;
            this.msiStatisticBill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msiStatisticBill.Name = "msiStatisticBill";
            this.msiStatisticBill.Size = new System.Drawing.Size(143, 26);
            this.msiStatisticBill.Text = "Thống kê hóa đơn";
            // 
            // msiStaticRevenue
            // 
            this.msiStaticRevenue.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.msiStaticRevenue.Name = "msiStaticRevenue";
            this.msiStaticRevenue.Size = new System.Drawing.Size(155, 26);
            this.msiStaticRevenue.Text = "Thống kê doanh thu";
            // 
            // pnlExcute
            // 
            this.pnlExcute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcute.Location = new System.Drawing.Point(0, 30);
            this.pnlExcute.Name = "pnlExcute";
            this.pnlExcute.Size = new System.Drawing.Size(1050, 535);
            this.pnlExcute.TabIndex = 1;
            // 
            // frmBoPhanKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 565);
            this.Controls.Add(this.pnlExcute);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBoPhanKeToan";
            this.Text = "frmPhongBan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiStatisticBill;
        private System.Windows.Forms.Panel pnlExcute;
        private System.Windows.Forms.ToolStripMenuItem msiSatisticSoldBook;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem msiStaticRevenue;
    }
}