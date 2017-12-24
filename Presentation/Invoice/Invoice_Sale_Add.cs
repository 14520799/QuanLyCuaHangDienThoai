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
    public partial class Invoice_Sale_Add : Form
    {
        HoaDonBan_BL bl = new HoaDonBan_BL();

        public Invoice_Sale_Add()
        {
            InitializeComponent();
        }

        private void Invoice_Sale_Add_Load(object sender, EventArgs e)
        {
            // Khởi tạo giá trị cho các ComboBox
            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                cbTenHang.Items.Add(hsx.TenHang);
            }

            dgvChiTietBan.AutoGenerateColumns = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtMaHDB.ReadOnly)
            {
                try
                {
                    HoaDonBan hdb = new HoaDonBan();

                    if (!bl.timMaHDB(txtMaHDB.Text) && bl.timMaNV(txtMaNV.Text) && bl.timMaKH(txtMaKH.Text))
                    {
                        hdb.MaHDB = bl.MaHDB = txtMaHDB.Text;
                        hdb.MaNV = bl.MaNV = txtMaNV.Text;
                        hdb.MaKH = bl.MaKH = txtMaKH.Text;
                    }
                        

                    hdb.NgayBan = bl.NgayBan = DateTime.Parse(dtNgayBan.Text);
                    hdb.TongTien = bl.TongTien = decimal.Parse(txtTongTien.Text);
                    hdb.TienNo = bl.TienNo = decimal.Parse(txtTienNo.Text);

                    bl.themHDB(hdb);
                    MessageBox.Show("Thêm thành công !");
                    txtMaHDB.ReadOnly = true;
                    txtMaNV.ReadOnly = true;
                    txtMaKH.ReadOnly = true;
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi kìa !");
                }
            }

            if (bl.timMaCTB(txtMaCTB.Text))
                MessageBox.Show("Chi tiết bán đã tồn tại !");
            else
            {
                bl.TongTien += decimal.Parse(txtThanhTien.Text);
                txtTongTien.Text = bl.TongTien.ToString();
                dgvChiTietBan.Rows.Add(txtMaCTB.Text, cbTenSP.Text, txtDonGia.Text, txtSoLuong.Text, txtGiamGia.Text, txtThanhTien.Text);
                txtMaCTB.Text = cbTenHang.Text = cbTenSP.Text = txtSoLuong.Text = txtDonGia.Text = txtGiamGia.Text = txtThanhTien.Text = string.Empty;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvChiTietBan.Rows.RemoveAt(dgvChiTietBan.CurrentRow.Index);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvChiTietBan.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvChiTietBan.Rows)
                {
                    try
                    {
                        ChiTietBan ctb = new ChiTietBan();
                        ctb.MaCTB = row.Cells[0].Value.ToString();

                        foreach (SanPham sp in bl.laySanPham())
                        {
                            if (sp.TenSP.Equals(row.Cells[1].Value.ToString()))
                            {
                                ctb.MaSP = sp.MaSP;
                                break;
                            }
                        }

                        ctb.DonGia = decimal.Parse(row.Cells[2].Value.ToString());
                        ctb.SoLuong = int.Parse(row.Cells[3].Value.ToString());
                        ctb.GiamGia = decimal.Parse(row.Cells[4].Value.ToString());
                        ctb.ThanhTien = decimal.Parse(row.Cells[5].Value.ToString());


                        ctb.MaHDB = bl.MaHDB;
                        bl.themCTB(ctb);
                        MessageBox.Show("Thêm thành công");
                        bl.TienNo = decimal.Parse(txtTienNo.Text);
                        bl.suaHDB();
                    }
                    catch
                    {
                        MessageBox.Show("Chi tiết bán đã tồn tại");
                    }
                }
            }
            else
            {
                bl.xoaHDB();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dgvChiTietBan.DataSource = null;
            Algorithm.clearInput(this);
            cbTenHang.Text = "";
            cbTenSP.Text = "";
            txtDonGia.Text = "0";
            txtSoLuong.Text = "1";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtTienNo.Text = "0";
            txtMaHDB.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            txtMaKH.ReadOnly = false;
        }

        private void cbTenHang_TextChanged(object sender, EventArgs e)
        {
            cbTenSP.Text = "";
            cbTenSP.Items.Clear();
            txtSoLuong.Text = "1";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";

            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                if (hsx.TenHang.Equals(cbTenHang.Text))
                {
                    foreach (SanPham sp in bl.laySanPham())
                    {
                        if (sp.MaHang.Equals(hsx.MaHang))
                            cbTenSP.Items.Add(sp.TenSP);
                    }

                    break;
                }
            }
        }

        private void cbTenSP_TextChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";

            foreach (SanPham sp in bl.laySanPham())
            {
                if (sp.TenSP.Equals(cbTenSP.Text))
                {
                    bl.MaSP = sp.MaSP;
                    txtDonGia.Text = sp.DonGia.ToString();
                    txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
                    return;
                }
            }
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

        private void dgvChiTietBan_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
