using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Properties
{
    public partial class Addmedicalinfo : Form
    {
        public Addmedicalinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            donordash managerec = new donordash();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
