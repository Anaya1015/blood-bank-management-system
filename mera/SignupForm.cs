using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class sign_up : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public sign_up()
        {
            InitializeComponent();
        }

        private void sgnbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_pass.Text) ||
                string.IsNullOrWhiteSpace(txt_contact.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(rolecombo.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string (Update with your database details)
            string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL Insert Command
                    string query = "INSERT INTO users (email, pass, addrss, contact, userrole) VALUES (@mail, @password, @address, @cntact, @role)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL Injection
                        command.Parameters.AddWithValue("@mail", txt_email.Text);
                        command.Parameters.AddWithValue("@password", txt_pass.Text); // Consider hashing the password
                        command.Parameters.AddWithValue("@address", txt_address.Text);
                        command.Parameters.AddWithValue("@cntact", txt_contact.Text);
                        command.Parameters.AddWithValue("@role", rolecombo.Text);

                        // Execute the query
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Loginform uf = new Loginform();
                            uf.Show();
                            this.Hide();
                            uf.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 10, 10, 10); // Bright cyan
                                                                    // Frost green color

            sgnbtn.FlatAppearance.BorderSize = 0;
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
        }

        private void rolecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

