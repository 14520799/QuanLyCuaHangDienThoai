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

namespace Presentation.Invoice
{
    public partial class Invoice_Buy_Add : Form
    {
        HoaDonMua_BL bl = new HoaDonMua_BL();

        public Invoice_Buy_Add()
        {
            InitializeComponent();
        }


        private void Invoice_Buy_Add_Load(object sender, EventArgs e)
        {
            // Khởi tạo giá trị cho các ComboBox
            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                cbMaHang.Items.Add(hsx.TenHang);
            }

            foreach (SanPham sp in bl.laySanPham(""))
            {
                cbMaSP.Items.Add(sp.TenSP);
            }

            dgvChiTietMua.AutoGenerateColumns = false;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonMua hdm = new HoaDonMua();
                hdm.MaHDM = bl.MaHDM = txtMaHDM.Text;

                foreach (HangSanXuat hsx in bl.layHangSX())
                {
                    if (hsx.TenHang.Equals(cbMaHang.Text))
                        hdm.MaHang = bl.MaHang = hsx.MaHang;
                }

                hdm.MaNV = bl.MaNV = txtMaNV.Text;
                hdm.NgayMua = bl.NgayMua = DateTime.Parse(dtNgayMua.Text);
                hdm.TongTien = bl.TongTien = decimal.Parse(txtTongTien.Text);
                hdm.TienNo = bl.TienNo = decimal.Parse(txtTienNo.Text);

                bl.themHDM(hdm);
                MessageBox.Show("Thêm thành công. Bắt đầu tạo chi tiết mua !");
                txtMaHDM.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Lỗi rồi kìa !");
                txtMaHDM.ReadOnly = false;
            }
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtMaHDM.ReadOnly = false;
            dgvChiTietMua.DataSource = null;
            Algorithm.clearInput(this);
            cbMaHang.Text = "";
            cbMaSP.Text = "";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtTienNo.Text = "0";
        }


        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            bl.TongTien = decimal.Parse(txtTongTien.Text);
        }


        private void cbMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (SanPham sp in bl.laySanPham(""))
                {
                    if (sp.TenSP.Equals(cbMaSP.Text))
                        txtDonGia.Text = sp.DonGia.ToString();
                }
                
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
            try
            {
                ChiTietMua ctm = new ChiTietMua();
                ctm.MaCTM = txtMaCTM.Text;

                foreach (SanPham sp in bl.laySanPham(""))
                {
                    if (sp.TenSP.Equals(cbMaSP.Text))
                        ctm.MaSP = sp.MaSP;
                }

                ctm.SoLuong = int.Parse(txtSoLuong.Text);
                ctm.DonGia = decimal.Parse(txtDonGia.Text);
                ctm.GiamGia = decimal.Parse(txtGiamGia.Text);
                ctm.ThanhTien = decimal.Parse(txtThanhTien.Text);

                if(txtMaHDM.Text != "")
                {
                    ctm.MaHDM = txtMaHDM.Text;
                    bl.themCTM(ctm);
                    MessageBox.Show("Thêm thành công");
                    dgvChiTietMua.DataSource = bl.xemCTM();
                    bl.TongTien += ctm.ThanhTien;
                    txtTongTien.Text = bl.TongTien.ToString();
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
                bl.xoaCTM();
                MessageBox.Show("Xóa thành công !");
            }
            catch
            {
                MessageBox.Show("Lỗi rồi kìa !");
            }
        }
    }
}
