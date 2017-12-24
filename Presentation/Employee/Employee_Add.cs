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
using Function;

namespace Presentation.Employee
{
    public partial class Employee_Add : Form
    {
        NhanVien_BL bl = new NhanVien_BL();

        public Employee_Add()
        {
            InitializeComponent();
        }

        // Lấy danh sách chức vụ nhân viên
        private void Employee_Add_Load(object sender, EventArgs e)
        {
            foreach(NhanVien nv in bl.layNhanVien())
            {
                if(nv.Quyen.Equals("Nhân viên"))
                    cbChucVu.Items.Add(nv.ChucVu);
            }
        }

        // Click Add để thêm nhân viên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtTenNV.Text;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.GioiTinh = cbGioiTinh.Text;
                nv.SoDT = txtSoDT.Text;
                nv.Email = txtEmail.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.Quyen = "Nhân viên";
                nv.ChucVu = cbChucVu.Text;
                nv.MatKhau = null;

                if (bl.themNhanVien(nv))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Vui lòng kiểm tra lại");
            }
            catch
            {

            }
        }

        // Clear các TextBox
        private void btnClear_Click(object sender, EventArgs e)
        {
            Algorithm.clearInput(this);
        }
    }
}
