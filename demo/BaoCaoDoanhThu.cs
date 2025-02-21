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
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace demo
{
    public partial class BaoCaoDoanhThu : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyCuaHangBanDoAnNhanh;Integrated Security=True";
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            LoadChart();
        }
        private void LoadChart()
        {
            string connectionString = "Server=ASUS-TUF-GAMING;Database=QuanLyCuaHangBanDoAnNhanh;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Thang, SUM(DoanhThu) AS TongDoanhThu FROM DoanhThu GROUP BY Thang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                chartDoanhThu.Series.Clear(); 
                Series series = new Series("Doanh Thu");
                series.ChartType = SeriesChartType.Column; 
                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["Thang"].ToString(), Convert.ToDouble(row["TongDoanhThu"]));
                }

                chartDoanhThu.Series.Add(series);
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }
        private void LoadDoanhThu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT DH.IDDonHang, KH.HoTen AS KhachHang, NV.HoTen AS NhanVien, DH.NgayTao, SUM(CT.SoLuong * CT.Gia) AS TongTien
                    FROM DonHang DH
                    JOIN ChiTietDonHang CT ON DH.IDDonHang = CT.IDDonHang
                    LEFT JOIN KhachHang KH ON DH.IDKhachHang = KH.IDKhachHang
                    JOIN NhanVien NV ON DH.IDNhanVien = NV.IDNhanVien
                    WHERE DH.NgayTao BETWEEN @TuNgay AND @DenNgay
                    GROUP BY DH.IDDonHang, KH.HoTen, NV.HoTen, DH.NgayTao
                    ORDER BY DH.NgayTao DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value);
                cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBaoCao.DataSource = dt;

                // Tính tổng doanh thu
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["TongTien"]);
                }
                lblTongDoanhThu.Text = $"Tổng Doanh Thu: {tongDoanhThu:N0} VNĐ";
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new OfficeOpenXml.ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Báo Cáo Doanh Thu");
                        worksheet.Cells["A1"].LoadFromDataTable((DataTable)dgvBaoCao.DataSource, true);
                        package.SaveAs(new System.IO.FileInfo(sfd.FileName));
                    }
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
