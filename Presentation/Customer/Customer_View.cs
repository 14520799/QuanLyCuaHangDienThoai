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

namespace Presentation.Customer
{
    public partial class Customer_View : Form
    {
        KhachHang_BL kh = new KhachHang_BL();

        public Customer_View()
        {
            InitializeComponent();

        }

        // Lấy danh sách khách hàng
        private void Customer_View_Load(object sender, EventArgs e)
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.DataSource = kh.danhSach();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                kh.TenKH = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.GioiTinh = cbGioiTinh.Text;
                kh.SoDT = txtSoDT.Text;
                kh.Email = txtEmail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.TienNo = decimal.Parse(txtSoTienNo.Text);
                kh.LoaiKH = cbLoaiKH.Text;
                kh.capNhat();
                dgvDanhSach.DataSource = kh.danhSach();
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                kh.xoa();
                dgvDanhSach.DataSource = kh.danhSach();
                MessageBox.Show("Xóa thành công !");
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }
    }
}
