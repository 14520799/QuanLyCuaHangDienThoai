using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation.Customer
{
    public partial class Customer_View : Form
    {
        KhachHang_BL kh = new KhachHang_BL();

        public Customer_View()
        {
            InitializeComponent();

        }

        // Lấy danh sách khách hàng
        private void Customer_View_Load(object sender, EventArgs e)
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.DataSource = kh.danhSach();
        }
    }
}
