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

        // Lấy danh sách hãng sản xuất
        private void Invoice_Buy_Add_Load(object sender, EventArgs e)
        {
            dgvChiTietMua.AutoGenerateColumns = false;

            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                cbTenHang.Items.Add(hsx.TenHang);
            }
        }

        // Click Add để thêm hóa đơn mua + thêm chi tiết mua vào DataGridView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtMaHDM.ReadOnly) // Nếu hóa đơn mua chưa được tạo
                {
                    foreach(HoaDonMua item in bl.layHDM())
                    {
                        if (item.MaHDM.Equals(txtMaHDM.Text))
                        {
                            MessageBox.Show("Mã HDM đã tồn tại");
                            return;
                        }
                    }

                    HoaDonMua hdm = new HoaDonMua();
                    hdm.MaHDM = bl.MaHDM = txtMaHDM.Text;

                    foreach (HangSanXuat hsx in bl.layHangSX())
                    {
                        if (hsx.TenHang.Equals(cbTenHang.Text))
                        {
                            hdm.MaHang = bl.MaHang = hsx.MaHang;
                            break;
                        }
                    }

                    foreach(NhanVien nv in bl.layNhanVien())
                    {
                        if (nv.MaNV.Equals(txtMaNV.Text))
                        {
                            hdm.MaNV = bl.MaNV = txtMaNV.Text;
                            break;
                        }
                    }
                        
                    hdm.NgayMua = bl.NgayMua = DateTime.Parse(dtNgayMua.Text);
                    hdm.TongTien = bl.TongTien = decimal.Parse(txtTongTien.Text);
                    hdm.TienNo = bl.TienNo = decimal.Parse(txtTienNo.Text);

                    // Mã HDM readonly nếu được tạo thành công
                    // Không được phép chỉnh sửa nếu đã tạo hóa đơn mua
                    if (bl.themHDM(hdm))
                    {
                        MessageBox.Show("Thêm thành công");
                        txtMaHDM.ReadOnly = true;    
                        txtMaNV.ReadOnly = true;    
                    }
                    else
                        MessageBox.Show("Vui lòng kiểm tra lại");
                }

                foreach (ChiTietMua ctm in bl.layCTM())
                {
                    if (ctm.MaCTM.Equals(txtMaCTM.Text))
                    {
                        MessageBox.Show("Mã CTM đã tồn tại");
                        return;
                    }
                }

                foreach (DataGridViewRow row in dgvChiTietMua.Rows)
                {
                    if (row.Cells[0].Value.Equals(txtMaCTM.Text))
                    {
                        MessageBox.Show("Mã CTM đã tồn tại");
                        return;
                    }
                }

                bl.TongTien += decimal.Parse(txtThanhTien.Text);
                txtTongTien.Text = bl.TongTien.ToString();
                dgvChiTietMua.Rows.Add(txtMaCTM.Text, cbTenSP.Text, txtDonGia.Text, txtSoLuong.Text, txtGiamGia.Text, txtThanhTien.Text);
                txtMaCTM.Text = string.Empty;
                cbTenSP.Text = string.Empty;
                txtSoLuong.Text = "1";
                txtDonGia.Text = "0";
                txtGiamGia.Text = "0";
                txtThanhTien.Text = "0";
            }
            catch
            {

            }
        }

        // Click Delete để xóa một chi tiết mua khỏi DataGridView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvChiTietMua.Rows.Remove(dgvChiTietMua.CurrentRow);
        }

        // Click Submit để thêm tất cả chi tiết mua trong DataGridView
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietMua.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in dgvChiTietMua.Rows)
                    {
                        ChiTietMua ctm = new ChiTietMua();
                        ctm.MaCTM = row.Cells[0].Value.ToString();

                        foreach (SanPham sp in bl.laySanPham())
                        {
                            if (sp.TenSP.Equals(row.Cells[1].Value))
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

                        if (bl.themCTM(ctm))
                            MessageBox.Show("Thêm " + ctm.MaCTM + " thành công");
                        else
                            MessageBox.Show("Vui lòng kiểm tra " + ctm.MaCTM);
                    }

                    // Cập nhật tổng tiền + tiền nợ của hóa đơn mua
                    bl.TienNo = decimal.Parse(txtTienNo.Text);

                    if (bl.suaHDM())
                        MessageBox.Show("Thêm hóa đơn thành công");
                    else
                        MessageBox.Show("Vui lòng kiểm tra lại");
                }
            }
            catch
            {

            }
        }

        // Click AddNew để clear các input
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dgvChiTietMua.DataSource = null;
            Algorithm.clearInput(this);
            txtSoLuong.Text = "1";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtTienNo.Text = "0";

            // Cho phép thêm hóa đơn mua
            txtMaHDM.ReadOnly = false;
            txtMaNV.ReadOnly = false;
        }

        // Sự kiện khi thay đổi tên hãng sản xuất
        private void cbTenHang_TextChanged(object sender, EventArgs e)
        {
            cbTenSP.Text = string.Empty;
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

        // Sự kiện khi thay đổi tên sản phẩm
        private void cbTenSP_TextChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtGiamGia.Text = "0";

            foreach (SanPham sp in bl.laySanPham())
            {
                if(sp.TenSP.Equals(cbTenSP.Text))
                {
                    bl.MaSP = sp.MaSP;
                    txtDonGia.Text = sp.DonGia.ToString();
                    txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * decimal.Parse(txtDonGia.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
                    return;
                }
            }
        }

        // Sự kiện khi thay đổi số lượng
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (!txtSoLuong.Text.Equals(string.Empty) && !txtGiamGia.Text.Equals(string.Empty))
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * decimal.Parse(txtDonGia.Text) - decimal.Parse(txtGiamGia.Text)).ToString();
        }

        // Sự kiện khi thay đổi giảm giá
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            txtSoLuong_TextChanged(sender, e);
        }

        // Tính tổng tiền khi thêm một chi tiết mua
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            bl.TongTien = decimal.Parse(txtTongTien.Text);
        }
    }
}
