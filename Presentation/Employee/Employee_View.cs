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
    public partial class Employee_View : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Employee_View()
        {
            InitializeComponent();
        }


        // Lấy danh sách nhân viên
        private void Employee_View_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = bl.danhSach();
        }


        // Tìm nhân viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cbTheoLoai.Text == "Tên NV")
                dgvNhanVien.DataSource = bl.timTheoTen(txtTimKiem.Text);
            else if(cbTheoLoai.Text == "Quyen")
                dgvNhanVien.DataSource = bl.timTheoQuyen(txtTimKiem.Text);
            else
                dgvNhanVien.DataSource = bl.timTheoChucVu(txtTimKiem.Text);

            if (dgvNhanVien.RowCount == 0)
                MessageBox.Show("Không có kết quả phù hợp !");
        }


        // Nạp thông tin nhân viên vào các TextBox khi click DataGridView
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                bl.MaNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                dtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtSoDT.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                cbQuyen.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                cbChucVu.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            }
        }


        // Sửa thông tin nhân viên
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bl.TenNV = txtTenNV.Text;
                bl.NgaySinh = dtNgaySinh.Value;
                bl.GioiTinh = cbGioiTinh.Text;
                bl.SoDT = txtSoDT.Text;
                bl.Email = txtEmail.Text;
                bl.DiaChi = txtDiaChi.Text;
                bl.Quyen = cbQuyen.Text;
                bl.ChucVu = cbChucVu.Text;

                bl.capNhat();
                dgvNhanVien.DataSource = bl.danhSach();
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }


        // Xóa nhân viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Xác nhận xóa ?");

            try
            {
                bl.xoa();
                dgvNhanVien.DataSource = bl.danhSach();
                MessageBox.Show("Xóa thành công !");
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }
    }
}
