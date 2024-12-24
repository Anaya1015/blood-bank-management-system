using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class IncreaseStock : Form
    {
        public IncreaseStock()
        {
            InitializeComponent();
        }

        private void optionmanagepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IncreaseStock_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(20, 10, 10, 10);
        }
    }
}
