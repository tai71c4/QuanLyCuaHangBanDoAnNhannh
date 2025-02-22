using Org.BouncyCastle.Pqc.Crypto.Lms;
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
using Microsoft.VisualBasic;


namespace QuanLyCuaHangBanDoAnNhanh
{
    public partial class DangNhap : Form
    {
        private Database db = new Database();
        public static string userRole = "";
        public DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Properties.Resources.Nen;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;


        }
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

            string connectionString = "Data Source=.;Initial Catalog=QuanLyCuaHangBanDoAnNhanh;Integrated Security=True";
            DataTable result = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (result.Rows.Count > 0)
            {
                userRole = result.Rows[0]["LoaiTaiKhoan"].ToString();
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string adminPassword = "123456";
            string inputPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Vui lòng nhập mật khẩu Admin để đăng ký tài khoản mới:",
                "Xác nhận ",
                "",
                -1,
                -1
            );

            if (inputPassword == adminPassword)
            {
                this.Hide();
                DangKy formDangKy = new DangKy();
                formDangKy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mật khẩu Admin  không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !ckbHienMatKhau.Checked;
        }
    }
    
}
