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
    public partial class IncreaseStock : Form
    {
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

        public IncreaseStock()
        {
            InitializeComponent();
            LoadBloodStock();
        }
        private void LoadBloodStock()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT BloodGroup, Units FROM BloodStock";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewstock.DataSource = dataTable;
            }
        }
        private void optionmanagepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IncreaseStock_Load(object sender, EventArgs e)
        {
            increasepnl.BackColor = Color.FromArgb(20, 10, 10, 10);
        }

        private void increasebtn_Click(object sender, EventArgs e)
        {

            string bloodGroup = bloodgroupincreasetxt.Text;
            int unitsToAdd;

            if (!int.TryParse(unitsincreasetxt.Text, out unitsToAdd) || unitsToAdd <= 0)
            {
                MessageBox.Show("Please enter a valid number of units.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Check if the blood group already exists
                string checkQuery = "SELECT Units FROM BloodStock WHERE BloodGroup = @BloodGroup";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    // If not exists, insert a new record
                    string insertQuery = "INSERT INTO BloodStock (BloodGroup, Units) VALUES (@BloodGroup, @Units)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                    insertCmd.Parameters.AddWithValue("@Units", unitsToAdd);
                    insertCmd.ExecuteNonQuery();
                }
                else
                {
                    // If exists, update the units
                    string updateQuery = "UPDATE BloodStock SET Units = Units + @Units WHERE BloodGroup = @BloodGroup";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                    updateCmd.Parameters.AddWithValue("@Units", unitsToAdd);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Stock increased successfully.");
                LoadBloodStock(); // Refresh the data grid
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyStock managerec = new ModifyStock();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }

}
