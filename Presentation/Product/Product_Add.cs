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
using System.IO;

namespace Presentation.Product
{
    public partial class Product_Add : Form
    {
        SanPham_BL bl = new SanPham_BL();
        Image img;

        public Product_Add()
        {
            InitializeComponent();
        }

        // Thêm sản phẩm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.MaSP = txtMaSP.Text;
            sp.HinhAnh = picHinhAnh.Text;
            sp.MaSP = txtMaSP.Text;
            sp.MoTa = txtMoTa.Text;
            sp.ManHinh = txtManHinh.Text;
            sp.HDH = txtHDH.Text;
            sp.CameraTruoc = txtCameraTruoc.Text;
            sp.CameraSau = txtCameraSau.Text;
            sp.CPU = txtCPU.Text;
            sp.RAM = txtRAM.Text;
            sp.BoNhoTrong = txtBoNhoTrong.Text;
            sp.TheNho = txtTheNho.Text;
            sp.TheSIM = txtTheSIM.Text;
            sp.DungLuongPin = txtDungLuongPin.Text;
            sp.MaLoai = cbMaLoai.Text;
            sp.MaHang = cbMaHang.Text;

            if (!Directory.Exists("Image"))
                Directory.CreateDirectory("Image");
            img.Save(@"Image\" + picHinhAnh.Text);
            try
            {
                bl.them(sp);
                MessageBox.Show("Thêm thành công...");
            }
            catch
            {
                MessageBox.Show("Lỗi gì đó...");
            }
        }


        // Load hình ảnh sản phẩm
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(ofd.FileName);
                picHinhAnh.Image = img;
                picHinhAnh.Text = ofd.SafeFileName;
            }
        }
    }
}
