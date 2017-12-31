namespace Presentation.Statistic
{
    partial class Statistic_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic_View));
            this.cbLoaiHD = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnXuat = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnXuat)).BeginInit();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiHD
            // 
            this.cbLoaiHD.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHD.FormattingEnabled = true;
            this.cbLoaiHD.Items.AddRange(new object[] {
            "Thống kê mua",
            "Thống kê bán"});
            this.cbLoaiHD.Location = new System.Drawing.Point(197, 55);
            this.cbLoaiHD.Name = "cbLoaiHD";
            this.cbLoaiHD.Size = new System.Drawing.Size(112, 24);
            this.cbLoaiHD.TabIndex = 66;
            this.cbLoaiHD.Text = "Loại HĐ";
            this.cbLoaiHD.TextChanged += new System.EventHandler(this.cbLoaiHD_TextChanged);
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(61, 55);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(112, 24);
            this.cbThang.TabIndex = 65;
            this.cbThang.Text = "Tháng";
            this.cbThang.TextChanged += new System.EventHandler(this.cbThang_TextChanged);
            // 
            // btnXuat
            // 
            this.btnXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.BackgroundImage")));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.Location = new System.Drawing.Point(522, 51);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(80, 32);
            this.btnXuat.TabIndex = 64;
            this.btnXuat.TabStop = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.dgvThongKe);
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Red;
            this.SearchBox.Location = new System.Drawing.Point(61, 97);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(542, 262);
            this.SearchBox.TabIndex = 63;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "THỐNG KÊ";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(16, 32);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(511, 207);
            this.dgvThongKe.TabIndex = 55;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(490, 378);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(112, 20);
            this.txtTongTien.TabIndex = 67;
            this.txtTongTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tổng nợ";
            // 
            // txtTongNo
            // 
            this.txtTongNo.Location = new System.Drawing.Point(305, 378);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(112, 20);
            this.txtTongNo.TabIndex = 69;
            this.txtTongNo.Text = "0";
            // 
            // Statistic_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.cbLoaiHD);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.SearchBox);
            this.Name = "Statistic_View";
            this.Text = "Statistic_View";
            this.Load += new System.EventHandler(this.Statistic_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnXuat)).EndInit();
            this.SearchBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoaiHD;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.PictureBox btnXuat;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongNo;
    }
}