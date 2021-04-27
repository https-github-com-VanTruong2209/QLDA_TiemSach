namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    partial class frmStatisticBook
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
            this.cbbTypeStatistic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lblWorstSeller = new System.Windows.Forms.Label();
            this.lblBestSeller = new System.Windows.Forms.Label();
            this.lblSoldBookAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(368, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê sách bán ra";
            // 
            // cbbTypeStatistic
            // 
            this.cbbTypeStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTypeStatistic.FormattingEnabled = true;
            this.cbbTypeStatistic.Location = new System.Drawing.Point(555, 100);
            this.cbbTypeStatistic.Name = "cbbTypeStatistic";
            this.cbbTypeStatistic.Size = new System.Drawing.Size(148, 24);
            this.cbbTypeStatistic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(439, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo:";
            // 
            // dgvBook
            // 
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(2, 130);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(701, 421);
            this.dgvBook.TabIndex = 0;
            // 
            // lblWorstSeller
            // 
            this.lblWorstSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWorstSeller.AutoSize = true;
            this.lblWorstSeller.BackColor = System.Drawing.Color.LightCoral;
            this.lblWorstSeller.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblWorstSeller.Location = new System.Drawing.Point(795, 451);
            this.lblWorstSeller.Name = "lblWorstSeller";
            this.lblWorstSeller.Size = new System.Drawing.Size(187, 29);
            this.lblWorstSeller.TabIndex = 15;
            this.lblWorstSeller.Text = "Sách bán ít nhất";
            // 
            // lblBestSeller
            // 
            this.lblBestSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblBestSeller.AutoSize = true;
            this.lblBestSeller.BackColor = System.Drawing.Color.YellowGreen;
            this.lblBestSeller.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblBestSeller.Location = new System.Drawing.Point(776, 292);
            this.lblBestSeller.Name = "lblBestSeller";
            this.lblBestSeller.Size = new System.Drawing.Size(221, 29);
            this.lblBestSeller.TabIndex = 16;
            this.lblBestSeller.Text = "Sách bán chạy nhất";
            // 
            // lblSoldBookAmount
            // 
            this.lblSoldBookAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSoldBookAmount.AutoSize = true;
            this.lblSoldBookAmount.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSoldBookAmount.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblSoldBookAmount.Location = new System.Drawing.Point(740, 159);
            this.lblSoldBookAmount.Name = "lblSoldBookAmount";
            this.lblSoldBookAmount.Size = new System.Drawing.Size(297, 29);
            this.lblSoldBookAmount.TabIndex = 17;
            this.lblSoldBookAmount.Text = "Tổng số lượng sách bán ra";
            // 
            // frmStatisticBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 551);
            this.Controls.Add(this.lblWorstSeller);
            this.Controls.Add(this.lblBestSeller);
            this.Controls.Add(this.lblSoldBookAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTypeStatistic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBook);
            this.Name = "frmStatisticBook";
            this.Text = "frmThongKeSachBanRa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTypeStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWorstSeller;
        private System.Windows.Forms.Label lblBestSeller;
        private System.Windows.Forms.Label lblSoldBookAmount;
    }
}