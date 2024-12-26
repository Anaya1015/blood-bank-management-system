using Microsoft.Data.SqlClient;
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
    public partial class AddRecipient : Form
    {
        string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string
        public AddRecipient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRecipient_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 10, 10, 10);
        }

        private void adddonorpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addsavebtn_Click(object sender, EventArgs e)
        {
            string email = maildonortxt.Text;  // Assuming you have a TextBox named 'txtName' for the donor's name
            string password = passadddonortxt.Text;
            string address = addressdonortxt.Text;
            string contact = contactdonortxt.Text;// Assuming you have a TextBox named 'txtEmail' for the donor's email

            // Ensure that both fields are filled out
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please provide all credentials.", "Error");
                return;
            }

            // Call the function to add the donor
            AddRecipientToDatabase(connectionString, email, password, address, contact);
        }
        private void AddRecipientToDatabase(string connectionString, string email, string password, string address, string contact)
        {
            // SQL query to insert the donor into the users table
            string query = "INSERT INTO users (email,pass,addrss,contact,userrole) VALUES (@Email,@Password,@Address,@Contact, @Role)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query

                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Role", "Recipient");  // Set role as 'donor'

                    try
                    {
                        // Open the connection and execute the query
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Show a success or error message
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipient added successfully.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the recipient.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRecipient managerec = new ManageRecipient();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
