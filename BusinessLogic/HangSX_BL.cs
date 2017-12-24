using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class HangSX_BL
    {
        private DataModel model;
        public string MaHang, TenHang, SoDT, Email, DiaChi;
        
        public HangSX_BL()
        {
            model = new DataModel();
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

        // Thêm hãng sản xuất
        public bool themHangSX(HangSanXuat hsx)
        {
            try
            {
                model.HangSanXuats.Add(hsx);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa hãng sản xuất
        public bool xoaHangSX()
        {
            try
            {
                HangSanXuat hsx = model.HangSanXuats.Find(MaHang);
                model.HangSanXuats.Remove(hsx);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa hãng sản xuất
        public bool suaHangSX()
        {
            try
            {
                HangSanXuat hsx = model.HangSanXuats.Find(MaHang);
                hsx.TenHang = TenHang;
                hsx.SoDT = SoDT;
                hsx.Email = Email;
                hsx.DiaChi = DiaChi;
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Tìm sản phẩm theo Mã Hãng
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
    }
}
