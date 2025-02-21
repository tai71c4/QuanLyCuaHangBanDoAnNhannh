using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class DonHang : Form
    {
        Database db = new Database();
        public DonHang()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxData();
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
            int idDonHang = int.Parse(txtIDDonHang.Text);
            int idKhachHang = Convert.ToInt32(cbKhachHang.SelectedValue);
            int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);
            int? idKhuyenMai = cbKhuyenMai.SelectedValue != null ? (int?)Convert.ToInt32(cbKhuyenMai.SelectedValue) : null;
            DateTime ngayTao = dtpNgayTao.Value;
            string trangThai = cbTrangThai.Text;

            string query = $"INSERT INTO DonHang (IDDonHang, IDKhachHang, IDNhanVien, IDKhuyenMai, NgayTao, TrangThai) " +
                           $"VALUES ({idDonHang}, {idKhachHang}, {idNhanVien}, {idKhuyenMai}, '{ngayTao}', N'{trangThai}')";

            if (db.ExecuteQuery(query))
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
                int idKhachHang = Convert.ToInt32(cbKhachHang.SelectedValue);
                int idNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue);
                int? idKhuyenMai = cbKhuyenMai.SelectedValue != null ? (int?)Convert.ToInt32(cbKhuyenMai.SelectedValue) : null;
                DateTime ngayTao = dtpNgayTao.Value;
                string trangThai = cbTrangThai.Text;

                string query = $"UPDATE DonHang SET IDKhachHang = {idKhachHang}, IDNhanVien = {idNhanVien}, " +
                               $"IDKhuyenMai = {idKhuyenMai}, NgayTao = '{ngayTao}', TrangThai = N'{trangThai}' " +
                               $"WHERE IDDonHang = {id}";

                if (db.ExecuteQuery(query))
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
                string query = $"DELETE FROM DonHang WHERE IDDonHang = {id}";

                if (db.ExecuteQuery(query))
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
    }
}
