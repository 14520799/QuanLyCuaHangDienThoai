using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Product
{
    public partial class Product_Detail : Form
    {
        public Product_Detail(List<string> ctsp)
        {
            InitializeComponent();
            txtManHinh.Text = ctsp[0];
            txtCameraTruoc.Text = ctsp[1];
            txtCameraSau.Text = ctsp[2];
            txtHDH.Text = ctsp[3];
            txtCPU.Text = ctsp[4];
            txtRAM.Text = ctsp[5];
            txtBoNhoTrong.Text = ctsp[6];
            txtTheNho.Text = ctsp[7];
            txtTheSIM.Text = ctsp[8];
            txtDungLuongPin.Text = ctsp[9];
        }
    }
}
