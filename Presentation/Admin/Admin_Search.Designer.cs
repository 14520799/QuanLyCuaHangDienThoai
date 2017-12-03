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
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cbThuocTinh
            // 
            this.cbThuocTinh.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThuocTinh.FormattingEnabled = true;
            this.cbThuocTinh.Location = new System.Drawing.Point(390, 39);
            this.cbThuocTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbThuocTinh.Name = "cbThuocTinh";
            this.cbThuocTinh.Size = new System.Drawing.Size(148, 29);
            this.cbThuocTinh.TabIndex = 58;
            this.cbThuocTinh.Text = "Thuộc tính";
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Nhân Viên",
            "Khách Hàng",
            "Sản Phẩm",
            "Hãng Sản Xuất",
            "Hóa Đơn Mua",
            "Hóa Đơn Bán"});
            this.cbDanhMuc.Location = new System.Drawing.Point(209, 39);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(148, 29);
            this.cbDanhMuc.TabIndex = 57;
            this.cbDanhMuc.Text = "Danh mục";
            this.cbDanhMuc.SelectionChangeCommitted += new System.EventHandler(this.cbDanhMuc_SelectionChangeCommitted);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(571, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.TabStop = false;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(28, 39);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(148, 28);
            this.txtTuKhoa.TabIndex = 55;
            this.txtTuKhoa.Text = "Từ khóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 255);
            this.dataGridView1.TabIndex = 55;
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.dataGridView1);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(573, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Back | Next";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(688, 444);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 31);
            this.btnNext.TabIndex = 61;
            this.btnNext.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(532, 444);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 31);
            this.btnBack.TabIndex = 60;
            this.btnBack.TabStop = false;
            // 
            // Admin_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(760, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbThuocTinh);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.SearchBox);
            this.Name = "Admin_Search";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Admin_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SearchBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThuocTinh;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnBack;
    }
}