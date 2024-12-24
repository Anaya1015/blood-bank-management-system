using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace project
{
    public partial class Reset : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        private DatabaseHelper db;
        public Reset()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";
            db = new DatabaseHelper(connectionString);
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Load(object sender, EventArgs e)
        {
            resetpnl.BackColor = Color.FromArgb(20, 10, 10, 10);
            resetpnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetpnl.Width, resetpnl.Height, 25, 25));
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;

            // Check if the username field is empty
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query to check if the username exists in the database
            string query = "SELECT COUNT(*) FROM users WHERE email = @username"; // Replace 'Users' with your table name

            try
            {
                // Execute the query
                using (SqlConnection connection = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameterized queries to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);

                        // Execute the query and get the count
                        int userCount = (int)command.ExecuteScalar();

                        // Check if the username exists
                        if (userCount ==1)
                        {
                            MessageBox.Show("Username exists in the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Forgotpass fg = new Forgotpass(username);
                            fg.Show();
                            this.Hide();
                            fg.FormClosed += (s, args) => this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Username does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
