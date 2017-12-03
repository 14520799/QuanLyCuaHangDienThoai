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
                    thuocTinh.AddRange(new[] { "Tên NV", "Số ĐT", "Chức Vụ" });
                    break;
            }

            return thuocTinh;
        }
    }
}
