using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace project
{
    public partial class Updatedonor : Form
    {
        private string connectionString = "Data Source=DESKTOP-CB6C8TK\\SQLEXPRESS01;Initial Catalog=bloodbankmanagementsystem;Integrated Security=True;Encrypt=False";

        public Updatedonor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            Updatedonorpanel = new Panel();
            button1 = new Button();
            updatedonortxtbtn = new Button();
            donorgridview = new DataGridView();
            txtpanel = new Panel();
            upadtedonorbtn = new Button();
            upadtedonoridtxt = new TextBox();
            idupdatedonorlbl = new Label();
            addsavebtn = new Button();
            addressdonortxt = new TextBox();
            contactdonortxt = new TextBox();
            passadddonortxt = new TextBox();
            maildonortxt = new TextBox();
            passadddonorlbl = new Label();
            contactdonorlbl = new Label();
            addressdonorlbl = new Label();
            maildonorlabel = new Label();
            Updatedonorpanel.SuspendLayout();
            ((ISupportInitialize)donorgridview).BeginInit();
            txtpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Updatedonorpanel
            // 
            Updatedonorpanel.BackColor = Color.Maroon;
            Updatedonorpanel.Controls.Add(button1);
            Updatedonorpanel.Controls.Add(updatedonortxtbtn);
            Updatedonorpanel.Dock = DockStyle.Top;
            Updatedonorpanel.Location = new Point(0, 0);
            Updatedonorpanel.Name = "Updatedonorpanel";
            Updatedonorpanel.Size = new Size(852, 112);
            Updatedonorpanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(59, 36);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // updatedonortxtbtn
            // 
            updatedonortxtbtn.Anchor = AnchorStyles.None;
            updatedonortxtbtn.BackColor = Color.White;
            updatedonortxtbtn.FlatStyle = FlatStyle.Flat;
            updatedonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatedonortxtbtn.ForeColor = Color.Maroon;
            updatedonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            updatedonortxtbtn.Location = new Point(258, 36);
            updatedonortxtbtn.Name = "updatedonortxtbtn";
            updatedonortxtbtn.Size = new Size(310, 56);
            updatedonortxtbtn.TabIndex = 0;
            updatedonortxtbtn.Text = "UPDATE DONOR";
            updatedonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // donorgridview
            // 
            donorgridview.AccessibleDescription = " ";
            donorgridview.Anchor = AnchorStyles.None;
            donorgridview.BackgroundColor = Color.White;
            donorgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            donorgridview.GridColor = Color.White;
            donorgridview.Location = new Point(120, 118);
            donorgridview.Name = "donorgridview";
            donorgridview.Size = new Size(610, 237);
            donorgridview.TabIndex = 4;
            // 
            // txtpanel
            // 
            txtpanel.Anchor = AnchorStyles.None;
            txtpanel.BackColor = Color.Transparent;
            txtpanel.Controls.Add(upadtedonorbtn);
            txtpanel.Controls.Add(upadtedonoridtxt);
            txtpanel.Controls.Add(idupdatedonorlbl);
            txtpanel.Controls.Add(addsavebtn);
            txtpanel.Controls.Add(addressdonortxt);
            txtpanel.Controls.Add(contactdonortxt);
            txtpanel.Controls.Add(passadddonortxt);
            txtpanel.Controls.Add(maildonortxt);
            txtpanel.Controls.Add(passadddonorlbl);
            txtpanel.Controls.Add(contactdonorlbl);
            txtpanel.Controls.Add(addressdonorlbl);
            txtpanel.Controls.Add(maildonorlabel);
            txtpanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpanel.Location = new Point(35, 361);
            txtpanel.Name = "txtpanel";
            txtpanel.Size = new Size(794, 166);
            txtpanel.TabIndex = 5;
            // 
            // upadtedonorbtn
            // 
            upadtedonorbtn.Anchor = AnchorStyles.None;
            upadtedonorbtn.BackColor = Color.Maroon;
            upadtedonorbtn.FlatStyle = FlatStyle.Popup;
            upadtedonorbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upadtedonorbtn.ForeColor = Color.White;
            upadtedonorbtn.Location = new Point(322, 130);
            upadtedonorbtn.Name = "upadtedonorbtn";
            upadtedonorbtn.Size = new Size(87, 33);
            upadtedonorbtn.TabIndex = 11;
            upadtedonorbtn.Text = "Update";
            upadtedonorbtn.UseVisualStyleBackColor = false;
            upadtedonorbtn.Click += upadtedonorbtn_Click_1;
            // 
            // upadtedonoridtxt
            // 
            upadtedonoridtxt.Anchor = AnchorStyles.None;
            upadtedonoridtxt.Location = new Point(53, 21);
            upadtedonoridtxt.Name = "upadtedonoridtxt";
            upadtedonoridtxt.Size = new Size(168, 29);
            upadtedonoridtxt.TabIndex = 10;
            // 
            // idupdatedonorlbl
            // 
            idupdatedonorlbl.Anchor = AnchorStyles.None;
            idupdatedonorlbl.AutoSize = true;
            idupdatedonorlbl.BackColor = Color.Maroon;
            idupdatedonorlbl.FlatStyle = FlatStyle.Flat;
            idupdatedonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idupdatedonorlbl.ForeColor = Color.White;
            idupdatedonorlbl.Location = new Point(3, 27);
            idupdatedonorlbl.Name = "idupdatedonorlbl";
            idupdatedonorlbl.Size = new Size(27, 21);
            idupdatedonorlbl.TabIndex = 9;
            idupdatedonorlbl.Text = "ID";
            // 
            // addsavebtn
            // 
            addsavebtn.Anchor = AnchorStyles.None;
            addsavebtn.BackColor = Color.Maroon;
            addsavebtn.FlatStyle = FlatStyle.Popup;
            addsavebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addsavebtn.ForeColor = Color.White;
            addsavebtn.Location = new Point(587, 251);
            addsavebtn.Name = "addsavebtn";
            addsavebtn.Size = new Size(97, 32);
            addsavebtn.TabIndex = 8;
            addsavebtn.Text = "Add";
            addsavebtn.UseVisualStyleBackColor = false;
            // 
            // addressdonortxt
            // 
            addressdonortxt.Anchor = AnchorStyles.None;
            addressdonortxt.Location = new Point(493, 74);
            addressdonortxt.Multiline = true;
            addressdonortxt.Name = "addressdonortxt";
            addressdonortxt.Size = new Size(168, 29);
            addressdonortxt.TabIndex = 7;
            // 
            // contactdonortxt
            // 
            contactdonortxt.Anchor = AnchorStyles.None;
            contactdonortxt.Location = new Point(193, 74);
            contactdonortxt.Name = "contactdonortxt";
            contactdonortxt.Size = new Size(168, 29);
            contactdonortxt.TabIndex = 6;
            // 
            // passadddonortxt
            // 
            passadddonortxt.Anchor = AnchorStyles.None;
            passadddonortxt.Location = new Point(623, 19);
            passadddonortxt.Name = "passadddonortxt";
            passadddonortxt.Size = new Size(168, 29);
            passadddonortxt.TabIndex = 5;
            // 
            // maildonortxt
            // 
            maildonortxt.Anchor = AnchorStyles.None;
            maildonortxt.Location = new Point(332, 21);
            maildonortxt.Name = "maildonortxt";
            maildonortxt.Size = new Size(168, 29);
            maildonortxt.TabIndex = 4;
            // 
            // passadddonorlbl
            // 
            passadddonorlbl.Anchor = AnchorStyles.None;
            passadddonorlbl.AutoSize = true;
            passadddonorlbl.BackColor = Color.Maroon;
            passadddonorlbl.FlatStyle = FlatStyle.Flat;
            passadddonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passadddonorlbl.ForeColor = Color.White;
            passadddonorlbl.Location = new Point(535, 27);
            passadddonorlbl.Name = "passadddonorlbl";
            passadddonorlbl.Size = new Size(82, 21);
            passadddonorlbl.TabIndex = 3;
            passadddonorlbl.Text = "Password";
            // 
            // contactdonorlbl
            // 
            contactdonorlbl.Anchor = AnchorStyles.None;
            contactdonorlbl.AutoSize = true;
            contactdonorlbl.BackColor = Color.Maroon;
            contactdonorlbl.FlatStyle = FlatStyle.Flat;
            contactdonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactdonorlbl.ForeColor = Color.White;
            contactdonorlbl.Location = new Point(99, 82);
            contactdonorlbl.Name = "contactdonorlbl";
            contactdonorlbl.Size = new Size(69, 21);
            contactdonorlbl.TabIndex = 2;
            contactdonorlbl.Text = "Contact";
            // 
            // addressdonorlbl
            // 
            addressdonorlbl.Anchor = AnchorStyles.None;
            addressdonorlbl.AutoSize = true;
            addressdonorlbl.BackColor = Color.Maroon;
            addressdonorlbl.FlatStyle = FlatStyle.Flat;
            addressdonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressdonorlbl.ForeColor = Color.White;
            addressdonorlbl.Location = new Point(402, 82);
            addressdonorlbl.Name = "addressdonorlbl";
            addressdonorlbl.Size = new Size(70, 21);
            addressdonorlbl.TabIndex = 1;
            addressdonorlbl.Text = "Address";
            // 
            // maildonorlabel
            // 
            maildonorlabel.Anchor = AnchorStyles.None;
            maildonorlabel.AutoSize = true;
            maildonorlabel.BackColor = Color.Maroon;
            maildonorlabel.FlatStyle = FlatStyle.Flat;
            maildonorlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maildonorlabel.ForeColor = Color.White;
            maildonorlabel.Location = new Point(259, 27);
            maildonorlabel.Name = "maildonorlabel";
            maildonorlabel.Size = new Size(57, 21);
            maildonorlabel.TabIndex = 0;
            maildonorlabel.Text = "E mail";
            // 
            // Updatedonor
            // 
            ClientSize = new Size(852, 539);
            Controls.Add(txtpanel);
            Controls.Add(donorgridview);
            Controls.Add(Updatedonorpanel);
            Name = "Updatedonor";
            WindowState = FormWindowState.Maximized;
            Load += Updatedonor_Load;
            Updatedonorpanel.ResumeLayout(false);
            ((ISupportInitialize)donorgridview).EndInit();
            txtpanel.ResumeLayout(false);
            txtpanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel Updatedonorpanel;
        private DataGridView donorgridview;
        private Panel txtpanel;
        private Button addsavebtn;
        private TextBox addressdonortxt;
        private TextBox contactdonortxt;
        private TextBox passadddonortxt;
        private TextBox maildonortxt;
        private Label passadddonorlbl;
        private Label contactdonorlbl;
        private Label addressdonorlbl;
        private Label maildonorlabel;
        private Button upadtedonorbtn;
        private TextBox upadtedonoridtxt;
        private Label idupdatedonorlbl;
        private Button button1;
        private Button updatedonortxtbtn;
        private void Updatedonor_Load(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void LoadDonors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ID, email, addrss,pass, contact, userrole FROM users WHERE userrole = 'donor'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable donorTable = new DataTable();
                    adapter.Fill(donorTable);
                    donorgridview.DataSource = donorTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading donors: " + ex.Message);
                }
            }
        }

        private void UpdateDonor(int donorId)
        {
            string email = maildonortxt.Text;
            string address = addressdonortxt.Text;
            string contact = contactdonortxt.Text;
            string password = passadddonortxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Users 
                                     SET email = @Email, addrss = @Address, contact = @Contact, pass = @Password 
                                     WHERE ID = @DonorId AND userrole = 'donor'";
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
                            MessageBox.Show("Donor updated successfully.");
                            LoadDonors();
                        }
                        else
                        {
                            MessageBox.Show("Donor not found or update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating donor: " + ex.Message);
                }
            }
        }

        private void upadtedonorbtn_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(upadtedonoridtxt.Text, out int donorId))
            {
                UpdateDonor(donorId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Donor ID.");
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
