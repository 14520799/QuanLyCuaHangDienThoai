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

namespace Presentation.Employee
{
    public partial class Employee_View : Form
    {
        NhanVien nv = new NhanVien();

        public Employee_View()
        {
            InitializeComponent();
        }

        private void Employee_View_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = nv.layDanhSach();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = nv.timTheoTen(txtSearch.Text);
        }
    }
}
