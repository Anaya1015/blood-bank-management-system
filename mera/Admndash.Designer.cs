namespace project
{
    partial class Admndash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admndash));
            blackpanel = new Panel();
            managestckbtn = new Button();
            managerecipientbtn = new Button();
            managedonorbtn = new Button();
            Admindashpnlbar = new Panel();
            logoutbtn = new Label();
            bbmstxt = new Label();
            blackpanel.SuspendLayout();
            Admindashpnlbar.SuspendLayout();
            SuspendLayout();
            // 
            // blackpanel
            // 
            blackpanel.BackColor = Color.Transparent;
            blackpanel.Controls.Add(managestckbtn);
            blackpanel.Controls.Add(managerecipientbtn);
            blackpanel.Controls.Add(managedonorbtn);
            blackpanel.Dock = DockStyle.Left;
            blackpanel.Location = new Point(0, 0);
            blackpanel.Name = "blackpanel";
            blackpanel.Size = new Size(221, 525);
            blackpanel.TabIndex = 0;
            // 
            // managestckbtn
            // 
            managestckbtn.BackColor = Color.Maroon;
            managestckbtn.FlatStyle = FlatStyle.Popup;
            managestckbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managestckbtn.ForeColor = Color.White;
            managestckbtn.Location = new Point(32, 430);
            managestckbtn.Name = "managestckbtn";
            managestckbtn.Size = new Size(157, 57);
            managestckbtn.TabIndex = 2;
            managestckbtn.Text = "Manage Stock";
            managestckbtn.UseVisualStyleBackColor = false;
            // 
            // managerecipientbtn
            // 
            managerecipientbtn.BackColor = Color.Maroon;
            managerecipientbtn.FlatStyle = FlatStyle.Popup;
            managerecipientbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerecipientbtn.ForeColor = Color.White;
            managerecipientbtn.Location = new Point(32, 318);
            managerecipientbtn.Name = "managerecipientbtn";
            managerecipientbtn.Size = new Size(157, 59);
            managerecipientbtn.TabIndex = 1;
            managerecipientbtn.Text = "Manage Recipient";
            managerecipientbtn.UseVisualStyleBackColor = false;
            managerecipientbtn.Click += button2_Click;
            // 
            // managedonorbtn
            // 
            managedonorbtn.BackColor = Color.Maroon;
            managedonorbtn.FlatStyle = FlatStyle.Popup;
            managedonorbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managedonorbtn.ForeColor = Color.White;
            managedonorbtn.Location = new Point(32, 208);
            managedonorbtn.Name = "managedonorbtn";
            managedonorbtn.Size = new Size(157, 59);
            managedonorbtn.TabIndex = 0;
            managedonorbtn.Text = "Manage Donor";
            managedonorbtn.UseVisualStyleBackColor = false;
            // 
            // Admindashpnlbar
            // 
            Admindashpnlbar.Anchor = AnchorStyles.None;
            Admindashpnlbar.BackColor = Color.Transparent;
            Admindashpnlbar.Controls.Add(logoutbtn);
            Admindashpnlbar.Controls.Add(bbmstxt);
            Admindashpnlbar.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admindashpnlbar.ForeColor = Color.Maroon;
            Admindashpnlbar.Location = new Point(-47, 0);
            Admindashpnlbar.Name = "Admindashpnlbar";
            Admindashpnlbar.Size = new Size(1092, 64);
            Admindashpnlbar.TabIndex = 3;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.None;
            logoutbtn.AutoSize = true;
            logoutbtn.BackColor = Color.Maroon;
            logoutbtn.BorderStyle = BorderStyle.FixedSingle;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(937, 14);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(88, 32);
            logoutbtn.TabIndex = 1;
            logoutbtn.Text = "Logout";
            // 
            // bbmstxt
            // 
            bbmstxt.Anchor = AnchorStyles.None;
            bbmstxt.AutoSize = true;
            bbmstxt.BackColor = Color.Transparent;
            bbmstxt.FlatStyle = FlatStyle.Flat;
            bbmstxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bbmstxt.Location = new Point(73, 14);
            bbmstxt.Name = "bbmstxt";
            bbmstxt.Size = new Size(388, 32);
            bbmstxt.TabIndex = 0;
            bbmstxt.Text = "Blood Bank Management system";
            bbmstxt.Click += bbmstxt_Click;
            // 
            // Admndash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 525);
            Controls.Add(Admindashpnlbar);
            Controls.Add(blackpanel);
            Name = "Admndash";
            Load += Admndash_Load;
            blackpanel.ResumeLayout(false);
            Admindashpnlbar.ResumeLayout(false);
            Admindashpnlbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel blackpanel;
        private Panel Admindashpnlbar;
        private Label logoutbtn;
        private Label bbmstxt;
        private Button managestckbtn;
        private Button managerecipientbtn;
        private Button managedonorbtn;
    }
}