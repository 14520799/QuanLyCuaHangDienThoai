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
    public class SanPham_BL
    {
        private DataModel model;
        public DateTime NgaySinh;
        public decimal DonGia;
        public int SoLuong;
        public string MaSP, TenSP, HinhAnh, MoTa, ManHinh, HDH, CameraTruoc, CameraSau, CPU, RAM, BoNhoTrong, TheNho, TheSIM, DungLuongPin, MaHang, MaLoai;

        public SanPham_BL()
        {
            model = new DataModel();
        }


        // Tìm sản phẩm theo MaSP
        public SanPham timTheoID(string MaSP)
        {
            try
            {
                SanPham sp = model.SanPhams.First(x => x.MaSP.Equals(MaSP));
                return sp;
            }
            catch
            {
                return null;
            }
        }


        // Lấy danh sách sản phẩm
        public List<SanPham> load()
        {
            return model.SanPhams.ToList();
        }

        // Thêm sản phẩm
        public void them(SanPham sp)
        {
            try
            {
                model.SanPhams.Add(sp);
                model.SaveChanges();
            }
            catch
            {

            }
        }

        // Xóa sản phẩm
        public void xoa()
        {
            SanPham sp = model.SanPhams.First(x => x.MaSP.Equals(MaSP));
            model.SanPhams.Remove(sp);
            model.SaveChanges();
        }

        // Sửa thông tin sản phẩm
        public void sua()
        {
            try
            {
                SanPham sp = model.SanPhams.Find(MaSP);
                sp.TenSP = TenSP;
                sp.HinhAnh = HinhAnh;
                sp.MoTa = MoTa;
                sp.ManHinh = ManHinh;
                sp.HDH = HDH;
                sp.CameraTruoc = CameraTruoc;
                sp.CameraSau = CameraSau;
                sp.CPU = CPU;
                sp.RAM = RAM;
                sp.BoNhoTrong = BoNhoTrong;
                sp.TheNho = TheNho;
                sp.TheSIM = TheSIM;
                sp.DungLuongPin = DungLuongPin;
                model.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
