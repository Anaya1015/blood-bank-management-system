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
            ManageRecipient manageDonorForm = new ManageRecipient();

            // Show the form
            manageDonorForm.Show();

            // Optionally, hide the current form (if you don't want to show both forms)
            this.Hide();

            // You can also handle the FormClosed event if you want the current form to close when the new form is closed
            manageDonorForm.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void managedonorbtn_Click(object sender, EventArgs e)
        {
            Managedonor manageDonorForm = new Managedonor();

            // Show the form
            manageDonorForm.Show();

            // Optionally, hide the current form (if you don't want to show both forms)
            this.Hide();

            // You can also handle the FormClosed event if you want the current form to close when the new form is closed
            manageDonorForm.FormClosed += (s, args) => this.Close();
        }

        private void managestckbtn_Click(object sender, EventArgs e)
        {
            ModifyStock manageDonorForm = new ModifyStock();

            // Show the form
            manageDonorForm.Show();

            // Optionally, hide the current form (if you don't want to show both forms)
            this.Hide();

            // You can also handle the FormClosed event if you want the current form to close when the new form is closed
            manageDonorForm.FormClosed += (s, args) => this.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // Confirm if the user really wants to log out
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
