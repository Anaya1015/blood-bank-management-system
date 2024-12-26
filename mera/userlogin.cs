using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace project
{
    public partial class Loginform : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            logbtn.FlatAppearance.BorderSize = 0;
            loginpnl.BackColor = Color.FromArgb(20, 10, 10, 10);
            loginpnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginpnl.Width, loginpnl.Height, 25, 25));
            nametxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nametxt.Width, nametxt.Height, 10, 10));
            passtext.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, passtext.Width, passtext.Height, 10, 10));
            logbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, logbtn.Width, logbtn.Height, 25, 25));
        }

        private void shwpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (shwpass.Text == "show password")
            {
                shwpass.Text = "hide password";
                passtext.PasswordChar = '\0';
            }
            else
            {
                shwpass.Text = "show password";
                passtext.PasswordChar = '*';
            }
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            logbtn.Enabled = check.Checked;
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string email = nametxt.Text.Trim();
            string password = passtext.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check admin credentials (hardcoded as Ali@gmail.com and 123)
            if (email == "Ali@gmail.com" && password == "123")
            {
                // Admin login
                this.Hide();
                Admndash db = new Admndash();
                db.Show();
                db.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // Validate user role (Donor or Recipient)
                string role = ValidateUserRoleAndCredentials(email, password);
                if (role == "Donor"||role=="donor")
                {
                    // Redirect to Donor Dashboard
                    this.Hide();
                    donordash donorForm = new donordash();
                    donorForm.Show();
                    donorForm.FormClosed += (s, args) => this.Close();
                }
                else if (role == "Recipient"||role=="recipient")
                {
                    // Redirect to Recipient Dashboard
                    this.Hide();
                    Recipientdashboard recipientForm = new Recipientdashboard();
                    recipientForm.Show();
                    recipientForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials or role. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Consolidated method to validate user and their role
        private string ValidateUserRoleAndCredentials(string email, string password)
        {
            string role = null;
            string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query to check user credentials and role
                    string query = "SELECT userrole FROM users WHERE email = @Email AND pass = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // You should hash the password in practice

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while validating the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return role;
        }

        private void forgotlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset rese = new Reset();
            rese.Show();
            this.Hide();
            rese.FormClosed += (s, args) => this.Close();
        }

        private void signlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sign_up sign_Up = new sign_up();
            sign_Up.Show();
            sign_Up.FormClosed += (s, args) => this.Close();
        }
    }
}
