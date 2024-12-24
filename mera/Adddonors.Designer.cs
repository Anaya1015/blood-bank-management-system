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
            components = new System.ComponentModel.Container();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            adddonorpanel.Margin = new Padding(4, 5, 4, 5);
            adddonorpanel.Name = "adddonorpanel";
            adddonorpanel.Size = new Size(1143, 187);
            adddonorpanel.TabIndex = 0;
            // 
            // adddonortxtbtn
            // 
            adddonortxtbtn.Anchor = AnchorStyles.None;
            adddonortxtbtn.BackColor = Color.White;
            adddonortxtbtn.FlatStyle = FlatStyle.Flat;
            adddonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adddonortxtbtn.ForeColor = Color.Maroon;
            adddonortxtbtn.Location = new Point(394, 40);
            adddonortxtbtn.Margin = new Padding(4, 5, 4, 5);
            adddonortxtbtn.Name = "adddonortxtbtn";
            adddonortxtbtn.Size = new Size(443, 93);
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
            txtpanel.Location = new Point(106, 197);
            txtpanel.Margin = new Padding(4, 5, 4, 5);
            txtpanel.Name = "txtpanel";
            txtpanel.Size = new Size(953, 528);
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
            addsavebtn.Location = new Point(414, 363);
            addsavebtn.Margin = new Padding(4, 5, 4, 5);
            addsavebtn.Name = "addsavebtn";
            addsavebtn.Size = new Size(139, 53);
            addsavebtn.TabIndex = 8;
            addsavebtn.Text = "Add";
            addsavebtn.UseVisualStyleBackColor = false;
            // 
            // addressdonortxt
            // 
            addressdonortxt.Anchor = AnchorStyles.None;
            addressdonortxt.Location = new Point(663, 237);
            addressdonortxt.Margin = new Padding(4, 5, 4, 5);
            addressdonortxt.Multiline = true;
            addressdonortxt.Name = "addressdonortxt";
            addressdonortxt.Size = new Size(238, 46);
            addressdonortxt.TabIndex = 7;
            // 
            // contactdonortxt
            // 
            contactdonortxt.Anchor = AnchorStyles.None;
            contactdonortxt.Location = new Point(227, 237);
            contactdonortxt.Margin = new Padding(4, 5, 4, 5);
            contactdonortxt.Name = "contactdonortxt";
            contactdonortxt.Size = new Size(238, 39);
            contactdonortxt.TabIndex = 6;
            // 
            // passadddonortxt
            // 
            passadddonortxt.Anchor = AnchorStyles.None;
            passadddonortxt.Location = new Point(663, 98);
            passadddonortxt.Margin = new Padding(4, 5, 4, 5);
            passadddonortxt.Name = "passadddonortxt";
            passadddonortxt.Size = new Size(238, 39);
            passadddonortxt.TabIndex = 5;
            // 
            // maildonortxt
            // 
            maildonortxt.Anchor = AnchorStyles.None;
            maildonortxt.Location = new Point(206, 98);
            maildonortxt.Margin = new Padding(4, 5, 4, 5);
            maildonortxt.Name = "maildonortxt";
            maildonortxt.Size = new Size(238, 39);
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
            passadddonorlbl.Location = new Point(519, 103);
            passadddonorlbl.Margin = new Padding(4, 0, 4, 0);
            passadddonorlbl.Name = "passadddonorlbl";
            passadddonorlbl.Size = new Size(122, 32);
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
            contactdonorlbl.Location = new Point(106, 242);
            contactdonorlbl.Margin = new Padding(4, 0, 4, 0);
            contactdonorlbl.Name = "contactdonorlbl";
            contactdonorlbl.Size = new Size(102, 32);
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
            addressdonorlbl.Location = new Point(519, 242);
            addressdonorlbl.Margin = new Padding(4, 0, 4, 0);
            addressdonorlbl.Name = "addressdonorlbl";
            addressdonorlbl.Size = new Size(106, 32);
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
            maildonorlabel.Location = new Point(106, 103);
            maildonorlabel.Margin = new Padding(4, 0, 4, 0);
            maildonorlabel.Name = "maildonorlabel";
            maildonorlabel.Size = new Size(83, 32);
            maildonorlabel.TabIndex = 0;
            maildonorlabel.Text = "E mail";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Adddonors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 760);
            Controls.Add(txtpanel);
            Controls.Add(adddonorpanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Adddonors";
            Text = "Adddonors";
            Load += Adddonors_Load;
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
        private ContextMenuStrip contextMenuStrip1;
    }
}