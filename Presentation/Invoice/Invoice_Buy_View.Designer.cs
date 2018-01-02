namespace Presentation.Invoice
{
    partial class Invoice_Buy_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetailBox = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonMua = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietMua = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonMua)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMua)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailBox
            // 
            this.DetailBox.Controls.Add(this.dgvHoaDonMua);
            this.DetailBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailBox.ForeColor = System.Drawing.Color.Red;
            this.DetailBox.Location = new System.Drawing.Point(25, 20);
            this.DetailBox.Name = "DetailBox";
            this.DetailBox.Size = new System.Drawing.Size(555, 255);
            this.DetailBox.TabIndex = 36;
            this.DetailBox.TabStop = false;
            this.DetailBox.Text = "DANH SÁCH HÓA ĐƠN MUA";
            // 
            // dgvHoaDonMua
            // 
            this.dgvHoaDonMua.AllowUserToAddRows = false;
            this.dgvHoaDonMua.AllowUserToDeleteRows = false;
            this.dgvHoaDonMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonMua.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvHoaDonMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.TenHang,
            this.HoTen,
            this.NgayMua,
            this.TongTien,
            this.SoTienNo});
            this.dgvHoaDonMua.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHoaDonMua.Location = new System.Drawing.Point(15, 28);
            this.dgvHoaDonMua.MultiSelect = false;
            this.dgvHoaDonMua.Name = "dgvHoaDonMua";
            this.dgvHoaDonMua.ReadOnly = true;
            this.dgvHoaDonMua.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHoaDonMua.RowHeadersVisible = false;
            this.dgvHoaDonMua.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.dgvHoaDonMua.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonMua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonMua.Size = new System.Drawing.Size(525, 206);
            this.dgvHoaDonMua.TabIndex = 11;
            this.dgvHoaDonMua.SelectionChanged += new System.EventHandler(this.dgvHoaDonMua_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHDM";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã HDM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "MaHang";
            this.TenHang.HeaderText = "Hãng SX";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "MaNV";
            this.HoTen.HeaderText = "Mã NV";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayMua";
            this.NgayMua.HeaderText = "Ngày mua";
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // SoTienNo
            // 
            this.SoTienNo.DataPropertyName = "TienNo";
            this.SoTienNo.HeaderText = "Tiền nợ";
            this.SoTienNo.Name = "SoTienNo";
            this.SoTienNo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChiTietMua);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(25, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 230);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT HÓA ĐƠN MUA";
            // 
            // dgvChiTietMua
            // 
            this.dgvChiTietMua.AllowUserToAddRows = false;
            this.dgvChiTietMua.AllowUserToDeleteRows = false;
            this.dgvChiTietMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietMua.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChiTietMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenSP,
            this.GiaBan,
            this.Column1,
            this.GiamGia,
            this.HinhAnh});
            this.dgvChiTietMua.GridColor = System.Drawing.SystemColors.Control;
            this.dgvChiTietMua.Location = new System.Drawing.Point(14, 30);
            this.dgvChiTietMua.MultiSelect = false;
            this.dgvChiTietMua.Name = "dgvChiTietMua";
            this.dgvChiTietMua.ReadOnly = true;
            this.dgvChiTietMua.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.dgvChiTietMua.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietMua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietMua.Size = new System.Drawing.Size(526, 179);
            this.dgvChiTietMua.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaCTM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã CTM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "MaSP";
            this.TenSP.HeaderText = "Mã SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
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
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "ThanhTien";
            this.HinhAnh.HeaderText = "Thành tiền";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // Invoice_Buy_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(605, 566);
            this.Controls.Add(this.DetailBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Invoice_Buy_View";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Invoice_Buy_View_Load);
            this.DetailBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonMua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DetailBox;
        private System.Windows.Forms.DataGridView dgvHoaDonMua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
    }
}