using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class HoaDonBan_BL
    {
        private DataModel model;

        // Hóa Đơn Bán
        public string MaHDB, MaNV, MaKH;
        public DateTime NgayBan;
        public decimal TongTien, TienNo;

        // Chi Tiết Bán
        public string MaCTB, MaSP;
        public decimal DonGia, GiamGia, ThanhTien;
        public int SoLuong;

        public HoaDonBan_BL()
        {
            model = new DataModel();
        }

        // Lấy danh sách hóa đơn bán
        public List<HoaDonBan> layHDB()
        {
            try
            {
                return model.HoaDonBans.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Thêm hóa đơn bán
        public bool themHDB(HoaDonBan hdb)
        {
            try
            {
                model.HoaDonBans.Add(hdb);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa hóa đơn bán không có chi tiết bán
        public void xoaHDB(List<HoaDonBan> hdb)
        {
            try
            {
                foreach (HoaDonBan item in hdb)
                {
                    if (item.TongTien.Equals(0))
                    {
                        model.HoaDonBans.Remove(item);
                        model.SaveChangesAsync();
                    }
                }
            }
            catch
            {

            }
        }

        // Sửa hóa đơn bán
        public bool suaHDB()
        {
            try
            {
                HoaDonBan hdb = model.HoaDonBans.Find(MaHDB);
                hdb.TongTien = TongTien;
                hdb.TienNo = TienNo;
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Lấy danh sách chi tiết bán
        public List<ChiTietBan> layCTB()
        {
            try
            {
                return model.ChiTietBans.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Thêm chi tiết bán
        public bool themCTB(ChiTietBan ctb)
        {
            try
            {
                model.ChiTietBans.Add(ctb);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
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

        // Lấy danh sách sản phẩm
        public List<SanPham> laySanPham()
        {
            try
            {
                return model.SanPhams.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Lấy danh sách nhân viên
        public List<NhanVien> layNhanVien()
        {
            try
            {
                return model.NhanViens.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Lấy danh sách khách hàng
        public List<KhachHang> layKhachHang()
        {
            try
            {
                return model.KhachHangs.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Tìm chi tiết bán theo Mã HDB
        public List<ChiTietBan> ctbTheoMaHDB(string MaHDB)
        {
            try
            {
                return model.ChiTietBans.Where(ctb => ctb.MaHDB.Equals(MaHDB)).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
