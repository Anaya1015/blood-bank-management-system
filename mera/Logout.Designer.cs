namespace project
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            lblog = new Label();
            usename = new Label();
            logbtn = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblog
            // 
            lblog.Anchor = AnchorStyles.None;
            lblog.AutoSize = true;
            lblog.BackColor = Color.Transparent;
            lblog.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblog.ForeColor = Color.Maroon;
            lblog.Location = new Point(301, 120);
            lblog.Margin = new Padding(6, 0, 6, 0);
            lblog.Name = "lblog";
            lblog.Size = new Size(145, 47);
            lblog.TabIndex = 2;
            lblog.Text = "Logout";
            // 
            // usename
            // 
            usename.Anchor = AnchorStyles.None;
            usename.AutoSize = true;
            usename.BackColor = Color.Transparent;
            usename.Font = new Font("Bell MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usename.ForeColor = Color.Maroon;
            usename.Location = new Point(151, 222);
            usename.Margin = new Padding(6, 0, 6, 0);
            usename.Name = "usename";
            usename.Size = new Size(444, 34);
            usename.TabIndex = 3;
            usename.Text = "Are you sure you want to logout?";
            // 
            // logbtn
            // 
            logbtn.Anchor = AnchorStyles.None;
            logbtn.BackColor = Color.Maroon;
            logbtn.FlatStyle = FlatStyle.Flat;
            logbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbtn.ForeColor = Color.White;
            logbtn.Location = new Point(409, 316);
            logbtn.Margin = new Padding(2);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(157, 46);
            logbtn.TabIndex = 8;
            logbtn.Text = "No";
            logbtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(202, 316);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(152, 46);
            button1.TabIndex = 9;
            button1.Text = "Yes";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(135, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(481, 406);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 588);
            Controls.Add(button1);
            Controls.Add(logbtn);
            Controls.Add(usename);
            Controls.Add(lblog);
            Controls.Add(flowLayoutPanel1);
            Name = "Logout";
            Text = "Logout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblog;
        private Label usename;
        private Button logbtn;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}