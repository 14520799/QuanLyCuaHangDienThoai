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

namespace Presentation.Factory
{
    public partial class Factory_Add : Form
    {
        HangSX_BL bl = new HangSX_BL();

        public Factory_Add()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            HangSanXuat hsx = new HangSanXuat();
            hsx.MaHang = txtMaHang.Text;
            hsx.TenHang = txtTenHang.Text;
            hsx.SoDT = txtSoDT.Text;
            hsx.Email = txtEmail.Text;
            hsx.DiaChi = txtDiaChi.Text;

            try
            {
                bl.create(hsx);
                MessageBox.Show("Thêm thành công !");
            }
            catch
            {

            }
        }
    }
}
