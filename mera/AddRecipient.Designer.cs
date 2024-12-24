namespace project
{
    partial class AddRecipient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipient));
            adddonorpanel = new Panel();
            adddonortxtbtn = new Button();
            panel1 = new Panel();
            addsavebtn = new Button();
            addressdonortxt = new TextBox();
            addressdonorlbl = new Label();
            contactdonortxt = new TextBox();
            contactdonorlbl = new Label();
            passadddonortxt = new TextBox();
            passadddonorlbl = new Label();
            maildonortxt = new TextBox();
            maildonorlabel = new Label();
            adddonorpanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // adddonorpanel
            // 
            adddonorpanel.BackColor = Color.Maroon;
            adddonorpanel.Controls.Add(adddonortxtbtn);
            adddonorpanel.Dock = DockStyle.Top;
            adddonorpanel.Location = new Point(0, 0);
            adddonorpanel.Margin = new Padding(4, 5, 4, 5);
            adddonorpanel.Name = "adddonorpanel";
            adddonorpanel.Size = new Size(1034, 187);
            adddonorpanel.TabIndex = 1;
            // 
            // adddonortxtbtn
            // 
            adddonortxtbtn.Anchor = AnchorStyles.None;
            adddonortxtbtn.BackColor = Color.White;
            adddonortxtbtn.FlatStyle = FlatStyle.Flat;
            adddonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adddonortxtbtn.ForeColor = Color.Maroon;
            adddonortxtbtn.Location = new Point(312, 41);
            adddonortxtbtn.Margin = new Padding(4, 5, 4, 5);
            adddonortxtbtn.Name = "adddonortxtbtn";
            adddonortxtbtn.Size = new Size(443, 93);
            adddonortxtbtn.TabIndex = 0;
            adddonortxtbtn.Text = "ADD RECIPIENT";
            adddonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(addsavebtn);
            panel1.Controls.Add(addressdonortxt);
            panel1.Controls.Add(addressdonorlbl);
            panel1.Controls.Add(contactdonortxt);
            panel1.Controls.Add(contactdonorlbl);
            panel1.Controls.Add(passadddonortxt);
            panel1.Controls.Add(passadddonorlbl);
            panel1.Controls.Add(maildonortxt);
            panel1.Controls.Add(maildonorlabel);
            panel1.Location = new Point(87, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 410);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // addsavebtn
            // 
            addsavebtn.Anchor = AnchorStyles.None;
            addsavebtn.BackColor = Color.Maroon;
            addsavebtn.FlatStyle = FlatStyle.Popup;
            addsavebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addsavebtn.ForeColor = Color.White;
            addsavebtn.Location = new Point(403, 255);
            addsavebtn.Margin = new Padding(4, 5, 4, 5);
            addsavebtn.Name = "addsavebtn";
            addsavebtn.Size = new Size(139, 53);
            addsavebtn.TabIndex = 12;
            addsavebtn.Text = "Add";
            addsavebtn.UseVisualStyleBackColor = false;
            // 
            // addressdonortxt
            // 
            addressdonortxt.Anchor = AnchorStyles.None;
            addressdonortxt.Location = new Point(622, 159);
            addressdonortxt.Margin = new Padding(4, 5, 4, 5);
            addressdonortxt.Multiline = true;
            addressdonortxt.Name = "addressdonortxt";
            addressdonortxt.Size = new Size(238, 46);
            addressdonortxt.TabIndex = 11;
            // 
            // addressdonorlbl
            // 
            addressdonorlbl.Anchor = AnchorStyles.None;
            addressdonorlbl.AutoSize = true;
            addressdonorlbl.BackColor = Color.Maroon;
            addressdonorlbl.FlatStyle = FlatStyle.Flat;
            addressdonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressdonorlbl.ForeColor = Color.White;
            addressdonorlbl.Location = new Point(488, 173);
            addressdonorlbl.Margin = new Padding(4, 0, 4, 0);
            addressdonorlbl.Name = "addressdonorlbl";
            addressdonorlbl.Size = new Size(106, 32);
            addressdonorlbl.TabIndex = 10;
            addressdonorlbl.Text = "Address";
            // 
            // contactdonortxt
            // 
            contactdonortxt.Anchor = AnchorStyles.None;
            contactdonortxt.Location = new Point(225, 173);
            contactdonortxt.Margin = new Padding(4, 5, 4, 5);
            contactdonortxt.Name = "contactdonortxt";
            contactdonortxt.Size = new Size(238, 31);
            contactdonortxt.TabIndex = 9;
            // 
            // contactdonorlbl
            // 
            contactdonorlbl.Anchor = AnchorStyles.None;
            contactdonorlbl.AutoSize = true;
            contactdonorlbl.BackColor = Color.Maroon;
            contactdonorlbl.FlatStyle = FlatStyle.Flat;
            contactdonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactdonorlbl.ForeColor = Color.White;
            contactdonorlbl.Location = new Point(103, 173);
            contactdonorlbl.Margin = new Padding(4, 0, 4, 0);
            contactdonorlbl.Name = "contactdonorlbl";
            contactdonorlbl.Size = new Size(102, 32);
            contactdonorlbl.TabIndex = 8;
            contactdonorlbl.Text = "Contact";
            // 
            // passadddonortxt
            // 
            passadddonortxt.Anchor = AnchorStyles.None;
            passadddonortxt.Location = new Point(622, 70);
            passadddonortxt.Margin = new Padding(4, 5, 4, 5);
            passadddonortxt.Name = "passadddonortxt";
            passadddonortxt.Size = new Size(238, 31);
            passadddonortxt.TabIndex = 7;
            // 
            // passadddonorlbl
            // 
            passadddonorlbl.Anchor = AnchorStyles.None;
            passadddonorlbl.AutoSize = true;
            passadddonorlbl.BackColor = Color.Maroon;
            passadddonorlbl.FlatStyle = FlatStyle.Flat;
            passadddonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passadddonorlbl.ForeColor = Color.White;
            passadddonorlbl.Location = new Point(488, 57);
            passadddonorlbl.Margin = new Padding(4, 0, 4, 0);
            passadddonorlbl.Name = "passadddonorlbl";
            passadddonorlbl.Size = new Size(122, 32);
            passadddonorlbl.TabIndex = 6;
            passadddonorlbl.Text = "Password";
            // 
            // maildonortxt
            // 
            maildonortxt.Anchor = AnchorStyles.None;
            maildonortxt.Location = new Point(217, 52);
            maildonortxt.Margin = new Padding(4, 5, 4, 5);
            maildonortxt.Name = "maildonortxt";
            maildonortxt.Size = new Size(238, 31);
            maildonortxt.TabIndex = 5;
            // 
            // maildonorlabel
            // 
            maildonorlabel.Anchor = AnchorStyles.None;
            maildonorlabel.AutoSize = true;
            maildonorlabel.BackColor = Color.Maroon;
            maildonorlabel.FlatStyle = FlatStyle.Flat;
            maildonorlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maildonorlabel.ForeColor = Color.White;
            maildonorlabel.Location = new Point(103, 52);
            maildonorlabel.Margin = new Padding(4, 0, 4, 0);
            maildonorlabel.Name = "maildonorlabel";
            maildonorlabel.Size = new Size(83, 32);
            maildonorlabel.TabIndex = 1;
            maildonorlabel.Text = "E mail";
            // 
            // AddRecipient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 708);
            Controls.Add(adddonorpanel);
            Controls.Add(panel1);
            Name = "AddRecipient";
            Text = "AddRecipient";
            Load += AddRecipient_Load;
            adddonorpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel adddonorpanel;
        private Button adddonortxtbtn;
        private Panel panel1;
        private Label maildonorlabel;
        private TextBox maildonortxt;
        private Label passadddonorlbl;
        private TextBox passadddonortxt;
        private Label contactdonorlbl;
        private TextBox contactdonortxt;
        private Label addressdonorlbl;
        private TextBox addressdonortxt;
        private Button addsavebtn;
    }
}