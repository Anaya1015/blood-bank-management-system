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
    public partial class UpdateRecipient : Form
    {
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";
        public UpdateRecipient()
        {
            InitializeComponent();
        }

        private void UpdateRecipient_Load(object sender, EventArgs e)
        {
            LoadRecipient();
        }

        private void recipientgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadRecipient()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ID, email, addrss,pass, contact, userrole FROM users WHERE userrole = 'recipient'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable donorTable = new DataTable();
                    adapter.Fill(donorTable);
                    recipientgridview.DataSource = donorTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading donors: " + ex.Message);
                }
            }
        }

        private void UpdateDonor(int donorId)
        {
            string email = mailrecipienttxt.Text;
            string address = addressrecipienttxt.Text;
            string contact = contactrecipienttxt.Text;
            string password = passaddrecipienttxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Users 
                                     SET email = @Email, addrss = @Address, contact = @Contact, pass = @Password 
                                     WHERE ID = @DonorId AND userrole = 'recipient'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DonorId", donorId);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipient updated successfully.");
                            LoadRecipient();
                        }
                        else
                        {
                            MessageBox.Show("Recipient not found or update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating recipient: " + ex.Message);
                }
            }
        }

        private void upadterecipientbtn_Click(object sender, EventArgs e)
        {

            if (int.TryParse(upadterecipientidtxt.Text, out int donorId))
            {
                UpdateDonor(donorId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Recipient ID.");
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
