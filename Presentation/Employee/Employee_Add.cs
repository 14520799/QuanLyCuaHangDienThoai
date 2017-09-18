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
    public partial class Employee_Add : Form
    {
        NhanVien nv = new NhanVien();

        public Employee_Add()
        {
            InitializeComponent();
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 31; i++)
            {
                cbNgay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }

            for (int i = 1970; i <= 2000; i++)
            {
                cbNam.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess.NhanVien member = new DataAccess.NhanVien();
            /* 
             * member.TenNV = txtTenNV.Text;
             * member.NgaySinh .............
            */
            nv.them(member);
        }
    }
}
