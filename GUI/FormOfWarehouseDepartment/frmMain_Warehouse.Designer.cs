namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    partial class frmMain_Warehouse
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
            this.msiCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.msiManageBook = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlExcute = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCreateOrder,
            this.msiManageOrder,
            this.msiManageBook});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiCreateOrder
            // 
            this.msiCreateOrder.Name = "msiCreateOrder";
            this.msiCreateOrder.Size = new System.Drawing.Size(142, 24);
            this.msiCreateOrder.Text = "Lập đơn nhập kho";
            // 
            // msiManageOrder
            // 
            this.msiManageOrder.Name = "msiManageOrder";
            this.msiManageOrder.Size = new System.Drawing.Size(168, 24);
            this.msiManageOrder.Text = "Quản lý đơn nhập kho";
            // 
            // msiManageBook
            // 
            this.msiManageBook.Name = "msiManageBook";
            this.msiManageBook.Size = new System.Drawing.Size(174, 24);
            this.msiManageBook.Text = "Quản lý sách trong kho";
            // 
            // pnlExcute
            // 
            this.pnlExcute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcute.Location = new System.Drawing.Point(0, 28);
            this.pnlExcute.Name = "pnlExcute";
            this.pnlExcute.Size = new System.Drawing.Size(1102, 500);
            this.pnlExcute.TabIndex = 1;
            // 
            // frmMain_Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 528);
            this.Controls.Add(this.pnlExcute);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain_Warehouse";
            this.Text = "frmBoPhanKho";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem msiManageOrder;
        private System.Windows.Forms.ToolStripMenuItem msiManageBook;
        private System.Windows.Forms.Panel pnlExcute;
    }
}