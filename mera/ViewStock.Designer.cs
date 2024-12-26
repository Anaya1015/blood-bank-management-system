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
            viewstockpanel = new Panel();
            button1 = new Button();
            viewstocktxtbtn = new Button();
            viewstockgrid = new DataGridView();
            viewstockpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewstockgrid).BeginInit();
            SuspendLayout();
            // 
            // viewstockpanel
            // 
            viewstockpanel.BackColor = Color.Maroon;
            viewstockpanel.Controls.Add(button1);
            viewstockpanel.Controls.Add(viewstocktxtbtn);
            viewstockpanel.Dock = DockStyle.Top;
            viewstockpanel.Location = new Point(0, 0);
            viewstockpanel.Name = "viewstockpanel";
            viewstockpanel.Size = new Size(685, 112);
            viewstockpanel.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(32, 44);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // viewstocktxtbtn
            // 
            viewstocktxtbtn.Anchor = AnchorStyles.None;
            viewstocktxtbtn.BackColor = Color.White;
            viewstocktxtbtn.FlatStyle = FlatStyle.Flat;
            viewstocktxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewstocktxtbtn.ForeColor = Color.Maroon;
            viewstocktxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            viewstocktxtbtn.Location = new Point(195, 26);
            viewstocktxtbtn.Name = "viewstocktxtbtn";
            viewstocktxtbtn.Size = new Size(310, 56);
            viewstocktxtbtn.TabIndex = 0;
            viewstocktxtbtn.Text = "VIEW STOCK";
            viewstocktxtbtn.UseVisualStyleBackColor = false;
            // 
            // viewstockgrid
            // 
            viewstockgrid.AllowUserToAddRows = false;
            viewstockgrid.AllowUserToDeleteRows = false;
            viewstockgrid.Anchor = AnchorStyles.None;
            viewstockgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewstockgrid.Location = new Point(177, 155);
            viewstockgrid.Name = "viewstockgrid";
            viewstockgrid.ReadOnly = true;
            viewstockgrid.Size = new Size(389, 226);
            viewstockgrid.TabIndex = 7;
            // 
            // ViewStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(685, 437);
            Controls.Add(viewstockgrid);
            Controls.Add(viewstockpanel);
            Margin = new Padding(2);
            Name = "ViewStock";
            Text = "ViewStock";
            WindowState = FormWindowState.Minimized;
            Load += ViewStock_Load;
            viewstockpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewstockgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewstockpanel;
        private Button viewstocktxtbtn;
        private DataGridView viewstockgrid;
        private Button button1;
    }
}