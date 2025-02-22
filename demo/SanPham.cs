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
using System.IO;


namespace QuanLyCuaHangBanDoAnNhanh
{
    public partial class SanPham : Form
    {
        Database db = new Database();
        string imagePath = "";
        public SanPham()
        {
            InitializeComponent();
            LoadData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            int idSanPham = int.Parse(txtIDSanPham.Text);
            string tenSanPham = txtTenSanPham.Text;
            decimal gia = Convert.ToDecimal(txtGia.Text);
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            string hinhAnh = string.IsNullOrEmpty(imagePath) ? "NULL" : $"'{imagePath}'";

            string query = $"INSERT INTO SanPham (IDSanPham, TenSanPham, Gia, SoLuong, HinhAnh) " +
                           $"VALUES ({idSanPham}, N'{tenSanPham}', {gia}, {soLuong}, {hinhAnh})";

            if (db.ExecuteQuery(query))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm!");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                int idSanPham = Convert.ToInt32(txtIDSanPham.Text);
                string tenSanPham = txtTenSanPham.Text;
                decimal gia = Convert.ToDecimal(txtGia.Text);
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                string hinhAnh = string.IsNullOrEmpty(imagePath) ? "NULL" : $"'{imagePath}'";

                string query = $"UPDATE SanPham SET TenSanPham = N'{tenSanPham}', Gia = {gia}, " +
                               $"SoLuong = {soLuong}, HinhAnh = {hinhAnh} " +
                               $"WHERE IDSanPham = {idSanPham}";

                if (db.ExecuteQuery(query))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật sản phẩm!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                int idSanPham = Convert.ToInt32(txtIDSanPham.Text);
                string query = $"DELETE FROM SanPham WHERE IDSanPham = {idSanPham}";

                if (db.ExecuteQuery(query))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
        }


        private void LoadData()
        {
            string query = "SELECT IDSanPham, TenSanPham, Gia, HinhAnh, SoLuong FROM SanPham";
            dgvSanPham.DataSource = db.GetData(query);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTenSanPham.Text;
            string query = $"SELECT * FROM SanPham WHERE TenSanPham LIKE N'%{keyword}%'";
            dgvSanPham.DataSource = db.GetData(query);
        }
        private int GetNextID()
        {
            DataTable dt = db.GetData("SELECT MAX(IDSanPham) FROM SanPham");
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
            return 1;
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName; 
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show();
            this.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtIDSanPham.Text = row.Cells["IDSanPham"].Value.ToString();
                txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                imagePath = row.Cells["HinhAnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                }
    
        }
    }
}
