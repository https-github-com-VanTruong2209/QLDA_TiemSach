namespace PBL3_ChuongTrinhQuanLyTiemSach.GUI.FormOfCashierDepartment
{
    partial class frmMain_Cashier
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
            this.msiCreateBill = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageBill = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlExcute = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCreateBill,
            this.msiManageCustomer,
            this.msiManageBill});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiCreateBill
            // 
            this.msiCreateBill.Name = "msiCreateBill";
            this.msiCreateBill.Size = new System.Drawing.Size(181, 24);
            this.msiCreateBill.Text = "Lập hóa đơn thanh toán";
            // 
            // msiManageCustomer
            // 
            this.msiManageCustomer.Name = "msiManageCustomer";
            this.msiManageCustomer.Size = new System.Drawing.Size(216, 24);
            this.msiManageCustomer.Text = "Quản lý thông tin khách hàng";
            // 
            // msiManageBill
            // 
            this.msiManageBill.Name = "msiManageBill";
            this.msiManageBill.Size = new System.Drawing.Size(132, 24);
            this.msiManageBill.Text = "Quản lý hóa đơn";
            // 
            // pnlExcute
            // 
            this.pnlExcute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcute.Location = new System.Drawing.Point(0, 28);
            this.pnlExcute.Name = "pnlExcute";
            this.pnlExcute.Size = new System.Drawing.Size(988, 488);
            this.pnlExcute.TabIndex = 2;
            // 
            // Main_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.pnlExcute);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main_Cashier";
            this.Text = "Main_Cashier";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiCreateBill;
        private System.Windows.Forms.ToolStripMenuItem msiManageCustomer;
        private System.Windows.Forms.ToolStripMenuItem msiManageBill;
        private System.Windows.Forms.Panel pnlExcute;
    }
}