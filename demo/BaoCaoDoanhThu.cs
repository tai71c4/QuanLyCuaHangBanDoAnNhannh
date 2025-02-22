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


namespace QuanLyCuaHangBanDoAnNhanh
{
    public partial class BaoCaoDoanhThu : Form
    {
        Database db = new Database();
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            LoadChart();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            DateTime fromDate = dtpTuNgay.Value;
            DateTime toDate = dtpDenNgay.Value;

            string query = $@"
                SELECT NgayThanhToan, SUM(TongTien) AS DoanhThu
                FROM HoaDon
                WHERE NgayThanhToan BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'
                GROUP BY NgayThanhToan
                ORDER BY NgayThanhToan";

         
            DataTable dt = db.GetData(query);
            dgvBaoCao.DataSource = dt;

            decimal totalRevenue = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["DoanhThu"]);
            }

            lblTongDoanhThu.Text = "Tổng Doanh Thu: " + totalRevenue.ToString("N0");

            chartDoanhThu.Series["DoanhThu"].Points.Clear(); 

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayThanhToan = Convert.ToDateTime(row["NgayThanhToan"]);
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);

                chartDoanhThu.Series["DoanhThu"].Points.AddXY(ngayThanhToan.ToString("dd/MM/yyyy"), doanhThu);
            }
        }
        

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count > 0)
            {
                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.FileName = "DoanhThuReport.xlsx"; // Đặt tên mặc định cho file

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("DoanhThu");

                     
                        for (int col = 0; col < dgvBaoCao.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col + 1].Value = dgvBaoCao.Columns[col].HeaderText; 

                            for (int row = 0; row < dgvBaoCao.Rows.Count; row++)
                            {
                                if (dgvBaoCao.Rows[row].Cells[col].Value != null)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dgvBaoCao.Rows[row].Cells[col].Value.ToString(); 
                                }
                            }
                        }

                      
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fileInfo);
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show();
            this.Close();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
