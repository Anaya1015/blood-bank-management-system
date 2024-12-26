namespace project
{
    partial class ModifyStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyStock));
            viewdonorpanel = new Panel();
            viewdonortxtbtn = new Button();
            addrecipientbtn = new Button();
            button1 = new Button();
            optionmanagepnl = new Panel();
            button3 = new Button();
            button2 = new Button();
            exitbtndonor = new Button();
            viewdonorpanel.SuspendLayout();
            optionmanagepnl.SuspendLayout();
            SuspendLayout();
            // 
            // viewdonorpanel
            // 
            viewdonorpanel.BackColor = Color.Maroon;
            viewdonorpanel.Controls.Add(viewdonortxtbtn);
            viewdonorpanel.Dock = DockStyle.Top;
            viewdonorpanel.Location = new Point(0, 0);
            viewdonorpanel.Name = "viewdonorpanel";
            viewdonorpanel.Size = new Size(728, 112);
            viewdonorpanel.TabIndex = 3;
            // 
            // viewdonortxtbtn
            // 
            viewdonortxtbtn.Anchor = AnchorStyles.None;
            viewdonortxtbtn.BackColor = Color.White;
            viewdonortxtbtn.FlatStyle = FlatStyle.Flat;
            viewdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonortxtbtn.ForeColor = Color.Maroon;
            viewdonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewdonortxtbtn.Location = new Point(214, 22);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(310, 56);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "MODIFY STOCK";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // addrecipientbtn
            // 
            addrecipientbtn.Anchor = AnchorStyles.None;
            addrecipientbtn.BackColor = Color.Maroon;
            addrecipientbtn.FlatStyle = FlatStyle.Popup;
            addrecipientbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addrecipientbtn.ForeColor = Color.White;
            addrecipientbtn.Location = new Point(38, 187);
            addrecipientbtn.Name = "addrecipientbtn";
            addrecipientbtn.Size = new Size(181, 48);
            addrecipientbtn.TabIndex = 5;
            addrecipientbtn.Text = "View Stock";
            addrecipientbtn.UseVisualStyleBackColor = false;
            addrecipientbtn.Click += addrecipientbtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(38, 113);
            button1.Name = "button1";
            button1.Size = new Size(181, 48);
            button1.TabIndex = 6;
            button1.Text = "  Decrease Stock";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // optionmanagepnl
            // 
            optionmanagepnl.Controls.Add(button3);
            optionmanagepnl.Controls.Add(button2);
            optionmanagepnl.Controls.Add(exitbtndonor);
            optionmanagepnl.Controls.Add(button1);
            optionmanagepnl.Controls.Add(addrecipientbtn);
            optionmanagepnl.Dock = DockStyle.Left;
            optionmanagepnl.Location = new Point(0, 112);
            optionmanagepnl.Name = "optionmanagepnl";
            optionmanagepnl.Size = new Size(257, 337);
            optionmanagepnl.TabIndex = 7;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Maroon;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(38, 45);
            button3.Name = "button3";
            button3.Size = new Size(181, 48);
            button3.TabIndex = 8;
            button3.Text = "  Increase Stock";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(38, 261);
            button2.Name = "button2";
            button2.Size = new Size(181, 48);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // exitbtndonor
            // 
            exitbtndonor.Anchor = AnchorStyles.None;
            exitbtndonor.BackColor = Color.Maroon;
            exitbtndonor.FlatStyle = FlatStyle.Popup;
            exitbtndonor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbtndonor.ForeColor = Color.White;
            exitbtndonor.Location = new Point(116, 462);
            exitbtndonor.Name = "exitbtndonor";
            exitbtndonor.Size = new Size(181, 48);
            exitbtndonor.TabIndex = 4;
            exitbtndonor.Text = "Exit";
            exitbtndonor.UseVisualStyleBackColor = false;
            // 
            // ModifyStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(728, 449);
            Controls.Add(optionmanagepnl);
            Controls.Add(viewdonorpanel);
            Margin = new Padding(2);
            Name = "ModifyStock";
            Text = "ModifyStock";
            WindowState = FormWindowState.Maximized;
            Load += ModifyStock_Load;
            viewdonorpanel.ResumeLayout(false);
            optionmanagepnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private Button addrecipientbtn;
        private Button button1;
        private Panel optionmanagepnl;
        private Button exitbtndonor;
        private Button button3;
        private Button button2;
    }
}