using project.Properties;
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
    public partial class donordash : Form
    {
        public donordash()
        {
            InitializeComponent();
        }

        private void Adddetailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Login form again
            Addmedicalinfo loginForm = new Addmedicalinfo();
            loginForm.Show();

            // Optionally, close the current form completely when Login form is closed
            loginForm.FormClosed += (s, args) => this.Close();
        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out?",
                                                 "Confirm Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Close the current form (dashboard or any other form)
                this.Hide();

                // Show the Login form again
                Loginform loginForm = new Loginform();
                loginForm.Show();

                // Optionally, close the current form completely when Login form is closed
                loginForm.FormClosed += (s, args) => this.Close();
            }
        }
    }
}
