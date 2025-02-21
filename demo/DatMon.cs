using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace demo
{
    public partial class DatMon : Form
    {
        private Database db = new Database();
        private int soBan;
        public DatMon(int soBan)
        {
            InitializeComponent();
            this.soBan = soBan;
            lblSoBan.Text = "Bàn " + soBan;
            LoadDanhSachMon();
            LoadData();
        }
        private void LoadDanhSachMon()
        {
            DataTable dt = db.GetDanhSachMon();
            lvDanhSachMon.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string tenMon = row["TenSanPham"].ToString();
                string gia = row["Gia"].ToString();

                ListViewItem item = new ListViewItem(tenMon);
                item.SubItems.Add(gia);

                lvDanhSachMon.Items.Add(item);
            }
        }
        private void LoadData()
        {
            string query = "SELECT * FROM DonHang";
            DataTable dt = db.GetData(query);

            lvMonDaChon.Items.Clear(); 

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["IDHoaDon"].ToString());
                item.SubItems.Add(row["IDKhachHang"].ToString());
                item.SubItems.Add(row["NgayLap"].ToString());
                item.SubItems.Add(row["TrangThai"].ToString());

                lvMonDaChon.Items.Add(item);
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (lvMonDaChon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để thanh toán!");
                return;
            }

            int idHoaDon = Convert.ToInt32(lvMonDaChon.SelectedItems[0].SubItems[0].Text);
            string query = $"UPDATE HoaDon SET TrangThai = N'Đã thanh toán' WHERE IDHoaDon = {idHoaDon}";

            if (db.ExecuteQuery(query))
            {
                MessageBox.Show("Thanh toán thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi thanh toán!");
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (lvMonDaChon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in!");
                return;
            }

            int idHoaDon = Convert.ToInt32(lvMonDaChon.SelectedItems[0].SubItems[0].Text);

            // Truy vấn dữ liệu hóa đơn
            string query = $"SELECT * FROM HoaDon WHERE IDHoaDon = {idHoaDon}";
            DataTable dt = db.GetData(query);

            if (dt.Rows.Count > 0)
            {
                string fileName = $"HoaDon_{idHoaDon}.pdf";
                ExportToPDF(dt, fileName);
                MessageBox.Show($"Hóa đơn đã được lưu thành file {fileName}");
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
            }
        }

        // Hàm xuất dữ liệu ra PDF (cần thư viện iTextSharp)
        private void ExportToPDF(DataTable dt, string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                PdfPTable table = new PdfPTable(dt.Columns.Count);
                foreach (DataColumn col in dt.Columns)
                {
                    table.AddCell(new Phrase(col.ColumnName));
                }

                foreach (DataRow row in dt.Rows)
                {
                    foreach (object cell in row.ItemArray)
                    {
                        table.AddCell(new Phrase(cell.ToString()));
                    }
                }

                pdfDoc.Add(table);
                pdfDoc.Close();
            }
        }

        private void btnGopHoaDon_Click(object sender, EventArgs e)
        {
           
            if (lvMonDaChon.SelectedItems.Count != 2)
            {
                MessageBox.Show("Vui lòng chọn đúng 2 hóa đơn để gộp!");
                return;
            }

            int idHoaDon1 = Convert.ToInt32(lvMonDaChon.SelectedItems[0].SubItems[0].Text);
            int idHoaDon2 = Convert.ToInt32(lvMonDaChon.SelectedItems[1].SubItems[0].Text);

            // Kiểm tra nếu 2 hóa đơn cùng khách hàng
            string queryCheck = $"SELECT IDKhachHang FROM HoaDon WHERE IDHoaDon IN ({idHoaDon1}, {idHoaDon2}) GROUP BY IDKhachHang HAVING COUNT(*) = 1";
            DataTable dtCheck = db.GetData(queryCheck);
            if (dtCheck.Rows.Count == 0)
            {
                MessageBox.Show("Hai hóa đơn phải thuộc cùng một khách hàng!");
                return;
            }

            // Gộp các món ăn từ hóa đơn 2 vào hóa đơn 1
            string queryMerge = $"UPDATE ChiTietHoaDon SET IDHoaDon = {idHoaDon1} WHERE IDHoaDon = {idHoaDon2};";
            string queryDelete = $"DELETE FROM HoaDon WHERE IDHoaDon = {idHoaDon2};";

            if (db.ExecuteQuery(queryMerge) && db.ExecuteQuery(queryDelete))
            {
                MessageBox.Show("Gộp hóa đơn thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi gộp hóa đơn!");
            }
        }

        

        private void lvDanhSachMon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string tenMon = e.Item.Text;
                string gia = e.Item.SubItems[1].Text;

                foreach (ListViewItem item in lvMonDaChon.Items)
                {
                    if (item.Text == tenMon)
                    {
                        
                        int soLuong = int.Parse(item.SubItems[1].Text) + 1;
                        item.SubItems[1].Text = soLuong.ToString();
                        return;
                    }
                }

          
                ListViewItem newItem = new ListViewItem(tenMon);
                newItem.SubItems.Add("1"); 
                newItem.SubItems.Add(gia);

                lvMonDaChon.Items.Add(newItem);
            }
        }

        private void lvMonDaChon_DoubleClick(object sender, EventArgs e)
        {
            if (lvMonDaChon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMonDaChon.SelectedItems[0];
                int soLuong = int.Parse(selectedItem.SubItems[1].Text) + 1;
                selectedItem.SubItems[1].Text = soLuong.ToString();
            }
        }

        private void lvMonDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMonDaChon.SelectedItems.Count > 0)
            {
                int idHoaDon = Convert.ToInt32(lvMonDaChon.SelectedItems[0].SubItems[0].Text);
                LoadChiTietHoaDon(idHoaDon);
                UpdateThanhTien();
            }
        }
        private void LoadChiTietHoaDon(int idHoaDon)
        {
            string query = $"SELECT MonAn.TenSanPham, ChiTietHoaDon.SoLuong, MonAn.Gia " +
                           $"FROM ChiTietHoaDon " +
                           $"JOIN MonAn ON ChiTietHoaDon.IDMonAn = MonAn.IDMonAn " +
                           $"WHERE ChiTietHoaDon.IDHoaDon = {idHoaDon}";

            DataTable dt = db.GetData(query);
            lvDanhSachMon.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["TenSanPham"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(row["Gia"].ToString());

                lvDanhSachMon.Items.Add(item);
            }
        }
        private void UpdateThanhTien()
{
    if (lvMonDaChon.SelectedItems.Count > 0)
    {
        int idHoaDon = Convert.ToInt32(lvMonDaChon.SelectedItems[0].SubItems[0].Text);

        string query = $"SELECT SUM(ChiTietHoaDon.SoLuong * MonAn.Gia) AS TienHang, " +
                       $"KhuyenMai.PhanTramGiam AS Giam " +
                       $"FROM ChiTietHoaDon " +
                       $"JOIN MonAn ON ChiTietHoaDon.IDMonAn = MonAn.IDMonAn " +
                       $"LEFT JOIN HoaDon ON ChiTietHoaDon.IDHoaDon = HoaDon.IDHoaDon " +
                       $"LEFT JOIN KhuyenMai ON HoaDon.IDKhuyenMai = KhuyenMai.IDKhuyenMai " +
                       $"WHERE ChiTietHoaDon.IDHoaDon = {idHoaDon}";

        DataTable dt = db.GetData(query);
        if (dt.Rows.Count > 0)
        {
            double tienHang = Convert.ToDouble(dt.Rows[0]["TienHang"]);
            double giam = dt.Rows[0]["Giam"] != DBNull.Value ? Convert.ToDouble(dt.Rows[0]["Giam"]) : 0;
            double tongTien = tienHang - (tienHang * giam / 100);

            lblTienHang.Text = tienHang.ToString("N0") + " VNĐ";
            lblGiam.Text = giam + "%";
            lblTong.Text = tongTien.ToString("N0") + " VNĐ";
        }
    }
}

    }
}