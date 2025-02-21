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
    public partial class KhuyenMai : Form
    {
        Database db = new Database();
        public KhuyenMai()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT IDKhuyenMai, MaKhuyenMai, PhanTramGiam, NgayBatDau, NgayKetThuc FROM KhuyenMai";
            dgvKhuyenMai.DataSource = db.GetData(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int idKhuyenMai = int.Parse(txtIDKhuyenMai.Text);
            string maKM = txtMaKhuyenMai.Text;
            decimal phanTram = decimal.Parse(txtPhanTramGiam.Text);
            DateTime ngayBD = dtpNgayBatDau.Value;
            DateTime ngayKT = dtpNgayKetThuc.Value;

            // Kiểm tra ngày hợp lệ
            if (ngayKT <= ngayBD)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                return;
            }

            string query = $"INSERT INTO KhuyenMai (IDKhuyenMai, MaKhuyenMai, PhanTramGiam, NgayBatDau, NgayKetThuc) " +
                           $"VALUES ({idKhuyenMai}, N'{maKM}', {phanTram}, '{ngayBD}', '{ngayKT}')";

            if (db.ExecuteQuery(query))
            {
                MessageBox.Show("Thêm khuyến mãi thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm khuyến mãi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKhuyenMai.SelectedRows[0].Cells[0].Value);
                string maKM = txtMaKhuyenMai.Text;
                decimal phanTram = decimal.Parse(txtPhanTramGiam.Text);
                DateTime ngayBD = dtpNgayBatDau.Value;
                DateTime ngayKT = dtpNgayKetThuc.Value;

                if (ngayKT <= ngayBD)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                    return;
                }

                string query = $"UPDATE KhuyenMai SET MaKhuyenMai = N'{maKM}', PhanTramGiam = {phanTram}, " +
                               $"NgayBatDau = '{ngayBD}', NgayKetThuc = '{ngayKT}' WHERE IDKhuyenMai = {id}";

                if (db.ExecuteQuery(query))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuyenMai.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKhuyenMai.SelectedRows[0].Cells[0].Value);
                string query = $"DELETE FROM KhuyenMai WHERE IDKhuyenMai = {id}";

                if (db.ExecuteQuery(query))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi!");
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];
                txtIDKhuyenMai.Text = row.Cells["IDKhuyenMai"].Value.ToString();
                txtMaKhuyenMai.Text = row.Cells["MaKhuyenMai"].Value.ToString();
                txtPhanTramGiam.Text = row.Cells["PhanTramGiam"].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
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
