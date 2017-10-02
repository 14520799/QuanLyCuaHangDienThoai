using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccess;
using Function;

namespace BusinessLogic
{
    public class NhanVien_BL
    {
        private DataModel model;
        public DateTime NgaySinh;
        public string MaNV, TenNV, GioiTinh, SoDT, Email, DiaChi, Quyen, ChucVu, MatKhau;

        public NhanVien_BL()
        {
            model = new DataModel();
        }


        // Lấy danh sách nhân viên
        public List<NhanVien> danhSach()
        {
            return model.NhanViens.ToList();
        }

        
        // Sửa thông tin nhân viên
        public void capNhat()
        {
            try
            {
                NhanVien nv = model.NhanViens.First(x => x.MaNV.Equals(MaNV));
                nv.TenNV = TenNV;
                nv.NgaySinh = NgaySinh;
                nv.GioiTinh = GioiTinh;
                nv.SoDT = SoDT;
                nv.Email = Email;
                nv.DiaChi = DiaChi;
                nv.Quyen = Quyen;
                nv.ChucVu = ChucVu;
                model.SaveChanges();
            }
            catch
            {

            }
        }


        // Tìm nhân viên theo tên
        public List<NhanVien> timTheoTen(string TenNV)
        {
            return model.NhanViens.Where(x => x.TenNV.Contains(TenNV)).ToList();
        }


        // Tìm nhân viên theo quyền
        public List<NhanVien> timTheoQuyen(string Quyen)
        {
            return model.NhanViens.Where(x => x.Quyen.Contains(Quyen)).ToList();
        }


        // Tìm nhân viên theo chức vụ
        public List<NhanVien> timTheoChucVu(string ChucVu)
        {
            return model.NhanViens.Where(x => x.ChucVu.Contains(ChucVu)).ToList();
        }


        // Kiểm tra đăng nhập (QTV)
        public string dangNhap()
        {
            NhanVien nv = model.NhanViens.First(x => x.MaNV.Equals(MaNV));

            if (nv == null || nv.Quyen != "Quản trị" || nv.MatKhau != MatKhau)
                return string.Empty;
            return nv.TenNV;
        }


        // Thêm nhân viên
        public void them(NhanVien nv)
        {
            try
            {
                model.NhanViens.Add(nv);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        // Xóa nhân viên
        public void xoa()
        {
            NhanVien nv = model.NhanViens.First(x => x.MaNV.Equals(MaNV));
            model.NhanViens.Remove(nv);
            model.SaveChanges();
        }
    }
}
