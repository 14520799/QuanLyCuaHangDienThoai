using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

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

        public List<NhanVien> findMaNV(string MaNV)
        {
            return model.NhanViens.Where(x => x.MaNV.Contains(MaNV)).ToList();
        }
    }
}
