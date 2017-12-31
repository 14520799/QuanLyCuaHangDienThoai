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

namespace Presentation.Statistic
{
    public partial class Statistic_View : Form
    {
        ThongKe_BL bl = new ThongKe_BL();

        public Statistic_View()
        {
            InitializeComponent();
        }

        private void Statistic_View_Load(object sender, EventArgs e)
        {
            dgvThongKe.RowHeadersVisible = false;
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.AutoGenerateColumns = false;
            dgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        string tensp, tenhang;

        private void btnXuat_Click(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();
            dgvThongKe.DataSource = null;

            switch (cbLoaiHD.Text)
            {
                case "Thống kê mua":
                    {
                        DataGridViewTextBoxColumn ThangMua = new DataGridViewTextBoxColumn();
                        ThangMua.DataPropertyName = "ThangMua";
                        ThangMua.HeaderText = "Tháng mua";

                        DataGridViewTextBoxColumn TenSP = new DataGridViewTextBoxColumn();
                        TenSP.DataPropertyName = "TenSP";
                        TenSP.HeaderText = "Tên SP";

                        DataGridViewTextBoxColumn TenHang = new DataGridViewTextBoxColumn();
                        TenHang.DataPropertyName = "TenHang";
                        TenHang.HeaderText = "Tên Hãng";

                        DataGridViewTextBoxColumn TongSoLuong = new DataGridViewTextBoxColumn();
                        TongSoLuong.DataPropertyName = "TongSoLuong";
                        TongSoLuong.HeaderText = "Tổng Số Lượng";

                        DataGridViewTextBoxColumn TongTienMua = new DataGridViewTextBoxColumn();
                        TongTienMua.DataPropertyName = "TongTienMua";
                        TongTienMua.HeaderText = "Tổng tiền mua";

                        dgvThongKe.Columns.AddRange(new DataGridViewColumn[] { ThangMua, TenSP, TenHang, TongSoLuong, TongTienMua });

                        foreach (ChiTietMua ctm in bl.ctmTheoThang(cbThang.Text))
                        {
                            foreach (SanPham sp in bl.laySanPham())
                            {
                                if (sp.MaSP.Equals(ctm.MaSP))
                                {
                                    tensp = sp.TenSP;
                                    foreach (HangSanXuat hsx in bl.layHangSX())
                                    {
                                        if (sp.MaHang.Equals(hsx.MaHang))
                                        {
                                            tenhang = hsx.TenHang;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }

                            dgvThongKe.Rows.Add(cbThang.Text, tensp, tenhang, ctm.SoLuong, ctm.ThanhTien);
                        }

                        txtTongNo.Text = bl.tongNoMua(cbThang.Text).ToString("N0");
                        txtTongTien.Text = bl.tongTienMua(cbThang.Text).ToString("N0");
                    }
                    break;

                case "Thống kê bán":
                    {
                        DataGridViewTextBoxColumn ThangBan = new DataGridViewTextBoxColumn();
                        ThangBan.DataPropertyName = "ThangBan";
                        ThangBan.HeaderText = "Tháng bán";

                        DataGridViewTextBoxColumn TenSP = new DataGridViewTextBoxColumn();
                        TenSP.DataPropertyName = "TenSP";
                        TenSP.HeaderText = "Tên SP";

                        DataGridViewTextBoxColumn TenHang = new DataGridViewTextBoxColumn();
                        TenHang.DataPropertyName = "TenHang";
                        TenHang.HeaderText = "Tên Hãng";

                        DataGridViewTextBoxColumn TongSoLuong = new DataGridViewTextBoxColumn();
                        TongSoLuong.DataPropertyName = "TongSoLuong";
                        TongSoLuong.HeaderText = "Tổng Số Lượng";

                        DataGridViewTextBoxColumn TongTienBan = new DataGridViewTextBoxColumn();
                        TongTienBan.DataPropertyName = "TongTienBan";
                        TongTienBan.HeaderText = "Tổng tiền bán";

                        dgvThongKe.Columns.AddRange(new DataGridViewColumn[] { ThangBan, TenSP, TenHang, TongSoLuong, TongTienBan });

                        foreach (ChiTietBan ctb in bl.ctbTheoThang(cbThang.Text))
                        {
                            foreach (SanPham sp in bl.laySanPham())
                            {
                                if (sp.MaSP.Equals(ctb.MaSP))
                                {
                                    tensp = sp.TenSP;
                                    foreach (HangSanXuat hsx in bl.layHangSX())
                                    {
                                        if (sp.MaHang.Equals(hsx.MaHang))
                                        {
                                            tenhang = hsx.TenHang;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }

                            dgvThongKe.Rows.Add(cbThang.Text, tensp, tenhang, ctb.SoLuong, ctb.ThanhTien);
                        }

                        txtTongNo.Text = bl.tongNoBan(cbThang.Text).ToString("N0");
                        txtTongTien.Text = bl.tongTienBan(cbThang.Text).ToString("N0");
                    }
                    break;

                default:
                    break;
            }
        }

        private void cbThang_TextChanged(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();
            dgvThongKe.DataSource = null;
            txtTongTien.Text = "0";
            txtTongNo.Text = "0";
        }

        private void cbLoaiHD_TextChanged(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();
            dgvThongKe.DataSource = null;
            txtTongTien.Text = "0";
            txtTongNo.Text = "0";
        }
    }
}
