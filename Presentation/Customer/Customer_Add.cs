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
using Function;

namespace Presentation.Customer
{
    public partial class Customer_Add : Form
    {
        KhachHang_BL bl = new KhachHang_BL();

        public Customer_Add()
        {
            InitializeComponent();
        }

        // Click Add để thêm khách hàng
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

                if (bl.themKhachHang(kh))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {
                
            }
        }

        // Clear các input
        private void btnClear_Click(object sender, EventArgs e)
        {
            Algorithm.clearInput(this);
        }
    }
}
