using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class KhachHang
    {
        DataModel model;

        public KhachHang()
        {
            model = new DataModel();
        }

        public List<DataAccess.KhachHang> danhSach()
        {
            return model.KhachHangs.ToList();
        }
    }
}
