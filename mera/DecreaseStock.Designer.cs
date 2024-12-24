namespace project
{
    partial class DecreaseStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecreaseStock));
            viewdonorpanel = new Panel();
            viewdonortxtbtn = new Button();
            textBox1 = new TextBox();
            idtxtfordeletedonor = new TextBox();
            button1 = new Button();
            idfordeletedonorbtn = new Button();
            addrecipientbtn = new Button();
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
            viewdonorpanel.Size = new Size(1062, 187);
            viewdonorpanel.TabIndex = 5;
            // 
            // viewdonortxtbtn
            // 
            viewdonortxtbtn.Anchor = AnchorStyles.None;
            viewdonortxtbtn.BackColor = Color.White;
            viewdonortxtbtn.FlatStyle = FlatStyle.Flat;
            viewdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonortxtbtn.ForeColor = Color.Maroon;
            viewdonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewdonortxtbtn.Location = new Point(345, 50);
            viewdonortxtbtn.Margin = new Padding(4, 5, 4, 5);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(443, 93);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "DECREASE STOCK";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(848, 306);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 31);
            textBox1.TabIndex = 8;
            // 
            // idtxtfordeletedonor
            // 
            idtxtfordeletedonor.Anchor = AnchorStyles.None;
            idtxtfordeletedonor.Location = new Point(373, 306);
            idtxtfordeletedonor.Margin = new Padding(4, 5, 4, 5);
            idtxtfordeletedonor.Name = "idtxtfordeletedonor";
            idtxtfordeletedonor.Size = new Size(173, 31);
            idtxtfordeletedonor.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(460, 460);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(189, 55);
            button1.TabIndex = 6;
            button1.Text = "Decrease";
            button1.UseVisualStyleBackColor = false;
            // 
            // idfordeletedonorbtn
            // 
            idfordeletedonorbtn.Anchor = AnchorStyles.None;
            idfordeletedonorbtn.BackColor = Color.Maroon;
            idfordeletedonorbtn.BackgroundImageLayout = ImageLayout.None;
            idfordeletedonorbtn.FlatStyle = FlatStyle.Flat;
            idfordeletedonorbtn.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            idfordeletedonorbtn.ForeColor = Color.White;
            idfordeletedonorbtn.Location = new Point(124, 283);
            idfordeletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            idfordeletedonorbtn.Name = "idfordeletedonorbtn";
            idfordeletedonorbtn.Size = new Size(223, 54);
            idfordeletedonorbtn.TabIndex = 4;
            idfordeletedonorbtn.Text = "Blood Group:";
            idfordeletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // addrecipientbtn
            // 
            addrecipientbtn.Anchor = AnchorStyles.None;
            addrecipientbtn.BackColor = Color.Maroon;
            addrecipientbtn.FlatStyle = FlatStyle.Popup;
            addrecipientbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addrecipientbtn.ForeColor = Color.White;
            addrecipientbtn.Location = new Point(574, 286);
            addrecipientbtn.Margin = new Padding(4, 5, 4, 5);
            addrecipientbtn.Name = "addrecipientbtn";
            addrecipientbtn.Size = new Size(259, 51);
            addrecipientbtn.TabIndex = 5;
            addrecipientbtn.Text = "No of Units:";
            addrecipientbtn.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(99, 250);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(951, 400);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // DecreaseStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 733);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(idtxtfordeletedonor);
            Controls.Add(viewdonorpanel);
            Controls.Add(addrecipientbtn);
            Controls.Add(idfordeletedonorbtn);
            Controls.Add(flowLayoutPanel1);
            Name = "DecreaseStock";
            Text = "DecreaseStock";
            Load += DecreaseStock_Load;
            viewdonorpanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private TextBox textBox1;
        private TextBox idtxtfordeletedonor;
        private Button button1;
        private Button idfordeletedonorbtn;
        private Button addrecipientbtn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}