using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Function;

namespace BusinessLogic
{
    public class ThongKe_BL
    {
        private DataModel model;
        private decimal tongNo, tongTien;
        private bool FirstThongKe = true;

        public ThongKe_BL()
        {
            model = new DataModel();
        }

        
        public List<ChiTietMua> ctmTheoThang(string thang)
        {
            List<HoaDonMua> hdm = model.HoaDonMuas.Where(item => item.NgayMua.Month.ToString().Equals(thang)).ToList();
            List<ChiTietMua> listResult = new List<ChiTietMua>();

            try
            {
                foreach(HoaDonMua item in hdm)
                {
                    foreach(ChiTietMua ctm in model.ChiTietMuas)
                    {
                        if (ctm.MaHDM.Equals(item.MaHDM))
                        {
                            listResult.Add(ctm);
                        }
                    }
                }

                return listResult;
            }
            catch
            {
                return null;
            }
        }

        public List<ChiTietBan> ctbTheoThang(string thang)
        {
            List<HoaDonBan> hdb = model.HoaDonBans.Where(item => item.NgayBan.Month.ToString().Equals(thang)).ToList();
            List<ChiTietBan> listResult = new List<ChiTietBan>();

            try
            {
                foreach (HoaDonBan item in hdb)
                {
                    foreach (ChiTietBan ctb in model.ChiTietBans)
                    {
                        if (ctb.MaHDB.Equals(item.MaHDB))
                        {
                            listResult.Add(ctb);
                        }
                    }
                }

                if (listResult.Count > 0)
                {
                    //Tra du lieu ve nhu cu tu lan thu 2 tro di
                    if (!FirstThongKe)
                    {
                        for (int i = 0; i < listResult.Count - 1; i++)
                        {
                            for (int j = i + 1; j < listResult.Count; j++)
                            {
                                if (listResult[i].MaSP == listResult[j].MaSP)
                                {
                                    listResult[i].SoLuong -= listResult[j].SoLuong;
                                    listResult[i].ThanhTien -= listResult[j].ThanhTien;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < listResult.Count - 1; i++)
                    {
                        for (int j = i + 1; j < listResult.Count; j++)
                        {
                            if (listResult[i].MaSP == listResult[j].MaSP)
                            {
                                listResult[i].SoLuong += listResult[j].SoLuong;
                                listResult[i].ThanhTien += listResult[j].ThanhTien;
                                listResult.RemoveAt(j);
                                j--;
                            }
                        }
                    }

                    FirstThongKe = false;
                }

                return listResult;
            }
            catch
            {
                return null;
            }
        }

        public decimal tongNoMua(string thang)
        {
            tongNo = 0;
            List<HoaDonMua> hdm = model.HoaDonMuas.Where(item => item.NgayMua.Month.ToString().Equals(thang)).ToList();

            try
            {
                foreach (HoaDonMua item in hdm)
                {
                    tongNo += item.TienNo;
                }

                return tongNo;
            }
            catch
            {
                return 0;
            }
        }

        public decimal tongNoBan(string thang)
        {
            tongNo = 0;
            List<HoaDonBan> hdb = model.HoaDonBans.Where(item => item.NgayBan.Month.ToString().Equals(thang)).ToList();

            try
            {
                foreach (HoaDonBan item in hdb)
                {
                    tongNo += item.TienNo;
                }

                return tongNo;
            }
            catch
            {
                return 0;
            }
        }

        public decimal tongTienMua(string thang)
        {
            tongTien = 0;
            List<HoaDonMua> hdm = model.HoaDonMuas.Where(item => item.NgayMua.Month.ToString().Equals(thang)).ToList();

            try
            {
                foreach (HoaDonMua item in hdm)
                {
                    tongTien += item.TongTien;
                }

                return tongTien;
            }
            catch
            {
                return 0;
            }
        }

        public decimal tongTienBan(string thang)
        {
            tongTien = 0;
            List<HoaDonBan> hdb = model.HoaDonBans.Where(item => item.NgayBan.Month.ToString().Equals(thang)).ToList();

            try
            {
                foreach (HoaDonBan item in hdb)
                {
                    tongTien += item.TongTien;
                }

                return tongTien;
            }
            catch
            {
                return 0;
            }
        }

        public List<SanPham> laySanPham()
        {
            return model.SanPhams.ToList();
        }

        public List<HangSanXuat> layHangSX()
        {
            return model.HangSanXuats.ToList();
        }
    }
}
