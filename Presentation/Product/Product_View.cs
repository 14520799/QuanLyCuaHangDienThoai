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

namespace Presentation.Product
{
    public partial class Product_View : Form
    {
        SanPham_BL bl = new SanPham_BL();

        public Product_View()
        {
            InitializeComponent();
        }

        // Xem danh sách sản phẩm
        private void Product_View_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = bl.laySanPham();

            // Định dạng các giá trị trong DataGridView 
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                row.Cells[3].Value = row.Cells[3].Value.ToString().Replace(".000", "");
            }
        }

        // Click Delete để xóa sản phẩm
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl.xoaSanPham())
                {
                    MessageBox.Show("Xóa thành công");
                    dgvSanPham.DataSource = bl.laySanPham();
                }
                else
                    MessageBox.Show("Vui lòng thử lại sau");
            }
            catch
            {
                
            }
        }

        // Click Update để sửa sản phẩm
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bl.TenSP = txtTenSP.Text;
                bl.HinhAnh = picHinhAnh.Text;
                bl.DonGia = decimal.Parse(txtDonGia.Text);
                bl.MoTa = txtMoTa.Text;
                bl.SoLuong = int.Parse(txtSoLuong.Text);
                bl.ManHinh = txtManHinh.Text;
                bl.HDH = txtHDH.Text;
                bl.CameraTruoc = txtCameraTruoc.Text;
                bl.CameraSau = txtCameraSau.Text;
                bl.CPU = txtCPU.Text;
                bl.RAM = txtRAM.Text;
                bl.BoNhoTrong = txtBoNhoTrong.Text;
                bl.TheNho = txtTheNho.Text;
                bl.TheSIM = txtTheSIM.Text;
                bl.DungLuongPin = txtDungLuongPin.Text;

                foreach(HangSanXuat hsx in bl.layHangSX())
                {
                    if (hsx.TenHang.Equals(cbTenHang.Text))
                    {
                        bl.MaHang = hsx.MaHang;
                        break;
                    }
                }

                bl.MaLoai = bl.timMaLoai(cbTenLoai.Text);

                if (bl.suaSanPham())
                {
                    MessageBox.Show("Cập nhật thành công");
                    dgvSanPham.DataSource = bl.laySanPham();
                    picHinhAnh.Image.Save(@"Image\" + bl.HinhAnh);
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {
                
            }
        }

        // Sự kiện thay đổi lựa chọn trên DataGridView => Lưu trữ biến bl.MaSP
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                bl.MaSP = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                picHinhAnh.Image = Image.FromFile(Application.StartupPath + @"\Image\" + dgvSanPham.CurrentRow.Cells[2].Value.ToString());
                picHinhAnh.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtMoTa.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtManHinh.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                txtHDH.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                txtCameraTruoc.Text = dgvSanPham.CurrentRow.Cells[8].Value.ToString();
                txtCameraSau.Text = dgvSanPham.CurrentRow.Cells[9].Value.ToString();
                txtCPU.Text = dgvSanPham.CurrentRow.Cells[10].Value.ToString();
                txtRAM.Text = dgvSanPham.CurrentRow.Cells[11].Value.ToString();
                txtBoNhoTrong.Text = dgvSanPham.CurrentRow.Cells[12].Value.ToString();
                txtTheNho.Text = dgvSanPham.CurrentRow.Cells[13].Value.ToString();
                txtTheSIM.Text = dgvSanPham.CurrentRow.Cells[14].Value.ToString();
                txtDungLuongPin.Text = dgvSanPham.CurrentRow.Cells[15].Value.ToString();
                cbTenHang.Text = dgvSanPham.CurrentRow.Cells[16].Value.ToString();
                cbTenLoai.Text = dgvSanPham.CurrentRow.Cells[17].Value.ToString();
            }
        }
        
        // Click Load để duyệt hình ảnh sản phẩm
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(ofd.FileName);
                picHinhAnh.Text = ofd.SafeFileName;
            }
        }
    }
}
