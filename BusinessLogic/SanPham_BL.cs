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

        // Lấy danh sách sản phẩm
        public List<SanPham> laySanPham()
        {
            try
            {
                return model.SanPhams.ToList();
            }
            catch
            {
                return null;
            }
        }

        // Thêm sản phẩm
        public bool themSanPham(SanPham sp)
        {
            try
            {
                model.SanPhams.Add(sp);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa sản phẩm
        public bool xoaSanPham()
        {
            try
            {
                SanPham sp = model.SanPhams.Find(MaSP);
                model.SanPhams.Remove(sp);
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa sản phẩm
        public bool suaSanPham()
        {
            try
            {
                SanPham sp = model.SanPhams.Find(MaSP);
                sp.TenSP = TenSP;
                sp.HinhAnh = HinhAnh;
                sp.DonGia = DonGia;
                sp.MoTa = MoTa;
                sp.SoLuong = SoLuong;
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
                sp.MaHang = MaHang;
                sp.MaLoai = MaLoai;
                model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
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

        // Tìm Mã Loại tương ứng với Tên Loại
        public string timMaLoai(string TenLoai)
        {
            if (TenLoai.Equals("Điện thoại"))
                return "LSP01";

            return "LSP02";
        }
    }
}
