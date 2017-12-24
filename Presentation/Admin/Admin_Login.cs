using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace Presentation.Admin
{
    public partial class Admin_Login : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Admin_Login()
        {
            InitializeComponent();
        }
        
        // Click Confirm để đăng nhập
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach(NhanVien nv in bl.layNhanVien())
            {
                if (nv.Quyen.Equals("Quản trị") && nv.MaNV.Equals(txtMaNV.Text) && nv.MatKhau.Equals(txtMatKhau.Text))  // Kiểm tra Username + Password
                {
                    Hide();
                    new Form_Main(nv.MaNV, nv.TenNV).Show();
                    return;
                }
            }

            MessageBox.Show("Vui lòng kiểm tra lại");
        }

        // Nhấn Enter để đăng nhập
        private void txtMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm_Click(sender, e);
        }
        
        // Nhấn Enter để đăng nhập
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm_Click(sender, e);
        }
        
        // Click Close để đóng Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
