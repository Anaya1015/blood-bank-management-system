namespace project
{
    partial class IncreaseStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncreaseStock));
            viewdonorpanel = new Panel();
            button1 = new Button();
            viewdonortxtbtn = new Button();
            bloodgroupincreasetxt = new TextBox();
            unitsincreasetxt = new TextBox();
            increasebtn = new Button();
            bloodgroupincreaselbl = new Label();
            unitsincreaselbl = new Label();
            increasepnl = new Panel();
            dataGridViewstock = new DataGridView();
            viewdonorpanel.SuspendLayout();
            increasepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstock).BeginInit();
            SuspendLayout();
            // 
            // viewdonorpanel
            // 
            viewdonorpanel.BackColor = Color.Maroon;
            viewdonorpanel.Controls.Add(button1);
            viewdonorpanel.Controls.Add(viewdonortxtbtn);
            viewdonorpanel.Dock = DockStyle.Top;
            viewdonorpanel.Location = new Point(0, 0);
            viewdonorpanel.Name = "viewdonorpanel";
            viewdonorpanel.Size = new Size(898, 85);
            viewdonorpanel.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(69, 24);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // viewdonortxtbtn
            // 
            viewdonortxtbtn.Anchor = AnchorStyles.None;
            viewdonortxtbtn.BackColor = Color.White;
            viewdonortxtbtn.FlatStyle = FlatStyle.Flat;
            viewdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonortxtbtn.ForeColor = Color.Maroon;
            viewdonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewdonortxtbtn.Location = new Point(316, 6);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(310, 56);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "INCREASE STOCK";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // bloodgroupincreasetxt
            // 
            bloodgroupincreasetxt.Anchor = AnchorStyles.None;
            bloodgroupincreasetxt.Location = new Point(176, 20);
            bloodgroupincreasetxt.Name = "bloodgroupincreasetxt";
            bloodgroupincreasetxt.Size = new Size(122, 23);
            bloodgroupincreasetxt.TabIndex = 8;
            // 
            // unitsincreasetxt
            // 
            unitsincreasetxt.Anchor = AnchorStyles.None;
            unitsincreasetxt.Location = new Point(447, 20);
            unitsincreasetxt.Name = "unitsincreasetxt";
            unitsincreasetxt.Size = new Size(122, 23);
            unitsincreasetxt.TabIndex = 10;
            // 
            // increasebtn
            // 
            increasebtn.Anchor = AnchorStyles.None;
            increasebtn.BackColor = Color.Maroon;
            increasebtn.FlatStyle = FlatStyle.Popup;
            increasebtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            increasebtn.ForeColor = Color.White;
            increasebtn.Location = new Point(266, 85);
            increasebtn.Name = "increasebtn";
            increasebtn.Size = new Size(132, 33);
            increasebtn.TabIndex = 11;
            increasebtn.Text = "Increase";
            increasebtn.UseVisualStyleBackColor = false;
            increasebtn.Click += increasebtn_Click;
            // 
            // bloodgroupincreaselbl
            // 
            bloodgroupincreaselbl.Anchor = AnchorStyles.None;
            bloodgroupincreaselbl.AutoSize = true;
            bloodgroupincreaselbl.BackColor = Color.Maroon;
            bloodgroupincreaselbl.FlatStyle = FlatStyle.Flat;
            bloodgroupincreaselbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bloodgroupincreaselbl.ForeColor = Color.White;
            bloodgroupincreaselbl.Location = new Point(54, 23);
            bloodgroupincreaselbl.Name = "bloodgroupincreaselbl";
            bloodgroupincreaselbl.Size = new Size(98, 20);
            bloodgroupincreaselbl.TabIndex = 12;
            bloodgroupincreaselbl.Text = "Blood Group";
            // 
            // unitsincreaselbl
            // 
            unitsincreaselbl.Anchor = AnchorStyles.None;
            unitsincreaselbl.AutoSize = true;
            unitsincreaselbl.BackColor = Color.Maroon;
            unitsincreaselbl.FlatStyle = FlatStyle.Flat;
            unitsincreaselbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unitsincreaselbl.ForeColor = Color.White;
            unitsincreaselbl.Location = new Point(338, 23);
            unitsincreaselbl.Name = "unitsincreaselbl";
            unitsincreaselbl.Size = new Size(90, 20);
            unitsincreaselbl.TabIndex = 13;
            unitsincreaselbl.Text = "No of Units";
            // 
            // increasepnl
            // 
            increasepnl.Anchor = AnchorStyles.None;
            increasepnl.Controls.Add(increasebtn);
            increasepnl.Controls.Add(unitsincreaselbl);
            increasepnl.Controls.Add(unitsincreasetxt);
            increasepnl.Controls.Add(bloodgroupincreasetxt);
            increasepnl.Controls.Add(bloodgroupincreaselbl);
            increasepnl.Location = new Point(140, 350);
            increasepnl.Name = "increasepnl";
            increasepnl.Size = new Size(646, 161);
            increasepnl.TabIndex = 14;
            // 
            // dataGridViewstock
            // 
            dataGridViewstock.AllowUserToAddRows = false;
            dataGridViewstock.AllowUserToDeleteRows = false;
            dataGridViewstock.Anchor = AnchorStyles.None;
            dataGridViewstock.BackgroundColor = Color.White;
            dataGridViewstock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewstock.Location = new Point(269, 107);
            dataGridViewstock.Name = "dataGridViewstock";
            dataGridViewstock.ReadOnly = true;
            dataGridViewstock.Size = new Size(378, 237);
            dataGridViewstock.TabIndex = 15;
            // 
            // IncreaseStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 523);
            Controls.Add(dataGridViewstock);
            Controls.Add(viewdonorpanel);
            Controls.Add(increasepnl);
            Margin = new Padding(2);
            Name = "IncreaseStock";
            Text = "IncreaseStock";
            WindowState = FormWindowState.Maximized;
            Load += IncreaseStock_Load;
            viewdonorpanel.ResumeLayout(false);
            increasepnl.ResumeLayout(false);
            increasepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private TextBox bloodgroupincreasetxt;
        private TextBox unitsincreasetxt;
        private Button increasebtn;
        private Label bloodgroupincreaselbl;
        private Label unitsincreaselbl;
        private Panel increasepnl;
        private DataGridView dataGridViewstock;
        private Button button1;
    }
}