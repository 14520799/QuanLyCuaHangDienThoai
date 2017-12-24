using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataAccess;
using BusinessLogic;

namespace Presentation.Product
{
    public partial class Product_Add : Form
    {
        SanPham_BL bl = new SanPham_BL();

        public Product_Add()
        {
            InitializeComponent();
        }

        // Load danh sách hãng sản xuất
        private void Product_Add_Load(object sender, EventArgs e)
        {
            foreach(HangSanXuat hsx in bl.layHangSX())
            {
                cbTenHang.Items.Add(hsx.TenHang);
            }

            // Tạo folder Image lưu trữ hình ảnh sản phẩm
            if (!Directory.Exists("Image"))
                Directory.CreateDirectory("Image");
        }

        // Click Add để thêm sản phẩm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.HinhAnh = picHinhAnh.Text;
                sp.DonGia = decimal.Parse(txtDonGia.Text);
                sp.MoTa = txtMoTa.Text;
                sp.SoLuong = int.Parse(txtSoLuong.Text);
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

                foreach (HangSanXuat hsx in bl.layHangSX())
                {
                    if (hsx.TenHang.Equals(cbTenHang.Text))
                    {
                        sp.MaHang = hsx.MaHang;
                        break;
                    }
                }

                sp.MaLoai = bl.timMaLoai(cbTenLoai.Text);

                if (bl.themSanPham(sp))
                {
                    MessageBox.Show("Thêm thành công");
                    picHinhAnh.Image.Save(@"Image\" + picHinhAnh.Text);
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {

            }
        }
        
        // Click Load để duyệt hình ảnh sản phẩm
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(ofd.FileName);
                picHinhAnh.Text = ofd.SafeFileName;
            }
        }
    }
}
