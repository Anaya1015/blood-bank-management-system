namespace project
{
    partial class sign_up
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            labelssign = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txt_email = new TextBox();
            signlbl = new Label();
            sgnbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_contact = new TextBox();
            txt_pass = new TextBox();
            txt_address = new TextBox();
            label4 = new Label();
            rolecombo = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelssign
            // 
            labelssign.Anchor = AnchorStyles.None;
            labelssign.AutoSize = true;
            labelssign.BackColor = Color.Transparent;
            labelssign.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelssign.ForeColor = Color.Maroon;
            labelssign.Location = new Point(69, 121);
            labelssign.Name = "labelssign";
            labelssign.Size = new Size(42, 17);
            labelssign.TabIndex = 0;
            labelssign.Text = "Email";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Location = new Point(69, 141);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(226, 23);
            txt_email.TabIndex = 2;
            // 
            // signlbl
            // 
            signlbl.Anchor = AnchorStyles.None;
            signlbl.AutoSize = true;
            signlbl.BackColor = Color.Transparent;
            signlbl.Font = new Font("Candara", 20F, FontStyle.Bold);
            signlbl.ForeColor = Color.Maroon;
            signlbl.Location = new Point(128, 68);
            signlbl.Name = "signlbl";
            signlbl.Size = new Size(105, 33);
            signlbl.TabIndex = 9;
            signlbl.Text = "Sign Up";
            // 
            // sgnbtn
            // 
            sgnbtn.Anchor = AnchorStyles.None;
            sgnbtn.BackColor = Color.Maroon;
            sgnbtn.FlatStyle = FlatStyle.Flat;
            sgnbtn.ForeColor = Color.White;
            sgnbtn.Location = new Point(128, 401);
            sgnbtn.Name = "sgnbtn";
            sgnbtn.Size = new Size(91, 33);
            sgnbtn.TabIndex = 10;
            sgnbtn.Text = "Sign Up";
            sgnbtn.UseVisualStyleBackColor = false;
            sgnbtn.Click += sgnbtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(69, 289);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 11;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(71, 231);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 12;
            label2.Text = "Contact";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(69, 174);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 13;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txt_contact
            // 
            txt_contact.Anchor = AnchorStyles.None;
            txt_contact.Location = new Point(69, 251);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(226, 23);
            txt_contact.TabIndex = 14;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(69, 194);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(226, 23);
            txt_pass.TabIndex = 15;
            // 
            // txt_address
            // 
            txt_address.Anchor = AnchorStyles.None;
            txt_address.Location = new Point(69, 309);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(226, 23);
            txt_address.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(71, 342);
            label4.Name = "label4";
            label4.Size = new Size(35, 17);
            label4.TabIndex = 17;
            label4.Text = "Role";
            // 
            // rolecombo
            // 
            rolecombo.Anchor = AnchorStyles.None;
            rolecombo.ForeColor = Color.Maroon;
            rolecombo.FormattingEnabled = true;
            rolecombo.Items.AddRange(new object[] { "Donor", "Recipient" });
            rolecombo.Location = new Point(69, 362);
            rolecombo.Name = "rolecombo";
            rolecombo.Size = new Size(121, 23);
            rolecombo.TabIndex = 18;
            rolecombo.SelectedIndexChanged += rolecombo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signlbl);
            panel1.Controls.Add(labelssign);
            panel1.Controls.Add(rolecombo);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(sgnbtn);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_contact);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(740, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 484);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 540);
            Controls.Add(panel1);
            Name = "sign_up";
            WindowState = FormWindowState.Maximized;
            Load += sign_up_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelssign;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_email;
        private Label signlbl;
        private Button sgnbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_contact;
        private TextBox txt_pass;
        private TextBox txt_address;
        private Label label4;
        private ComboBox rolecombo;
        private Panel panel1;
    }
}