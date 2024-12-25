namespace project
{
    partial class Adddonors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adddonors));
            adddonorpanel = new Panel();
            adddonortxtbtn = new Button();
            txtpanel = new Panel();
            addsavebtn = new Button();
            addressdonortxt = new TextBox();
            contactdonortxt = new TextBox();
            passadddonortxt = new TextBox();
            maildonortxt = new TextBox();
            passadddonorlbl = new Label();
            contactdonorlbl = new Label();
            addressdonorlbl = new Label();
            maildonorlabel = new Label();
            adddonorpanel.SuspendLayout();
            txtpanel.SuspendLayout();
            SuspendLayout();
            // 
            // adddonorpanel
            // 
            adddonorpanel.BackColor = Color.Maroon;
            adddonorpanel.Controls.Add(adddonortxtbtn);
            adddonorpanel.Dock = DockStyle.Top;
            adddonorpanel.Location = new Point(0, 0);
            adddonorpanel.Name = "adddonorpanel";
            adddonorpanel.Size = new Size(800, 112);
            adddonorpanel.TabIndex = 0;
            adddonorpanel.Paint += adddonorpanel_Paint;
            // 
            // adddonortxtbtn
            // 
            adddonortxtbtn.Anchor = AnchorStyles.None;
            adddonortxtbtn.BackColor = Color.White;
            adddonortxtbtn.FlatStyle = FlatStyle.Flat;
            adddonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adddonortxtbtn.ForeColor = Color.Maroon;
            adddonortxtbtn.Location = new Point(276, 24);
            adddonortxtbtn.Name = "adddonortxtbtn";
            adddonortxtbtn.Size = new Size(310, 56);
            adddonortxtbtn.TabIndex = 0;
            adddonortxtbtn.Text = "ADD DONOR";
            adddonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // txtpanel
            // 
            txtpanel.Anchor = AnchorStyles.None;
            txtpanel.BackColor = Color.Transparent;
            txtpanel.Controls.Add(addsavebtn);
            txtpanel.Controls.Add(addressdonortxt);
            txtpanel.Controls.Add(contactdonortxt);
            txtpanel.Controls.Add(passadddonortxt);
            txtpanel.Controls.Add(maildonortxt);
            txtpanel.Controls.Add(passadddonorlbl);
            txtpanel.Controls.Add(contactdonorlbl);
            txtpanel.Controls.Add(addressdonorlbl);
            txtpanel.Controls.Add(maildonorlabel);
            txtpanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpanel.Location = new Point(74, 118);
            txtpanel.Name = "txtpanel";
            txtpanel.Size = new Size(667, 317);
            txtpanel.TabIndex = 1;
            txtpanel.Paint += mailadddonorlbl_Paint;
            // 
            // addsavebtn
            // 
            addsavebtn.Anchor = AnchorStyles.None;
            addsavebtn.BackColor = Color.Maroon;
            addsavebtn.FlatStyle = FlatStyle.Popup;
            addsavebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addsavebtn.ForeColor = Color.White;
            addsavebtn.Location = new Point(290, 218);
            addsavebtn.Name = "addsavebtn";
            addsavebtn.Size = new Size(97, 32);
            addsavebtn.TabIndex = 8;
            addsavebtn.Text = "Add";
            addsavebtn.UseVisualStyleBackColor = false;
            addsavebtn.Click += addsavebtn_Click;
            // 
            // addressdonortxt
            // 
            addressdonortxt.Anchor = AnchorStyles.None;
            addressdonortxt.Location = new Point(464, 142);
            addressdonortxt.Multiline = true;
            addressdonortxt.Name = "addressdonortxt";
            addressdonortxt.Size = new Size(168, 29);
            addressdonortxt.TabIndex = 7;
            // 
            // contactdonortxt
            // 
            contactdonortxt.Anchor = AnchorStyles.None;
            contactdonortxt.Location = new Point(159, 142);
            contactdonortxt.Name = "contactdonortxt";
            contactdonortxt.Size = new Size(168, 29);
            contactdonortxt.TabIndex = 6;
            // 
            // passadddonortxt
            // 
            passadddonortxt.Anchor = AnchorStyles.None;
            passadddonortxt.Location = new Point(464, 59);
            passadddonortxt.Name = "passadddonortxt";
            passadddonortxt.Size = new Size(168, 29);
            passadddonortxt.TabIndex = 5;
            // 
            // maildonortxt
            // 
            maildonortxt.Anchor = AnchorStyles.None;
            maildonortxt.Location = new Point(144, 59);
            maildonortxt.Name = "maildonortxt";
            maildonortxt.Size = new Size(168, 29);
            maildonortxt.TabIndex = 4;
            maildonortxt.TextChanged += maildonortxt_TextChanged;
            // 
            // passadddonorlbl
            // 
            passadddonorlbl.Anchor = AnchorStyles.None;
            passadddonorlbl.AutoSize = true;
            passadddonorlbl.BackColor = Color.Maroon;
            passadddonorlbl.FlatStyle = FlatStyle.Flat;
            passadddonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passadddonorlbl.ForeColor = Color.White;
            passadddonorlbl.Location = new Point(363, 62);
            passadddonorlbl.Name = "passadddonorlbl";
            passadddonorlbl.Size = new Size(82, 21);
            passadddonorlbl.TabIndex = 3;
            passadddonorlbl.Text = "Password";
            // 
            // contactdonorlbl
            // 
            contactdonorlbl.Anchor = AnchorStyles.None;
            contactdonorlbl.AutoSize = true;
            contactdonorlbl.BackColor = Color.Maroon;
            contactdonorlbl.FlatStyle = FlatStyle.Flat;
            contactdonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactdonorlbl.ForeColor = Color.White;
            contactdonorlbl.Location = new Point(74, 145);
            contactdonorlbl.Name = "contactdonorlbl";
            contactdonorlbl.Size = new Size(69, 21);
            contactdonorlbl.TabIndex = 2;
            contactdonorlbl.Text = "Contact";
            // 
            // addressdonorlbl
            // 
            addressdonorlbl.Anchor = AnchorStyles.None;
            addressdonorlbl.AutoSize = true;
            addressdonorlbl.BackColor = Color.Maroon;
            addressdonorlbl.FlatStyle = FlatStyle.Flat;
            addressdonorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressdonorlbl.ForeColor = Color.White;
            addressdonorlbl.Location = new Point(363, 145);
            addressdonorlbl.Name = "addressdonorlbl";
            addressdonorlbl.Size = new Size(70, 21);
            addressdonorlbl.TabIndex = 1;
            addressdonorlbl.Text = "Address";
            // 
            // maildonorlabel
            // 
            maildonorlabel.Anchor = AnchorStyles.None;
            maildonorlabel.AutoSize = true;
            maildonorlabel.BackColor = Color.Maroon;
            maildonorlabel.FlatStyle = FlatStyle.Flat;
            maildonorlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maildonorlabel.ForeColor = Color.White;
            maildonorlabel.Location = new Point(74, 62);
            maildonorlabel.Name = "maildonorlabel";
            maildonorlabel.Size = new Size(57, 21);
            maildonorlabel.TabIndex = 0;
            maildonorlabel.Text = "E mail";
            // 
            // Adddonors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 449);
            Controls.Add(txtpanel);
            Controls.Add(adddonorpanel);
            Name = "Adddonors";
            Text = "Adddonors";
            adddonorpanel.ResumeLayout(false);
            txtpanel.ResumeLayout(false);
            txtpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel adddonorpanel;
        private Button adddonortxtbtn;
        private Panel txtpanel;
        private Label maildonorlabel;
        private Label passadddonorlbl;
        private Label contactdonorlbl;
        private Label addressdonorlbl;
        private TextBox passadddonortxt;
        private TextBox maildonortxt;
        private TextBox addressdonortxt;
        private TextBox contactdonortxt;
        private Button addsavebtn;
    }
}