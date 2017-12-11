using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Function;

namespace BusinessLogic
{
    public class TraCuu_BL
    {
        private DataModel model;

        public TraCuu_BL()
        {
            model = new DataModel();
        }


        public List<string> layThuocTinh(string danhMuc)
        {
            List<string> listThuocTinh = new List<string>();

            switch (danhMuc)
            {
                case "Nhân Viên":
                    listThuocTinh.AddRange(new [] { "Mã NV", "Tên NV", "Chức Vụ" });
                    break;
                case "Khách Hàng":
                    listThuocTinh.AddRange(new [] { "Tên KH", "Số ĐT", "Còn Nợ" });
                    break;
                case "Sản Phẩm":
                    listThuocTinh.AddRange(new [] { "Tên SP", "Hãng SX", "Còn Hàng" });
                    break;
                case "Hóa Đơn Mua":
                    listThuocTinh.AddRange(new [] { "Mã HĐM", "Hãng SX", "Nhân Viên", "Còn Nợ" });
                    break;
                case "Hóa Đơn Bán":
                    listThuocTinh.AddRange(new [] { "Mã HĐB", "Nhân Viên", "Khách Hàng", "Còn Nợ" });
                    break;
                default:
                    listThuocTinh.Clear();
                    break;
            }

            return listThuocTinh;
        }

        /*** TRA CỨU NHÂN VIÊN ***/
        public List<NhanVien> nvTheoMaNV(string MaNV)
        {
            return model.NhanViens.Where(nv => nv.MaNV.Contains(MaNV)).ToList();
        }

        public List<NhanVien> nvTheoTenNV(string TenNV)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            foreach(NhanVien nv in model.NhanViens)
            {
                if (Algorithm.convertText(nv.TenNV).Contains(Algorithm.convertText(TenNV)))
                    listNhanVien.Add(nv);
            }

            return listNhanVien;
        }

        public List<NhanVien> nvTheoChucVu(string ChucVu)
        {
            return model.NhanViens.Where(nv => nv.ChucVu.Contains(ChucVu)).ToList();
        }


        /*** TRA CỨU KHÁCH HÀNG ***/
        public List<KhachHang> khTheoTenKH(string TenKH)
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            foreach (KhachHang kh in model.KhachHangs)
            {
                if (Algorithm.convertText(kh.TenKH).Contains(Algorithm.convertText(TenKH)))
                    listKhachHang.Add(kh);
            }

            return listKhachHang;
        }

        public List<KhachHang> khTheoSoDT(string SoDT)
        {
            return model.KhachHangs.Where(kh => kh.SoDT.Contains(SoDT)).ToList();
        }

        public List<KhachHang> khTheoConNo()
        {
            return model.KhachHangs.Where(kh => kh.TienNo > 0).ToList();
        }


        /*** TRA CỨU SẢN PHẨM ***/
        public List<SanPham> spTheoTenSP(string TenSP)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            foreach (SanPham sp in model.SanPhams)
            {
                if (Algorithm.convertText(sp.TenSP).Contains(Algorithm.convertText(TenSP)))
                    listSanPham.Add(sp);
            }

            return listSanPham;
        }

        public List<HangSanXuat> layHangSX()
        {
            return model.HangSanXuats.ToList();
        }

        public List<SanPham> spTheoHangSX(string MaHang)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            try
            {
                listSanPham = model.SanPhams.Where(sp => sp.MaHang.Equals(MaHang)).ToList();
            }
            catch
            {

            }

            return listSanPham;
        }

        public List<SanPham> spTheoConHang()
        {
            return model.SanPhams.Where(sp => sp.SoLuong > 0).ToList();
        }


        /*** TRA CỨU HÓA ĐƠN MUA ***/
        public List<HoaDonMua> hdmTheoMaHDM(string MaHDM)
        {
            return model.HoaDonMuas.Where(hdm => hdm.MaHDM.Contains(MaHDM)).ToList();
        }

        public List<HoaDonMua> hdmTheoHangSX(string MaHang)
        {
            List<HoaDonMua> listHDM = new List<HoaDonMua>();

            try
            {
                listHDM = model.HoaDonMuas.Where(hdm => hdm.MaHang.Equals(MaHang)).ToList();
            }
            catch
            {

            }

            return listHDM;
        }

        public List<HoaDonMua> hdmTheoNhanVien(string MaNV)
        {
            return model.HoaDonMuas.Where(hdm => hdm.MaNV.Contains(MaNV)).ToList();
        }

        public List<HoaDonMua> hdmTheoConNo()
        {
            return model.HoaDonMuas.Where(hdm => hdm.TienNo > 0).ToList();
        }
    }
}
