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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.Load += TrangChu_Load; // Gán sự kiện Load cho form

            // Gán sự kiện click cho tất cả nút bàn
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text.StartsWith("Bàn"))
                {
                    control.Click += btnBan_Click;
                }
            }
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text.StartsWith("Bàn "))
                {
                    control.Click += btnBan_Click; // Gán sự kiện BanClick cho button bàn
                }
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Lấy số bàn từ Text của button (VD: "Bàn 1" → 1)
                int soBan = int.Parse(clickedButton.Text.Replace("Bàn ", ""));

                // Mở form Đặt Món với số bàn
                DatMon datMonForm = new DatMon(soBan);
                datMonForm.ShowDialog();
            }
        }

        
    }
}




