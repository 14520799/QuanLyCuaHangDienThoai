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

namespace Presentation.Employee
{
    public partial class Employee_Add : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Employee_Add()
        {
            InitializeComponent();
        }

        
        // Nhấn nút thêm nhân viên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.NgaySinh = dtNgaySinh.Value;
            nv.GioiTinh = cbGioiTinh.Text;
            nv.SoDT = txtSoDT.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Quyen = cbQuyen.Text;
            nv.ChucVu = cbChucVu.Text;

            try
            {
                if (cbQuyen.Text == "Quản trị")
                {
                    if (txtMatKhauMoi1.Text == txtMatKhauMoi2.Text)
                    {
                        nv.MatKhau = txtMatKhauMoi1.Text;
                        bl.them(nv);
                        MessageBox.Show("Thêm thành công !");
                    }
                    else
                        MessageBox.Show("Mật khẩu không trùng khớp !");
                }
                else
                {
                    nv.MatKhau = "";
                    bl.them(nv);
                    MessageBox.Show("Thêm thành công !");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }
    }
}
