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
    public partial class DonHang : Form
    {
        Database db = new Database();
        public DonHang()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoadData()
        {
            string query = "SELECT IDDonHang, IDKhachHang, IDNhanVien, IDKhuyenMai, NgayTao, TrangThai FROM DonHang";
            dgvDonHang.DataSource = db.GetData(query);

        }

   
        private void LoadComboBoxData()
        {
            cbKhachHang.DataSource = db.GetData("SELECT IDKhachHang, HoTen FROM KhachHang");
            cbKhachHang.DisplayMember = "HoTen";
            cbKhachHang.ValueMember = "IDKhachHang";

            cbNhanVien.DataSource = db.GetData("SELECT IDNhanVien, HoTen FROM NhanVien");
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "IDNhanVien";

            cbKhuyenMai.DataSource = db.GetData("SELECT IDKhuyenMai, MaKhuyenMai FROM KhuyenMai");
            cbKhuyenMai.DisplayMember = "MaKhuyenMai";
            cbKhuyenMai.ValueMember = "IDKhuyenMai";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DonHang (IDDonHang, IDKhachHang, IDNhanVien, IDKhuyenMai, NgayTao, TrangThai) " +
                   "VALUES (@idDonHang, @idKhachHang, @idNhanVien, @idKhuyenMai, @ngayTao, @trangThai)";

            SqlParameter[] parameters =
            {
        new SqlParameter("@idDonHang", int.Parse(txtIDDonHang.Text)),
        new SqlParameter("@idKhachHang", Convert.ToInt32(cbKhachHang.SelectedValue)),
        new SqlParameter("@idNhanVien", Convert.ToInt32(cbNhanVien.SelectedValue)),
        new SqlParameter("@idKhuyenMai", cbKhuyenMai.SelectedValue ?? (object)DBNull.Value),
        new SqlParameter("@ngayTao", dtpNgayTao.Value),
        new SqlParameter("@trangThai", cbTrangThai.Text)
    };

            if (db.ExecuteQueryWithParams(query, parameters))
            {
                MessageBox.Show("Thêm đơn hàng thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDonHang.SelectedRows[0].Cells[0].Value);
                string query = "UPDATE DonHang SET IDKhachHang = @idKhachHang, IDNhanVien = @idNhanVien, " +
                               "IDKhuyenMai = @idKhuyenMai, NgayTao = @ngayTao, TrangThai = @trangThai " +
                               "WHERE IDDonHang = @id";

                SqlParameter[] parameters =
                {
            new SqlParameter("@id", id),
            new SqlParameter("@idKhachHang", Convert.ToInt32(cbKhachHang.SelectedValue)),
            new SqlParameter("@idNhanVien", Convert.ToInt32(cbNhanVien.SelectedValue)),
            new SqlParameter("@idKhuyenMai", cbKhuyenMai.SelectedValue ?? (object)DBNull.Value),
            new SqlParameter("@ngayTao", dtpNgayTao.Value),
            new SqlParameter("@trangThai", cbTrangThai.Text)
        };

                if (db.ExecuteQueryWithParams(query, parameters))
                {
                    MessageBox.Show("Cập nhật đơn hàng thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!");
            }
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDonHang.SelectedRows[0].Cells[0].Value);
                string query = "DELETE FROM DonHang WHERE IDDonHang = @id";

                SqlParameter[] parameters =
                {
            new SqlParameter("@id", id)
        };

                if (db.ExecuteQueryWithParams(query, parameters))
                {
                    MessageBox.Show("Xóa đơn hàng thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!");
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];
                txtIDDonHang.Text = row.Cells["IDDonHang"].Value.ToString();
                cbKhachHang.SelectedValue = row.Cells["IDKhachHang"].Value;
                cbNhanVien.SelectedValue = row.Cells["IDNhanVien"].Value;
                cbKhuyenMai.SelectedValue = row.Cells["IDKhuyenMai"].Value;
                dtpNgayTao.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);
                cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show(); 
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            string query = "SELECT IDDonHang, IDKhachHang, IDNhanVien, IDKhuyenMai, NgayTao, TrangThai " +
                           "FROM DonHang WHERE IDDonHang LIKE @keyword OR " +
                           "IDKhachHang IN (SELECT IDKhachHang FROM KhachHang WHERE HoTen LIKE @keyword) OR " +
                           "TrangThai LIKE @keyword";

            SqlParameter[] parameters =
            {
        new SqlParameter("@keyword", "%" + keyword + "%")
    };

            dgvDonHang.DataSource = db.ExecuteQueryWithParams(query, parameters);
        }
    }
}
