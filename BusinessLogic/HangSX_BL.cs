using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Function;

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


        public void create(HangSanXuat hsx)
        {
            try
            {
                model.HangSanXuats.Add(hsx);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public List<HangSanXuat> read()
        {
            return model.HangSanXuats.ToList();
        }


        public void delete()
        {
            try
            {
                HangSanXuat hsx = model.HangSanXuats.Find(MaHang);
                model.HangSanXuats.Remove(hsx);
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public void update()
        {
            try
            {
                HangSanXuat hsx = model.HangSanXuats.Find(MaHang);
                hsx.TenHang = TenHang;
                hsx.SoDT = SoDT;
                hsx.Email = Email;
                hsx.DiaChi = DiaChi;
                model.SaveChanges();
            }
            catch
            {

            }
        }


        public List<SanPham> sanPhamHang(string id)
        {
            List<SanPham> sp = new List<SanPham>();

            try
            {
                sp = model.SanPhams.Where(x => x.MaHang.Equals(id)).ToList();
            }
            catch
            {

            }

            return sp;
        }
    }
}
