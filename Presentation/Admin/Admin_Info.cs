using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentation.Admin
{
    public partial class Admin_Info : Form
    {
        public Admin_Info()
        {            
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=desktop-r6658fp\sqlexpress;Initial Catalog=QuanLyCuaHangDienThoai;Integrated Security=True");
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin_Info_Load(sender, e);
        }

        private void Admin_Info_Load(object sender, EventArgs e)
        {
            //Load data
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From NhanVien", conn);
                da.Fill(dt);                
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbHoTen.DataSource = dt;
                cbHoTen.DisplayMember = "Tên Nhân Viên";
                cbHoTen.ValueMember = "TenNV";
                //cbGioiTinh.DataSource = dt;
                //cbGioiTinh.DisplayMember = "Male";
                //cbGioiTinh.ValueMember = "GioiTinh"; 
                conn.Open();
                SqlDataAdapter adt = new SqlDataAdapter("Select * from NhanVien", conn);
                DataTable dtab = new DataTable();
                adt.Fill(dtab);
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Value", dtab, "NgaySinh", true);
                txtSoDT.DataBindings.Clear();
                txtSoDT.DataBindings.Add("Text", dtab, "SoDT", true);
                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("Text", dtab, "Email", true);
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", dtab, "DiaChi", true);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Update NhanVien\nSet SoDT = values('" + txtSoDT.Text + "'), Email = values('" + txtEmail.Text + "'), DiaChi = values('" + txtDiaChi.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa thông tin QTV thành công!\n");
                //TenNV = values('" + cbHoTen.ValueMember + "'),  GioiTinh = values('" + cbGioiTinh.ValueMember + "'), NgaySinh = values('" + dtpNgaySinh.Value + "'), 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.ToString());
            }
        }

    }
}
