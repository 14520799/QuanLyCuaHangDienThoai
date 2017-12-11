namespace Presentation
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.button_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.button_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.button_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.button_product = new System.Windows.Forms.ToolStripMenuItem();
            this.button_invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.button_statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_above = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_invoice = new System.Windows.Forms.MenuStrip();
            this.menu_invoice_buy_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_invoice_buy_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_invoice_sale_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_invoice_sale_add = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_statistic = new System.Windows.Forms.MenuStrip();
            this.menu_statistic_grow = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statistic_math = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_customer = new System.Windows.Forms.MenuStrip();
            this.menu_customer_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_customer_add = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_home = new System.Windows.Forms.MenuStrip();
            this.menu_admin_info = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_admin_password = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_admin_search = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_product = new System.Windows.Forms.MenuStrip();
            this.menu_product_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_product_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_factory_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_factory_add = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.PictureBox();
            this.label_logout = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.panel_employee = new System.Windows.Forms.MenuStrip();
            this.menu_employee_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employee_add = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_content = new System.Windows.Forms.Panel();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.picture_welcome = new System.Windows.Forms.PictureBox();
            this.label_welcome = new System.Windows.Forms.Label();
            this.panel_below = new System.Windows.Forms.Panel();
            this.menu_bar.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_invoice.SuspendLayout();
            this.panel_statistic.SuspendLayout();
            this.panel_customer.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_logout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_logout)).BeginInit();
            this.panel_employee.SuspendLayout();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_welcome)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_bar
            // 
            this.menu_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_bar.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_admin,
            this.button_employee,
            this.button_customer,
            this.button_product,
            this.button_invoice,
            this.button_statistic});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu_bar.Size = new System.Drawing.Size(1360, 58);
            this.menu_bar.TabIndex = 8;
            this.menu_bar.Text = "menuStrip1";
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button_admin.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_admin.Image = ((System.Drawing.Image)(resources.GetObject("button_admin.Image")));
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(155, 54);
            this.button_admin.Text = "Quản trị";
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // button_employee
            // 
            this.button_employee.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button_employee.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_employee.Image = ((System.Drawing.Image)(resources.GetObject("button_employee.Image")));
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(177, 54);
            this.button_employee.Text = "Nhân viên";
            this.button_employee.Click += new System.EventHandler(this.button_employee_Click);
            // 
            // button_customer
            // 
            this.button_customer.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button_customer.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_customer.Image = ((System.Drawing.Image)(resources.GetObject("button_customer.Image")));
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(197, 54);
            this.button_customer.Text = "Khách hàng";
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // button_product
            // 
            this.button_product.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button_product.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_product.Image = ((System.Drawing.Image)(resources.GetObject("button_product.Image")));
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(177, 54);
            this.button_product.Text = "Sản phẩm";
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_invoice
            // 
            this.button_invoice.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button_invoice.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_invoice.Image = ((System.Drawing.Image)(resources.GetObject("button_invoice.Image")));
            this.button_invoice.Name = "button_invoice";
            this.button_invoice.Size = new System.Drawing.Size(163, 54);
            this.button_invoice.Text = "Hóa đơn";
            this.button_invoice.Click += new System.EventHandler(this.button_invoice_Click);
            // 
            // button_statistic
            // 
            this.button_statistic.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button_statistic.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_statistic.Image = ((System.Drawing.Image)(resources.GetObject("button_statistic.Image")));
            this.button_statistic.Name = "button_statistic";
            this.button_statistic.Size = new System.Drawing.Size(171, 54);
            this.button_statistic.Text = "Thống kê";
            // 
            // panel_above
            // 
            this.panel_above.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_above.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_above.Location = new System.Drawing.Point(0, 58);
            this.panel_above.Margin = new System.Windows.Forms.Padding(4);
            this.panel_above.Name = "panel_above";
            this.panel_above.Size = new System.Drawing.Size(1360, 12);
            this.panel_above.TabIndex = 9;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_left.Controls.Add(this.panel_invoice);
            this.panel_left.Controls.Add(this.panel_statistic);
            this.panel_left.Controls.Add(this.panel_customer);
            this.panel_left.Controls.Add(this.panel_home);
            this.panel_left.Controls.Add(this.panel_product);
            this.panel_left.Controls.Add(this.logo);
            this.panel_left.Controls.Add(this.panel_logout);
            this.panel_left.Controls.Add(this.panel_employee);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 70);
            this.panel_left.Margin = new System.Windows.Forms.Padding(4);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(333, 663);
            this.panel_left.TabIndex = 10;
            // 
            // panel_invoice
            // 
            this.panel_invoice.AutoSize = false;
            this.panel_invoice.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_invoice.Dock = System.Windows.Forms.DockStyle.None;
            this.panel_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_invoice.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.panel_invoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_invoice_buy_view,
            this.menu_invoice_buy_add,
            this.menu_invoice_sale_view,
            this.menu_invoice_sale_add});
            this.panel_invoice.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panel_invoice.Location = new System.Drawing.Point(15, 126);
            this.panel_invoice.Name = "panel_invoice";
            this.panel_invoice.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.panel_invoice.Size = new System.Drawing.Size(321, 183);
            this.panel_invoice.TabIndex = 10;
            // 
            // menu_invoice_buy_view
            // 
            this.menu_invoice_buy_view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_invoice_buy_view.ForeColor = System.Drawing.Color.White;
            this.menu_invoice_buy_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_invoice_buy_view.Image")));
            this.menu_invoice_buy_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_buy_view.Name = "menu_invoice_buy_view";
            this.menu_invoice_buy_view.Size = new System.Drawing.Size(312, 34);
            this.menu_invoice_buy_view.Text = "Xem hóa đơn mua";
            this.menu_invoice_buy_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_buy_view.Click += new System.EventHandler(this.menu_invoice_buy_view_Click);
            // 
            // menu_invoice_buy_add
            // 
            this.menu_invoice_buy_add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_invoice_buy_add.ForeColor = System.Drawing.Color.White;
            this.menu_invoice_buy_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_invoice_buy_add.Image")));
            this.menu_invoice_buy_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_buy_add.Name = "menu_invoice_buy_add";
            this.menu_invoice_buy_add.Size = new System.Drawing.Size(312, 34);
            this.menu_invoice_buy_add.Text = "Thêm hóa đơn mua";
            this.menu_invoice_buy_add.Click += new System.EventHandler(this.menu_invoice_buy_add_Click);
            // 
            // menu_invoice_sale_view
            // 
            this.menu_invoice_sale_view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_invoice_sale_view.ForeColor = System.Drawing.Color.White;
            this.menu_invoice_sale_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_invoice_sale_view.Image")));
            this.menu_invoice_sale_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_sale_view.Name = "menu_invoice_sale_view";
            this.menu_invoice_sale_view.Size = new System.Drawing.Size(312, 34);
            this.menu_invoice_sale_view.Text = "Xem hóa đơn bán";
            this.menu_invoice_sale_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_sale_view.Click += new System.EventHandler(this.menu_invoice_sale_view_Click);
            // 
            // menu_invoice_sale_add
            // 
            this.menu_invoice_sale_add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_invoice_sale_add.ForeColor = System.Drawing.Color.White;
            this.menu_invoice_sale_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_invoice_sale_add.Image")));
            this.menu_invoice_sale_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_sale_add.Name = "menu_invoice_sale_add";
            this.menu_invoice_sale_add.Size = new System.Drawing.Size(312, 34);
            this.menu_invoice_sale_add.Text = "Thêm hóa đơn bán";
            this.menu_invoice_sale_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_invoice_sale_add.Click += new System.EventHandler(this.menu_invoice_sale_add_Click);
            // 
            // panel_statistic
            // 
            this.panel_statistic.AutoSize = false;
            this.panel_statistic.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_statistic.Dock = System.Windows.Forms.DockStyle.None;
            this.panel_statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_statistic.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.panel_statistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_statistic_grow,
            this.menu_statistic_math});
            this.panel_statistic.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panel_statistic.Location = new System.Drawing.Point(15, 126);
            this.panel_statistic.Name = "panel_statistic";
            this.panel_statistic.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.panel_statistic.Size = new System.Drawing.Size(321, 167);
            this.panel_statistic.TabIndex = 9;
            // 
            // menu_statistic_grow
            // 
            this.menu_statistic_grow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_statistic_grow.ForeColor = System.Drawing.Color.White;
            this.menu_statistic_grow.Image = ((System.Drawing.Image)(resources.GetObject("menu_statistic_grow.Image")));
            this.menu_statistic_grow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_statistic_grow.Name = "menu_statistic_grow";
            this.menu_statistic_grow.Size = new System.Drawing.Size(312, 34);
            this.menu_statistic_grow.Text = "Growth rate deverlop";
            this.menu_statistic_grow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_statistic_math
            // 
            this.menu_statistic_math.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_statistic_math.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_statistic_math.Image = ((System.Drawing.Image)(resources.GetObject("menu_statistic_math.Image")));
            this.menu_statistic_math.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_statistic_math.Name = "menu_statistic_math";
            this.menu_statistic_math.Size = new System.Drawing.Size(312, 34);
            this.menu_statistic_math.Text = "Statistic";
            // 
            // panel_customer
            // 
            this.panel_customer.AutoSize = false;
            this.panel_customer.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_customer.Dock = System.Windows.Forms.DockStyle.None;
            this.panel_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_customer.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.panel_customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_customer_view,
            this.menu_customer_add});
            this.panel_customer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panel_customer.Location = new System.Drawing.Point(15, 126);
            this.panel_customer.Name = "panel_customer";
            this.panel_customer.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.panel_customer.Size = new System.Drawing.Size(321, 160);
            this.panel_customer.TabIndex = 8;
            // 
            // menu_customer_view
            // 
            this.menu_customer_view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_customer_view.ForeColor = System.Drawing.Color.White;
            this.menu_customer_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer_view.Image")));
            this.menu_customer_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_view.Name = "menu_customer_view";
            this.menu_customer_view.Size = new System.Drawing.Size(312, 34);
            this.menu_customer_view.Text = "Xem khách hàng";
            this.menu_customer_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_view.Click += new System.EventHandler(this.menu_customer_view_Click);
            // 
            // menu_customer_add
            // 
            this.menu_customer_add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_customer_add.ForeColor = System.Drawing.Color.White;
            this.menu_customer_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer_add.Image")));
            this.menu_customer_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_customer_add.Name = "menu_customer_add";
            this.menu_customer_add.Size = new System.Drawing.Size(312, 34);
            this.menu_customer_add.Text = "Thêm khách hàng";
            this.menu_customer_add.Click += new System.EventHandler(this.menu_customer_add_Click);
            // 
            // panel_home
            // 
            this.panel_home.AutoSize = false;
            this.panel_home.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_home.Dock = System.Windows.Forms.DockStyle.None;
            this.panel_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_home.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.panel_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_admin_info,
            this.menu_admin_password,
            this.menu_admin_search});
            this.panel_home.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panel_home.Location = new System.Drawing.Point(15, 126);
            this.panel_home.Name = "panel_home";
            this.panel_home.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.panel_home.Size = new System.Drawing.Size(321, 155);
            this.panel_home.TabIndex = 0;
            // 
            // menu_admin_info
            // 
            this.menu_admin_info.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_admin_info.ForeColor = System.Drawing.Color.White;
            this.menu_admin_info.Image = ((System.Drawing.Image)(resources.GetObject("menu_admin_info.Image")));
            this.menu_admin_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_admin_info.Name = "menu_admin_info";
            this.menu_admin_info.Size = new System.Drawing.Size(312, 34);
            this.menu_admin_info.Text = "Xem thông tin";
            this.menu_admin_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_admin_info.Click += new System.EventHandler(this.menu_admin_info_Click);
            // 
            // menu_admin_password
            // 
            this.menu_admin_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_admin_password.ForeColor = System.Drawing.Color.White;
            this.menu_admin_password.Image = ((System.Drawing.Image)(resources.GetObject("menu_admin_password.Image")));
            this.menu_admin_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_admin_password.Name = "menu_admin_password";
            this.menu_admin_password.Size = new System.Drawing.Size(312, 34);
            this.menu_admin_password.Text = "Đổi mật khẩu";
            this.menu_admin_password.Click += new System.EventHandler(this.menu_admin_password_Click);
            // 
            // menu_admin_search
            // 
            this.menu_admin_search.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_admin_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_admin_search.ForeColor = System.Drawing.Color.White;
            this.menu_admin_search.Image = ((System.Drawing.Image)(resources.GetObject("menu_admin_search.Image")));
            this.menu_admin_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_admin_search.Name = "menu_admin_search";
            this.menu_admin_search.Size = new System.Drawing.Size(312, 34);
            this.menu_admin_search.Text = "Tra cứu";
            this.menu_admin_search.Click += new System.EventHandler(this.menu_admin_search_Click);
            // 
            // panel_product
            // 
            this.panel_product.AutoSize = false;
            this.panel_product.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_product.Dock = System.Windows.Forms.DockStyle.None;
            this.panel_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_product.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.panel_product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_product_view,
            this.menu_product_add,
            this.menu_factory_view,
            this.menu_factory_add});
            this.panel_product.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panel_product.Location = new System.Drawing.Point(15, 126);
            this.panel_product.Name = "panel_product";
            this.panel_product.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.panel_product.Size = new System.Drawing.Size(321, 217);
            this.panel_product.TabIndex = 7;
            // 
            // menu_product_view
            // 
            this.menu_product_view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_product_view.ForeColor = System.Drawing.Color.White;
            this.menu_product_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_product_view.Image")));
            this.menu_product_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_product_view.Name = "menu_product_view";
            this.menu_product_view.Size = new System.Drawing.Size(312, 34);
            this.menu_product_view.Text = "Xem sản phẩm";
            this.menu_product_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_product_view.Click += new System.EventHandler(this.menu_product_view_Click);
            // 
            // menu_product_add
            // 
            this.menu_product_add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_product_add.ForeColor = System.Drawing.Color.White;
            this.menu_product_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_product_add.Image")));
            this.menu_product_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_product_add.Name = "menu_product_add";
            this.menu_product_add.Size = new System.Drawing.Size(312, 34);
            this.menu_product_add.Text = "Thêm sản phẩm";
            this.menu_product_add.Click += new System.EventHandler(this.menu_product_add_Click);
            // 
            // menu_factory_view
            // 
            this.menu_factory_view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_factory_view.ForeColor = System.Drawing.Color.White;
            this.menu_factory_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_factory_view.Image")));
            this.menu_factory_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_factory_view.Name = "menu_factory_view";
            this.menu_factory_view.Size = new System.Drawing.Size(312, 34);
            this.menu_factory_view.Text = "Xem hãng sản xuất";
            this.menu_factory_view.Click += new System.EventHandler(this.menu_factory_view_Click);
            // 
            // menu_factory_add
            // 
            this.menu_factory_add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_factory_add.ForeColor = System.Drawing.Color.White;
            this.menu_factory_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_factory_add.Image")));
            this.menu_factory_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_factory_add.Name = "menu_factory_add";
            this.menu_factory_add.Size = new System.Drawing.Size(312, 34);
            this.menu_factory_add.Text = "Thêm hãng sản xuất";
            this.menu_factory_add.Click += new System.EventHandler(this.menu_factory_add_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(119, 7);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(93, 86);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // panel_logout
            // 
            this.panel_logout.Controls.Add(this.button_logout);
            this.panel_logout.Controls.Add(this.label_logout);
            this.panel_logout.Controls.Add(this.lblMaNV);
            this.panel_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_logout.Location = new System.Drawing.Point(0, 540);
            this.panel_logout.Margin = new System.Windows.Forms.Padding(4);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(333, 123);
            this.panel_logout.TabIndex = 4;
            // 
            // button_logout
            // 
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_logout.Location = new System.Drawing.Point(13, 63);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(50, 47);
            this.button_logout.TabIndex = 2;
            this.button_logout.TabStop = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.White;
            this.label_logout.Location = new System.Drawing.Point(75, 85);
            this.label_logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(85, 26);
            this.label_logout.TabIndex = 3;
            this.label_logout.Text = "Logout";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.White;
            this.lblMaNV.Location = new System.Drawing.Point(75, 59);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(0, 26);
            this.lblMaNV.TabIndex = 1;
            // 
            // panel_employee
            // 
            this.panel_employee.AutoSize = false;
            this.panel_employee.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_employee.Dock = System.Windows.Forms.DockStyle.None;
            this.panel_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_employee.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.panel_employee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_employee_view,
            this.menu_employee_add});
            this.panel_employee.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.panel_employee.Location = new System.Drawing.Point(15, 126);
            this.panel_employee.Name = "panel_employee";
            this.panel_employee.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.panel_employee.Size = new System.Drawing.Size(321, 155);
            this.panel_employee.TabIndex = 6;
            this.panel_employee.Text = "menuStrip1";
            // 
            // menu_employee_view
            // 
            this.menu_employee_view.BackColor = System.Drawing.Color.OrangeRed;
            this.menu_employee_view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_employee_view.ForeColor = System.Drawing.Color.White;
            this.menu_employee_view.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee_view.Image")));
            this.menu_employee_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_employee_view.Name = "menu_employee_view";
            this.menu_employee_view.Size = new System.Drawing.Size(312, 34);
            this.menu_employee_view.Text = "Xem nhân viên";
            this.menu_employee_view.Click += new System.EventHandler(this.menu_employee_view_Click);
            // 
            // menu_employee_add
            // 
            this.menu_employee_add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menu_employee_add.ForeColor = System.Drawing.Color.White;
            this.menu_employee_add.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee_add.Image")));
            this.menu_employee_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_employee_add.Name = "menu_employee_add";
            this.menu_employee_add.Size = new System.Drawing.Size(312, 34);
            this.menu_employee_add.Text = "Thêm nhân viên";
            this.menu_employee_add.Click += new System.EventHandler(this.menu_employee_add_Click);
            // 
            // panel_content
            // 
            this.panel_content.AutoScroll = true;
            this.panel_content.Controls.Add(this.lblTenNV);
            this.panel_content.Controls.Add(this.picture_welcome);
            this.panel_content.Controls.Add(this.label_welcome);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(333, 70);
            this.panel_content.Margin = new System.Windows.Forms.Padding(4);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1027, 663);
            this.panel_content.TabIndex = 11;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTenNV.Location = new System.Drawing.Point(41, 28);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(143, 35);
            this.lblTenNV.TabIndex = 5;
            this.lblTenNV.Text = "Welcome, ";
            // 
            // picture_welcome
            // 
            this.picture_welcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_welcome.BackgroundImage")));
            this.picture_welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_welcome.Location = new System.Drawing.Point(170, 106);
            this.picture_welcome.Margin = new System.Windows.Forms.Padding(4);
            this.picture_welcome.Name = "picture_welcome";
            this.picture_welcome.Size = new System.Drawing.Size(811, 399);
            this.picture_welcome.TabIndex = 4;
            this.picture_welcome.TabStop = false;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_welcome.Location = new System.Drawing.Point(87, 54);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(0, 31);
            this.label_welcome.TabIndex = 0;
            // 
            // panel_below
            // 
            this.panel_below.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_below.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_below.Location = new System.Drawing.Point(333, 721);
            this.panel_below.Margin = new System.Windows.Forms.Padding(4);
            this.panel_below.Name = "panel_below";
            this.panel_below.Size = new System.Drawing.Size(1027, 12);
            this.panel_below.TabIndex = 12;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1360, 733);
            this.Controls.Add(this.panel_below);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_above);
            this.Controls.Add(this.menu_bar);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "Quản Lý Cửa Hàng Điện Thoại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_invoice.ResumeLayout(false);
            this.panel_invoice.PerformLayout();
            this.panel_statistic.ResumeLayout(false);
            this.panel_statistic.PerformLayout();
            this.panel_customer.ResumeLayout(false);
            this.panel_customer.PerformLayout();
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            this.panel_product.ResumeLayout(false);
            this.panel_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel_logout.ResumeLayout(false);
            this.panel_logout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_logout)).EndInit();
            this.panel_employee.ResumeLayout(false);
            this.panel_employee.PerformLayout();
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_welcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_bar;
        private System.Windows.Forms.ToolStripMenuItem button_admin;
        private System.Windows.Forms.ToolStripMenuItem button_employee;
        private System.Windows.Forms.ToolStripMenuItem button_customer;
        private System.Windows.Forms.ToolStripMenuItem button_product;
        private System.Windows.Forms.ToolStripMenuItem button_invoice;
        private System.Windows.Forms.ToolStripMenuItem button_statistic;
        private System.Windows.Forms.Panel panel_above;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.MenuStrip panel_invoice;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice_buy_view;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice_buy_add;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice_sale_view;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice_sale_add;
        private System.Windows.Forms.MenuStrip panel_statistic;
        private System.Windows.Forms.ToolStripMenuItem menu_statistic_grow;
        private System.Windows.Forms.ToolStripMenuItem menu_statistic_math;
        private System.Windows.Forms.MenuStrip panel_customer;
        private System.Windows.Forms.ToolStripMenuItem menu_customer_view;
        private System.Windows.Forms.ToolStripMenuItem menu_customer_add;
        private System.Windows.Forms.MenuStrip panel_product;
        private System.Windows.Forms.ToolStripMenuItem menu_product_view;
        private System.Windows.Forms.ToolStripMenuItem menu_product_add;
        private System.Windows.Forms.ToolStripMenuItem menu_factory_view;
        private System.Windows.Forms.ToolStripMenuItem menu_factory_add;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.PictureBox button_logout;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.MenuStrip panel_home;
        private System.Windows.Forms.ToolStripMenuItem menu_admin_info;
        private System.Windows.Forms.ToolStripMenuItem menu_admin_password;
        private System.Windows.Forms.MenuStrip panel_employee;
        private System.Windows.Forms.ToolStripMenuItem menu_employee_view;
        private System.Windows.Forms.ToolStripMenuItem menu_employee_add;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.PictureBox picture_welcome;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Panel panel_below;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ToolStripMenuItem menu_admin_search;
    }
}