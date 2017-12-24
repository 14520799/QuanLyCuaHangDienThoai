using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class KhachHang_BL
    {
        private DataModel model;
        public DateTime NgaySinh;
        public string MaKH, TenKH, GioiTinh, SoDT, Email, DiaChi, LoaiKH;
        public decimal TienNo;

        public KhachHang_BL()
        {
            model = new DataModel();
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

        // Thêm khách hàng
        public bool themKhachHang(KhachHang kh)
        {
            try
            {
                model.KhachHangs.Add(kh);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa khách hàng
        public bool xoaKhachHang()
        {
            try
            {
                KhachHang kh = model.KhachHangs.Find(MaKH);
                model.KhachHangs.Remove(kh);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa khách hàng
        public bool suaKhachHang()
        {
            try
            {
                KhachHang kh = model.KhachHangs.Find(MaKH);
                kh.TenKH = TenKH;
                kh.NgaySinh = NgaySinh;
                kh.GioiTinh = GioiTinh;
                kh.SoDT = SoDT;
                kh.Email = Email;
                kh.DiaChi = DiaChi;
                kh.TienNo = TienNo;
                kh.LoaiKH = LoaiKH;
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
