using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace project
{
    public partial class deletedonor : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string

        public deletedonor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletedonor_Load(object sender, EventArgs e)
        {
            // Load the donors data into the DataGridView
            LoadDonorsData();
        }

        // Function to load the donors' data from the database into the DataGridView
        private void LoadDonorsData()
        {
            string query = "SELECT id, email, address, contact FROM users WHERE userrole = 'donor'"; // Query to get all donors

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to the DataGridView
                donorsDataGridView.DataSource = dataTable;
            }
        }

        // Event handler for the delete donor button click
        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            // Get the selected donor's ID from the DataGridView
            if (donorsDataGridView.SelectedRows.Count > 0)
            {
                int donorId = Convert.ToInt32(donorsDataGridView.SelectedRows[0].Cells[0].Value); // Get donor ID from the first column

                // Ask the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this donor?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Call the function to delete the donor from the database
                    DeleteDonorFromDatabase(donorId);
                    // Reload the data after deletion
                    LoadDonorsData();
                }
            }
            else
            {
                MessageBox.Show("Please select a donor to delete.", "Error");
            }
        }

        // Function to delete a donor from the database
        private void DeleteDonorFromDatabase(int donorId)
        {
            string query = "DELETE FROM users WHERE id = @DonorId AND userrole = 'donor'"; // Only delete donors

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DonorId", donorId);

                    try
                    {
                        // Open the connection and execute the query
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Show a success or error message
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Donor deleted successfully.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("No donor found with the given ID or the user is not a donor.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error");
                    }
                }
            }
        }
    }
}
