using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class DangNhap : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyCuaHangBanDoAnNhanh;Integrated Security=True";
        public static string userRole = "";
        public DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
             
                string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    object result = cmd.ExecuteScalar();
                    if (result != null)  
                    {
                        string userRole = result.ToString();  
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TrangChu formTrangChu = new TrangChu(userRole);
                        formTrangChu.Show();

                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy formDangKy = new DangKy();
            formDangKy.ShowDialog();
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !ckbHienMatKhau.Checked;
        }

       
    }
    
}
