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
    public partial class ModifyStock : Form
    {
        public ModifyStock()
        {
            InitializeComponent();
        }

        private void addrecipientbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStock managerec = new ViewStock();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void ModifyStock_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncreaseStock managerec = new IncreaseStock();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DecreaseStock managerec = new DecreaseStock();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admndash managerec = new Admndash();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
