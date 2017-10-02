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

        public KhachHang_BL()
        {
            model = new DataModel();
        }


        // Lấy danh sách tất cả khách hàng
        public List<KhachHang> danhSach()
        {
            return model.KhachHangs.ToList();
        }
    }
}
