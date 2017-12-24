using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace Presentation.Invoice
{
    public partial class Invoice_Buy_View : Form
    {
        HoaDonMua_BL bl = new HoaDonMua_BL();

        public Invoice_Buy_View()
        {
            InitializeComponent();
        }

        // Xem danh sách hóa đơn mua + chi tiết mua tương ứng
        private void Invoice_Buy_View_Load(object sender, EventArgs e)
        {
            dgvHoaDonMua.AutoGenerateColumns = false;
            dgvChiTietMua.AutoGenerateColumns = false;
            bl.xoaHDM(bl.layHDM());
            dgvHoaDonMua.DataSource = bl.layHDM();
        }

        // Sự kiện thay đổi lựa chọn trên dgvHoaDonMua => Load danh sách chi tiết mua tương ứng
        private void dgvHoaDonMua_SelectionChanged(object sender, EventArgs e)
        {
            dgvChiTietMua.DataSource = bl.ctmTheoMaHDM(dgvHoaDonMua.CurrentRow.Cells[0].Value.ToString());

            // Định dạng các giá trị trong DataGridView 
            foreach (DataGridViewRow row in dgvChiTietMua.Rows)
            {
                foreach (SanPham sp in bl.laySanPham())
                {
                    if (sp.MaSP.Equals(row.Cells[1].Value))
                    {
                        row.Cells[1].Value = sp.TenSP;
                        break;
                    }
                }

                row.Cells[2].Value = row.Cells[2].Value.ToString().Replace(".000", "");
                row.Cells[4].Value = row.Cells[4].Value.ToString().Replace(".000", "");
                row.Cells[5].Value = row.Cells[5].Value.ToString().Replace(".000", "");
            }
        }
    }
}
