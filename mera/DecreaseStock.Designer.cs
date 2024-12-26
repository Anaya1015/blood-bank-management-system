namespace project
{
    partial class DecreaseStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecreaseStock));
            viewdonorpanel = new Panel();
            button1 = new Button();
            viewdonortxtbtn = new Button();
            dataGridViewstock = new DataGridView();
            deccreasepnl = new Panel();
            decreasebtn = new Button();
            unitsdecreaselbl = new Label();
            unitsdecreasetxt = new TextBox();
            bloodgroupdecreasetxt = new TextBox();
            bloodgroupdecreaselbl = new Label();
            viewdonorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstock).BeginInit();
            deccreasepnl.SuspendLayout();
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
            viewdonorpanel.Size = new Size(782, 112);
            viewdonorpanel.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(38, 30);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 1;
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
            viewdonortxtbtn.Location = new Point(262, 30);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(310, 56);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "DECREASE STOCK";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewstock
            // 
            dataGridViewstock.AllowUserToAddRows = false;
            dataGridViewstock.AllowUserToDeleteRows = false;
            dataGridViewstock.Anchor = AnchorStyles.None;
            dataGridViewstock.BackgroundColor = Color.White;
            dataGridViewstock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewstock.Location = new Point(222, 129);
            dataGridViewstock.Name = "dataGridViewstock";
            dataGridViewstock.ReadOnly = true;
            dataGridViewstock.Size = new Size(378, 237);
            dataGridViewstock.TabIndex = 16;
            // 
            // deccreasepnl
            // 
            deccreasepnl.Anchor = AnchorStyles.None;
            deccreasepnl.Controls.Add(decreasebtn);
            deccreasepnl.Controls.Add(unitsdecreaselbl);
            deccreasepnl.Controls.Add(unitsdecreasetxt);
            deccreasepnl.Controls.Add(bloodgroupdecreasetxt);
            deccreasepnl.Controls.Add(bloodgroupdecreaselbl);
            deccreasepnl.Location = new Point(56, 372);
            deccreasepnl.Name = "deccreasepnl";
            deccreasepnl.Size = new Size(714, 161);
            deccreasepnl.TabIndex = 17;
            // 
            // decreasebtn
            // 
            decreasebtn.Anchor = AnchorStyles.None;
            decreasebtn.BackColor = Color.Maroon;
            decreasebtn.FlatStyle = FlatStyle.Popup;
            decreasebtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decreasebtn.ForeColor = Color.White;
            decreasebtn.Location = new Point(291, 92);
            decreasebtn.Name = "decreasebtn";
            decreasebtn.Size = new Size(132, 33);
            decreasebtn.TabIndex = 11;
            decreasebtn.Text = "Decrease";
            decreasebtn.UseVisualStyleBackColor = false;
            decreasebtn.Click += decreasebtn_Click;
            // 
            // unitsdecreaselbl
            // 
            unitsdecreaselbl.Anchor = AnchorStyles.None;
            unitsdecreaselbl.AutoSize = true;
            unitsdecreaselbl.BackColor = Color.Maroon;
            unitsdecreaselbl.FlatStyle = FlatStyle.Flat;
            unitsdecreaselbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unitsdecreaselbl.ForeColor = Color.White;
            unitsdecreaselbl.Location = new Point(372, 29);
            unitsdecreaselbl.Name = "unitsdecreaselbl";
            unitsdecreaselbl.Size = new Size(90, 20);
            unitsdecreaselbl.TabIndex = 13;
            unitsdecreaselbl.Text = "No of Units";
            // 
            // unitsdecreasetxt
            // 
            unitsdecreasetxt.Anchor = AnchorStyles.None;
            unitsdecreasetxt.Location = new Point(499, 26);
            unitsdecreasetxt.Name = "unitsdecreasetxt";
            unitsdecreasetxt.Size = new Size(122, 23);
            unitsdecreasetxt.TabIndex = 10;
            // 
            // bloodgroupdecreasetxt
            // 
            bloodgroupdecreasetxt.Anchor = AnchorStyles.None;
            bloodgroupdecreasetxt.Location = new Point(199, 26);
            bloodgroupdecreasetxt.Name = "bloodgroupdecreasetxt";
            bloodgroupdecreasetxt.Size = new Size(122, 23);
            bloodgroupdecreasetxt.TabIndex = 8;
            // 
            // bloodgroupdecreaselbl
            // 
            bloodgroupdecreaselbl.Anchor = AnchorStyles.None;
            bloodgroupdecreaselbl.AutoSize = true;
            bloodgroupdecreaselbl.BackColor = Color.Maroon;
            bloodgroupdecreaselbl.FlatStyle = FlatStyle.Flat;
            bloodgroupdecreaselbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bloodgroupdecreaselbl.ForeColor = Color.White;
            bloodgroupdecreaselbl.Location = new Point(71, 29);
            bloodgroupdecreaselbl.Name = "bloodgroupdecreaselbl";
            bloodgroupdecreaselbl.Size = new Size(98, 20);
            bloodgroupdecreaselbl.TabIndex = 12;
            bloodgroupdecreaselbl.Text = "Blood Group";
            // 
            // DecreaseStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 524);
            Controls.Add(deccreasepnl);
            Controls.Add(dataGridViewstock);
            Controls.Add(viewdonorpanel);
            Margin = new Padding(2);
            Name = "DecreaseStock";
            Text = "DecreaseStock";
            WindowState = FormWindowState.Maximized;
            Load += DecreaseStock_Load;
            viewdonorpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewstock).EndInit();
            deccreasepnl.ResumeLayout(false);
            deccreasepnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private DataGridView dataGridViewstock;
        private Panel deccreasepnl;
        private Button decreasebtn;
        private Label unitsdecreaselbl;
        private TextBox unitsdecreasetxt;
        private TextBox bloodgroupdecreasetxt;
        private Label bloodgroupdecreaselbl;
        private Button button1;
    }
}