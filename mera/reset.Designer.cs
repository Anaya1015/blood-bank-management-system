namespace project
{
    partial class Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            entruser = new Label();
            usertxt = new TextBox();
            nextbtn = new Button();
            resetpnl = new Panel();
            forgotlabel = new Label();
            resetpnl.SuspendLayout();
            SuspendLayout();
            // 
            // entruser
            // 
            entruser.Anchor = AnchorStyles.None;
            entruser.AutoSize = true;
            entruser.BackColor = Color.Transparent;
            entruser.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entruser.ForeColor = Color.Maroon;
            entruser.Location = new Point(56, 110);
            entruser.Name = "entruser";
            entruser.Size = new Size(121, 17);
            entruser.TabIndex = 0;
            entruser.Text = "Enter Username:";
            // 
            // usertxt
            // 
            usertxt.Anchor = AnchorStyles.None;
            usertxt.Cursor = Cursors.SizeAll;
            usertxt.Location = new Point(56, 130);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(192, 23);
            usertxt.TabIndex = 1;
            usertxt.TextChanged += usertxt_TextChanged;
            // 
            // nextbtn
            // 
            nextbtn.Anchor = AnchorStyles.None;
            nextbtn.BackColor = Color.Maroon;
            nextbtn.BackgroundImageLayout = ImageLayout.Zoom;
            nextbtn.FlatStyle = FlatStyle.Flat;
            nextbtn.ForeColor = Color.White;
            nextbtn.Location = new Point(114, 197);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 23);
            nextbtn.TabIndex = 2;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = false;
            nextbtn.Click += nextbtn_Click;
            // 
            // resetpnl
            // 
            resetpnl.Anchor = AnchorStyles.None;
            resetpnl.BackColor = Color.Transparent;
            resetpnl.Controls.Add(forgotlabel);
            resetpnl.Controls.Add(nextbtn);
            resetpnl.Controls.Add(usertxt);
            resetpnl.Controls.Add(entruser);
            resetpnl.Location = new Point(202, 99);
            resetpnl.Name = "resetpnl";
            resetpnl.Size = new Size(307, 272);
            resetpnl.TabIndex = 3;
            // 
            // forgotlabel
            // 
            forgotlabel.Anchor = AnchorStyles.None;
            forgotlabel.AutoSize = true;
            forgotlabel.BackColor = Color.Transparent;
            forgotlabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotlabel.ForeColor = Color.Maroon;
            forgotlabel.Location = new Point(87, 41);
            forgotlabel.Name = "forgotlabel";
            forgotlabel.Size = new Size(139, 19);
            forgotlabel.TabIndex = 3;
            forgotlabel.Text = "Forgot Password?";
            // 
            // Reset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(657, 450);
            Controls.Add(resetpnl);
            Name = "Reset";
            WindowState = FormWindowState.Minimized;
            Load += reset_Load;
            resetpnl.ResumeLayout(false);
            resetpnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label entruser;
        private TextBox usertxt;
        private Button nextbtn;
        private Panel resetpnl;
        private Label forgotlabel;
    }
}