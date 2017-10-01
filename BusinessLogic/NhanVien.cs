using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Function;
using System.Data.Entity;

namespace BusinessLogic
{
    public class NhanVien
    {
        DataModel model;
        
        public NhanVien()
        {
            model = new DataModel();
        }

        public List<DataAccess.NhanVien> danhSach()
        {
            return model.NhanViens.ToList();
        }

        public void capNhat(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string SoDT, string Email, string DiaChi, string Quyen, string ChucVu)
        {
            try
            {
                DataAccess.NhanVien nv = new DataAccess.NhanVien();
                nv = model.NhanViens.First(x => x.MaNV == MaNV);
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

        public List<DataAccess.NhanVien> timTheoTen(string TenNV)
        {
            return model.NhanViens.Where(nv => nv.TenNV.Contains(TenNV)).ToList();
        }
    }
}
