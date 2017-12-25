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

        // Xem danh sách khách hàng
        private void Customer_View_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = bl.layKhachHang();

            // Định dạng các giá trị trong DataGridView 
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                row.Cells[7].Value = row.Cells[7].Value.ToString().Replace(".000", "");
            }
        }

        // Click Delete để xóa khách hàng
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl.xoaKhachHang())
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKhachHang.DataSource = bl.layKhachHang();
                }
                else
                    MessageBox.Show("Vui lòng thử lại sau");
            }
            catch
            {
                
            }
        }
        
        // Click Update để sửa khách hàng
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

                if (bl.suaKhachHang())
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvKhachHang.DataSource = bl.layKhachHang();
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {
                
            }
        }

        // Sự kiện thay đổi lựa chọn trên DataGridView => Lưu trữ biến bl.MaKH
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

        // Click Cancel để hủy cập nhật
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Customer_View_Load(sender, e);
        }
    }
}