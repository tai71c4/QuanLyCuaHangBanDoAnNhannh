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
    public partial class DatMon : Form
    {
        private int soBan;
        public DatMon(int soBan)
        {
            InitializeComponent();
            this.soBan = soBan;
            lblSoBan.Text = "Bàn " + soBan;
        }
    }
}
