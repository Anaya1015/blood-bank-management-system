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
    public partial class AddRecipient : Form
    {
        public AddRecipient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRecipient_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 10, 10, 10);
        }
    }
}
