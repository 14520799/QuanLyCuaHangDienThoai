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

namespace Presentation.Employee
{
    public partial class Employee_View : Form
    {
        NhanVien nv = new NhanVien();

        DateTime NgaySinh;
        string MaNV, TenNV, GioiTinh, SoDT, Email, DiaChi, Quyen, ChucVu, MatKhau;

        public Employee_View()
        {
            InitializeComponent();
        }

        // Lấy danh sách nhân viên
        private void Employee_View_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = nv.danhSach();
        }

        // Tìm nhân viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.timTheoTen(txtTimKiem.Text);
        }

        // Nạp thông tin nhân viên vào các TextBox khi click DataGridView
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                MaNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
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
                TenNV = txtTenNV.Text;
                NgaySinh = dtNgaySinh.Value;
                GioiTinh = cbGioiTinh.Text;
                SoDT = txtSoDT.Text;
                Email = txtEmail.Text;
                DiaChi = txtDiaChi.Text;
                Quyen = cbQuyen.Text;
                ChucVu = cbChucVu.Text;
                MatKhau = txtMatKhauMoi1.Text;

                if(Quyen == "Quản trị")
                {
                    if (txtMatKhauMoi1.Text != txtMatKhauMoi2.Text)
                        MessageBox.Show("Mật khẩu không trùng khớp !");
                    else
                        nv.capNhat(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, Email, DiaChi, Quyen, ChucVu, MatKhau);
                }
                else
                    nv.capNhat(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, Email, DiaChi, Quyen, ChucVu, "");

                dgvNhanVien.DataSource = nv.danhSach();
            }
            catch {

            }
        }
    }
}
