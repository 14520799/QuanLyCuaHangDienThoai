using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class HoaDonMua_BL
    {
        private DataModel model;

        // Hóa Đơn Mua
        public string MaHDM, MaHang, MaNV;
        public DateTime NgayMua;
        public decimal TongTien, TienNo;

        // Chi Tiết Mua
        public string MaCTM, MaSP;
        public decimal DonGia, GiamGia, ThanhTien;
        public int SoLuong;

        public HoaDonMua_BL()
        {
            model = new DataModel();
        }

        // Lấy danh sách hóa đơn mua
        public List<HoaDonMua> layHDM()
        {
            try
            {
                return model.HoaDonMuas.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Thêm hóa đơn mua
        public bool themHDM(HoaDonMua hdm)
        {
            try
            {
                model.HoaDonMuas.Add(hdm);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa hóa đơn mua
        public bool xoaHDM()
        {
            try
            {
                HoaDonMua hdm = model.HoaDonMuas.Find(MaHDM);
                model.HoaDonMuas.Remove(hdm);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool suaHDM()
        {
            try
            {
                HoaDonMua hdm = model.HoaDonMuas.Find(MaHDM);
                hdm.TongTien = TongTien;
                hdm.TienNo = TienNo;
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Lấy danh sách chi tiết mua
        public List<ChiTietMua> layCTM(string MaHDM)
        {
            try
            {
                return model.ChiTietMuas.Where(ctm => ctm.MaHDM.Equals(MaHDM)).ToList();
            }
            catch
            {
                return null;
            }
        }

        // Thêm chi tiết mua
        public bool themCTM(ChiTietMua ctm)
        {
            try
            {
                model.ChiTietMuas.Add(ctm);
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
    }
}
