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


        /*** ĐỊNH DẠNG DATAGRIDVIEW ***/
        private void Admin_Search_Load(object sender, EventArgs e)
        {
            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        

        /*** EVENT THAY ĐỔI VALUE CÁC COMBOBOX ***/
        private void cbDanhMuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbTuKhoa.Text = "Từ khóa";
                cbThuocTinh.Items.Clear();
                cbThuocTinh.Text = "Thuộc tính";

                foreach (string item in bl.layThuocTinh(cbDanhMuc.Text))
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
            cbTuKhoa.Enabled = true;
            cbTuKhoa.Text = "Từ khóa";
            cbTuKhoa.DropDownStyle = ComboBoxStyle.Simple;

            switch (cbThuocTinh.Text)
            {
                // Nhân Viên
                case "Chức Vụ":
                    cbTuKhoa.Text = string.Empty;
                    cbTuKhoa.DropDownStyle = ComboBoxStyle.DropDown;

                    foreach(NhanVien nv in bl.nvTheoChucVu(""))
                    {
                        if(!cbTuKhoa.Items.Contains(nv.ChucVu))
                            cbTuKhoa.Items.Add(nv.ChucVu);
                    }

                    break;

                // Khách Hàng
                case "Còn Nợ":
                    cbTuKhoa.Enabled = false;
                    cbTuKhoa.Text = string.Empty;
                    break;

                // Sản Phẩm & Hóa Đơn Mua
                case "Hãng SX":
                    cbTuKhoa.Text = string.Empty;
                    cbTuKhoa.DropDownStyle = ComboBoxStyle.DropDown;

                    foreach (HangSanXuat hsx in bl.layHangSX())
                    {
                        cbTuKhoa.Items.Add(hsx.TenHang);
                    }

                    break;

                case "Còn Hàng":
                    cbTuKhoa.Enabled = false;
                    cbTuKhoa.Text = string.Empty;
                    break;

                default:
                    break;
            }
        }

        private void cbTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = null;
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
                                dgvKetQua.DataSource = bl.nvTheoMaNV(cbTuKhoa.Text);
                                break;
                            case "Tên NV":
                                dgvKetQua.DataSource = bl.nvTheoTenNV(cbTuKhoa.Text);
                                break;
                            case "Chức Vụ":
                                dgvKetQua.DataSource = bl.nvTheoChucVu(cbTuKhoa.Text);
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
                                dgvKetQua.DataSource = bl.khTheoTenKH(cbTuKhoa.Text);
                                break;
                            case "Số ĐT":
                                dgvKetQua.DataSource = bl.khTheoSoDT(cbTuKhoa.Text);
                                break;
                            case "Còn Nợ":
                                dgvKetQua.DataSource = bl.khTheoConNo();
                                break;
                            default:
                                break;
                        }
                    }

                    break;

                case "Sản Phẩm":
                    {
                        DataGridViewTextBoxColumn MaSP = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TenSP = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn HinhAnh = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn DonGia = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MoTa = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn SoLuong = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn ManHinh = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn HDH = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn CameraTruoc = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn CameraSau = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn CPU = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn RAM = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn BoNhoTrong = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TheNho = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TheSIM = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn DungLuongPin = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MaHang = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MaLoai = new DataGridViewTextBoxColumn();

                        MaSP.DataPropertyName = "MaSP";
                        MaSP.HeaderText = "Mã SP";

                        TenSP.DataPropertyName = "TenSP";
                        TenSP.HeaderText = "Tên SP";

                        HinhAnh.DataPropertyName = "HinhAnh";
                        HinhAnh.HeaderText = "Hình Ảnh";

                        DonGia.DataPropertyName = "DonGia";
                        DonGia.HeaderText = "Đơn Giá";

                        MoTa.DataPropertyName = "MoTa";
                        MoTa.HeaderText = "Mô Tả";

                        SoLuong.DataPropertyName = "SoLuong";
                        SoLuong.HeaderText = "Số Lượng";

                        ManHinh.DataPropertyName = "ManHinh";
                        ManHinh.HeaderText = "Màn Hình";

                        HDH.DataPropertyName = "HDH";
                        HDH.HeaderText = "HĐH";

                        CameraTruoc.DataPropertyName = "CameraTruoc";
                        CameraTruoc.HeaderText = "Camera Trước";

                        CameraSau.DataPropertyName = "CameraSau";
                        CameraSau.HeaderText = "Camera Sau";

                        CPU.DataPropertyName = "CPU";
                        CPU.HeaderText = "CPU";

                        RAM.DataPropertyName = "RAM";
                        RAM.HeaderText = "RAM";

                        BoNhoTrong.DataPropertyName = "BoNhoTrong";
                        BoNhoTrong.HeaderText = "Bộ Nhớ Trong";

                        TheNho.DataPropertyName = "TheNho";
                        TheNho.HeaderText = "Thẻ Nhớ";

                        TheSIM.DataPropertyName = "TheSIM";
                        TheSIM.HeaderText = "Thẻ SIM";

                        DungLuongPin.DataPropertyName = "DungLuongPin";
                        DungLuongPin.HeaderText = "Dung Lượng Pin";

                        MaHang.DataPropertyName = "MaHang";
                        MaHang.HeaderText = "Hãng SX";

                        MaLoai.DataPropertyName = "MaLoai";
                        MaLoai.HeaderText = "Loại SP";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, HinhAnh, DonGia, MoTa, SoLuong, ManHinh, HDH, CameraTruoc, CameraSau, CPU, RAM, BoNhoTrong, TheNho, TheSIM, DungLuongPin, MaHang, MaLoai });

                        switch (cbThuocTinh.Text)
                        {
                            case "Tên SP":
                                dgvKetQua.DataSource = bl.spTheoTenSP(cbTuKhoa.Text);
                                break;

                            case "Hãng SX":
                                foreach(HangSanXuat hsx in bl.layHangSX())
                                {
                                    if (hsx.TenHang.Equals(cbTuKhoa.Text))
                                        dgvKetQua.DataSource = bl.spTheoHangSX(hsx.MaHang);
                                }

                                break;

                            case "Còn Hàng":
                                dgvKetQua.DataSource = bl.spTheoConHang();
                                break;

                            default:
                                break;
                        }
                    }

                    break;

                case "Hóa Đơn Mua":
                    {
                        DataGridViewTextBoxColumn MaHDM = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MaHang = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn NgayMua = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TongTien = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TienNo = new DataGridViewTextBoxColumn();

                        MaHDM.DataPropertyName = "MaHDM";
                        MaHDM.HeaderText = "Mã HDM";

                        MaHang.DataPropertyName = "MaHang";
                        MaHang.HeaderText = "Hãng SX";

                        MaNV.DataPropertyName = "MaNV";
                        MaNV.HeaderText = "Mã NV";

                        NgayMua.DataPropertyName = "NgayMua";
                        NgayMua.HeaderText = "Ngày Mua";

                        TongTien.DataPropertyName = "TongTien";
                        TongTien.HeaderText = "Tổng Tiền";

                        TienNo.DataPropertyName = "TienNo";
                        TienNo.HeaderText = "Tiền Nợ";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaHDM, MaHang, MaNV, NgayMua, TongTien, TienNo });

                        switch (cbThuocTinh.Text)
                        {
                            case "Mã HDM":
                                dgvKetQua.DataSource = bl.hdmTheoMaHDM(cbTuKhoa.Text);
                                break;

                            case "Hãng SX":
                                foreach(HangSanXuat hsx in bl.layHangSX())
                                {
                                    if (hsx.TenHang.Equals(cbTuKhoa.Text))
                                        dgvKetQua.DataSource = bl.hdmTheoHangSX(hsx.MaHang);
                                }

                                break;

                            case "Mã NV":
                                dgvKetQua.DataSource = bl.hdmTheoMaNV(cbTuKhoa.Text);
                                break;

                            case "Còn Nợ":
                                dgvKetQua.DataSource = bl.hdmTheoConNo();
                                break;

                            default:
                                break;
                        }
                    }

                    break;

                case "Hóa Đơn Bán":
                    {
                        DataGridViewTextBoxColumn MaHDB = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn NgayBan = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TongTien = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn TienNo = new DataGridViewTextBoxColumn();

                        MaHDB.DataPropertyName = "MaHDB";
                        MaHDB.HeaderText = "Mã HDB";

                        MaKH.DataPropertyName = "MaKH";
                        MaKH.HeaderText = "Mã KH";

                        MaNV.DataPropertyName = "MaNV";
                        MaNV.HeaderText = "Mã NV";

                        NgayBan.DataPropertyName = "NgayBan";
                        NgayBan.HeaderText = "Ngày Bán";

                        TongTien.DataPropertyName = "TongTien";
                        TongTien.HeaderText = "Tổng Tiền";

                        TienNo.DataPropertyName = "TienNo";
                        TienNo.HeaderText = "Tiền Nợ";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaHDB, MaKH, MaNV, NgayBan, TongTien, TienNo });

                        switch (cbThuocTinh.Text)
                        {
                            case "Mã HDB":
                                dgvKetQua.DataSource = bl.hdbTheoMaHDB(cbTuKhoa.Text);
                                break;

                            case "Mã NV":
                                dgvKetQua.DataSource = bl.hdbTheoMaNV(cbTuKhoa.Text);
                                break;

                            case "Mã KH":
                                dgvKetQua.DataSource = bl.hdbTheoMaKH(cbTuKhoa.Text);
                                break;

                            case "Còn Nợ":
                                dgvKetQua.DataSource = bl.hdmTheoConNo();
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
