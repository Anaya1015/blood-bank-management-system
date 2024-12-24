namespace project
{
    partial class Forgotpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgotpass));
            newpasslbl = new Label();
            newpasstxt = new TextBox();
            label1 = new Label();
            confirmpasstext = new TextBox();
            forgotpanel = new Panel();
            btnUpdatePassword = new Button();
            forgotpanel.SuspendLayout();
            SuspendLayout();
            // 
            // newpasslbl
            // 
            newpasslbl.Anchor = AnchorStyles.None;
            newpasslbl.AutoSize = true;
            newpasslbl.BackColor = Color.Transparent;
            newpasslbl.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newpasslbl.ForeColor = Color.Maroon;
            newpasslbl.Location = new Point(55, 59);
            newpasslbl.Name = "newpasslbl";
            newpasslbl.Size = new Size(140, 17);
            newpasslbl.TabIndex = 0;
            newpasslbl.Text = "Enter new password";
            // 
            // newpasstxt
            // 
            newpasstxt.Anchor = AnchorStyles.None;
            newpasstxt.Location = new Point(55, 79);
            newpasstxt.Name = "newpasstxt";
            newpasstxt.PasswordChar = '*';
            newpasstxt.Size = new Size(205, 23);
            newpasstxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(55, 121);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 4;
            label1.Text = "Confirm Password";
            // 
            // confirmpasstext
            // 
            confirmpasstext.Anchor = AnchorStyles.None;
            confirmpasstext.Location = new Point(55, 141);
            confirmpasstext.Name = "confirmpasstext";
            confirmpasstext.PasswordChar = '*';
            confirmpasstext.Size = new Size(205, 23);
            confirmpasstext.TabIndex = 5;
            // 
            // forgotpanel
            // 
            forgotpanel.Anchor = AnchorStyles.None;
            forgotpanel.BackColor = Color.Transparent;
            forgotpanel.Controls.Add(btnUpdatePassword);
            forgotpanel.Controls.Add(newpasslbl);
            forgotpanel.Controls.Add(confirmpasstext);
            forgotpanel.Controls.Add(newpasstxt);
            forgotpanel.Controls.Add(label1);
            forgotpanel.Location = new Point(156, 84);
            forgotpanel.Name = "forgotpanel";
            forgotpanel.Size = new Size(325, 281);
            forgotpanel.TabIndex = 7;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.White;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = Color.Maroon;
            btnUpdatePassword.Location = new Point(116, 213);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(75, 23);
            btnUpdatePassword.TabIndex = 6;
            btnUpdatePassword.Text = "Confirm";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // Forgotpass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(604, 450);
            Controls.Add(forgotpanel);
            Name = "Forgotpass";
            WindowState = FormWindowState.Maximized;
            Load += forgotpass_Load;
            forgotpanel.ResumeLayout(false);
            forgotpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label newpasslbl;
        private TextBox newpasstxt;
        private Label label1;
        private TextBox confirmpasstext;
        private Panel forgotpanel;
        private Button btnUpdatePassword;
    }
}