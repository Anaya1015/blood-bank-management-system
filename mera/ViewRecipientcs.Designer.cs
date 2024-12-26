namespace project
{
    partial class ViewRecipientcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecipientcs));
            viewdonorpanel = new Panel();
            button1 = new Button();
            viewdonortxtbtn = new Button();
            viewrecipientgrid = new DataGridView();
            viewdonorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewrecipientgrid).BeginInit();
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
            viewdonorpanel.Size = new Size(853, 112);
            viewdonorpanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(55, 28);
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
            viewdonortxtbtn.Location = new Point(297, 28);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(310, 56);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "VIEW RECIPIENT";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // viewrecipientgrid
            // 
            viewrecipientgrid.Anchor = AnchorStyles.None;
            viewrecipientgrid.BackgroundColor = Color.White;
            viewrecipientgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewrecipientgrid.Location = new Point(140, 161);
            viewrecipientgrid.Name = "viewrecipientgrid";
            viewrecipientgrid.Size = new Size(610, 228);
            viewrecipientgrid.TabIndex = 4;
            viewrecipientgrid.CellContentClick += viewrecipientgrid_CellContentClick;
            // 
            // ViewRecipientcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 422);
            Controls.Add(viewrecipientgrid);
            Controls.Add(viewdonorpanel);
            Margin = new Padding(2);
            Name = "ViewRecipientcs";
            Text = "ViewRecipientcs";
            WindowState = FormWindowState.Maximized;
            Load += ViewRecipientcs_Load;
            viewdonorpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewrecipientgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private DataGridView viewrecipientgrid;
        private Button button1;
    }
}