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
        KhachHang_BL bl = new KhachHang_BL();

        public Customer_View()
        {
            InitializeComponent();

        }

        // Lấy danh sách khách hàng
        private void Customer_View_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = bl.danhSach();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                bl.MaKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                dtNgaySinh.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                cbGioiTinh.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                txtSoDT.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
                txtTienNo.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
                cbLoaiKH.Text = dgvKhachHang.CurrentRow.Cells[8].Value.ToString();
            }
        }

        // Sửa khách hàng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bl.TenKH = txtTenKH.Text;
                bl.NgaySinh = dtNgaySinh.Value;
                bl.GioiTinh = cbGioiTinh.Text;
                bl.SoDT = txtSoDT.Text;
                bl.Email = txtEmail.Text;
                bl.DiaChi = txtDiaChi.Text;
                bl.TienNo = decimal.Parse(txtTienNo.Text);
                bl.LoaiKH = cbLoaiKH.Text;

                bl.capNhat();
                dgvKhachHang.DataSource = bl.danhSach();
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
                bl.xoa();
                dgvKhachHang.DataSource = bl.danhSach();
                MessageBox.Show("Xóa thành công !");
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }


        // Tìm kiếm khách hàng
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Theo tên KH
            if(cbTheoLoai.Text == "Tên KH")
                dgvKhachHang.DataSource = bl.timTheoTen(txtTimKiem.Text);
            else if(cbTheoLoai.Text == "Loại KH")
                dgvKhachHang.DataSource = bl.timTheoLoai(txtTimKiem.Text);
            else
                dgvKhachHang.DataSource = bl.timTheoNo();
        }
    }
}
// Các dạng của hê thống thông tin
// Tông quan ve pp phat trien phan mem SDLC