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
    public partial class Admin_Pass : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Admin_Pass(string MaNV)
        {
            InitializeComponent();
            txtMaNV.Text = bl.MaNV = MaNV;
        }

        // Click Update để đổi mật khẩu
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (NhanVien nv in bl.layNhanVien())
                {
                    if (nv.MaNV.Equals(bl.MaNV) && nv.MatKhau.Equals(txtMatKhauCu.Text) && txtMatKhauMoi1.Text.Equals(txtMatKhauMoi2.Text))
                    {
                        bl.TenNV = nv.TenNV;
                        bl.NgaySinh = nv.NgaySinh;
                        bl.GioiTinh = nv.GioiTinh;
                        bl.SoDT = nv.SoDT;
                        bl.Email = nv.Email;
                        bl.DiaChi = nv.DiaChi;
                        bl.Quyen = nv.Quyen;
                        bl.ChucVu = nv.ChucVu;
                        bl.MatKhau = txtMatKhauMoi1.Text;

                        if (bl.suaNhanVien())
                        {
                            MessageBox.Show("Cập nhật thành công");
                            return;
                        }
                    }
                }

                MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        // Click Cancel để hủy cập nhật
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = txtMatKhauMoi1.Text = txtMatKhauMoi2.Text = string.Empty;
        }
    }
}
