using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Function;

namespace BusinessLogic
{
    public class TraCuu_BL
    {
        private DataModel model;

        public TraCuu_BL()
        {
            model = new DataModel();
        }


        public List<string> loadThuocTinh(string danhMuc)
        {
            List<string> thuocTinh = new List<string>();

            switch (danhMuc)
            {
                case "Nhân Viên":
                    thuocTinh.AddRange(new [] { "Mã NV", "Tên NV", "Chức Vụ" });
                    break;
                case "Khách Hàng":
                    thuocTinh.AddRange(new [] { "Tên KH", "Số ĐT", "Còn Nợ" });
                    break;
                case "Sản Phẩm":
                    thuocTinh.AddRange(new [] { "Tên SP", "Loại SP", "Hãng SX" });
                    break;
                case "Hóa Đơn Mua":
                    thuocTinh.AddRange(new [] { "Mã HDM", "Nhân Viên", "Còn Nợ" });
                    break;
                case "Hóa Đơn Bán":
                    thuocTinh.AddRange(new [] { "Mã HDB", "Nhân Viên", "Khách Hàng", "Còn Nợ" });
                    break;
                default:
                    thuocTinh.Clear();
                    break;
            }

            return thuocTinh;
        }
        
        /*** TRA CỨU NHÂN VIÊN ***/
        public List<NhanVien> timMaNV(string MaNV)
        {
            return model.NhanViens.Where(x => x.MaNV.Contains(MaNV)).ToList();
        }

        public List<NhanVien> timTenNV(string TenNV)
        {
            List<NhanVien> result = new List<NhanVien>();

            foreach(NhanVien nv in model.NhanViens)
            {
                if (Algorithm.convertText(nv.TenNV).Contains(Algorithm.convertText(TenNV)))
                    result.Add(nv);
            }

            return result;
        }

        public List<NhanVien> timChucVu(string ChucVu)
        {
            return model.NhanViens.Where(x => x.ChucVu.Contains(ChucVu)).ToList();
        }


        /*** TRA CỨU KHÁCH HÀNG ***/
        public List<KhachHang> timTenKH(string TenKH)
        {
            List<KhachHang> result = new List<KhachHang>();

            foreach (KhachHang kh in model.KhachHangs)
            {
                if (Algorithm.convertText(kh.TenKH).Contains(Algorithm.convertText(TenKH)))
                    result.Add(kh);
            }

            return result;
        }

        public List<KhachHang> timSoDT(string SoDT)
        {
            return model.KhachHangs.Where(x => x.SoDT.Contains(SoDT)).ToList();
        }

        public List<KhachHang> timTienNo()
        {
            return model.KhachHangs.Where(x => x.TienNo > 0).ToList();
        }
    }
}
