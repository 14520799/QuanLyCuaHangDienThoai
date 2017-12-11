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

namespace Presentation.Admin
{
    public partial class Admin_Search : Form
    {
        TraCuu_BL bl = new TraCuu_BL();

        public Admin_Search()
        {
            InitializeComponent();
        }


        private void Admin_Search_Load(object sender, EventArgs e)
        {
            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        
        private void cbDanhMuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbTuKhoa.Text = "Từ khóa";
                cbThuocTinh.Items.Clear();
                cbThuocTinh.Text = "Thuộc tính";
                List<string> thuocTinh = bl.loadThuocTinh(cbDanhMuc.Text);

                foreach (string item in thuocTinh)
                {
                    cbThuocTinh.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        private void cbThuocTinh_TextChanged(object sender, EventArgs e)
        {
            cbTuKhoa.Items.Clear();

            if (cbThuocTinh.Text.Equals("Chức Vụ"))
            {
                cbTuKhoa.Text = string.Empty;
                cbTuKhoa.DropDownStyle = ComboBoxStyle.DropDown;
                cbTuKhoa.Items.AddRange(new[] { "Bán Hàng", "Tiếp Thị", "Bảo Hành" });
            }
            else
                cbTuKhoa.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void cbTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvKetQua.Columns.Clear();

            switch (cbDanhMuc.Text)
            {
                case "Nhân Viên":
                    {
                        DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TenNV = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn SoDT = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn ChucVu = new DataGridViewTextBoxColumn();

                        MaNV.DataPropertyName = "MaNV";
                        MaNV.HeaderText = "Mã NV";

                        TenNV.DataPropertyName = "TenNV";
                        TenNV.HeaderText = "Tên NV";

                        NgaySinh.DataPropertyName = "NgaySinh";
                        NgaySinh.HeaderText = "Ngày Sinh";

                        GioiTinh.DataPropertyName = "GioiTinh";
                        GioiTinh.HeaderText = "Giới Tính";

                        SoDT.DataPropertyName = "SoDT";
                        SoDT.HeaderText = "Số ĐT";

                        Email.DataPropertyName = "Email";
                        Email.HeaderText = "Email";

                        DiaChi.DataPropertyName = "DiaChi";
                        DiaChi.HeaderText = "Địa Chỉ";

                        ChucVu.DataPropertyName = "ChucVu";
                        ChucVu.HeaderText = "Chức Vụ";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, NgaySinh, GioiTinh, SoDT, Email, DiaChi, ChucVu });

                        switch (cbThuocTinh.Text)
                        {
                            case "Mã NV":
                                dgvKetQua.DataSource = bl.timMaNV(cbTuKhoa.Text);
                                break;
                            case "Tên NV":
                                dgvKetQua.DataSource = bl.timTenNV(cbTuKhoa.Text);
                                break;
                            case "Chức Vụ":
                                dgvKetQua.DataSource = bl.timChucVu(cbTuKhoa.Text);
                                break;
                            default:
                                break;
                        }
                    }

                    break;

                case "Khách Hàng":
                    {
                        DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TenKH = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn SoDT = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TienNo = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn LoaiKH = new DataGridViewTextBoxColumn();

                        MaKH.DataPropertyName = "MaKH";
                        MaKH.HeaderText = "Mã KH";

                        TenKH.DataPropertyName = "TenKH";
                        TenKH.HeaderText = "Tên KH";

                        NgaySinh.DataPropertyName = "NgaySinh";
                        NgaySinh.HeaderText = "Ngày Sinh";

                        GioiTinh.DataPropertyName = "GioiTinh";
                        GioiTinh.HeaderText = "Giới Tính";

                        SoDT.DataPropertyName = "SoDT";
                        SoDT.HeaderText = "Số ĐT";

                        Email.DataPropertyName = "Email";
                        Email.HeaderText = "Email";

                        DiaChi.DataPropertyName = "DiaChi";
                        DiaChi.HeaderText = "Địa Chỉ";

                        TienNo.DataPropertyName = "TienNo";
                        TienNo.HeaderText = "Tiền Nợ";

                        LoaiKH.DataPropertyName = "LoaiKH";
                        LoaiKH.HeaderText = "Loại KH";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, NgaySinh, GioiTinh, SoDT, Email, DiaChi, TienNo, LoaiKH });

                        switch (cbThuocTinh.Text)
                        {
                            case "Tên KH":
                                dgvKetQua.DataSource = bl.timTenKH(cbTuKhoa.Text);
                                break;
                            case "Số ĐT":
                                dgvKetQua.DataSource = bl.timSoDT(cbTuKhoa.Text);
                                break;
                            case "Còn Nợ":
                                dgvKetQua.DataSource = bl.timTienNo();
                                break;
                            default:
                                break;
                        }
                    }

                    break;

                default:
                    break;
            }
        }
    }
}
