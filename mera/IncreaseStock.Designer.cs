namespace project
{
    partial class IncreaseStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncreaseStock));
            viewdonorpanel = new Panel();
            viewdonortxtbtn = new Button();
            idfordeletedonorbtn = new Button();
            idtxtfordeletedonor = new TextBox();
            addrecipientbtn = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            viewdonorpanel.SuspendLayout();
            SuspendLayout();
            // 
            // viewdonorpanel
            // 
            viewdonorpanel.BackColor = Color.Maroon;
            viewdonorpanel.Controls.Add(viewdonortxtbtn);
            viewdonorpanel.Dock = DockStyle.Top;
            viewdonorpanel.Location = new Point(0, 0);
            viewdonorpanel.Margin = new Padding(4, 5, 4, 5);
            viewdonorpanel.Name = "viewdonorpanel";
            viewdonorpanel.Size = new Size(1036, 142);
            viewdonorpanel.TabIndex = 4;
            // 
            // viewdonortxtbtn
            // 
            viewdonortxtbtn.Anchor = AnchorStyles.None;
            viewdonortxtbtn.BackColor = Color.White;
            viewdonortxtbtn.FlatStyle = FlatStyle.Flat;
            viewdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonortxtbtn.ForeColor = Color.Maroon;
            viewdonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewdonortxtbtn.Location = new Point(327, 10);
            viewdonortxtbtn.Margin = new Padding(4, 5, 4, 5);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(443, 93);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "INCREASE STOCK";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // idfordeletedonorbtn
            // 
            idfordeletedonorbtn.Anchor = AnchorStyles.None;
            idfordeletedonorbtn.BackColor = Color.Maroon;
            idfordeletedonorbtn.BackgroundImageLayout = ImageLayout.None;
            idfordeletedonorbtn.FlatStyle = FlatStyle.Flat;
            idfordeletedonorbtn.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            idfordeletedonorbtn.ForeColor = Color.White;
            idfordeletedonorbtn.Location = new Point(86, 246);
            idfordeletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            idfordeletedonorbtn.Name = "idfordeletedonorbtn";
            idfordeletedonorbtn.Size = new Size(223, 54);
            idfordeletedonorbtn.TabIndex = 5;
            idfordeletedonorbtn.Text = "Blood Group:";
            idfordeletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // idtxtfordeletedonor
            // 
            idtxtfordeletedonor.Anchor = AnchorStyles.None;
            idtxtfordeletedonor.Location = new Point(327, 264);
            idtxtfordeletedonor.Margin = new Padding(4, 5, 4, 5);
            idtxtfordeletedonor.Name = "idtxtfordeletedonor";
            idtxtfordeletedonor.Size = new Size(173, 31);
            idtxtfordeletedonor.TabIndex = 8;
            // 
            // addrecipientbtn
            // 
            addrecipientbtn.Anchor = AnchorStyles.None;
            addrecipientbtn.BackColor = Color.Maroon;
            addrecipientbtn.FlatStyle = FlatStyle.Popup;
            addrecipientbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addrecipientbtn.ForeColor = Color.White;
            addrecipientbtn.Location = new Point(533, 253);
            addrecipientbtn.Margin = new Padding(4, 5, 4, 5);
            addrecipientbtn.Name = "addrecipientbtn";
            addrecipientbtn.Size = new Size(259, 51);
            addrecipientbtn.TabIndex = 9;
            addrecipientbtn.Text = "No of Units:";
            addrecipientbtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(816, 269);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 31);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(446, 432);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(189, 55);
            button1.TabIndex = 11;
            button1.Text = "Increase";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(66, 212);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(958, 378);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // IncreaseStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1036, 652);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(addrecipientbtn);
            Controls.Add(idtxtfordeletedonor);
            Controls.Add(idfordeletedonorbtn);
            Controls.Add(viewdonorpanel);
            Controls.Add(flowLayoutPanel1);
            Name = "IncreaseStock";
            Text = "IncreaseStock";
            Load += IncreaseStock_Load;
            viewdonorpanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private Button idfordeletedonorbtn;
        private TextBox idtxtfordeletedonor;
        private Button addrecipientbtn;
        private TextBox textBox1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}