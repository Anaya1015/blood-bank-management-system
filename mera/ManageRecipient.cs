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
    public partial class ManageRecipient : Form
    {
        public ManageRecipient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageRecipient_Load(object sender, EventArgs e)
        {
            optionrecientpanel.BackColor = Color.FromArgb(20, 10, 10, 10);
        }
    }
}
