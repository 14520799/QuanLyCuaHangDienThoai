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

        // Lấy danh sách thuộc tính tương ứng với danh mục
        public List<string> layThuocTinh(string danhMuc)
        {
            List<string> thuocTinh = new List<string>();

            switch (danhMuc)
            {
                case "Nhân viên":
                    thuocTinh.AddRange(new [] { "Mã NV", "Tên NV", "Chức vụ" });
                    break;
                case "Khách hàng":
                    thuocTinh.AddRange(new [] { "Tên KH", "Số ĐT", "Còn nợ" });
                    break;
                case "Sản phẩm":
                    thuocTinh.AddRange(new [] { "Tên SP", "Hãng SX", "Còn hàng" });
                    break;
                case "Hóa đơn mua":
                    thuocTinh.AddRange(new [] { "Mã HDM", "Hãng SX", "Mã NV", "Còn nợ" });
                    break;
                case "Hóa đơn bán":
                    thuocTinh.AddRange(new [] { "Mã HDB", "Mã NV", "Mã KH", "Còn nợ" });
                    break;
                default:
                    thuocTinh.Clear();
                    break;
            }

            return thuocTinh;
        }

        /***** TRA CỨU NHÂN VIÊN *****/

        // Tìm nhân viên theo Mã NV
        public List<NhanVien> nvTheoMaNV(string MaNV)
        {
            try
            {
                return model.NhanViens.Where(nv => nv.MaNV.Contains(MaNV)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm nhân viên theo Tên NV
        public List<NhanVien> nvTheoTenNV(string TenNV)
        {
            try
            {
                List<NhanVien> nhanVien = new List<NhanVien>();

                foreach (NhanVien nv in model.NhanViens)
                {
                    if (Algorithm.convertText(nv.TenNV).Contains(Algorithm.convertText(TenNV)))
                        nhanVien.Add(nv);
                }

                return nhanVien;
            }
            catch
            {
                return null;
            }
        }

        // Tìm nhân viên theo Chức vụ
        public List<NhanVien> nvTheoChucVu(string ChucVu)
        {
            try
            {
                return model.NhanViens.Where(nv => nv.ChucVu.Contains(ChucVu)).ToList();
            }
            catch
            {
                return null;
            }
        }


        /***** TRA CỨU KHÁCH HÀNG *****/

        // Tìm khách hàng theo Tên KH
        public List<KhachHang> khTheoTenKH(string TenKH)
        {
            try
            {
                List<KhachHang> khachHang = new List<KhachHang>();

                foreach (KhachHang kh in model.KhachHangs)
                {
                    if (Algorithm.convertText(kh.TenKH).Contains(Algorithm.convertText(TenKH)))
                        khachHang.Add(kh);
                }

                return khachHang;
            }
            catch
            {
                return null;
            }
        }

        // Tìm khách hàng theo Số ĐT
        public List<KhachHang> khTheoSoDT(string SoDT)
        {
            try
            {
                return model.KhachHangs.Where(kh => kh.SoDT.Contains(SoDT)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm khách hàng theo Còn nợ
        public List<KhachHang> khTheoTienNo()
        {
            try
            {
                return model.KhachHangs.Where(kh => kh.TienNo > 0).ToList();
            }
            catch
            {
                return null;
            }
        }


        /***** TRA CỨU SẢN PHẨM *****/

        // Tìm sản phẩm theo Tên SP
        public List<SanPham> spTheoTenSP(string TenSP)
        {
            try
            {
                List<SanPham> sanPham = new List<SanPham>();

                foreach (SanPham sp in model.SanPhams)
                {
                    if (Algorithm.convertText(sp.TenSP).Contains(Algorithm.convertText(TenSP)))
                        sanPham.Add(sp);
                }

                return sanPham;
            }
            catch
            {
                return null;
            }
        }

        // Lấy danh sách hãng sản xuất
        public List<HangSanXuat> layHangSX()
        {
            try
            {
                return model.HangSanXuats.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm sản phẩm theo Hãng SX
        public List<SanPham> spTheoMaHang(string MaHang)
        {
            try
            {
                return model.SanPhams.Where(sp => sp.MaHang.Equals(MaHang)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm sản phẩm theo Còn hàng
        public List<SanPham> spTheoSoLuong()
        {
            try
            {
                return model.SanPhams.Where(sp => sp.SoLuong > 0).ToList();
            }
            catch
            {
                return null;
            }
        }


        /***** TRA CỨU HÓA ĐƠN MUA *****/

        // Tìm hóa đơn mua theo Mã HDM
        public List<HoaDonMua> hdmTheoMaHDM(string MaHDM)
        {
            try
            {
                return model.HoaDonMuas.Where(hdm => hdm.MaHDM.Contains(MaHDM)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm hóa đơn mua theo Hãng SX
        public List<HoaDonMua> hdmTheoMaHang(string MaHang)
        {
            try
            {
                return model.HoaDonMuas.Where(hdm => hdm.MaHang.Equals(MaHang)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm hóa đơn mua theo Mã NV
        public List<HoaDonMua> hdmTheoMaNV(string MaNV)
        {
            try
            {
                return model.HoaDonMuas.Where(hdm => hdm.MaNV.Contains(MaNV)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm hóa đơn mua theo Còn nợ
        public List<HoaDonMua> hdmTheoTienNo()
        {
            try
            {
                return model.HoaDonMuas.Where(hdm => hdm.TienNo > 0).ToList();
            }
            catch
            {
                return null;
            }
        }


        /***** TRA CỨU HÓA ĐƠN BÁN *****/

        // Tìm hóa đơn bán theo Mã HDB
        public List<HoaDonBan> hdbTheoMaHDB(string MaHDB)
        {
            try
            {
                return model.HoaDonBans.Where(hdb => hdb.MaHDB.Contains(MaHDB)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm hóa đơn bán theo Mã NV
        public List<HoaDonBan> hdbTheoMaNV(string MaNV)
        {
            try
            {
                return model.HoaDonBans.Where(hdb => hdb.MaNV.Contains(MaNV)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm hóa đơn bán theo Mã KH
        public List<HoaDonBan> hdbTheoMaKH(string MaKH)
        {
            try
            {
                return model.HoaDonBans.Where(hdb => hdb.MaKH.Contains(MaKH)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm hóa đơn bán theo Còn nợ
        public List<HoaDonBan> hdbTheoTienNo()
        {
            try
            {
                return model.HoaDonBans.Where(hdb => hdb.TienNo > 0).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
