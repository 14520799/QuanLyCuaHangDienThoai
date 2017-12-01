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


        private void Invoice_Buy_View_Load(object sender, EventArgs e)
        {
            dgvHoaDonMua.AutoGenerateColumns = false;

        }
    }
}
