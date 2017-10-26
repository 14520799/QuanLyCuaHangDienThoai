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

namespace Presentation.Customer
{
    public partial class Customer_Add : Form
    {
        KhachHang_BL bl = new KhachHang_BL();

        public Customer_Add()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.GioiTinh = cbGioiTinh.Text;
                kh.SoDT = txtSoDT.Text;
                kh.Email = txtEmail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.TienNo = Decimal.Parse(txtTienNo.Text);
                kh.LoaiKH = cbLoaiKH.Text;

                bl.them(kh);
                MessageBox.Show("Thêm khách hàng thành công !");
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }
    }
}
