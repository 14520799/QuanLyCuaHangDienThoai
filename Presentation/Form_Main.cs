using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_customer.Visible = false;
            panel_product.Visible = false;
            panel_employee.Visible = false;
            panel_invoice.Visible = false;
            panel_statistic.Visible = false;
        }
        
        // Hàm nhúng form
        public void embed(Form form)
        {
            panel_content.Controls.Clear();  // Xóa các control khỏi form cũ
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.Fill;
            panel_content.Controls.Add(form);   // Thêm form mới vào panel
            panel_content.Show();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            Admin.Admin_Info admin_info = new Admin.Admin_Info();
            embed(admin_info);

            panel_home.Visible = true;
            panel_customer.Visible = false;
            panel_product.Visible = false;
            panel_employee.Visible = false;
            panel_invoice.Visible = false;
            panel_statistic.Visible = false;

            menu_admin_info.BackColor = Color.White;
            menu_admin_info.ForeColor = Color.OrangeRed;

            menu_admin_password.BackColor = Color.OrangeRed;
            menu_admin_password.ForeColor = Color.White;
        }

        private void menu_admin_info_Click(object sender, EventArgs e)
        {
            Admin.Admin_Info admin_info = new Admin.Admin_Info();
            embed(admin_info);

            menu_admin_info.BackColor = Color.White;
            menu_admin_info.ForeColor = Color.OrangeRed;

            menu_admin_password.BackColor = Color.OrangeRed;
            menu_admin_password.ForeColor = Color.White;
        }

        private void menu_admin_password_Click(object sender, EventArgs e)
        {
            Admin.Admin_Pass admin_pass = new Admin.Admin_Pass();
            embed(admin_pass);

            menu_admin_info.BackColor = Color.OrangeRed;
            menu_admin_info.ForeColor = Color.White;

            menu_admin_password.BackColor = Color.White;
            menu_admin_password.ForeColor = Color.OrangeRed;
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            Employee.Employee_Logo employee_logo = new Employee.Employee_Logo();
            embed(employee_logo);

            panel_employee.Visible = true;
            panel_home.Visible = false;
            panel_customer.Visible = false;
            panel_product.Visible = false;
            panel_invoice.Visible = false;
            panel_statistic.Visible = false;

            menu_employee_view.BackColor = Color.OrangeRed;
            menu_employee_view.ForeColor = Color.White;

            menu_employee_add.BackColor = Color.OrangeRed;
            menu_employee_add.ForeColor = Color.White;
        }

        private void menu_employee_view_Click(object sender, EventArgs e)
        {
            Employee.Employee_View employee_view = new Employee.Employee_View();
            embed(employee_view);

            menu_employee_view.BackColor = Color.White;
            menu_employee_view.ForeColor = Color.OrangeRed;

            menu_employee_add.BackColor = Color.OrangeRed;
            menu_employee_add.ForeColor = Color.White;
        }

        private void menu_employee_add_Click(object sender, EventArgs e)
        {
            Employee.Employee_Add employee_add = new Employee.Employee_Add();
            embed(employee_add);

            menu_employee_add.BackColor = Color.White;
            menu_employee_add.ForeColor = Color.OrangeRed;

            menu_employee_view.BackColor = Color.OrangeRed;
            menu_employee_view.ForeColor = Color.White;
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            Customer.Customer_Logo customer_logo = new Customer.Customer_Logo();
            embed(customer_logo);

            panel_customer.Visible = true;
            panel_home.Visible = false;
            panel_employee.Visible = false;
            panel_product.Visible = false;
            panel_invoice.Visible = false;
            panel_statistic.Visible = false;

            menu_customer_add.BackColor = Color.OrangeRed;
            menu_customer_add.ForeColor = Color.White;

            menu_customer_view.BackColor = Color.OrangeRed;
            menu_customer_view.ForeColor = Color.White;
        }

        private void menu_customer_view_Click(object sender, EventArgs e)
        {
            Customer.Customer_View customer_view = new Customer.Customer_View();
            embed(customer_view);

            menu_customer_view.BackColor = Color.White;
            menu_customer_view.ForeColor = Color.OrangeRed;

            menu_customer_add.BackColor = Color.OrangeRed;
            menu_customer_add.ForeColor = Color.White;
        }

        private void menu_customer_add_Click(object sender, EventArgs e)
        {
            Customer.Customer_Add customer_add = new Customer.Customer_Add();
            embed(customer_add);

            menu_customer_add.BackColor = Color.White;
            menu_customer_add.ForeColor = Color.OrangeRed;

            menu_customer_view.BackColor = Color.OrangeRed;
            menu_customer_view.ForeColor = Color.White;
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            Product.Product_Logo product_logo = new Product.Product_Logo();
            embed(product_logo);

            panel_product.Visible = true;
            panel_customer.Visible = false;
            panel_home.Visible = false;
            panel_employee.Visible = false;
            panel_invoice.Visible = false;
            panel_statistic.Visible = false;

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;

            menu_product_add.BackColor = Color.OrangeRed;
            menu_product_add.ForeColor = Color.White;

            menu_product_view.BackColor = Color.OrangeRed;
            menu_product_view.ForeColor = Color.White;
        }

        private void menu_product_view_Click(object sender, EventArgs e)
        {
            Product.Product_View product_view = new Product.Product_View();
            embed(product_view);

            menu_product_view.BackColor = Color.White;
            menu_product_view.ForeColor = Color.OrangeRed;

            menu_product_add.BackColor = Color.OrangeRed;
            menu_product_add.ForeColor = Color.White;

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
        }

        private void menu_product_add_Click(object sender, EventArgs e)
        {
            Product.Product_Add product_add = new Product.Product_Add();
            embed(product_add);

            menu_product_add.BackColor = Color.White;
            menu_product_add.ForeColor = Color.OrangeRed;

            menu_product_view.BackColor = Color.OrangeRed;
            menu_product_view.ForeColor = Color.White;

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
        }

        private void menu_factory_view_Click(object sender, EventArgs e)
        {
            Factory.Factory_View factory_view = new Factory.Factory_View();
            embed(factory_view);

            menu_factory_view.BackColor = Color.White;
            menu_factory_view.ForeColor = Color.OrangeRed;

            menu_product_add.BackColor = Color.OrangeRed;
            menu_product_add.ForeColor = Color.White;

            menu_product_view.BackColor = Color.OrangeRed;
            menu_product_view.ForeColor = Color.White;

            menu_factory_add.BackColor = Color.OrangeRed;
            menu_factory_add.ForeColor = Color.White;
        }

        private void menu_factory_add_Click(object sender, EventArgs e)
        {
            Factory.Factory_Add factory_add = new Factory.Factory_Add();
            embed(factory_add);

            menu_factory_add.BackColor = Color.White;
            menu_factory_add.ForeColor = Color.OrangeRed;

            menu_factory_view.BackColor = Color.OrangeRed;
            menu_factory_view.ForeColor = Color.White;

            menu_product_add.BackColor = Color.OrangeRed;
            menu_product_add.ForeColor = Color.White;

            menu_product_view.BackColor = Color.OrangeRed;
            menu_product_view.ForeColor = Color.White;
        }

        private void button_invoice_Click(object sender, EventArgs e)
        {
            Invoice.Invoice_Logo invoice_logo = new Invoice.Invoice_Logo();
            embed(invoice_logo);

            panel_invoice.Visible = true;
            panel_customer.Visible = false;
            panel_home.Visible = false;
            panel_product.Visible = false;
            panel_employee.Visible = false;

            menu_invoice_buy_view.BackColor = Color.OrangeRed;
            menu_invoice_buy_view.ForeColor = Color.White;

            menu_invoice_buy_add.BackColor = Color.OrangeRed;
            menu_invoice_buy_add.ForeColor = Color.White;

            menu_invoice_sale_view.BackColor = Color.OrangeRed;
            menu_invoice_sale_view.ForeColor = Color.White;

            menu_invoice_sale_add.BackColor = Color.OrangeRed;
            menu_invoice_sale_add.ForeColor = Color.White;
        }

        private void menu_invoice_buy_view_Click(object sender, EventArgs e)
        {
            Invoice.Invoice_Buy_View invoice_buy_view = new Invoice.Invoice_Buy_View();
            embed(invoice_buy_view);

            menu_invoice_buy_view.BackColor = Color.White;
            menu_invoice_buy_view.ForeColor = Color.OrangeRed;

            menu_invoice_buy_add.BackColor = Color.OrangeRed;
            menu_invoice_buy_add.ForeColor = Color.White;

            menu_invoice_sale_view.BackColor = Color.OrangeRed;
            menu_invoice_sale_view.ForeColor = Color.White;

            menu_invoice_sale_add.BackColor = Color.OrangeRed;
            menu_invoice_sale_add.ForeColor = Color.White;
        }

        private void menu_invoice_buy_add_Click(object sender, EventArgs e)
        {
            Invoice.Invoice_Buy_Add invoice_buy_add = new Invoice.Invoice_Buy_Add();
            embed(invoice_buy_add);

            menu_invoice_buy_add.BackColor = Color.White;
            menu_invoice_buy_add.ForeColor = Color.OrangeRed;

            menu_invoice_buy_view.BackColor = Color.OrangeRed;
            menu_invoice_buy_view.ForeColor = Color.White;

            menu_invoice_sale_view.BackColor = Color.OrangeRed;
            menu_invoice_sale_view.ForeColor = Color.White;

            menu_invoice_sale_add.BackColor = Color.OrangeRed;
            menu_invoice_sale_add.ForeColor = Color.White;
        }

        private void menu_invoice_sale_view_Click(object sender, EventArgs e)
        {
            Invoice.Invoice_Sale_View invoice_sale_view = new Invoice.Invoice_Sale_View();
            embed(invoice_sale_view);

            menu_invoice_sale_view.BackColor = Color.White;
            menu_invoice_sale_view.ForeColor = Color.OrangeRed;

            menu_invoice_sale_add.BackColor = Color.OrangeRed;
            menu_invoice_sale_add.ForeColor = Color.White;

            menu_invoice_buy_add.BackColor = Color.OrangeRed;
            menu_invoice_buy_add.ForeColor = Color.White;

            menu_invoice_buy_view.BackColor = Color.OrangeRed;
            menu_invoice_buy_view.ForeColor = Color.White;
        }

        private void menu_invoice_sale_add_Click(object sender, EventArgs e)
        {
            Invoice.Invoice_Sale_Add invoice_sale_add = new Invoice.Invoice_Sale_Add();
            embed(invoice_sale_add);

            menu_invoice_sale_add.BackColor = Color.White;
            menu_invoice_sale_add.ForeColor = Color.OrangeRed;

            menu_invoice_sale_view.BackColor = Color.OrangeRed;
            menu_invoice_sale_view.ForeColor = Color.White;

            menu_invoice_buy_add.BackColor = Color.OrangeRed;
            menu_invoice_buy_add.ForeColor = Color.White;

            menu_invoice_buy_view.BackColor = Color.OrangeRed;
            menu_invoice_buy_view.ForeColor = Color.White;
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
