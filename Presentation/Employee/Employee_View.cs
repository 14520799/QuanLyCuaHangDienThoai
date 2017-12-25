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
        
        // Xem danh sách nhân viên
        private void Employee_View_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;

            foreach(NhanVien nv in bl.layNhanVien())
            {
                if (nv.Quyen.Equals("Nhân viên"))
                    dgvNhanVien.Rows.Add(nv.MaNV, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.SoDT, nv.Email, nv.DiaChi, nv.ChucVu, nv.Quyen);
            }
        }

        // Click Delete để xóa nhân viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl.xoaNhanVien())
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNhanVien.DataSource = bl.layNhanVien();
                }
                else
                    MessageBox.Show("Vui lòng thử lại sau");
            }
            catch
            {

            }
        }

        // Click Update để sửa nhân viên
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
                bl.Quyen = "Nhân viên";
                bl.ChucVu = cbChucVu.Text;
                bl.MatKhau = null;

                if (bl.suaNhanVien())
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {
                
            }
        }
        
        // Sự kiện thay đổi lựa chọn trên DataGridView => Lưu trữ biến bl.MaNV
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

        // Click Cancel để hủy cập nhật
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Employee_View_Load(sender, e);
        }
    }
}
