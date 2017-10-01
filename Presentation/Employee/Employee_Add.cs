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
        NhanVien nv;

        public Employee_Add()
        {
            InitializeComponent();
        }
        
        // Nhấn nút thêm nhân viên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                nv = new NhanVien();

                if (cbQuyen.Text == "Quản trị" && txtMatKhauMoi1.Text == txtMatKhauMoi2.Text)
                    nv.them(txtMaNV.Text, txtTenNV.Text, dtNgaySinh.Value, cbGioiTinh.Text, txtSoDT.Text, txtEmail.Text, txtDiaChi.Text, cbQuyen.Text, cbChucVu.Text, txtMatKhauMoi1.Text);
                else
                    nv.them(txtMaNV.Text, txtTenNV.Text, dtNgaySinh.Value, cbGioiTinh.Text, txtSoDT.Text, txtEmail.Text, txtDiaChi.Text, cbQuyen.Text, cbChucVu.Text, "");
                
                MessageBox.Show("Thêm thành công nhân viên : " + txtTenNV.Text);
            }
            catch
            {
                MessageBox.Show("Rất tiếc. Đã xảy ra lỗi !");
            }

        }
    }
}
