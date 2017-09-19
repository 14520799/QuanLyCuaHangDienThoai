using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Function;

namespace BusinessLogic
{
    public class NhanVien
    {
        DataModelEntities model;

        public NhanVien()
        {
            model = new DataModelEntities();
        }

        public List<DataAccess.NhanVien> layDanhSach()
        {
            return model.NhanViens.ToList();
        }

        public List<DataAccess.NhanVien> timTheoTen(string ten)
        {
            return model.NhanViens.Where(nv => nv.TenNV.Contains(ten)).ToList();
        }

        public void them(DataAccess.NhanVien nv)
        {
            model.NhanViens.Add(nv);
            model.SaveChanges();
        }
    }
}
