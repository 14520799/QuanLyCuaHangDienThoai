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

namespace Presentation.Admin
{
    public partial class Admin_Search : Form
    {
        TraCuu_BL bl = new TraCuu_BL();

        public Admin_Search()
        {
            InitializeComponent();
        }


        private void Admin_Search_Load(object sender, EventArgs e)
        {

        }

        private void cbDanhMuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbThuocTinh.Items.Clear();
            List<string> thuocTinh = bl.loadThuocTinh(cbDanhMuc.Text);

            cbThuocTinh.Items.Add(thuocTinh[0]);
            cbThuocTinh.Items.Add(thuocTinh[1]);
            cbThuocTinh.Items.Add(thuocTinh[2]);
        }
    }
}
