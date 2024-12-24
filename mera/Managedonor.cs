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
    public partial class Managedonor : Form
    {
        public Managedonor()
        {
            InitializeComponent();
        }

        private void managedonortxtlabel_Click(object sender, EventArgs e)
        {

        }

        private void Managedonor_Load(object sender, EventArgs e)
        {
            optionmanagepnl.BackColor = Color.FromArgb(20, 10, 10, 10);
        }
    }
}
