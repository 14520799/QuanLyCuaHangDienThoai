namespace Presentation.Admin
{
    partial class Admin_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Search));
            this.cbThuocTinh = new System.Windows.Forms.ComboBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.cbTuKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbThuocTinh
            // 
            this.cbThuocTinh.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThuocTinh.FormattingEnabled = true;
            this.cbThuocTinh.Location = new System.Drawing.Point(209, 46);
            this.cbThuocTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbThuocTinh.Name = "cbThuocTinh";
            this.cbThuocTinh.Size = new System.Drawing.Size(148, 29);
            this.cbThuocTinh.TabIndex = 58;
            this.cbThuocTinh.Text = "Thuộc tính";
            this.cbThuocTinh.TextChanged += new System.EventHandler(this.cbThuocTinh_TextChanged);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Nhân viên",
            "Khách hàng",
            "Sản phẩm",
            "Hóa đơn mua",
            "Hóa đơn bán"});
            this.cbDanhMuc.Location = new System.Drawing.Point(28, 46);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(148, 29);
            this.cbDanhMuc.TabIndex = 57;
            this.cbDanhMuc.Text = "Danh mục";
            this.cbDanhMuc.TextChanged += new System.EventHandler(this.cbDanhMuc_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(642, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(22, 40);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.Size = new System.Drawing.Size(681, 255);
            this.dgvKetQua.TabIndex = 55;
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.dgvKetQua);
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Red;
            this.SearchBox.Location = new System.Drawing.Point(28, 97);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Padding = new System.Windows.Forms.Padding(4);
            this.SearchBox.Size = new System.Drawing.Size(723, 323);
            this.SearchBox.TabIndex = 47;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "TÌM KIẾM";
            // 
            // cbTuKhoa
            // 
            this.cbTuKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbTuKhoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuKhoa.FormattingEnabled = true;
            this.cbTuKhoa.Items.AddRange(new object[] {
            "Nhân Viên",
            "Khách Hàng",
            "Sản Phẩm",
            "Hãng Sản Xuất",
            "Hóa Đơn Mua",
            "Hóa Đơn Bán"});
            this.cbTuKhoa.Location = new System.Drawing.Point(389, 46);
            this.cbTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbTuKhoa.Name = "cbTuKhoa";
            this.cbTuKhoa.Size = new System.Drawing.Size(220, 29);
            this.cbTuKhoa.TabIndex = 62;
            this.cbTuKhoa.Text = "Từ khóa";
            // 
            // Admin_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(885, 505);
            this.Controls.Add(this.cbTuKhoa);
            this.Controls.Add(this.cbThuocTinh);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBox);
            this.Name = "Admin_Search";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Admin_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThuocTinh;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.ComboBox cbTuKhoa;
    }
}