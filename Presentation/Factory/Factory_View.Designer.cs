namespace Presentation.Factory
{
    partial class Factory_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factory_View));
            this.gbHangSX = new System.Windows.Forms.GroupBox();
            this.dgvHangSX = new System.Windows.Forms.DataGridView();
            this.MaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPhamHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.gbHangSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).BeginInit();
            this.InfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHangSX
            // 
            this.gbHangSX.Controls.Add(this.dgvHangSX);
            this.gbHangSX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHangSX.ForeColor = System.Drawing.Color.Red;
            this.gbHangSX.Location = new System.Drawing.Point(22, 18);
            this.gbHangSX.Name = "gbHangSX";
            this.gbHangSX.Size = new System.Drawing.Size(479, 184);
            this.gbHangSX.TabIndex = 29;
            this.gbHangSX.TabStop = false;
            this.gbHangSX.Text = "DANH SÁCH HÃNG SẢN XUẤT";
            // 
            // dgvHangSX
            // 
            this.dgvHangSX.AllowUserToAddRows = false;
            this.dgvHangSX.AllowUserToDeleteRows = false;
            this.dgvHangSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHangSX.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvHangSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSX,
            this.TenSX,
            this.SDT,
            this.Email1,
            this.DiaChi});
            this.dgvHangSX.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHangSX.Location = new System.Drawing.Point(14, 28);
            this.dgvHangSX.MultiSelect = false;
            this.dgvHangSX.Name = "dgvHangSX";
            this.dgvHangSX.ReadOnly = true;
            this.dgvHangSX.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.dgvHangSX.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangSX.Size = new System.Drawing.Size(450, 136);
            this.dgvHangSX.TabIndex = 2;
            this.dgvHangSX.SelectionChanged += new System.EventHandler(this.dgvHangSX_SelectionChanged);
            // 
            // MaSX
            // 
            this.MaSX.DataPropertyName = "MaHang";
            this.MaSX.HeaderText = "Mã hãng";
            this.MaSX.Name = "MaSX";
            this.MaSX.ReadOnly = true;
            this.MaSX.Width = 94;
            // 
            // TenSX
            // 
            this.TenSX.DataPropertyName = "TenHang";
            this.TenSX.HeaderText = "Tên hãng";
            this.TenSX.Name = "TenSX";
            this.TenSX.ReadOnly = true;
            this.TenSX.Width = 96;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SoDT";
            this.SDT.HeaderText = "Số ĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 77;
            // 
            // Email1
            // 
            this.Email1.DataPropertyName = "Email";
            this.Email1.HeaderText = "Email";
            this.Email1.Name = "Email1";
            this.Email1.ReadOnly = true;
            this.Email1.Width = 72;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(379, 237);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 34;
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.cbTenHang);
            this.InfoBox.Controls.Add(this.txtDiaChi);
            this.InfoBox.Controls.Add(this.txtEmail);
            this.InfoBox.Controls.Add(this.txtSoDT);
            this.InfoBox.Controls.Add(this.label5);
            this.InfoBox.Controls.Add(this.label4);
            this.InfoBox.Controls.Add(this.label3);
            this.InfoBox.Controls.Add(this.label1);
            this.InfoBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.Red;
            this.InfoBox.Location = new System.Drawing.Point(22, 237);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(367, 174);
            this.InfoBox.TabIndex = 30;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "CHI TIẾT HÃNG SẢN XUẤT";
            // 
            // cbTenHang
            // 
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Location = new System.Drawing.Point(129, 37);
            this.cbTenHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(204, 27);
            this.cbTenHang.TabIndex = 42;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(129, 130);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(204, 26);
            this.txtDiaChi.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(129, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 26);
            this.txtEmail.TabIndex = 39;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(129, 68);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(204, 26);
            this.txtSoDT.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(35, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Số ĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên hãng";
            // 
            // dgvSanPhamHang
            // 
            this.dgvSanPhamHang.AllowUserToAddRows = false;
            this.dgvSanPhamHang.AllowUserToDeleteRows = false;
            this.dgvSanPhamHang.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSanPhamHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenSP,
            this.GiaBan,
            this.Column1});
            this.dgvSanPhamHang.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSanPhamHang.Location = new System.Drawing.Point(16, 29);
            this.dgvSanPhamHang.MultiSelect = false;
            this.dgvSanPhamHang.Name = "dgvSanPhamHang";
            this.dgvSanPhamHang.ReadOnly = true;
            this.dgvSanPhamHang.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.dgvSanPhamHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPhamHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPhamHang.Size = new System.Drawing.Size(448, 179);
            this.dgvSanPhamHang.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên hãng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "DonGia";
            this.GiaBan.HeaderText = "Đơn giá";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoLuong";
            this.Column1.HeaderText = "Số lượng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSanPhamHang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(22, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 224);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SẢN PHẨM CỦA HÃNG";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(415, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(415, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 35);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(415, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Factory_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(542, 735);
            this.Controls.Add(this.gbHangSX);
            this.Controls.Add(this.error);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Factory_View";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Factory_View_Load);
            this.gbHangSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSX)).EndInit();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbHangSX;
        private System.Windows.Forms.DataGridView dgvHangSX;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPhamHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox btnUpdate;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}