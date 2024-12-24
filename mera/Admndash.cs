using System;
using System.Windows.Forms;

namespace project
{
    public partial class Admndash : Form
    {
        public Admndash()
        {

            InitializeComponent();

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Admndash_Load(object sender, EventArgs e)
        {
            Admindashpnlbar.Dock = DockStyle.Top;
            blackpanel.Dock = DockStyle.Left;
            Admindashpnlbar.BackColor = Color.FromArgb(20, 10, 10, 10);
            blackpanel.BackColor = Color.FromArgb(20, 10, 10, 10);
        }

        private void Admindashpnlbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bbmstxt_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
