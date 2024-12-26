namespace project
{
    partial class Searchdonor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchdonorpanel = new Panel();
            button1 = new Button();
            searchdonortxtbtn = new Button();
            searchbloodlabel = new Label();
            searchbloodtext = new TextBox();
            dataGridView1 = new DataGridView();
            searchdonorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchdonorpanel
            // 
            searchdonorpanel.BackColor = Color.Maroon;
            searchdonorpanel.Controls.Add(button1);
            searchdonorpanel.Controls.Add(searchdonortxtbtn);
            searchdonorpanel.Dock = DockStyle.Top;
            searchdonorpanel.Location = new Point(0, 0);
            searchdonorpanel.Name = "searchdonorpanel";
            searchdonorpanel.Size = new Size(732, 112);
            searchdonorpanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(39, 21);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // searchdonortxtbtn
            // 
            searchdonortxtbtn.Anchor = AnchorStyles.None;
            searchdonortxtbtn.BackColor = Color.White;
            searchdonortxtbtn.FlatStyle = FlatStyle.Flat;
            searchdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchdonortxtbtn.ForeColor = Color.Maroon;
            searchdonortxtbtn.Location = new Point(234, 21);
            searchdonortxtbtn.Name = "searchdonortxtbtn";
            searchdonortxtbtn.Size = new Size(310, 56);
            searchdonortxtbtn.TabIndex = 0;
            searchdonortxtbtn.Text = "SEARCH DONOR";
            searchdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // searchbloodlabel
            // 
            searchbloodlabel.Anchor = AnchorStyles.None;
            searchbloodlabel.AutoSize = true;
            searchbloodlabel.BackColor = Color.Maroon;
            searchbloodlabel.FlatStyle = FlatStyle.Flat;
            searchbloodlabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbloodlabel.ForeColor = Color.White;
            searchbloodlabel.Location = new Point(254, 153);
            searchbloodlabel.Name = "searchbloodlabel";
            searchbloodlabel.Size = new Size(98, 20);
            searchbloodlabel.TabIndex = 2;
            searchbloodlabel.Text = "Blood Group";
            // 
            // searchbloodtext
            // 
            searchbloodtext.Anchor = AnchorStyles.None;
            searchbloodtext.Location = new Point(402, 150);
            searchbloodtext.Name = "searchbloodtext";
            searchbloodtext.Size = new Size(100, 23);
            searchbloodtext.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(541, 203);
            dataGridView1.TabIndex = 4;
            // 
            // Searchdonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 450);
            Controls.Add(dataGridView1);
            Controls.Add(searchbloodtext);
            Controls.Add(searchbloodlabel);
            Controls.Add(searchdonorpanel);
            Name = "Searchdonor";
            Text = "Searchdonor";
            WindowState = FormWindowState.Maximized;
            searchdonorpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel searchdonorpanel;
        private Button button1;
        private Button searchdonortxtbtn;
        private Label searchbloodlabel;
        private TextBox searchbloodtext;
        private DataGridView dataGridView1;
    }
}