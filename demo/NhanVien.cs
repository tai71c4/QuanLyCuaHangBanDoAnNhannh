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
    public partial class NhanVien : Form
    {
        Database db = new Database();
        public NhanVien()
        {
            InitializeComponent();
            LoadData();
            LoadTaiKhoan();
        }
        private void LoadData()
        {
            string query = "SELECT IDNhanVien, HoTen, SDT, DiaChi, IDTaiKhoan FROM NhanVien";
            dgvNhanVien.DataSource = db.GetData(query);
        }
        private void LoadTaiKhoan()
        {
            string query = "SELECT IDTaiKhoan, TenDangNhap FROM TaiKhoan";
            DataTable dt = db.GetData(query);
            cbTaiKhoan.DataSource = dt;
            cbTaiKhoan.DisplayMember = "TenDangNhap";
            cbTaiKhoan.ValueMember = "IDTaiKhoan";
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            int idNhanVien = int.Parse(txtIDNhanVien.Text);
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            int idTaiKhoan = (int)cbTaiKhoan.SelectedValue;

            string query = $"INSERT INTO NhanVien (IDNhanVien, HoTen, SDT, DiaChi, IDTaiKhoan) " +
                           $"VALUES ({idNhanVien}, N'{hoTen}', '{sdt}', N'{diaChi}', {idTaiKhoan})";

            if (db.ExecuteQuery(query))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhân viên!");
            }
        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[0].Value);
                string hoTen = txtHoTen.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                int idTaiKhoan = (int)cbTaiKhoan.SelectedValue;

                string query = $"UPDATE NhanVien SET HoTen = N'{hoTen}', SDT = '{sdt}', " +
                               $"DiaChi = N'{diaChi}', IDTaiKhoan = {idTaiKhoan} WHERE IDNhanVien = {id}";

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
                MessageBox.Show("Vui lòng chọn nhân viên!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[0].Value);
                string query = $"DELETE FROM NhanVien WHERE IDNhanVien = {id}";

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
                MessageBox.Show("Vui lòng chọn nhân viên!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtHoTen.Text;
            string query = $"SELECT * FROM NhanVien WHERE HoTen LIKE N'%{keyword}%'";
            dgvNhanVien.DataSource = db.GetData(query);
        }

        private int GetNextID()
        {
            DataTable dt = db.GetData("SELECT MAX(IDNhanVien) FROM NhanVien");
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
            return 1;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtIDNhanVien.Text = row.Cells["IDNhanVien"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            cbTaiKhoan.SelectedValue = row.Cells["IDTaiKhoan"].Value;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show();
            this.Close();
        }
    }
}
    

