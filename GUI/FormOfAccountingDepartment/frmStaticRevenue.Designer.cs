namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    partial class frmStaticRevenue
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTypeStatistic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.lblLowestRevenue = new System.Windows.Forms.Label();
            this.lblHighestRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thông tin doanh thu";
            // 
            // cbbTypeStatistic
            // 
            this.cbbTypeStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTypeStatistic.FormattingEnabled = true;
            this.cbbTypeStatistic.Location = new System.Drawing.Point(486, 96);
            this.cbbTypeStatistic.Name = "cbbTypeStatistic";
            this.cbbTypeStatistic.Size = new System.Drawing.Size(148, 24);
            this.cbbTypeStatistic.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê theo:";
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(6, 126);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.RowTemplate.Height = 24;
            this.dgvRevenue.Size = new System.Drawing.Size(628, 421);
            this.dgvRevenue.TabIndex = 5;
            // 
            // lblLowestRevenue
            // 
            this.lblLowestRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLowestRevenue.AutoSize = true;
            this.lblLowestRevenue.BackColor = System.Drawing.Color.LightCoral;
            this.lblLowestRevenue.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblLowestRevenue.Location = new System.Drawing.Point(744, 420);
            this.lblLowestRevenue.Name = "lblLowestRevenue";
            this.lblLowestRevenue.Size = new System.Drawing.Size(233, 29);
            this.lblLowestRevenue.TabIndex = 9;
            this.lblLowestRevenue.Text = "Doanh thu thấp nhất";
            // 
            // lblHighestRevenue
            // 
            this.lblHighestRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblHighestRevenue.AutoSize = true;
            this.lblHighestRevenue.BackColor = System.Drawing.Color.YellowGreen;
            this.lblHighestRevenue.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblHighestRevenue.Location = new System.Drawing.Point(744, 259);
            this.lblHighestRevenue.Name = "lblHighestRevenue";
            this.lblHighestRevenue.Size = new System.Drawing.Size(220, 29);
            this.lblHighestRevenue.TabIndex = 10;
            this.lblHighestRevenue.Text = "Doanh thu cao nhất";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.Location = new System.Drawing.Point(753, 126);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(182, 29);
            this.lblTotalRevenue.TabIndex = 11;
            this.lblTotalRevenue.Text = "Tổng doanh thu";
            // 
            // frmStaticRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 551);
            this.Controls.Add(this.lblLowestRevenue);
            this.Controls.Add(this.lblHighestRevenue);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTypeStatistic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.label2);
            this.Name = "frmStaticRevenue";
            this.Text = "frmmThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTypeStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Label lblLowestRevenue;
        private System.Windows.Forms.Label lblHighestRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}