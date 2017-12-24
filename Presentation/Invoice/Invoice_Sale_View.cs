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

        private void Invoice_Sale_View_Load(object sender, EventArgs e)
        {
            dgvHoaDonBan.AutoGenerateColumns = false;
            dgvChiTietBan.AutoGenerateColumns = false;
            dgvHoaDonBan.DataSource = bl.xemHDB();
        }

        private void dgvHoaDonBan_SelectionChanged(object sender, EventArgs e)
        {
            dgvChiTietBan.DataSource = bl.xemCTB(dgvHoaDonBan.CurrentRow.Cells[0].Value.ToString());

            foreach (DataGridViewRow row in dgvChiTietBan.Rows)
            {
                foreach (SanPham sp in bl.laySanPham())
                {
                    if (sp.MaSP.Equals(row.Cells[1].Value.ToString()))
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
