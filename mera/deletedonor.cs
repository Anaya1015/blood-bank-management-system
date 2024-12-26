using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        // Function to load the donors' data from the database into the DataGridView
        private void LoadDonorsData()
        {
            string query = "SELECT ID, email, pass, addrss, contact FROM users WHERE userrole = 'donor'"; // Query to get all donors

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to the DataGridView
                donorsDataGridView.DataSource = dataTable;
            }
        }

        // Function to delete a donor from the database
        private void DeleteDonorFromDatabase(int donorId)
        {
            string query = "DELETE FROM users WHERE ID = @DonorId AND userrole = 'donor'"; // Only delete donors

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

        private void addeletedonorpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletedonor_Load(object sender, EventArgs e)
        {
            LoadDonorsData();
            StyleDataGridView();
        }

        private void deletedonorbtn_Click(object sender, EventArgs e)
        {
            // Get the ID entered by the user
            if (int.TryParse(idtxtfordeletedonor.Text, out int donorId))
            {
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
                MessageBox.Show("Please enter a valid donor ID.", "Error");
            }
        }

        private void StyleDataGridView()
        {
            // Set the background color of the entire DataGridView
            donorsDataGridView.BackgroundColor = Color.White;

            // Set the header style
            donorsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            donorsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            donorsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            donorsDataGridView.EnableHeadersVisualStyles = false; // Disable default header styling

            // Set the row style
            donorsDataGridView.RowsDefaultCellStyle.BackColor = Color.White;  // Default row color
            donorsDataGridView.RowsDefaultCellStyle.Font = new Font("Arial", 9.75F);
            donorsDataGridView.RowsDefaultCellStyle.ForeColor = Color.Maroon;

            // Set alternate row color (zebra style)
            donorsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Set the grid lines
            donorsDataGridView.GridColor = Color.Gray;
            donorsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Set the scrollbars to none (if required)
            donorsDataGridView.ScrollBars = ScrollBars.None;

            // Auto resize columns to fit content
            donorsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managedonor managerec = new Managedonor();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
