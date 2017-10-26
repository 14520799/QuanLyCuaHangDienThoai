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
        NhanVien nv = new NhanVien();
        NhanVien_BL bl = new NhanVien_BL();

        public Admin_Pass(string MaNV)
        {
            InitializeComponent();
            bl.MaNV = MaNV;
        }

        private void Admin_Pass_Load(object sender, EventArgs e)
        {
            nv = bl.timTheoID(bl.MaNV);
            txtMaNV.Text = nv.MaNV;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauCu.Text == nv.MatKhau && txtMatKhauMoi1.Text == txtMatKhauMoi2.Text)
                {
                    bl.TenNV = nv.TenNV;
                    bl.NgaySinh = nv.NgaySinh;
                    bl.GioiTinh = nv.GioiTinh;
                    bl.SoDT = nv.SoDT;
                    bl.Email = nv.Email;
                    bl.DiaChi = nv.DiaChi;
                    bl.ChucVu = nv.ChucVu;
                    bl.MatKhau = txtMatKhauMoi1.Text;
                    bl.capNhat();
                    MessageBox.Show("Đổi mật khẩu thành công !");
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu !");
                }
            }
            catch
            {

            }
        }
    }
}
