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
                cbTenHang.Items.Add(hsx.TenHang);
            }

            dgvChiTietMua.AutoGenerateColumns = false;
        }


        private void cbTenHang_TextChanged(object sender, EventArgs e)
        {
            cbTenSP.Text = "";
            cbTenSP.Items.Clear();
            txtSoLuong.Text = "1";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";

            foreach(HangSanXuat hsx in bl.layHangSX())
            {
                if (hsx.TenHang.Equals(cbTenHang.Text))
                {
                    bl.MaHang = hsx.MaHang;
                    break;
                }
            }

            foreach(SanPham sp in bl.laySanPham())
            {
                if (sp.MaHang.Equals(bl.MaHang))
                    cbTenSP.Items.Add(sp.TenSP);
            }
        }


        private void cbTenSP_TextChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";

            foreach (SanPham sp in bl.laySanPham())
            {
                if(sp.TenSP.Equals(cbTenSP.Text))
                {
                    bl.MaSP = sp.MaSP;
                    txtDonGia.Text = sp.DonGia.ToString();
                    txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
                    return;
                }
            }
        }


        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            bl.TongTien = decimal.Parse(txtTongTien.Text);
        }


        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != string.Empty && txtGiamGia.Text != string.Empty)
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
        }


        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != string.Empty && txtGiamGia.Text != string.Empty)
                txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtMaHDM.ReadOnly)
            {
                try
                {
                    HoaDonMua hdm = new HoaDonMua();

                    if (!bl.timMaHDM(txtMaHDM.Text))
                        hdm.MaHDM = bl.MaHDM = txtMaHDM.Text;

                    foreach (HangSanXuat hsx in bl.layHangSX())
                    {
                        if (hsx.TenHang.Equals(cbTenHang.Text))
                        {
                            hdm.MaHang = bl.MaHang = hsx.MaHang;
                            break;
                        }
                    }

                    if (bl.timMaNV(txtMaNV.Text))
                        hdm.MaNV = bl.MaNV = txtMaNV.Text;

                    hdm.NgayMua = bl.NgayMua = DateTime.Parse(dtNgayMua.Text);
                    hdm.TongTien = bl.TongTien = decimal.Parse(txtTongTien.Text);
                    hdm.TienNo = bl.TienNo = decimal.Parse(txtTienNo.Text);

                    bl.themHDM(hdm);
                    MessageBox.Show("Thêm thành công !");
                    txtMaHDM.ReadOnly = true;
                    txtMaNV.ReadOnly = true;
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi kìa !");
                }
            }



            if (bl.timMaCTM(txtMaCTM.Text))
                return;
            else
            {
                bl.TongTien += decimal.Parse(txtThanhTien.Text);
                txtTongTien.Text = bl.TongTien.ToString();
                dgvChiTietMua.Rows.Add(txtMaCTM.Text, cbTenSP.Text, txtDonGia.Text, txtSoLuong.Text, txtGiamGia.Text, txtThanhTien.Text);
                txtMaCTM.Text = cbTenSP.Text = txtSoLuong.Text = txtDonGia.Text = txtGiamGia.Text = txtThanhTien.Text = "";
            }
        }


        private void dgvChiTietMua_SelectionChanged(object sender, EventArgs e)
        {
            //bl.MaCTM = dgvChiTietMua.CurrentRow.Cells[0].Value.ToString();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvChiTietMua.Rows.RemoveAt(dgvChiTietMua.CurrentRow.Index);
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvChiTietMua.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvChiTietMua.Rows)
                {
                    try
                    {
                        ChiTietMua ctm = new ChiTietMua();
                        ctm.MaCTM = row.Cells[0].Value.ToString();

                        foreach (SanPham sp in bl.laySanPham())
                        {
                            if (sp.TenSP.Equals(row.Cells[1].Value.ToString()))
                            {
                                ctm.MaSP = sp.MaSP;
                                break;
                            }
                        }

                        ctm.DonGia = decimal.Parse(row.Cells[2].Value.ToString());
                        ctm.SoLuong = int.Parse(row.Cells[3].Value.ToString());
                        ctm.GiamGia = decimal.Parse(row.Cells[4].Value.ToString());
                        ctm.ThanhTien = decimal.Parse(row.Cells[5].Value.ToString());

                        
                        ctm.MaHDM = bl.MaHDM;
                        bl.themCTM(ctm);
                        MessageBox.Show("Thêm thành công");
                        bl.TienNo = decimal.Parse(txtTienNo.Text);
                        bl.suaHDM();
                    }
                    catch
                    {
                        MessageBox.Show("Chi tiết mua đã tồn tại");
                    }
                }
            }
            else
            {
                bl.xoaHDM();
            }
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dgvChiTietMua.DataSource = null;
            Algorithm.clearInput(this);
            cbTenHang.Text = "";
            cbTenSP.Text = "";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtTienNo.Text = "0";
            txtMaHDM.ReadOnly = false;
            txtMaNV.ReadOnly = false;
        }
    }
}
