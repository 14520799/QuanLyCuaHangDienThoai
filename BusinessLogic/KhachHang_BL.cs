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

        // Thêm khách hàng
        public void them(KhachHang kh)
        {
            try
            {
                model.KhachHangs.Add(kh);
                model.SaveChanges();
            }
            catch
            {

            }
        }

        // Xóa khách hàng
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


        // Tìm khách hàng teo tên
        public List<KhachHang> timTheoTen(string TenKH)
        {
            return model.KhachHangs.Where(x => x.TenKH.Contains(TenKH)).ToList();
        }


        // Tìm khách hàng theo loại KH
        public List<KhachHang> timTheoLoai(string LoaiKH)
        {
            return model.KhachHangs.Where(x => x.LoaiKH.Equals(LoaiKH)).ToList();
        }


        // Tìm khách hàng còn nợ
        public List<KhachHang> timTheoNo()
        {
            return model.KhachHangs.Where(x => x.TienNo > 0).ToList();
        }
    }
}
