namespace project
{
    partial class DeleteRecipient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecipient));
            addeletedonorpanel = new Panel();
            button1 = new Button();
            deleterecipienttxtbtn = new Button();
            idfordeletedonorbtn = new Button();
            idtxtfordeletedonor = new TextBox();
            deletedonorbtn = new Button();
            recipientdataGridView = new DataGridView();
            deletebtnrecipiet = new Button();
            addeletedonorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipientdataGridView).BeginInit();
            SuspendLayout();
            // 
            // addeletedonorpanel
            // 
            addeletedonorpanel.BackColor = Color.Maroon;
            addeletedonorpanel.Controls.Add(button1);
            addeletedonorpanel.Controls.Add(deleterecipienttxtbtn);
            addeletedonorpanel.Dock = DockStyle.Top;
            addeletedonorpanel.Location = new Point(0, 0);
            addeletedonorpanel.Margin = new Padding(5, 6, 5, 6);
            addeletedonorpanel.Name = "addeletedonorpanel";
            addeletedonorpanel.Size = new Size(860, 112);
            addeletedonorpanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(43, 31);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleterecipienttxtbtn
            // 
            deleterecipienttxtbtn.Anchor = AnchorStyles.None;
            deleterecipienttxtbtn.BackColor = Color.White;
            deleterecipienttxtbtn.FlatStyle = FlatStyle.Flat;
            deleterecipienttxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleterecipienttxtbtn.ForeColor = Color.Maroon;
            deleterecipienttxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            deleterecipienttxtbtn.Location = new Point(320, 31);
            deleterecipienttxtbtn.Name = "deleterecipienttxtbtn";
            deleterecipienttxtbtn.Size = new Size(310, 56);
            deleterecipienttxtbtn.TabIndex = 1;
            deleterecipienttxtbtn.Text = "DELETE RECIPIENT";
            deleterecipienttxtbtn.UseVisualStyleBackColor = false;
            // 
            // idfordeletedonorbtn
            // 
            idfordeletedonorbtn.Anchor = AnchorStyles.None;
            idfordeletedonorbtn.BackColor = Color.Maroon;
            idfordeletedonorbtn.BackgroundImageLayout = ImageLayout.None;
            idfordeletedonorbtn.FlatStyle = FlatStyle.Flat;
            idfordeletedonorbtn.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            idfordeletedonorbtn.ForeColor = Color.White;
            idfordeletedonorbtn.Location = new Point(256, 134);
            idfordeletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            idfordeletedonorbtn.Name = "idfordeletedonorbtn";
            idfordeletedonorbtn.Size = new Size(123, 30);
            idfordeletedonorbtn.TabIndex = 3;
            idfordeletedonorbtn.Text = "Id:";
            idfordeletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // idtxtfordeletedonor
            // 
            idtxtfordeletedonor.Anchor = AnchorStyles.None;
            idtxtfordeletedonor.Location = new Point(457, 138);
            idtxtfordeletedonor.Margin = new Padding(4, 5, 4, 5);
            idtxtfordeletedonor.Name = "idtxtfordeletedonor";
            idtxtfordeletedonor.Size = new Size(173, 26);
            idtxtfordeletedonor.TabIndex = 4;
            // 
            // deletedonorbtn
            // 
            deletedonorbtn.Anchor = AnchorStyles.None;
            deletedonorbtn.BackColor = Color.Maroon;
            deletedonorbtn.FlatStyle = FlatStyle.Flat;
            deletedonorbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonorbtn.ForeColor = Color.White;
            deletedonorbtn.Location = new Point(295, 635);
            deletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            deletedonorbtn.Name = "deletedonorbtn";
            deletedonorbtn.Size = new Size(177, 48);
            deletedonorbtn.TabIndex = 6;
            deletedonorbtn.Text = "Delete";
            deletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // recipientdataGridView
            // 
            recipientdataGridView.AllowUserToAddRows = false;
            recipientdataGridView.AllowUserToDeleteRows = false;
            recipientdataGridView.Anchor = AnchorStyles.None;
            recipientdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recipientdataGridView.Location = new Point(82, 199);
            recipientdataGridView.Name = "recipientdataGridView";
            recipientdataGridView.ReadOnly = true;
            recipientdataGridView.Size = new Size(685, 219);
            recipientdataGridView.TabIndex = 7;
            // 
            // deletebtnrecipiet
            // 
            deletebtnrecipiet.Anchor = AnchorStyles.None;
            deletebtnrecipiet.BackColor = Color.Maroon;
            deletebtnrecipiet.FlatStyle = FlatStyle.Flat;
            deletebtnrecipiet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtnrecipiet.ForeColor = Color.White;
            deletebtnrecipiet.Location = new Point(348, 444);
            deletebtnrecipiet.Name = "deletebtnrecipiet";
            deletebtnrecipiet.Size = new Size(124, 29);
            deletebtnrecipiet.TabIndex = 8;
            deletebtnrecipiet.Text = "Delete";
            deletebtnrecipiet.UseVisualStyleBackColor = false;
            deletebtnrecipiet.Click += deletebtnrecipiet_Click;
            // 
            // DeleteRecipient
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(860, 488);
            Controls.Add(deletebtnrecipiet);
            Controls.Add(recipientdataGridView);
            Controls.Add(deletedonorbtn);
            Controls.Add(idtxtfordeletedonor);
            Controls.Add(idfordeletedonorbtn);
            Controls.Add(addeletedonorpanel);
            Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "DeleteRecipient";
            Text = "DeleteRecipient";
            WindowState = FormWindowState.Maximized;
            Load += DeleteRecipient_Load;
            addeletedonorpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)recipientdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel addeletedonorpanel;
        private Button idfordeletedonorbtn;
        private TextBox idtxtfordeletedonor;
        private Button deletedonorbtn;
        private DataGridView recipientdataGridView;
        private Button deleterecipienttxtbtn;
        private Button deletebtnrecipiet;
        private Button button1;
    }
}