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
    public partial class Invoice_Sale_View : Form
    {
        HoaDonBan_BL bl = new HoaDonBan_BL();

        public Invoice_Sale_View()
        {
            InitializeComponent();
        }

        // Xem danh sách hóa đơn bán + chi tiết bán tương ứng
        private void Invoice_Sale_View_Load(object sender, EventArgs e)
        {
            dgvHoaDonBan.AutoGenerateColumns = false;
            dgvChiTietBan.AutoGenerateColumns = false;
            bl.xoaHDB(bl.layHDB());
            dgvHoaDonBan.DataSource = bl.layHDB();

            // Định dạng các giá trị trong DataGridView 
            foreach (DataGridViewRow row in dgvHoaDonBan.Rows)
            {
                row.Cells[4].Value = row.Cells[4].Value.ToString().Replace(".000", "");
                row.Cells[5].Value = row.Cells[5].Value.ToString().Replace(".000", "");
            }
        }

        // Sự kiện thay đổi lựa chọn trên dgvHoaDonBan => Load danh sách chi tiết bán tương ứng
        private void dgvHoaDonBan_SelectionChanged(object sender, EventArgs e)
        {
            dgvChiTietBan.DataSource = bl.ctbTheoMaHDB(dgvHoaDonBan.CurrentRow.Cells[0].Value.ToString());

            // Định dạng các giá trị trong DataGridView 
            foreach (DataGridViewRow row in dgvChiTietBan.Rows)
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
