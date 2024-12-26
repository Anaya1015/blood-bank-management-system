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
    public partial class ViewStock : Form
    {
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

        public ViewStock()
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
                viewstockgrid.DataSource = dataTable;
            }
        }
        private void viewdonorlistpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ViewStock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ModifyStock managerec = new ModifyStock();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
