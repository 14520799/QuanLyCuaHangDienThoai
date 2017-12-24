using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccess;

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
        public List<NhanVien> layNhanVien()
        {
            try
            {
                return model.NhanViens.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Thêm nhân viên
        public bool themNhanVien(NhanVien nv)
        {
            try
            {
                model.NhanViens.Add(nv);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        // Xóa nhân viên
        public bool xoaNhanVien()
        {
            try
            {
                NhanVien nv = model.NhanViens.Find(MaNV);
                model.NhanViens.Remove(nv);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa thông tin nhân viên
        public bool suaNhanVien()
        {
            try
            {
                NhanVien nv = model.NhanViens.Find(MaNV);
                nv.TenNV = TenNV;
                nv.NgaySinh = NgaySinh;
                nv.GioiTinh = GioiTinh;
                nv.SoDT = SoDT;
                nv.Email = Email;
                nv.DiaChi = DiaChi;
                nv.Quyen = Quyen;
                nv.ChucVu = ChucVu;
                nv.MatKhau = MatKhau;
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
