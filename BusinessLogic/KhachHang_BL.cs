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
        DataModel model;
        public DateTime NgaySinh;
        public string MaKH, TenKH, GioiTinh, SoDT, Email, DiaChi, LoaiKH;
        public decimal TienNo;

        public KhachHang_BL()
        {
            model = new DataModel();
        }


        // Lấy danh sách tất cả khách hàng
        public List<KhachHang> danhSach()
        {
            return model.KhachHangs.ToList();
        }

        // Xóa nhân viên
        public void xoa()
        {
            KhachHang kh = model.KhachHangs.First(x => x.MaKH.Equals(MaKH));
            model.KhachHangs.Remove(kh);
            model.SaveChanges();
        }

        // Cập nhật khách hàng
        public void capNhat()
        {
            try
            {
                KhachHang kh = model.KhachHangs.First(x => x.MaKH.Equals(MaKH));
                kh.TenKH = TenKH;
                kh.NgaySinh = NgaySinh;
                kh.GioiTinh = GioiTinh;
                kh.SoDT = SoDT;
                kh.Email = Email;
                kh.DiaChi = DiaChi;
                kh.TienNo = TienNo;
                kh.LoaiKH = LoaiKH;
                model.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
