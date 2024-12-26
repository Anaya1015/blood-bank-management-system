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

        private void addrecipientbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Login form again
            AddRecipient addrecep = new AddRecipient();
            addrecep.Show();

            // Optionally, close the current form completely when Login form is closed
            addrecep.FormClosed += (s, args) => this.Close();

        }

        private void deleterecipientbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Login form again
            DeleteRecipient deletrecep = new DeleteRecipient();
            deletrecep.Show();

            // Optionally, close the current form completely when Login form is closed
            deletrecep.FormClosed += (s, args) => this.Close();
        }

        private void viewrecipientbtn_Click(object sender, EventArgs e)
        {
            

            // Show the Login form again
            ViewRecipientcs viewrecep = new ViewRecipientcs();
            viewrecep.Show();

            // Optionally, close the current form completely when Login form is closed
            viewrecep.FormClosed += (s, args) => this.Close();
        }

        private void updaterecipient_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Login form again
            UpdateRecipient updaterecep = new UpdateRecipient();
            updaterecep.Show();

            // Optionally, close the current form completely when Login form is closed
            updaterecep.FormClosed += (s, args) => this.Close();
        }

        private void exitrecipient_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the Login form again
            Admndash admin = new Admndash();
            admin.Show();

            // Optionally, close the current form completely when Login form is closed
            admin.FormClosed += (s, args) => this.Close();
        }
    }
}
