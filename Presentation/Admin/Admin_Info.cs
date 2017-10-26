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
        NhanVien nv = new NhanVien();
        NhanVien_BL bl = new NhanVien_BL();

        public Admin_Info(string MaNV)
        {            
            InitializeComponent();
            bl.MaNV = MaNV;
        }

        private void Admin_Info_Load(object sender, EventArgs e)
        {
            nv = bl.timTheoID(bl.MaNV);
            txtHoTen.Text = nv.TenNV;
            cbGioiTinh.Text = nv.GioiTinh;
            txtSoDT.Text = nv.SoDT;
            txtEmail.Text = nv.Email;
            txtDiaChi.Text = nv.DiaChi;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bl.TenNV = txtHoTen.Text;
            bl.NgaySinh = nv.NgaySinh;
            bl.GioiTinh = nv.GioiTinh;
            bl.SoDT = txtSoDT.Text;
            bl.Email = txtEmail.Text;
            bl.DiaChi = txtDiaChi.Text;
            bl.ChucVu = nv.ChucVu;
            bl.MatKhau = nv.MatKhau;
            bl.capNhat();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
