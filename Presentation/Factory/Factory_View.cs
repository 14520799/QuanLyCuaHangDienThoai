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

namespace Presentation.Factory
{
    public partial class Factory_View : Form
    {
        HangSX_BL bl = new HangSX_BL();

        public Factory_View()
        {
            InitializeComponent();
        }


        private void Factory_View_Load(object sender, EventArgs e)
        {
            dgvHangSX.AutoGenerateColumns = false;
            dgvHangSX.DataSource = bl.read();

            foreach (HangSanXuat hsx in bl.read())
            {
                cbTenHang.Items.Add(hsx.TenHang);
            }
        }


        private void dgvHangSX_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHangSX.SelectedRows.Count > 0)
            {
                bl.MaHang = dgvHangSX.CurrentRow.Cells[0].Value.ToString();
                cbTenHang.Text = dgvHangSX.CurrentRow.Cells[1].Value.ToString();
                txtSoDT.Text = dgvHangSX.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvHangSX.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvHangSX.CurrentRow.Cells[4].Value.ToString();
            }

            try
            {
                dgvSanPhamHang.AutoGenerateColumns = false;
                dgvSanPhamHang.DataSource = bl.sanPhamHang(bl.MaHang);

                foreach (DataGridViewRow row in dgvSanPhamHang.Rows)
                {
                    switch (row.Cells[0].Value.ToString())
                    {
                        case "HSX01":
                            row.Cells[0].Value = "iPhone";
                            break;
                        case "HSX02":
                            row.Cells[0].Value = "Samsung";
                            break;
                        case "HSX03":
                            row.Cells[0].Value = "OPPO";
                            break;
                        case "HSX04":
                            row.Cells[0].Value = "Nokia";
                            break;
                        case "HSX05":
                            row.Cells[0].Value = "Zenfone";
                            break;
                        case "HSX06":
                            row.Cells[0].Value = "Philips";
                            break;
                        case "HSX07":
                            row.Cells[0].Value = "Mobiistar";
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {

            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bl.TenHang = cbTenHang.Text;
                bl.SoDT = txtSoDT.Text;
                bl.Email = txtEmail.Text;
                bl.DiaChi = txtDiaChi.Text;

                bl.update();
                MessageBox.Show("Sửa thành công !");
                dgvHangSX.DataSource = bl.read();
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
                bl.delete();
                dgvHangSX.DataSource = bl.read();
                MessageBox.Show("Xóa thành công !");
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }
    }
}
