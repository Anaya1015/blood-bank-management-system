using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace project
{
    public partial class viewdonor : Form
    {
        // Connection string for your database
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

        public viewdonor()
        {
            InitializeComponent();
        }

        private void viewdonor_Load(object sender, EventArgs e)
        {
            LoadDonorData();
        }

        private void LoadDonorData()
        {
            string query = "SELECT ID, email, addrss, contact FROM users WHERE userrole = 'donor'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to a DataGridView
                    donorgridview.DataSource = dataTable;

                    // Customize DataGridView styling
                    donorgridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    donorgridview.DefaultCellStyle.BackColor = Color.LightGray;
                    donorgridview.DefaultCellStyle.Font = new Font("Arial", 10);
                    donorgridview.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                    donorgridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    donorgridview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    donorgridview.RowHeadersVisible = false; // Hide row headers
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error");
            }
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

