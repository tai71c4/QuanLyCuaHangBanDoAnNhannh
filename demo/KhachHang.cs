using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDoAnNhanh
{
    public partial class KhachHang : Form
    {
        Database db = new Database();
        public KhachHang()
        {
            InitializeComponent();
            LoadData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoadData()
        {
            string query = "SELECT IDKhachHang, HoTen, SDT, DiemTichLuy FROM KhachHang";
            dgvKhachHang.DataSource = db.GetData(query);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int idKhachHang = int.Parse(txtIDKhachHang.Text);
            string hoTen = txtHoTenKhachHang.Text;
            string sdt = txtSDTKhachHang.Text;
            int diemTichLuy = int.Parse(txtDiemTichLuy.Text);

            string query = $"INSERT INTO KhachHang (IDKhachHang, HoTen, SDT, DiemTichLuy) " +
                           $"VALUES ({idKhachHang}, N'{hoTen}', '{sdt}', {diemTichLuy})";

            if (db.ExecuteQuery(query))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm khách hàng!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKhachHang.SelectedRows[0].Cells[0].Value);
                string hoTen = txtHoTen.Text;
                string sdt = txtSDTKhachHang.Text;
                int diemTichLuy = int.Parse(txtDiemTichLuy.Text);

                string query = $"UPDATE KhachHang SET HoTen = N'{hoTen}', SDT = '{sdt}', " +
                               $"DiemTichLuy = {diemTichLuy} WHERE IDKhachHang = {id}";

                if (db.ExecuteQuery(query))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật khách hàng!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKhachHang.SelectedRows[0].Cells[0].Value);
                string query = $"DELETE FROM KhachHang WHERE IDKhachHang = {id}";

                if (db.ExecuteQuery(query))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtIDKhachHang.Text = row.Cells["IDKhachHang"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtSDTKhachHang.Text = row.Cells["SDT"].Value.ToString();
            txtDiemTichLuy.Text = row.Cells["DiemTichLuy"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show();
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtHoTen.Text;
            string query = $"SELECT * FROM KhachHang WHERE HoTen LIKE N'%{keyword}%'";
            dgvKhachHang.DataSource = db.GetData(query);
        }
    }
}
