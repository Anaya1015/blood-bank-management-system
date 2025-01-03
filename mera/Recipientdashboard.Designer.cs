﻿namespace project
{
    partial class Recipientdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipientdashboard));
            Recipientdashpnlbar = new Panel();
            logoutbtn = new Label();
            bbmstxt = new Label();
            blackpanel = new Panel();
            logbutton = new Button();
            Searchdonorbtn = new Button();
            Recipientdashpnlbar.SuspendLayout();
            blackpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Recipientdashpnlbar
            // 
            Recipientdashpnlbar.BackColor = Color.Transparent;
            Recipientdashpnlbar.Controls.Add(logoutbtn);
            Recipientdashpnlbar.Controls.Add(bbmstxt);
            Recipientdashpnlbar.Dock = DockStyle.Top;
            Recipientdashpnlbar.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Recipientdashpnlbar.ForeColor = Color.Maroon;
            Recipientdashpnlbar.Location = new Point(0, 0);
            Recipientdashpnlbar.Name = "Recipientdashpnlbar";
            Recipientdashpnlbar.Size = new Size(1037, 98);
            Recipientdashpnlbar.TabIndex = 4;
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
            logoutbtn.Location = new Point(1355, 13);
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
            bbmstxt.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bbmstxt.Location = new Point(314, 30);
            bbmstxt.Name = "bbmstxt";
            bbmstxt.Size = new Size(593, 50);
            bbmstxt.TabIndex = 0;
            bbmstxt.Text = "Blood Bank Management system";
            // 
            // blackpanel
            // 
            blackpanel.BackColor = Color.Transparent;
            blackpanel.Controls.Add(logbutton);
            blackpanel.Controls.Add(Searchdonorbtn);
            blackpanel.Dock = DockStyle.Left;
            blackpanel.Location = new Point(0, 98);
            blackpanel.Name = "blackpanel";
            blackpanel.Size = new Size(233, 537);
            blackpanel.TabIndex = 5;
            // 
            // logbutton
            // 
            logbutton.Anchor = AnchorStyles.None;
            logbutton.BackColor = Color.Maroon;
            logbutton.FlatStyle = FlatStyle.Popup;
            logbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbutton.ForeColor = Color.White;
            logbutton.Location = new Point(32, 213);
            logbutton.Name = "logbutton";
            logbutton.Size = new Size(157, 59);
            logbutton.TabIndex = 1;
            logbutton.Text = "Logout";
            logbutton.UseVisualStyleBackColor = false;
            logbutton.Click += logbutton_Click;
            // 
            // Searchdonorbtn
            // 
            Searchdonorbtn.Anchor = AnchorStyles.None;
            Searchdonorbtn.BackColor = Color.Maroon;
            Searchdonorbtn.FlatStyle = FlatStyle.Popup;
            Searchdonorbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchdonorbtn.ForeColor = Color.White;
            Searchdonorbtn.Location = new Point(32, 96);
            Searchdonorbtn.Name = "Searchdonorbtn";
            Searchdonorbtn.Size = new Size(157, 59);
            Searchdonorbtn.TabIndex = 0;
            Searchdonorbtn.Text = "Search Donor";
            Searchdonorbtn.UseVisualStyleBackColor = false;
            Searchdonorbtn.Click += Searchdonorbtn_Click;
            // 
            // Recipientdashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 635);
            Controls.Add(blackpanel);
            Controls.Add(Recipientdashpnlbar);
            Name = "Recipientdashboard";
            Text = "Recipientdashboard";
            Recipientdashpnlbar.ResumeLayout(false);
            Recipientdashpnlbar.PerformLayout();
            blackpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Recipientdashpnlbar;
        private Label logoutbtn;
        private Label bbmstxt;
        private Panel blackpanel;
        private Button logbutton;
        private Button Searchdonorbtn;
    }
}