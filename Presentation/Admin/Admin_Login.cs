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

namespace Presentation.Admin
{
    public partial class Admin_Login : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Admin_Login()
        {
            InitializeComponent();
        }


        // Nhấn nút Confirm đăng nhập
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /*bl.MaNV = txtMaNV.Text;
            bl.MatKhau = txtMatKhau.Text;

            string TenNV = bl.dangNhap();
            if (TenNV != string.Empty)
            {
                Hide();
                new Form_Main(bl.MaNV, TenNV).Show();
            }
            else
                MessageBox.Show("Sai thông tin tài khoản !");*/
            
            Hide();
            new Form_Main("NV001", "Hoàng Tâm").Show();
        }


        // Nhấn nút Close đóng form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Nhấn Enter đăng nhập
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnConfirm_Click(sender, e);
        }
    }
}
