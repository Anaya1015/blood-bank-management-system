using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project
{
    public partial class ViewRecipientcs : Form
    {
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";
        public ViewRecipientcs()
        {
            InitializeComponent();
        }

        private void ViewRecipientcs_Load(object sender, EventArgs e)
        {
            LoadRecipientData();
        }
        private void LoadRecipientData()
        {
            string query = "SELECT ID, email, addrss,pass, contact FROM users WHERE userrole = 'recipient'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to a DataGridView
                    viewrecipientgrid.DataSource = dataTable;

                    // Customize DataGridView styling
                    viewrecipientgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    viewrecipientgrid.DefaultCellStyle.BackColor = Color.LightGray;
                    viewrecipientgrid.DefaultCellStyle.Font = new Font("Arial", 10);
                    viewrecipientgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                    viewrecipientgrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    viewrecipientgrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    viewrecipientgrid.RowHeadersVisible = false; // Hide row headers
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error");
            }
        }
        private void viewrecipientgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
