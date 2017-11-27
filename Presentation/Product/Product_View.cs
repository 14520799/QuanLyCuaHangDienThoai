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

        private void Product_View_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = bl.danhSach();
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
            }
        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            List<string> ctsp = new List<string>();
            ctsp.Add(dgvSanPham.CurrentRow.Cells[6].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[7].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[8].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[9].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[10].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[11].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[12].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[13].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[14].Value.ToString());
            ctsp.Add(dgvSanPham.CurrentRow.Cells[15].Value.ToString());
            new Product_Detail(ctsp).Show();
        }
    }
}
