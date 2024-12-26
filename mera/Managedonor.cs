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

        private void adddonorbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adddonors managerec = new Adddonors();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void deletedonotbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            deletedonor managerec = new deletedonor();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void viewdonorbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewdonor managerec = new viewdonor();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void updatedonorbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatedonor managerec = new Updatedonor();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }

        private void exitbtndonor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admndash managerec = new Admndash();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
