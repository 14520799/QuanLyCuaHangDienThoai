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


        public SanPham_BL()
        {
            model = new DataModel();
        }


        // Lấy danh sách sản phẩm
        public List<SanPham> danhSach()
        {
            return model.SanPhams.ToList();
        }
    }
}
