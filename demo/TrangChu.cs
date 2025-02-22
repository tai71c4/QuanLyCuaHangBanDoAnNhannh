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
    public partial class TrangChu : Form
    {
        private string userRole;
        public TrangChu()
        {
            InitializeComponent();
            LoadBanAn();
            this.StartPosition = FormStartPosition.CenterScreen;
          
           
        }
        public TrangChu(string role) : this()
        {
            this.userRole = role;
        }

        private void LoadBanAn()
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= 20; i++)
            {
                Button btnBan = new Button();
                btnBan.Text = "Bàn " + i;
                btnBan.Name = "btnBan" + i;
                btnBan.Width = 150;
                btnBan.Height = 75;
                btnBan.Click += btnBan_Click;

                flowLayoutPanel1.Controls.Add(btnBan);
            }
        }



        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (userRole == "NhanVien")
            {
                quảnLýToolStripMenuItem.Enabled = false;
                thốngKêDoanhThuToolStripMenuItem.Enabled = false;
            }
            int soNut = flowLayoutPanel1.Controls.OfType<Button>().Count();
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
            this.Close();
            SanPham sanPhamForm = new SanPham();
            sanPhamForm.ShowDialog();
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            NhanVien nhanVienForm = new NhanVien();
            nhanVienForm.ShowDialog();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            KhachHang khachHangForm = new KhachHang();
            khachHangForm.ShowDialog();
           
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DonHang donHangForm = new DonHang();
            donHangForm.ShowDialog();
            
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            KhuyenMai khuyenMaiForm = new KhuyenMai();
            khuyenMaiForm.ShowDialog();
           
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BaoCaoDoanhThu frmBaoCao = new BaoCaoDoanhThu();
            frmBaoCao.ShowDialog();
           
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
           
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

       

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBan16_Click(object sender, EventArgs e)
        {

        }

        private void btnBan1_Click(object sender, EventArgs e)
        {

        }

        private void btnBan2_Click(object sender, EventArgs e)
        {

        }

        private void btnBan3_Click(object sender, EventArgs e)
        {

        }

        private void btnBan4_Click(object sender, EventArgs e)
        {

        }

        private void btnBan5_Click(object sender, EventArgs e)
        {

        }

        private void btnBan6_Click(object sender, EventArgs e)
        {

        }

        private void btnBan7_Click(object sender, EventArgs e)
        {

        }

        private void btnBan8_Click(object sender, EventArgs e)
        {

        }

        private void btnban9_Click(object sender, EventArgs e)
        {

        }

        private void btnBan10_Click(object sender, EventArgs e)
        {

        }

        private void btnBan11_Click(object sender, EventArgs e)
        {

        }

        private void btnBan12_Click(object sender, EventArgs e)
        {

        }

        private void btnBan13_Click(object sender, EventArgs e)
        {

        }

        private void btnBan14_Click(object sender, EventArgs e)
        {

        }

        private void btnBan15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
  



