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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

            if (email == "Ali@gmail.com" && password == "123")
            {
                // Admin login
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();
                db.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // Check donor credentials from the database
                if (ValidateUser(email, password))
                {
                    this.Hide();
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    userForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateUser(string email, string password)
        {
            bool isValid = false;

            string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND pass = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isValid = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while validating the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }

        private void forgotlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset rese = new Reset();
            rese.Show();
            this.Hide();
            rese.FormClosed += (s, args) => this.Close();
        }

        private void loginpnl_Paint(object sender, PaintEventArgs e)
        {
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
