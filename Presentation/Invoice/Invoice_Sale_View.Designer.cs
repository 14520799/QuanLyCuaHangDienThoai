namespace Presentation.Invoice
{
    partial class Invoice_Sale_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetailBox = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietBan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailBox
            // 
            this.DetailBox.Controls.Add(this.dgvHoaDonBan);
            this.DetailBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailBox.ForeColor = System.Drawing.Color.Red;
            this.DetailBox.Location = new System.Drawing.Point(22, 13);
            this.DetailBox.Margin = new System.Windows.Forms.Padding(4);
            this.DetailBox.Name = "DetailBox";
            this.DetailBox.Padding = new System.Windows.Forms.Padding(4);
            this.DetailBox.Size = new System.Drawing.Size(1080, 304);
            this.DetailBox.TabIndex = 43;
            this.DetailBox.TabStop = false;
            this.DetailBox.Text = "DANH SÁCH HÓA ĐƠN BÁN";
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.AllowUserToAddRows = false;
            this.dgvHoaDonBan.AllowUserToDeleteRows = false;
            this.dgvHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonBan.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.NgayMua,
            this.TongTien,
            this.SoTienNo,
            this.HoTen,
            this.TenHang});
            this.dgvHoaDonBan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(16, 34);
            this.dgvHoaDonBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDonBan.MultiSelect = false;
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.ReadOnly = true;
            this.dgvHoaDonBan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHoaDonBan.RowHeadersVisible = false;
            this.dgvHoaDonBan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.dgvHoaDonBan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDonBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(1045, 253);
            this.dgvHoaDonBan.TabIndex = 11;
            this.dgvHoaDonBan.SelectionChanged += new System.EventHandler(this.dgvHoaDonBan_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHDB";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã HDB";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayBan";
            this.NgayMua.HeaderText = "Ngày Bán";
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // SoTienNo
            // 
            this.SoTienNo.DataPropertyName = "TienNo";
            this.SoTienNo.HeaderText = "Tiền Nợ";
            this.SoTienNo.Name = "SoTienNo";
            this.SoTienNo.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "MaNV";
            this.HoTen.HeaderText = "Nhân Viên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "MaKH";
            this.TenHang.HeaderText = "Khách Hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChiTietBan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(22, 367);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 277);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT HÓA ĐƠN BÁN";
            // 
            // dgvChiTietBan
            // 
            this.dgvChiTietBan.AllowUserToAddRows = false;
            this.dgvChiTietBan.AllowUserToDeleteRows = false;
            this.dgvChiTietBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietBan.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenSP,
            this.GiaBan,
            this.Column1,
            this.GiamGia,
            this.HinhAnh});
            this.dgvChiTietBan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvChiTietBan.Location = new System.Drawing.Point(23, 34);
            this.dgvChiTietBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietBan.MultiSelect = false;
            this.dgvChiTietBan.Name = "dgvChiTietBan";
            this.dgvChiTietBan.ReadOnly = true;
            this.dgvChiTietBan.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.dgvChiTietBan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBan.Size = new System.Drawing.Size(1038, 220);
            this.dgvChiTietBan.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaCTB";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã CTB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "MaSP";
            this.TenSP.HeaderText = "Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "DonGia";
            this.GiaBan.HeaderText = "Đơn Giá";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoLuong";
            this.Column1.HeaderText = "Số Lượng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm Giá";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "ThanhTien";
            this.HinhAnh.HeaderText = "Thành Tiền";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // Invoice_Sale_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1129, 733);
            this.Controls.Add(this.DetailBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Invoice_Sale_View";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Invoice_Sale_View_Load);
            this.DetailBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DetailBox;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
    }
}