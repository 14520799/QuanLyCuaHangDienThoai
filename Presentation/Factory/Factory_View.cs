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

namespace Presentation.Factory
{
    public partial class Factory_View : Form
    {
        HangSX_BL bl = new HangSX_BL();

        public Factory_View()
        {
            InitializeComponent();
        }

        // Xem danh sách hãng sản xuất
        private void Factory_View_Load(object sender, EventArgs e)
        {
            dgvHangSX.AutoGenerateColumns = false;
            dgvSanPhamHang.AutoGenerateColumns = false;
            dgvHangSX.DataSource = bl.layHangSX();

            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                cbTenHang.Items.Add(hsx.TenHang);
            }
        }

        // Click Delete để xóa hãng sản xuất
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl.xoaHangSX())
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHangSX.DataSource = bl.layHangSX();
                }
                else
                    MessageBox.Show("Vui lòng thử lại sau");
            }
            catch
            {
                
            }
        }

        // Click Update để sửa hãng sản xuất
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bl.TenHang = cbTenHang.Text;
                bl.SoDT = txtSoDT.Text;
                bl.Email = txtEmail.Text;
                bl.DiaChi = txtDiaChi.Text;

                if (bl.suaHangSX())
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvHangSX.DataSource = bl.layHangSX();
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
                
            }
            catch
            {
                
            }
        }

        // Sự kiện thay đổi lựa chọn trên DataGridView => Lưu trữ biến bl.MaHang
        private void dgvHangSX_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHangSX.SelectedRows.Count > 0)
            {
                bl.MaHang = dgvHangSX.CurrentRow.Cells[0].Value.ToString();
                cbTenHang.Text = dgvHangSX.CurrentRow.Cells[1].Value.ToString();
                txtSoDT.Text = dgvHangSX.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvHangSX.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvHangSX.CurrentRow.Cells[4].Value.ToString();

                try
                {
                    dgvSanPhamHang.DataSource = bl.spTheoMaHang(bl.MaHang);

                    // Định dạng các giá trị trong DataGridView 
                    foreach (DataGridViewRow row in dgvSanPhamHang.Rows)
                    {
                        row.Cells[2].Value = row.Cells[2].Value.ToString().Replace(".000", "");
                    }
                }
                catch
                {

                }
            }
        }
        
        // Clear các input
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Algorithm.clearInput(this);
        }
    }
}
