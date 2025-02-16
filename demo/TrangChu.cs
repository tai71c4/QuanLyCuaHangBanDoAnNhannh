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
            AddEventForTables();
        }
        private void AddEventForTables()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Text.StartsWith("Bàn"))
                {
                    btn.Click += BtnTable_Click;
                }
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int tableNumber = int.Parse(clickedButton.Text.Replace("Bàn ", "").Trim());

            // Mở form đặt món, truyền số bàn
            DatMon formDatMon = new DatMon(tableNumber);
            formDatMon.Show();
        }

    }
}
