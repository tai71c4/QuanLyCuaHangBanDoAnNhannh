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
        private string userRole;
        public KhachMV()
        {
            InitializeComponent();
            LoadBanAn();
           

        }
        private void KhachMV_Load(object sender, EventArgs e)
        {
            if (userRole == "NhanVien")
            {
                quảnLýToolStripMenuItem.Enabled = false;
                thốngKêDoanhThuToolStripMenuItem.Enabled = false;
            }
            int soNut = flowLayoutPanel1.Controls.OfType<Button>().Count();
            
        }
        public KhachMV(string role) : this()
        {
            this.userRole = role;
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
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienForm = new NhanVien();
            nhanVienForm.ShowDialog();
            this.Close();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khachHangForm = new KhachHang();
            khachHangForm.ShowDialog();
            this.Close();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonHang donHangForm = new DonHang();
            donHangForm.ShowDialog();
            this.Close();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMaiForm = new KhuyenMai();
            khuyenMaiForm.ShowDialog();
            this.Close();
        }

        private void báoCáoDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu frmBaoCao = new BaoCaoDoanhThu();
            frmBaoCao.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void btnoTaiQuan_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.Show();
            this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userRole == "NhanVien")
            {
                MessageBox.Show("Bạn cần tài khoản Admin để truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userRole == "NhanVien")
            {
                MessageBox.Show("Bạn cần tài khoản Admin để truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaoCaoDoanhThu bcForm = new BaoCaoDoanhThu();
            bcForm.Show();
            this.Close();
        }
    }
}
