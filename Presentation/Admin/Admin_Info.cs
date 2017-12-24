using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic;

namespace Presentation.Admin
{
    public partial class Admin_Info : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Admin_Info(string MaNV)
        {            
            InitializeComponent();
            bl.MaNV = MaNV;
        }

        // Load thông tin người đăng nhập
        private void Admin_Info_Load(object sender, EventArgs e)
        {
            foreach(NhanVien nv in bl.layNhanVien())
            {
                if (nv.MaNV.Equals(bl.MaNV))
                {
                    txtMaNV.Text = bl.MaNV;
                    txtTenNV.Text = bl.TenNV = nv.TenNV;
                    bl.NgaySinh = nv.NgaySinh;
                    dtNgaySinh.Text = bl.NgaySinh.ToString();
                    cbGioiTinh.Text = bl.GioiTinh = nv.GioiTinh;
                    txtSoDT.Text = bl.SoDT = nv.SoDT;
                    txtEmail.Text = bl.Email = nv.Email;
                    txtDiaChi.Text = bl.DiaChi = nv.DiaChi;
                    bl.Quyen = nv.Quyen;
                    bl.ChucVu = nv.ChucVu;
                    bl.MatKhau = nv.MatKhau;
                    return;
                }
            }
        }

        // Click Update để sửa thông tin quản trị viên
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bl.TenNV = txtTenNV.Text;
            bl.NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            bl.GioiTinh = cbGioiTinh.Text;
            bl.SoDT = txtSoDT.Text;
            bl.Email = txtEmail.Text;
            bl.DiaChi = txtDiaChi.Text;

            try
            {
                if (bl.suaNhanVien())
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {
                
            }
        }

        // Hủy cập nhật => Trả về giá trị ban đầu
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin_Info_Load(sender, e);
        }
    }
}
