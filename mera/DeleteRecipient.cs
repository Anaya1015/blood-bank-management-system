using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace project
{
    public partial class DeleteRecipient : Form
    {
        string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string

        public DeleteRecipient()
        {
            InitializeComponent();
        }

        private void DeleteRecipient_Load(object sender, EventArgs e)
        {
            // Load recipient data into the DataGridView when the form loads
            LoadRecipientsData();
            StyleDataGridView();
        }

        // Function to load the recipients' data from the database into the DataGridView
        private void LoadRecipientsData()
        {
            string query = "SELECT ID, email, pass, addrss, contact FROM users WHERE userrole = 'recipient'"; // Query to get all recipients

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to the DataGridView
                recipientdataGridView.DataSource = dataTable;
            }
        }

        // Function to delete a recipient from the database
        private void DeleteRecipientFromDatabase(int recipientId)
        {
            string query = "DELETE FROM users WHERE ID = @RecipientId AND userrole = 'recipient'"; // Only delete recipients

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RecipientId", recipientId);

                    try
                    {
                        // Open the connection and execute the query
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Show a success or error message
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipient deleted successfully.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("No recipient found with the given ID or the user is not a recipient.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error");
                    }
                }
            }
        }

        // Button click to delete a recipient


        // Function to style the DataGridView
        private void StyleDataGridView()
        {
            // Set the background color of the entire DataGridView
            recipientdataGridView.BackgroundColor = Color.White;

            // Set the header style
            recipientdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            recipientdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            recipientdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
            recipientdataGridView.EnableHeadersVisualStyles = false; // Disable default header styling

            // Set the row style
            recipientdataGridView.RowsDefaultCellStyle.BackColor = Color.White;  // Default row color
            recipientdataGridView.RowsDefaultCellStyle.Font = new Font("Arial", 9.75F);
            recipientdataGridView.RowsDefaultCellStyle.ForeColor = Color.Maroon;

            // Set alternate row color (zebra style)
            recipientdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Set the grid lines
            recipientdataGridView.GridColor = Color.Gray;
            recipientdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Set the scrollbars to none (if required)
            recipientdataGridView.ScrollBars = ScrollBars.None;

            // Auto resize columns to fit content
            recipientdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void deletebtnrecipiet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idtxtfordeletedonor.Text, out int recipientId))
            {
                // Ask the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this recipient?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Call the function to delete the recipient from the database
                    DeleteRecipientFromDatabase(recipientId);
                    // Reload the data after deletion
                    LoadRecipientsData();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid recipient ID.", "Error");
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
