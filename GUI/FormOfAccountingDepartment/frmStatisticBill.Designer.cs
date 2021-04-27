namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    partial class frmStatisticBill
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
            this.cbbTypeSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPermit = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.dpkEnd = new System.Windows.Forms.DateTimePicker();
            this.dpkBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTypeStatistic = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvConfirmedBill = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmedBill)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTypeSort
            // 
            this.cbbTypeSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTypeSort.FormattingEnabled = true;
            this.cbbTypeSort.Location = new System.Drawing.Point(462, 87);
            this.cbbTypeSort.Name = "cbbTypeSort";
            this.cbbTypeSort.Size = new System.Drawing.Size(116, 24);
            this.cbbTypeSort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(395, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sắp xếp";
            // 
            // btnPermit
            // 
            this.btnPermit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPermit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPermit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPermit.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnPermit.Location = new System.Drawing.Point(893, 498);
            this.btnPermit.Name = "btnPermit";
            this.btnPermit.Size = new System.Drawing.Size(132, 38);
            this.btnPermit.TabIndex = 5;
            this.btnPermit.Text = "Đồng ý";
            this.btnPermit.UseVisualStyleBackColor = false;
            // 
            // btnDeny
            // 
            this.btnDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeny.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeny.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnDeny.Location = new System.Drawing.Point(720, 498);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(132, 38);
            this.btnDeny.TabIndex = 5;
            this.btnDeny.Text = "Từ chối";
            this.btnDeny.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnStatistic);
            this.groupBox1.Controls.Add(this.dpkEnd);
            this.groupBox1.Controls.Add(this.dpkBegin);
            this.groupBox1.Location = new System.Drawing.Point(2, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khoảng thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistic.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatistic.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnStatistic.Location = new System.Drawing.Point(871, 16);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(112, 36);
            this.btnStatistic.TabIndex = 5;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = false;
            // 
            // dpkEnd
            // 
            this.dpkEnd.Location = new System.Drawing.Point(572, 21);
            this.dpkEnd.Name = "dpkEnd";
            this.dpkEnd.Size = new System.Drawing.Size(230, 22);
            this.dpkEnd.TabIndex = 0;
            // 
            // dpkBegin
            // 
            this.dpkBegin.Location = new System.Drawing.Point(204, 24);
            this.dpkBegin.Name = "dpkBegin";
            this.dpkBegin.Size = new System.Drawing.Size(230, 22);
            this.dpkBegin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBill);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 422);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(3, 18);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(606, 401);
            this.dgvBill.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê theo:";
            // 
            // cbbTypeStatistic
            // 
            this.cbbTypeStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTypeStatistic.FormattingEnabled = true;
            this.cbbTypeStatistic.Location = new System.Drawing.Point(124, 86);
            this.cbbTypeStatistic.Name = "cbbTypeStatistic";
            this.cbbTypeStatistic.Size = new System.Drawing.Size(171, 24);
            this.cbbTypeStatistic.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvConfirmedBill);
            this.groupBox3.Location = new System.Drawing.Point(630, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 355);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn cần phê duyệt để xóa";
            // 
            // dgvConfirmedBill
            // 
            this.dgvConfirmedBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmedBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfirmedBill.Location = new System.Drawing.Point(3, 18);
            this.dgvConfirmedBill.Name = "dgvConfirmedBill";
            this.dgvConfirmedBill.RowHeadersWidth = 51;
            this.dgvConfirmedBill.RowTemplate.Height = 24;
            this.dgvConfirmedBill.Size = new System.Drawing.Size(424, 334);
            this.dgvConfirmedBill.TabIndex = 5;
            // 
            // frmStatisticBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnPermit);
            this.Controls.Add(this.cbbTypeStatistic);
            this.Controls.Add(this.cbbTypeSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStatisticBill";
            this.Text = "frmThongKeHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmedBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbTypeSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPermit;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DateTimePicker dpkEnd;
        private System.Windows.Forms.DateTimePicker dpkBegin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTypeStatistic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvConfirmedBill;
    }
}