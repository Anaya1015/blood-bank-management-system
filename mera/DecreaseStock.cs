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
    public partial class DecreaseStock : Form
    {
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

        public DecreaseStock()
        {
            InitializeComponent();
            LoadBloodStock();
        }



        private void DecreaseStock_Load(object sender, EventArgs e)
        {
            deccreasepnl.BackColor = Color.FromArgb(20, 10, 10, 10);
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
        private void decreasebtn_Click(object sender, EventArgs e)
        {
            string bloodGroup = bloodgroupdecreasetxt.Text;
            int unitsToDeduct;

            if (!int.TryParse(unitsdecreasetxt.Text, out unitsToDeduct) || unitsToDeduct <= 0)
            {
                MessageBox.Show("Please enter a valid number of units.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Check if the blood group exists
                string checkQuery = "SELECT Units FROM BloodStock WHERE BloodGroup = @BloodGroup";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Blood group not found.");
                    return;
                }
                else
                {
                    int currentUnits = Convert.ToInt32(result);

                    // Check if there are enough units to deduct
                    if (currentUnits < unitsToDeduct)
                    {
                        MessageBox.Show("Not enough stock to decrease.");
                        return;
                    }

                    // Update the units
                    string updateQuery = "UPDATE BloodStock SET Units = Units - @Units WHERE BloodGroup = @BloodGroup";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                    updateCmd.Parameters.AddWithValue("@Units", unitsToDeduct);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Stock decreased successfully.");
                    LoadBloodStock(); // Refresh the data grid
                }
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
