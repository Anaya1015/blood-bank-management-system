namespace project
{
    partial class ViewStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStock));
            viewdonorpanel = new Panel();
            viewdonortxtbtn = new Button();
            viewdonorlistpanel = new Panel();
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
            viewdonorpanel.Size = new Size(978, 187);
            viewdonorpanel.TabIndex = 6;
            // 
            // viewdonortxtbtn
            // 
            viewdonortxtbtn.Anchor = AnchorStyles.None;
            viewdonortxtbtn.BackColor = Color.White;
            viewdonortxtbtn.FlatStyle = FlatStyle.Flat;
            viewdonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonortxtbtn.ForeColor = Color.Maroon;
            viewdonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewdonortxtbtn.Location = new Point(278, 43);
            viewdonortxtbtn.Margin = new Padding(4, 5, 4, 5);
            viewdonortxtbtn.Name = "viewdonortxtbtn";
            viewdonortxtbtn.Size = new Size(443, 93);
            viewdonortxtbtn.TabIndex = 0;
            viewdonortxtbtn.Text = "VIEW STOCK";
            viewdonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // viewdonorlistpanel
            // 
            viewdonorlistpanel.Anchor = AnchorStyles.None;
            viewdonorlistpanel.Location = new Point(80, 245);
            viewdonorlistpanel.Margin = new Padding(4, 5, 4, 5);
            viewdonorlistpanel.Name = "viewdonorlistpanel";
            viewdonorlistpanel.Size = new Size(779, 435);
            viewdonorlistpanel.TabIndex = 7;
            // 
            // ViewStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 728);
            Controls.Add(viewdonorlistpanel);
            Controls.Add(viewdonorpanel);
            Name = "ViewStock";
            Text = "ViewStock";
            WindowState = FormWindowState.Maximized;
            viewdonorpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel viewdonorpanel;
        private Button viewdonortxtbtn;
        private Panel viewdonorlistpanel;
    }
}