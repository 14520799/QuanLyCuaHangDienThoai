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

        // Lấy danh sách hãng sản xuất
        private void Invoice_Sale_Add_Load(object sender, EventArgs e)
        {
            dgvChiTietBan.AutoGenerateColumns = false;

            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                cbTenHang.Items.Add(hsx.TenHang);
            }
        }

        // Click Add để thêm hóa đơn bán + thêm chi tiết bán vào DataGridView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtMaHDB.ReadOnly) // Nếu hóa đơn bán chưa được tạo
                {
                    foreach (HoaDonBan item in bl.layHDB())
                    {
                        if (item.MaHDB.Equals(txtMaHDB.Text))
                        {
                            MessageBox.Show("Mã HDB đã tồn tại");
                            return;
                        }
                    }

                    HoaDonBan hdb = new HoaDonBan();
                    hdb.MaHDB = bl.MaHDB = txtMaHDB.Text;

                    foreach (NhanVien nv in bl.layNhanVien())
                    {
                        if (nv.MaNV.Equals(txtMaNV.Text))
                        {
                            hdb.MaNV = bl.MaNV = txtMaNV.Text;
                            break;
                        }
                    }

                    foreach (KhachHang kh in bl.layKhachHang())
                    {
                        if (kh.MaKH.Equals(txtMaKH.Text))
                        {
                            hdb.MaKH = bl.MaKH = txtMaKH.Text;
                            break;
                        }
                    }
                    
                    hdb.NgayBan = bl.NgayBan = DateTime.Parse(dtNgayBan.Text);
                    hdb.TongTien = bl.TongTien = decimal.Parse(txtTongTien.Text);
                    hdb.TienNo = bl.TienNo = decimal.Parse(txtTienNo.Text);

                    // Mã HDB readonly nếu được tạo thành công
                    // Không được phép chỉnh sửa nếu đã tạo hóa đơn bán
                    if (bl.themHDB(hdb))
                    {
                        MessageBox.Show("Thêm thành công");
                        txtMaHDB.ReadOnly = true;   
                        txtMaNV.ReadOnly = true;    
                        txtMaKH.ReadOnly = true;
                    }
                    else
                        MessageBox.Show("Vui lòng kiểm tra lại");
                }

                foreach (ChiTietBan ctb in bl.layCTB())
                {
                    if (ctb.MaCTB.Equals(txtMaCTB.Text))
                    {
                        MessageBox.Show("Mã CTB đã tồn tại");
                        return;
                    }
                }

                foreach (DataGridViewRow row in dgvChiTietBan.Rows)
                {
                    if (row.Cells[0].Value.Equals(txtMaCTB.Text))
                    {
                        MessageBox.Show("Mã CTB đã tồn tại");
                        return;
                    }
                }

                bl.TongTien += decimal.Parse(txtThanhTien.Text);
                txtTongTien.Text = bl.TongTien.ToString();
                dgvChiTietBan.Rows.Add(txtMaCTB.Text, cbTenSP.Text, txtDonGia.Text, txtSoLuong.Text, txtGiamGia.Text, txtThanhTien.Text);
                txtMaCTB.Text = string.Empty;
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

        // Click Delete để xóa một chi tiết bán khỏi DataGridView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvChiTietBan.Rows.Remove(dgvChiTietBan.CurrentRow);
        }

        // Click Submit để thêm tất cả chi tiết bán trong DataGridView
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietBan.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in dgvChiTietBan.Rows)
                    {
                        ChiTietBan ctb = new ChiTietBan();
                        ctb.MaCTB = row.Cells[0].Value.ToString();

                        foreach (SanPham sp in bl.laySanPham())
                        {
                            if (sp.TenSP.Equals(row.Cells[1].Value))
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

                        if (bl.themCTB(ctb))
                            MessageBox.Show("Thêm " + ctb.MaCTB + " thành công");
                        else
                            MessageBox.Show("Vui lòng kiểm tra " + ctb.MaCTB);
                    }

                    // Cập nhật tổng tiền + tiền nợ của hóa đơn bán
                    bl.TienNo = decimal.Parse(txtTienNo.Text);

                    if (bl.suaHDB())
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
            dgvChiTietBan.DataSource = null;
            Algorithm.clearInput(this);
            txtSoLuong.Text = "1";
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtTienNo.Text = "0";

            // Cho phép thêm hóa đơn bán
            txtMaHDB.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            txtMaKH.ReadOnly = false;
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

            foreach (HangSanXuat hsx in bl.layHangSX())
            {
                if (hsx.TenHang.Equals(cbTenHang.Text))
                {
                    foreach (SanPham sp in bl.laySanPham())
                    {
                        if (sp.MaHang.Equals(hsx.MaHang))
                            cbTenSP.Items.Add(sp.TenSP);
                    }

                    return;
                }
            }
        }

        // Sự kiện khi thay đổi tên sản phẩm
        private void cbTenSP_TextChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtGiamGia.Text = "0";

            foreach (SanPham sp in bl.laySanPham())
            {
                if (sp.TenSP.Equals(cbTenSP.Text))
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

        // Tính tổng tiền khi thêm một chi tiết bán
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            bl.TongTien = decimal.Parse(txtTongTien.Text);
        }
    }
}
