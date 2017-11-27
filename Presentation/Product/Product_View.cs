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
    {   // 25:3
        SanPham_BL bl = new SanPham_BL();

        public Product_View()
        {
            InitializeComponent();
        }

        private void Product_View_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = bl.load();
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                bl.MaSP = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                picHinhAnh.Image = Image.FromFile(Application.StartupPath + @"\Image\" + dgvSanPham.CurrentRow.Cells[2].Value.ToString());
                txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtMoTa.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtManHinh.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                txtCameraTruoc.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                txtCameraSau.Text = dgvSanPham.CurrentRow.Cells[8].Value.ToString();
                txtHDH.Text = dgvSanPham.CurrentRow.Cells[9].Value.ToString();
                txtCPU.Text = dgvSanPham.CurrentRow.Cells[10].Value.ToString();
                txtRAM.Text = dgvSanPham.CurrentRow.Cells[11].Value.ToString();
                txtBoNhoTrong.Text = dgvSanPham.CurrentRow.Cells[12].Value.ToString();
                txtTheNho.Text = dgvSanPham.CurrentRow.Cells[13].Value.ToString();
                txtTheSIM.Text = dgvSanPham.CurrentRow.Cells[14].Value.ToString();
                txtDungLuongPin.Text = dgvSanPham.CurrentRow.Cells[15].Value.ToString();
                cbMaLoai.Text = dgvSanPham.CurrentRow.Cells[16].Value.ToString();
                cbMaHang.Text = dgvSanPham.CurrentRow.Cells[17].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bl.TenSP = txtTenSP.Text;
                bl.HinhAnh = picHinhAnh.Image.ToString();
                bl.SoLuong = int.Parse(txtSoLuong.Text);
                bl.DonGia = decimal.Parse(txtDonGia.Text);
                bl.MoTa = txtMoTa.Text;
                bl.ManHinh = txtManHinh.Text;
                bl.CameraTruoc = txtCameraTruoc.Text;
                bl.CameraSau = txtCameraSau.Text;
                bl.HDH = txtHDH.Text;
                bl.CPU = txtCPU.Text;
                bl.RAM = txtRAM.Text;
                bl.BoNhoTrong = txtBoNhoTrong.Text;
                bl.TheNho = txtTheNho.Text;
                bl.TheSIM = txtTheSIM.Text;
                bl.DungLuongPin = txtDungLuongPin.Text;
                bl.MaLoai = cbMaLoai.Text;
                bl.MaHang = cbMaHang.Text;

                bl.sua();
                dgvSanPham.DataSource = bl.load();
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }
    }
}
