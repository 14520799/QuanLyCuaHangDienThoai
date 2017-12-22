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


        public List<HangSanXuat> layHangSX()
        {
            return model.HangSanXuats.ToList();
        }


        public List<SanPham> laySanPham()
        {
            return model.SanPhams.ToList();
        }


        public bool timMaHDB(string MaHDB)
        {
            foreach (HoaDonBan hdb in model.HoaDonBans)
            {
                if (hdb.MaHDB.Equals(MaHDB))
                    return true;
            }

            return false;
        }


        public bool timMaNV(string MaNV)
        {
            foreach (NhanVien nv in model.NhanViens)
            {
                if (nv.MaNV.Equals(MaNV))
                    return true;
            }

            return false;
        }


        public bool timMaKH(string MaKH)
        {
            foreach (KhachHang kh in model.KhachHangs)
            {
                if (kh.MaKH.Equals(MaKH))
                    return true;
            }

            return false;
        }


        public bool timMaCTB(string MaCTB)
        {
            foreach (ChiTietBan ctb in model.ChiTietBans)
            {
                if (ctb.MaCTB.Equals(MaCTB))
                    return true;
            }

            return false;
        }


        public List<HoaDonBan> xemHDB()
        {
            return model.HoaDonBans.ToList();
        }


        public void themHDB(HoaDonBan hdb)
        {
            try
            {
                model.HoaDonBans.Add(hdb);
                model.SaveChangesAsync();
            }
            catch
            {

            }
        }


        public void xoaHDB()
        {
            try
            {
                HoaDonBan hdb = model.HoaDonBans.Find(MaHDB);
                model.HoaDonBans.Remove(hdb);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public void suaHDB()
        {
            try
            {
                HoaDonBan hdb = model.HoaDonBans.Find(MaHDB);
                hdb.TienNo = TienNo;
                hdb.TongTien = TongTien;
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public List<ChiTietBan> xemCTB(string MaHDB)
        {
            return model.ChiTietBans.Where(ctb => ctb.MaHDB.Equals(MaHDB)).ToList();
        }


        public void themCTB(ChiTietBan ctb)
        {
            try
            {
                model.ChiTietBans.Add(ctb);
                model.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
