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
    public partial class DangKy : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanDoAnNhanh;Integrated Security=True";
        public DangKy()
        {
            InitializeComponent();
        }

      

        private void DangKy_Load(object sender, EventArgs e)
        {
            cboLoaiTaiKhoan.Items.Add("Admin");
            cboLoaiTaiKhoan.Items.Add("NhanVien");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            string loaiTaiKhoan = cboLoaiTaiKhoan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMatKhau) || string.IsNullOrEmpty(loaiTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KiemTraTaiKhoanTonTai(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan) VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
        }

        private bool KiemTraTaiKhoanTonTai(string tenDangNhap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
        }
    }
    
}
