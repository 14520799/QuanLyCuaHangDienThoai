﻿using System;
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


        public List<SanPham> laySanPham()
        {
            return model.SanPhams.ToList();
        }


        public bool timMaHDM(string MaHDM)
        {
            foreach(HoaDonMua hdm in model.HoaDonMuas)
            {
                if (hdm.MaHDM.Equals(MaHDM))
                    return true;
            }

            return false;
        }


        public bool timMaNV(string MaNV)
        {
            foreach(NhanVien nv in model.NhanViens)
            {
                if (nv.MaNV.Equals(MaNV))
                    return true;
            }

            return false;
        }


        public bool timMaCTM(string MaCTM)
        {
            foreach (ChiTietMua ctm in model.ChiTietMuas)
            {
                if (ctm.MaCTM.Equals(MaCTM))
                    return true;
            }

            return false;
        }


        public List<HoaDonMua> xemHDM()
        {
            return model.HoaDonMuas.ToList();
        }


        public void themHDM(HoaDonMua hdm)
        {
            try
            {
                model.HoaDonMuas.Add(hdm);
                model.SaveChangesAsync();
            }
            catch
            {
                
            }
        }


        public void xoaHDM()
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


        public void suaHDM()
        {
            try
            {
                HoaDonMua hdm = model.HoaDonMuas.Find(MaHDM);
                hdm.TienNo = TienNo;
                hdm.TongTien = TongTien;
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public List<ChiTietMua> xemCTM(string MaHDM)
        {
            return model.ChiTietMuas.Where(ctm => ctm.MaHDM.Equals(MaHDM)).ToList();
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
    }
}
