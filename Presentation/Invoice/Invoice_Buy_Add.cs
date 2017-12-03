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

namespace Presentation.Invoice
{
    public partial class Invoice_Buy_Add : Form
    {
        HoaDonMua_BL bl = new HoaDonMua_BL();
        decimal tongTien = 0;

        public Invoice_Buy_Add()
        {
            InitializeComponent();
        }


        private void Invoice_Buy_Add_Load(object sender, EventArgs e)
        {
            foreach (HangSanXuat hsx in bl.readHangSX())
            {
                cbMaHang.Items.Add(hsx.TenHang);
            }
        }

        
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dgvChiTietMua.DataSource = null;
            dgvChiTietMua.AutoGenerateColumns = false;
            HoaDonMua hdm = new HoaDonMua();

            try
            {
                hdm.MaHDM = txtMaHDM.Text;
                hdm.MaHang = bl.findMaHang(cbMaHang.Text);
                hdm.MaNV = txtMaNV.Text;
                hdm.NgayMua = DateTime.Parse(dtNgayMua.Text);
                hdm.TongTien = int.Parse(txtTongTien.Text);
                hdm.TienNo = int.Parse(txtTienNo.Text);

                bl.createHDM(hdm);
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Đã tồn tại");
            }
        }


        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDonGia.Text = bl.findSanPham(txtMaSP.Text).DonGia.ToString();
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * decimal.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
            }
            catch
            {

            }
        }


        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * decimal.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
            }
            catch
            {

            }
        }


        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * decimal.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
            }
            catch
            {

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChiTietMua ctm = new ChiTietMua();

            try
            {
                ctm.MaCTM = txtMaCTM.Text;
                ctm.MaSP = txtMaSP.Text;
                ctm.SoLuong = int.Parse(txtSoLuong.Text);
                ctm.DonGia = decimal.Parse(txtDonGia.Text);
                ctm.GiamGia = decimal.Parse(txtGiamGia.Text);
                ctm.ThanhTien = decimal.Parse(txtThanhTien.Text);
                if(txtMaHDM.Text != "")
                {
                    ctm.MaHDM = txtMaHDM.Text;
                    bl.createCTM(ctm);
                    MessageBox.Show("Thêm thành công");
                    dgvChiTietMua.DataSource = bl.readCTM();


                    foreach (ChiTietMua item in bl.readCTM())
                    {
                        tongTien += item.ThanhTien;
                    }

                    txtTongTien.Text = tongTien.ToString();
                }
                else
                    MessageBox.Show("Mã HDM trống !");
            }
            catch
            {
                MessageBox.Show("Đã tồn tại");
            }
        }


        private void dgvChiTietMua_SelectionChanged(object sender, EventArgs e)
        {
            bl.MaCTM = dgvChiTietMua.CurrentRow.Cells[0].Value.ToString();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bl.deleteCTM();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {

            }
        }
    }
}
