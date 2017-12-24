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

        // Định dạng DataGridView
        private void Admin_Search_Load(object sender, EventArgs e)
        {
            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // Click Search để tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvKetQua.Columns.Clear();
            dgvKetQua.DataSource = null;

            switch (cbDanhMuc.Text)
            {
                // Tìm kiếm nhân viên
                case "Nhân viên":
                    {
                        DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
                        MaNV.DataPropertyName = "MaNV";
                        MaNV.HeaderText = "Mã NV";

                        DataGridViewTextBoxColumn TenNV = new DataGridViewTextBoxColumn();
                        TenNV.DataPropertyName = "TenNV";
                        TenNV.HeaderText = "Tên NV";

                        DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
                        NgaySinh.DataPropertyName = "NgaySinh";
                        NgaySinh.HeaderText = "Ngày sinh";

                        DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
                        GioiTinh.DataPropertyName = "GioiTinh";
                        GioiTinh.HeaderText = "Giới tính";

                        DataGridViewTextBoxColumn SoDT = new DataGridViewTextBoxColumn();
                        SoDT.DataPropertyName = "SoDT";
                        SoDT.HeaderText = "Số ĐT";

                        DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
                        Email.DataPropertyName = "Email";
                        Email.HeaderText = "Email";

                        DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
                        DiaChi.DataPropertyName = "DiaChi";
                        DiaChi.HeaderText = "Địa chỉ";

                        DataGridViewTextBoxColumn ChucVu = new DataGridViewTextBoxColumn();
                        ChucVu.DataPropertyName = "ChucVu";
                        ChucVu.HeaderText = "Chức vụ";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, NgaySinh, GioiTinh, SoDT, Email, DiaChi, ChucVu });

                        switch (cbThuocTinh.Text)
                        {
                            // Tìm nhân viên theo Mã NV
                            case "Mã NV":   
                                dgvKetQua.DataSource = bl.nvTheoMaNV(cbTuKhoa.Text);
                                break;

                            // Tìm nhân viên theo Tên NV
                            case "Tên NV":
                                dgvKetQua.DataSource = bl.nvTheoTenNV(cbTuKhoa.Text);
                                break;

                            // Tìm nhân viên theo Chức vụ
                            case "Chức vụ":
                                dgvKetQua.DataSource = bl.nvTheoChucVu(cbTuKhoa.Text);
                                break;

                            default:
                                break;
                        }
                    }

                    break;

                // Tìm kiếm khách hàng
                case "Khách hàng":
                    {
                        DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
                        MaKH.DataPropertyName = "MaKH";
                        MaKH.HeaderText = "Mã KH";

                        DataGridViewTextBoxColumn TenKH = new DataGridViewTextBoxColumn();
                        TenKH.DataPropertyName = "TenKH";
                        TenKH.HeaderText = "Tên KH";

                        DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
                        NgaySinh.DataPropertyName = "NgaySinh";
                        NgaySinh.HeaderText = "Ngày sinh";

                        DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
                        GioiTinh.DataPropertyName = "GioiTinh";
                        GioiTinh.HeaderText = "Giới tính";

                        DataGridViewTextBoxColumn SoDT = new DataGridViewTextBoxColumn();
                        SoDT.DataPropertyName = "SoDT";
                        SoDT.HeaderText = "Số ĐT";

                        DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
                        Email.DataPropertyName = "Email";
                        Email.HeaderText = "Email";

                        DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
                        DiaChi.DataPropertyName = "DiaChi";
                        DiaChi.HeaderText = "Địa chỉ";

                        DataGridViewTextBoxColumn TienNo = new DataGridViewTextBoxColumn();
                        TienNo.DataPropertyName = "TienNo";
                        TienNo.HeaderText = "Tiền nợ";

                        DataGridViewTextBoxColumn LoaiKH = new DataGridViewTextBoxColumn();
                        LoaiKH.DataPropertyName = "LoaiKH";
                        LoaiKH.HeaderText = "Loại KH";
                        
                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, NgaySinh, GioiTinh, SoDT, Email, DiaChi, TienNo, LoaiKH });

                        switch (cbThuocTinh.Text)
                        {
                            // Tìm khách hàng theo Tên KH
                            case "Tên KH":
                                dgvKetQua.DataSource = bl.khTheoTenKH(cbTuKhoa.Text);
                                break;

                            // Tìm khách hàng theo Số ĐT
                            case "Số ĐT":
                                dgvKetQua.DataSource = bl.khTheoSoDT(cbTuKhoa.Text);
                                break;

                            // Tìm khách hàng theo Còn nợ
                            case "Còn nợ":
                                dgvKetQua.DataSource = bl.khTheoTienNo();
                                break;

                            default:
                                break;
                        }
                    }

                    break;

                // Tìm kiếm sản phẩm
                case "Sản phẩm":
                    {
                        DataGridViewTextBoxColumn MaSP = new DataGridViewTextBoxColumn();
                        MaSP.DataPropertyName = "MaSP";
                        MaSP.HeaderText = "Mã SP";

                        DataGridViewTextBoxColumn TenSP = new DataGridViewTextBoxColumn();
                        TenSP.DataPropertyName = "TenSP";
                        TenSP.HeaderText = "Tên SP";

                        DataGridViewTextBoxColumn HinhAnh = new DataGridViewTextBoxColumn();
                        HinhAnh.DataPropertyName = "HinhAnh";
                        HinhAnh.HeaderText = "Hình ảnh";

                        DataGridViewTextBoxColumn DonGia = new DataGridViewTextBoxColumn();
                        DonGia.DataPropertyName = "DonGia";
                        DonGia.HeaderText = "Đơn giá";

                        DataGridViewTextBoxColumn MoTa = new DataGridViewTextBoxColumn();
                        MoTa.DataPropertyName = "MoTa";
                        MoTa.HeaderText = "Mô tả";

                        DataGridViewTextBoxColumn SoLuong = new DataGridViewTextBoxColumn();
                        SoLuong.DataPropertyName = "SoLuong";
                        SoLuong.HeaderText = "Số lượng";

                        DataGridViewTextBoxColumn ManHinh = new DataGridViewTextBoxColumn();
                        ManHinh.DataPropertyName = "ManHinh";
                        ManHinh.HeaderText = "Màn hình";

                        DataGridViewTextBoxColumn HDH = new DataGridViewTextBoxColumn();
                        HDH.DataPropertyName = "HDH";
                        HDH.HeaderText = "HĐH";

                        DataGridViewTextBoxColumn CameraTruoc = new DataGridViewTextBoxColumn();
                        CameraTruoc.DataPropertyName = "CameraTruoc";
                        CameraTruoc.HeaderText = "Camera trước";

                        DataGridViewTextBoxColumn CameraSau = new DataGridViewTextBoxColumn();
                        CameraSau.DataPropertyName = "CameraSau";
                        CameraSau.HeaderText = "Camera sau";

                        DataGridViewTextBoxColumn CPU = new DataGridViewTextBoxColumn();
                        CPU.DataPropertyName = "CPU";
                        CPU.HeaderText = "CPU";

                        DataGridViewTextBoxColumn RAM = new DataGridViewTextBoxColumn();
                        RAM.DataPropertyName = "RAM";
                        RAM.HeaderText = "RAM";

                        DataGridViewTextBoxColumn BoNhoTrong = new DataGridViewTextBoxColumn();
                        BoNhoTrong.DataPropertyName = "BoNhoTrong";
                        BoNhoTrong.HeaderText = "Bộ nhớ trong";

                        DataGridViewTextBoxColumn TheNho = new DataGridViewTextBoxColumn();
                        TheNho.DataPropertyName = "TheNho";
                        TheNho.HeaderText = "Thẻ nhớ";

                        DataGridViewTextBoxColumn TheSIM = new DataGridViewTextBoxColumn();
                        TheSIM.DataPropertyName = "TheSIM";
                        TheSIM.HeaderText = "Thẻ SIM";

                        DataGridViewTextBoxColumn DungLuongPin = new DataGridViewTextBoxColumn();
                        DungLuongPin.DataPropertyName = "DungLuongPin";
                        DungLuongPin.HeaderText = "Dung lượng pin";

                        DataGridViewTextBoxColumn MaHang = new DataGridViewTextBoxColumn();
                        MaHang.DataPropertyName = "MaHang";
                        MaHang.HeaderText = "Hãng SX";

                        DataGridViewTextBoxColumn MaLoai = new DataGridViewTextBoxColumn();
                        MaLoai.DataPropertyName = "MaLoai";
                        MaLoai.HeaderText = "Loại SP";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, HinhAnh, DonGia, MoTa, SoLuong, ManHinh, HDH, CameraTruoc, CameraSau, CPU, RAM, BoNhoTrong, TheNho, TheSIM, DungLuongPin, MaHang, MaLoai });

                        switch (cbThuocTinh.Text)
                        {
                            // Tìm sản phẩm theo Tên SP
                            case "Tên SP":
                                dgvKetQua.DataSource = bl.spTheoTenSP(cbTuKhoa.Text);
                                break;

                            // Tìm sản phẩm theo Hãng SX
                            case "Hãng SX":
                                foreach (HangSanXuat hsx in bl.layHangSX())
                                {
                                    if (hsx.TenHang.Equals(cbTuKhoa.Text))
                                    {
                                        dgvKetQua.DataSource = bl.spTheoMaHang(hsx.MaHang);
                                        break;
                                    }
                                }

                                break;

                            // Tìm sản phẩm theo Còn hàng
                            case "Còn hàng":
                                dgvKetQua.DataSource = bl.spTheoSoLuong();
                                break;

                            default:
                                break;
                        }
                    }

                    break;

                // Tìm kiếm hóa đơn mua
                case "Hóa đơn mua":
                    {
                        DataGridViewTextBoxColumn MaHDM = new DataGridViewTextBoxColumn();
                        MaHDM.DataPropertyName = "MaHDM";
                        MaHDM.HeaderText = "Mã HDM";

                        DataGridViewTextBoxColumn MaHang = new DataGridViewTextBoxColumn();
                        MaHang.DataPropertyName = "MaHang";
                        MaHang.HeaderText = "Hãng SX";

                        DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
                        MaNV.DataPropertyName = "MaNV";
                        MaNV.HeaderText = "Mã NV";

                        DataGridViewTextBoxColumn NgayMua = new DataGridViewTextBoxColumn();
                        NgayMua.DataPropertyName = "NgayMua";
                        NgayMua.HeaderText = "Ngày mua";

                        DataGridViewTextBoxColumn TongTien = new DataGridViewTextBoxColumn();
                        TongTien.DataPropertyName = "TongTien";
                        TongTien.HeaderText = "Tổng tiền";

                        DataGridViewTextBoxColumn TienNo = new DataGridViewTextBoxColumn();
                        TienNo.DataPropertyName = "TienNo";
                        TienNo.HeaderText = "Tiền nợ";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaHDM, MaHang, MaNV, NgayMua, TongTien, TienNo });

                        switch (cbThuocTinh.Text)
                        {
                            // Tìm hóa đơn mua tho Mã HDM
                            case "Mã HDM":
                                dgvKetQua.DataSource = bl.hdmTheoMaHDM(cbTuKhoa.Text);
                                break;

                            // Tìm hóa đơn mua theo Hãng SX
                            case "Hãng SX":
                                foreach (HangSanXuat hsx in bl.layHangSX())
                                {
                                    if (hsx.TenHang.Equals(cbTuKhoa.Text))
                                    {
                                        dgvKetQua.DataSource = bl.hdmTheoMaHang(hsx.MaHang);
                                        break;
                                    }
                                }

                                break;

                            // Tìm hóa đơn mua theo Mã NV
                            case "Mã NV":
                                dgvKetQua.DataSource = bl.hdmTheoMaNV(cbTuKhoa.Text);
                                break;

                            // Tìm hóa đơn mua theo Còn nợ
                            case "Còn nợ":
                                dgvKetQua.DataSource = bl.hdmTheoTienNo();
                                break;

                            default:
                                break;
                        }
                    }

                    break;

                // Tìm kiếm hóa đơn bán
                case "Hóa đơn bán":
                    {
                        DataGridViewTextBoxColumn MaHDB = new DataGridViewTextBoxColumn();
                        MaHDB.DataPropertyName = "MaHDB";
                        MaHDB.HeaderText = "Mã HDB";

                        DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
                        MaKH.DataPropertyName = "MaKH";
                        MaKH.HeaderText = "Mã KH";

                        DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
                        MaNV.DataPropertyName = "MaNV";
                        MaNV.HeaderText = "Mã NV";

                        DataGridViewTextBoxColumn NgayBan = new DataGridViewTextBoxColumn();
                        NgayBan.DataPropertyName = "NgayBan";
                        NgayBan.HeaderText = "Ngày bán";

                        DataGridViewTextBoxColumn TongTien = new DataGridViewTextBoxColumn();
                        TongTien.DataPropertyName = "TongTien";
                        TongTien.HeaderText = "Tổng tiền";

                        DataGridViewTextBoxColumn TienNo = new DataGridViewTextBoxColumn();
                        TienNo.DataPropertyName = "TienNo";
                        TienNo.HeaderText = "Tiền nợ";

                        dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { MaHDB, MaKH, MaNV, NgayBan, TongTien, TienNo });

                        switch (cbThuocTinh.Text)
                        {
                            // Tìm hóa đơn bán theo Mã HDB
                            case "Mã HDB":
                                dgvKetQua.DataSource = bl.hdbTheoMaHDB(cbTuKhoa.Text);
                                break;

                            // Tìm hóa đơn bán theo Mã NV
                            case "Mã NV":
                                dgvKetQua.DataSource = bl.hdbTheoMaNV(cbTuKhoa.Text);
                                break;

                            // Tìm hóa đơn bán theo Mã KH
                            case "Mã KH":
                                dgvKetQua.DataSource = bl.hdbTheoMaKH(cbTuKhoa.Text);
                                break;

                            // Tìm hóa đơn bán theo Còn nợ
                            case "Còn nợ":
                                dgvKetQua.DataSource = bl.hdmTheoTienNo();
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

        // Sự kiện thay đổi cbDanhMuc
        private void cbDanhMuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbThuocTinh.Items.Clear();
                cbThuocTinh.Text = "Thuộc tính";
                cbTuKhoa.Text = "Từ khóa";

                // Lấy danh sách thuộc tính tương ứng với danh mục
                foreach (string thuocTinh in bl.layThuocTinh(cbDanhMuc.Text))
                {
                    cbThuocTinh.Items.Add(thuocTinh);
                }
            }
            catch
            {

            }
        }

        // Sự kiện thay đổi cbThuocTinh
        private void cbThuocTinh_TextChanged(object sender, EventArgs e)
        {
            cbTuKhoa.Items.Clear();
            cbTuKhoa.Enabled = true;
            cbTuKhoa.Text = "Từ khóa";
            cbTuKhoa.DropDownStyle = ComboBoxStyle.Simple;

            switch (cbThuocTinh.Text)
            {
                // Tìm nhân viên theo :
                case "Chức vụ":
                    cbTuKhoa.Text = string.Empty;
                    cbTuKhoa.DropDownStyle = ComboBoxStyle.DropDown;

                    foreach(NhanVien nv in bl.nvTheoChucVu(""))
                    {
                        if(!cbTuKhoa.Items.Contains(nv.ChucVu))
                            cbTuKhoa.Items.Add(nv.ChucVu);
                    }

                    break;

                // Tìm khách hàng theo :
                case "Còn nợ":
                    cbTuKhoa.Enabled = false;
                    cbTuKhoa.Text = string.Empty;
                    break;

                // Tìm sản phẩm theo :
                case "Hãng SX":
                    cbTuKhoa.Text = string.Empty;
                    cbTuKhoa.DropDownStyle = ComboBoxStyle.DropDown;

                    foreach (HangSanXuat hsx in bl.layHangSX())
                    {
                        cbTuKhoa.Items.Add(hsx.TenHang);
                    }

                    break;

                case "Còn hàng":
                    cbTuKhoa.Enabled = false;
                    cbTuKhoa.Text = string.Empty;
                    break;

                default:
                    break;
            }
        }
    }
}
