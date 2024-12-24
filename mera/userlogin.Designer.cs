namespace project
{
    partial class Loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            loginpnl = new Panel();
            switchlbl = new LinkLabel();
            shwpass = new LinkLabel();
            label1 = new Label();
            signlink = new LinkLabel();
            forgotlink = new LinkLabel();
            check = new CheckBox();
            logbtn = new Button();
            nametxt = new TextBox();
            passtext = new TextBox();
            lblog = new Label();
            usename = new Label();
            password = new Label();
            loginpnl.SuspendLayout();
            SuspendLayout();
            // 
            // loginpnl
            // 
            loginpnl.Anchor = AnchorStyles.None;
            loginpnl.Controls.Add(switchlbl);
            loginpnl.Controls.Add(shwpass);
            loginpnl.Controls.Add(label1);
            loginpnl.Controls.Add(signlink);
            loginpnl.Controls.Add(forgotlink);
            loginpnl.Controls.Add(check);
            loginpnl.Controls.Add(logbtn);
            loginpnl.Controls.Add(nametxt);
            loginpnl.Controls.Add(passtext);
            loginpnl.Controls.Add(lblog);
            loginpnl.Controls.Add(usename);
            loginpnl.Controls.Add(password);
            loginpnl.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginpnl.Location = new Point(277, 59);
            loginpnl.Margin = new Padding(6, 7, 6, 7);
            loginpnl.Name = "loginpnl";
            loginpnl.Size = new Size(464, 450);
            loginpnl.TabIndex = 0;
            loginpnl.Paint += loginpnl_Paint;
            // 
            // switchlbl
            // 
            switchlbl.Location = new Point(0, 0);
            switchlbl.Name = "switchlbl";
            switchlbl.Size = new Size(100, 23);
            switchlbl.TabIndex = 0;
            // 
            // shwpass
            // 
            shwpass.ActiveLinkColor = Color.Maroon;
            shwpass.Anchor = AnchorStyles.None;
            shwpass.AutoSize = true;
            shwpass.BackColor = Color.Transparent;
            shwpass.Font = new Font("Times New Roman", 9F);
            shwpass.ForeColor = Color.White;
            shwpass.LinkColor = Color.DarkGreen;
            shwpass.Location = new Point(300, 199);
            shwpass.Name = "shwpass";
            shwpass.Size = new Size(120, 20);
            shwpass.TabIndex = 12;
            shwpass.TabStop = true;
            shwpass.Text = "show password";
            shwpass.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            shwpass.LinkClicked += shwpass_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 8F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(167, 376);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 11;
            label1.Text = "Don't have an account?";
            // 
            // signlink
            // 
            signlink.ActiveLinkColor = Color.Maroon;
            signlink.Anchor = AnchorStyles.None;
            signlink.BackColor = Color.Transparent;
            signlink.ForeColor = Color.White;
            signlink.LinkColor = Color.DarkGreen;
            signlink.Location = new Point(327, 362);
            signlink.Name = "signlink";
            signlink.Size = new Size(100, 33);
            signlink.TabIndex = 14;
            signlink.TabStop = true;
            signlink.Text = "Sign Up";
            signlink.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            signlink.LinkClicked += signlink_LinkClicked;
            // 
            // forgotlink
            // 
            forgotlink.ActiveLinkColor = Color.Maroon;
            forgotlink.Anchor = AnchorStyles.None;
            forgotlink.AutoSize = true;
            forgotlink.BackColor = Color.Transparent;
            forgotlink.Font = new Font("Times New Roman", 10F);
            forgotlink.ForeColor = Color.White;
            forgotlink.LinkColor = Color.DarkGreen;
            forgotlink.Location = new Point(300, 271);
            forgotlink.Margin = new Padding(2, 0, 2, 0);
            forgotlink.Name = "forgotlink";
            forgotlink.Size = new Size(140, 22);
            forgotlink.TabIndex = 9;
            forgotlink.TabStop = true;
            forgotlink.Text = "ForgotPassword";
            forgotlink.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            forgotlink.LinkClicked += forgotlink_LinkClicked;
            // 
            // check
            // 
            check.Anchor = AnchorStyles.None;
            check.AutoSize = true;
            check.BackColor = Color.Transparent;
            check.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            check.ForeColor = Color.Maroon;
            check.Location = new Point(92, 295);
            check.Margin = new Padding(2);
            check.Name = "check";
            check.Size = new Size(126, 24);
            check.TabIndex = 8;
            check.Text = "Accept T/c";
            check.UseVisualStyleBackColor = false;
            check.CheckedChanged += check_CheckedChanged;
            // 
            // logbtn
            // 
            logbtn.Anchor = AnchorStyles.None;
            logbtn.BackColor = Color.Maroon;
            logbtn.FlatStyle = FlatStyle.Flat;
            logbtn.ForeColor = Color.White;
            logbtn.Location = new Point(109, 323);
            logbtn.Margin = new Padding(2);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(255, 37);
            logbtn.TabIndex = 7;
            logbtn.Text = "Login";
            logbtn.UseVisualStyleBackColor = false;
            logbtn.Click += logbtn_Click;
            // 
            // nametxt
            // 
            nametxt.Anchor = AnchorStyles.None;
            nametxt.BorderStyle = BorderStyle.None;
            nametxt.Location = new Point(92, 159);
            nametxt.Margin = new Padding(2);
            nametxt.Multiline = true;
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(255, 24);
            nametxt.TabIndex = 6;
            // 
            // passtext
            // 
            passtext.Anchor = AnchorStyles.None;
            passtext.BorderStyle = BorderStyle.None;
            passtext.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passtext.Location = new Point(92, 236);
            passtext.Margin = new Padding(2);
            passtext.Multiline = true;
            passtext.Name = "passtext";
            passtext.PasswordChar = '*';
            passtext.Size = new Size(255, 24);
            passtext.TabIndex = 4;
            passtext.TextChanged += textBox1_TextChanged;
            // 
            // lblog
            // 
            lblog.Anchor = AnchorStyles.None;
            lblog.AutoSize = true;
            lblog.BackColor = Color.Transparent;
            lblog.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblog.ForeColor = Color.Maroon;
            lblog.Location = new Point(167, 47);
            lblog.Margin = new Padding(6, 0, 6, 0);
            lblog.Name = "lblog";
            lblog.Size = new Size(122, 47);
            lblog.TabIndex = 1;
            lblog.Text = "Login";
            // 
            // usename
            // 
            usename.Anchor = AnchorStyles.None;
            usename.AutoSize = true;
            usename.BackColor = Color.Transparent;
            usename.Font = new Font("Bell MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usename.ForeColor = Color.Maroon;
            usename.Location = new Point(92, 106);
            usename.Margin = new Padding(6, 0, 6, 0);
            usename.Name = "usename";
            usename.Size = new Size(143, 34);
            usename.TabIndex = 2;
            usename.Text = "Username";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Font = new Font("Bell MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Maroon;
            password.Location = new Point(92, 185);
            password.Margin = new Padding(6, 0, 6, 0);
            password.Name = "password";
            password.Size = new Size(137, 34);
            password.TabIndex = 3;
            password.Text = "Password";
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(23F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 569);
            Controls.Add(loginpnl);
            Font = new Font("Bahnschrift SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Loginform";
            WindowState = FormWindowState.Maximized;
            Load += loginform_Load;
            loginpnl.ResumeLayout(false);
            loginpnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginpnl;
        private Label lblog;
        private Label usename;
        private Label password;
        private TextBox nametxt;
        private TextBox passtext;
        private CheckBox check;
        private Button logbtn;
        private LinkLabel forgotlink;
        private Label label1;
        private LinkLabel signlink;
        private LinkLabel shwpass;
        private LinkLabel switchlbl;
    }
}
