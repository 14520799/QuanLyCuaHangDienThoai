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


        public List<HangSanXuat> layHangSX()
        {
            return model.HangSanXuats.ToList();
        }


        public List<SanPham> laySanPham(string MaSP)
        {
            return model.SanPhams.Where(sp => sp.MaSP.Contains(MaSP)).ToList();
        }


        public List<HoaDonMua> xemHDM()
        {
            return model.HoaDonMuas.ToList();
        }


        public List<ChiTietMua> xemCTM()
        {
            return model.ChiTietMuas.ToList();
        }


        public void themHDM(HoaDonMua hdm)
        {
            try
            {
                model.HoaDonMuas.Add(hdm);
                model.SaveChanges();
            }
            catch
            {
                HoaDonMua available = model.HoaDonMuas.Find(MaHDM);
                hdm.MaHang = MaHang;
                hdm.MaNV = MaNV;
                hdm.NgayMua = NgayMua;
                hdm.TongTien = TongTien;
                hdm.TienNo = TienNo;
                model.SaveChanges();
            }
        }


        public void themCTM(ChiTietMua ctm)
        {
            try
            {
                model.ChiTietMuas.Add(ctm);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public void xoaCTM()
        {
            try
            {
                ChiTietMua ctm = model.ChiTietMuas.Find(MaCTM);
                model.ChiTietMuas.Remove(ctm);
                model.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
