using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class HoaDonMua_BL
    {
        private DataModel model;

        // Hóa đơn mua
        public string MaHDM, MaHang, MaNV;
        public DateTime NgayMua;
        public decimal TongTien, TienNo;

        // Chi tiết mua
        public string MaCTM, MaSP;
        public decimal DonGia, GiamGia, ThanhTien;
        public int SoLuong;

        public HoaDonMua_BL()
        {
            model = new DataModel();
        }


        public void createHDM(HoaDonMua hdm)
        {
            try
            {
                model.HoaDonMuas.Add(hdm);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public void createCTM(ChiTietMua ctm)
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


        public List<HoaDonMua> readHDM()
        {
            return model.HoaDonMuas.ToList();
        }


        public List<ChiTietMua> readCTM()
        {
            return model.ChiTietMuas.ToList();
        }


        public void deleteCTM()
        {
            try
            {
                HoaDonMua hdm = model.HoaDonMuas.Find(MaHDM);
                model.HoaDonMuas.Remove(hdm);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public List<HangSanXuat> readHangSX()
        {
            return model.HangSanXuats.ToList();
        }


        public string findMaHang(string TenHang)
        {
            HangSanXuat hsx = new HangSanXuat();

            try
            {
                hsx = model.HangSanXuats.First(x => x.TenHang.Equals(TenHang));
            }
            catch
            {

            }

            return hsx.MaHang;
        }


        public SanPham findSanPham(string id)
        {
            SanPham sp = new SanPham();

            try
            {
                sp = model.SanPhams.Find(id);
            }
            catch
            {

            }

            return sp;
        }
    }
}
