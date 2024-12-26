namespace project
{
    partial class donordash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donordash));
            Donordashpnlbar = new Panel();
            logoutbtn = new Label();
            bbmstxt = new Label();
            blackpanel = new Panel();
            logbutton = new Button();
            Adddetailsbtn = new Button();
            Donordashpnlbar.SuspendLayout();
            blackpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Donordashpnlbar
            // 
            Donordashpnlbar.BackColor = Color.Transparent;
            Donordashpnlbar.Controls.Add(logoutbtn);
            Donordashpnlbar.Controls.Add(bbmstxt);
            Donordashpnlbar.Dock = DockStyle.Top;
            Donordashpnlbar.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Donordashpnlbar.ForeColor = Color.Maroon;
            Donordashpnlbar.Location = new Point(0, 0);
            Donordashpnlbar.Name = "Donordashpnlbar";
            Donordashpnlbar.Size = new Size(1017, 98);
            Donordashpnlbar.TabIndex = 5;
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
            logoutbtn.Location = new Point(1763, 12);
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
            bbmstxt.Location = new Point(285, 31);
            bbmstxt.Name = "bbmstxt";
            bbmstxt.Size = new Size(593, 50);
            bbmstxt.TabIndex = 0;
            bbmstxt.Text = "Blood Bank Management system";
            // 
            // blackpanel
            // 
            blackpanel.BackColor = Color.Transparent;
            blackpanel.Controls.Add(logbutton);
            blackpanel.Controls.Add(Adddetailsbtn);
            blackpanel.Dock = DockStyle.Left;
            blackpanel.Location = new Point(0, 98);
            blackpanel.Name = "blackpanel";
            blackpanel.Size = new Size(233, 398);
            blackpanel.TabIndex = 6;
            // 
            // logbutton
            // 
            logbutton.Anchor = AnchorStyles.None;
            logbutton.BackColor = Color.Maroon;
            logbutton.FlatStyle = FlatStyle.Popup;
            logbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbutton.ForeColor = Color.White;
            logbutton.Location = new Point(48, 207);
            logbutton.Name = "logbutton";
            logbutton.Size = new Size(157, 59);
            logbutton.TabIndex = 1;
            logbutton.Text = "Logout";
            logbutton.UseVisualStyleBackColor = false;
            logbutton.Click += logbutton_Click;
            // 
            // Adddetailsbtn
            // 
            Adddetailsbtn.Anchor = AnchorStyles.None;
            Adddetailsbtn.BackColor = Color.Maroon;
            Adddetailsbtn.FlatStyle = FlatStyle.Popup;
            Adddetailsbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adddetailsbtn.ForeColor = Color.White;
            Adddetailsbtn.Location = new Point(48, 79);
            Adddetailsbtn.Name = "Adddetailsbtn";
            Adddetailsbtn.Size = new Size(157, 59);
            Adddetailsbtn.TabIndex = 0;
            Adddetailsbtn.Text = "Add Medical Details";
            Adddetailsbtn.UseVisualStyleBackColor = false;
            Adddetailsbtn.Click += Adddetailsbtn_Click;
            // 
            // donordash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 496);
            Controls.Add(blackpanel);
            Controls.Add(Donordashpnlbar);
            Name = "donordash";
            Text = "UserForm";
            Donordashpnlbar.ResumeLayout(false);
            Donordashpnlbar.PerformLayout();
            blackpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Donordashpnlbar;
        private Label logoutbtn;
        private Label bbmstxt;
        private Panel blackpanel;
        private Button logbutton;
        private Button Adddetailsbtn;
    }
}