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
    public partial class Adddonors : Form
    {
        public Adddonors()
        {
            InitializeComponent();
        }

        private void Adddonors_Load(object sender, EventArgs e)
        {

            txtpanel.BackColor = Color.FromArgb(20, 10, 10, 10);
        }

        private void mailadddonorlbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maildonortxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
