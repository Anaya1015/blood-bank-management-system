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
            button1 = new Button();
            adddonorpanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // adddonorpanel
            // 
            adddonorpanel.BackColor = Color.Maroon;
            adddonorpanel.Controls.Add(button1);
            adddonorpanel.Controls.Add(adddonortxtbtn);
            adddonorpanel.Dock = DockStyle.Top;
            adddonorpanel.Location = new Point(0, 0);
            adddonorpanel.Name = "adddonorpanel";
            adddonorpanel.Size = new Size(724, 112);
            adddonorpanel.TabIndex = 1;
            adddonorpanel.Paint += adddonorpanel_Paint;
            // 
            // adddonortxtbtn
            // 
            adddonortxtbtn.Anchor = AnchorStyles.None;
            adddonortxtbtn.BackColor = Color.White;
            adddonortxtbtn.FlatStyle = FlatStyle.Flat;
            adddonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adddonortxtbtn.ForeColor = Color.Maroon;
            adddonortxtbtn.Location = new Point(218, 25);
            adddonortxtbtn.Name = "adddonortxtbtn";
            adddonortxtbtn.Size = new Size(310, 56);
            adddonortxtbtn.TabIndex = 0;
            adddonortxtbtn.Text = "ADD RECIPIENT";
            adddonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
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
            panel1.Location = new Point(61, 146);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 246);
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
            addsavebtn.Location = new Point(282, 153);
            addsavebtn.Name = "addsavebtn";
            addsavebtn.Size = new Size(97, 32);
            addsavebtn.TabIndex = 12;
            addsavebtn.Text = "Add";
            addsavebtn.UseVisualStyleBackColor = false;
            addsavebtn.Click += addsavebtn_Click;
            // 
            // addressdonortxt
            // 
            addressdonortxt.Anchor = AnchorStyles.None;
            addressdonortxt.Location = new Point(435, 95);
            addressdonortxt.Multiline = true;
            addressdonortxt.Name = "addressdonortxt";
            addressdonortxt.Size = new Size(168, 29);
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
            addressdonorlbl.Location = new Point(342, 104);
            addressdonorlbl.Name = "addressdonorlbl";
            addressdonorlbl.Size = new Size(70, 21);
            addressdonorlbl.TabIndex = 10;
            addressdonorlbl.Text = "Address";
            // 
            // contactdonortxt
            // 
            contactdonortxt.Anchor = AnchorStyles.None;
            contactdonortxt.Location = new Point(158, 104);
            contactdonortxt.Name = "contactdonortxt";
            contactdonortxt.Size = new Size(168, 23);
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
            contactdonorlbl.Location = new Point(72, 104);
            contactdonorlbl.Name = "contactdonorlbl";
            contactdonorlbl.Size = new Size(69, 21);
            contactdonorlbl.TabIndex = 8;
            contactdonorlbl.Text = "Contact";
            // 
            // passadddonortxt
            // 
            passadddonortxt.Anchor = AnchorStyles.None;
            passadddonortxt.Location = new Point(435, 42);
            passadddonortxt.Name = "passadddonortxt";
            passadddonortxt.Size = new Size(168, 23);
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
            passadddonorlbl.Location = new Point(342, 34);
            passadddonorlbl.Name = "passadddonorlbl";
            passadddonorlbl.Size = new Size(82, 21);
            passadddonorlbl.TabIndex = 6;
            passadddonorlbl.Text = "Password";
            // 
            // maildonortxt
            // 
            maildonortxt.Anchor = AnchorStyles.None;
            maildonortxt.Location = new Point(152, 31);
            maildonortxt.Name = "maildonortxt";
            maildonortxt.Size = new Size(168, 23);
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
            maildonorlabel.Location = new Point(72, 31);
            maildonorlabel.Name = "maildonorlabel";
            maildonorlabel.Size = new Size(57, 21);
            maildonorlabel.TabIndex = 1;
            maildonorlabel.Text = "E mail";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(40, 43);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddRecipient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 425);
            Controls.Add(adddonorpanel);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "AddRecipient";
            Text = "AddRecipient";
            WindowState = FormWindowState.Maximized;
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
        private Button button1;
    }
}