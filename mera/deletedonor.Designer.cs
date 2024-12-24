namespace project
{
    partial class deletedonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletedonor));
            addeletedonorpanel = new Panel();
            deletedonortxtbtn = new Button();
            idfordeletedonorbtn = new Button();
            idtxtfordeletedonor = new TextBox();
            deletedonorpanel = new Panel();
            deletedonorbtn = new Button();
            addeletedonorpanel.SuspendLayout();
            SuspendLayout();
            // 
            // addeletedonorpanel
            // 
            addeletedonorpanel.BackColor = Color.Maroon;
            addeletedonorpanel.Controls.Add(deletedonortxtbtn);
            addeletedonorpanel.Dock = DockStyle.Top;
            addeletedonorpanel.Location = new Point(0, 0);
            addeletedonorpanel.Margin = new Padding(4, 5, 4, 5);
            addeletedonorpanel.Name = "addeletedonorpanel";
            addeletedonorpanel.Size = new Size(1143, 187);
            addeletedonorpanel.TabIndex = 1;
            // 
            // deletedonortxtbtn
            // 
            deletedonortxtbtn.Anchor = AnchorStyles.None;
            deletedonortxtbtn.BackColor = Color.White;
            deletedonortxtbtn.FlatStyle = FlatStyle.Flat;
            deletedonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonortxtbtn.ForeColor = Color.Maroon;
            deletedonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            deletedonortxtbtn.Location = new Point(347, 52);
            deletedonortxtbtn.Margin = new Padding(4, 5, 4, 5);
            deletedonortxtbtn.Name = "deletedonortxtbtn";
            deletedonortxtbtn.Size = new Size(443, 93);
            deletedonortxtbtn.TabIndex = 0;
            deletedonortxtbtn.Text = "DELETE DONOR";
            deletedonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // idfordeletedonorbtn
            // 
            idfordeletedonorbtn.Anchor = AnchorStyles.None;
            idfordeletedonorbtn.BackColor = Color.Maroon;
            idfordeletedonorbtn.BackgroundImageLayout = ImageLayout.None;
            idfordeletedonorbtn.FlatStyle = FlatStyle.Flat;
            idfordeletedonorbtn.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            idfordeletedonorbtn.ForeColor = Color.White;
            idfordeletedonorbtn.Location = new Point(406, 252);
            idfordeletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            idfordeletedonorbtn.Name = "idfordeletedonorbtn";
            idfordeletedonorbtn.Size = new Size(126, 45);
            idfordeletedonorbtn.TabIndex = 2;
            idfordeletedonorbtn.Text = "Id:";
            idfordeletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // idtxtfordeletedonor
            // 
            idtxtfordeletedonor.Anchor = AnchorStyles.None;
            idtxtfordeletedonor.Location = new Point(579, 258);
            idtxtfordeletedonor.Margin = new Padding(4, 5, 4, 5);
            idtxtfordeletedonor.Name = "idtxtfordeletedonor";
            idtxtfordeletedonor.Size = new Size(173, 31);
            idtxtfordeletedonor.TabIndex = 3;
            // 
            // deletedonorpanel
            // 
            deletedonorpanel.Anchor = AnchorStyles.None;
            deletedonorpanel.Location = new Point(139, 332);
            deletedonorpanel.Margin = new Padding(4, 5, 4, 5);
            deletedonorpanel.Name = "deletedonorpanel";
            deletedonorpanel.Size = new Size(843, 343);
            deletedonorpanel.TabIndex = 4;
            // 
            // deletedonorbtn
            // 
            deletedonorbtn.Anchor = AnchorStyles.None;
            deletedonorbtn.BackColor = Color.Maroon;
            deletedonorbtn.FlatStyle = FlatStyle.Flat;
            deletedonorbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonorbtn.ForeColor = Color.White;
            deletedonorbtn.Location = new Point(463, 707);
            deletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            deletedonorbtn.Name = "deletedonorbtn";
            deletedonorbtn.Size = new Size(177, 48);
            deletedonorbtn.TabIndex = 5;
            deletedonorbtn.Text = "Delete";
            deletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // deletedonor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 775);
            Controls.Add(deletedonorbtn);
            Controls.Add(deletedonorpanel);
            Controls.Add(idtxtfordeletedonor);
            Controls.Add(idfordeletedonorbtn);
            Controls.Add(addeletedonorpanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "deletedonor";
            Text = "deletedonor";
            Load += deletedonor_Load;
            addeletedonorpanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel addeletedonorpanel;
        private Button deletedonortxtbtn;
        private Button idfordeletedonorbtn;
        private TextBox idtxtfordeletedonor;
        private Panel deletedonorpanel;
        private Button deletedonorbtn;
    }
}