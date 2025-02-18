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
    public partial class KhachMV : Form
    {
        public KhachMV()
        {
            InitializeComponent();
            LoadBanAn();
           

        }
        private void KhachMV_Load(object sender, EventArgs e)
        {
            int soNut = flowLayoutPanel1.Controls.OfType<Button>().Count();
            
        }

        private void LoadBanAn()
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa các button cũ (nếu có)

            for (int i = 1; i <= 16; i++) // Số bàn có thể thay đổi
            {
                Button btnBan = new Button();
                btnBan.Text = "Bàn " + i;
                btnBan.Name = "btnBan" + i;
                btnBan.Width = 150;
                btnBan.Height = 75;
                btnBan.Click += btnBan_Click; 

                flowLayoutPanel1.Controls.Add(btnBan); // Thêm vào FlowLayoutPanel
            }
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null)
                {
                    int soBan = int.Parse(clickedButton.Text.Replace("Bàn ", ""));
                    DatMon datMonForm = new DatMon(soBan);
                    datMonForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form Đặt Món: " + ex.Message);

            }
        }
        

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sanPhamForm = new SanPham();
            sanPhamForm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienForm = new NhanVien();
            nhanVienForm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khachHangForm = new KhachHang();
            khachHangForm.ShowDialog();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonHang donHangForm = new DonHang();
            donHangForm.ShowDialog();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMaiForm = new KhuyenMai();
            khuyenMaiForm.ShowDialog();
        }

        private void báoCáoDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu frmBaoCao = new BaoCaoDoanhThu();
            frmBaoCao.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
        }

        private void btnoTaiQuan_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show();
        }

        
    }
}
