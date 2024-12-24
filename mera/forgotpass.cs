using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace project
{
    public partial class Forgotpass : Form
    {
        public string Username { get; set; } // To store the user's email

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        public Forgotpass(string username)
        {
            InitializeComponent();
            this.Username = username; // Set the username for updating the password in the database
        }

        private void forgotpass_Load(object sender, EventArgs e)
        {
            forgotpanel.BackColor = Color.FromArgb(20, 10, 10, 10);
            forgotpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, forgotpanel.Width, forgotpanel.Height, 25, 25));
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = newpasstxt.Text.Trim();
            string confirmPassword = confirmpasstext.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the passwords match
            if (newPassword == confirmPassword)
            {
                if (UpdatePasswordInDatabase(newPassword))
                {
                    // If password updated successfully, show the login form
                    ShowLoginForm();
                }
                else
                {
                    MessageBox.Show("Error updating password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show error message if passwords do not match
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePasswordInDatabase(string newPassword)
        {
            bool isUpdated = false;

            // Update with your actual connection string
            string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Correct SQL query to match the email
                    string query = "UPDATE users SET pass = @Password WHERE email = @Email";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Password", newPassword); // Plaintext password (not hashed)
                    cmd.Parameters.AddWithValue("@Email", Username);        // Use the Username property to identify the user

                    int rowsAffected = cmd.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0;

                    if (isUpdated)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No user found with the specified email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isUpdated;
        }

        private void ShowLoginForm()
        {
            try
            {
                Loginform loginForm = new Loginform(); // Initialize the login form
                loginForm.Show(); // Show the login form
                this.Hide(); // Hide the forgot password form
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the login form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}