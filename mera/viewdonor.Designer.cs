namespace project
{
    partial class viewdonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewdonor));
            viewdonorpanel = new Panel();
            button1 = new Button();
            viewdonortxtbtn = new Button();
            donorgridview = new DataGridView();
            viewdonorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)donorgridview).BeginInit();
            SuspendLayout();
            // 
            // viewdonorpanel
            // 
            viewdonorpanel.BackColor = Color.Maroon;
            viewdonorpanel.Controls.Add(button1);
            viewdonorpanel.Controls.Add(viewdonortxtbtn);
            viewdonorpanel.Dock = DockStyle.Top;
            viewdonorpanel.Location = new Point(0, 0);
            viewdonorpanel.Name = "viewdonorpanel";
            viewdonorpanel.Size = new Size(800, 112);
            viewdonorpanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(52, 35);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // viewdonortxtbtn
            // 
            viewdonortxtbtn.Anchor = AnchorStyles.None;
            viewdonortxtbtn.BackColor = Color.White;
            viewdonortxtbtn.FlatStyle = FlatStyle.Flat;
            viewdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonortxtbtn.ForeColor = Color.Maroon;
            viewdonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewdonortxtbtn.Location = new Point(258, 35);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(310, 56);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "VIEW DONOR";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // donorgridview
            // 
            donorgridview.AccessibleDescription = " ";
            donorgridview.Anchor = AnchorStyles.None;
            donorgridview.BackgroundColor = Color.White;
            donorgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            donorgridview.GridColor = Color.White;
            donorgridview.Location = new Point(97, 142);
            donorgridview.Name = "donorgridview";
            donorgridview.Size = new Size(610, 274);
            donorgridview.TabIndex = 3;
            // 
            // viewdonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(donorgridview);
            Controls.Add(viewdonorpanel);
            Name = "viewdonor";
            Text = "viewdonor";
            WindowState = FormWindowState.Maximized;
            Load += viewdonor_Load;
            viewdonorpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)donorgridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private DataGridView donorgridview;
        private Button button1;
    }
}