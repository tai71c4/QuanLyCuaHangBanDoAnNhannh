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

namespace QuanLyCuaHangBanDoAnNhanh
{
    public partial class DangKy : Form
    {
        private Database db = new Database();
        public DangKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Properties.Resources.Nen;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void DangKy_Load(object sender, EventArgs e)
        {
            cboLoaiTaiKhoan.Items.AddRange(new object[] { "Admin", "NhanVien" });
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            string loaiTaiKhoan = cboLoaiTaiKhoan.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(nhapLaiMatKhau) || string.IsNullOrEmpty(loaiTaiKhoan))
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

            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan) VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau),
                new SqlParameter("@LoaiTaiKhoan", loaiTaiKhoan)
            };
            db.ExecuteQueryWithParams(query, parameters);

            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            new DangNhap().Show();
        }

        private bool KiemTraTaiKhoanTonTai(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

            SqlParameter[] parameters =
            {
        new SqlParameter("@TenDangNhap", tenDangNhap)
    };

            object result = db.ExecuteScalar(query, parameters);

            int count = (result != null) ? Convert.ToInt32(result) : 0;
            return count > 0;
        }
            
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new DangNhap().Show();
        }
    }
    
}
