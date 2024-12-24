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
            addeletedonorpanel.Margin = new Padding(5, 6, 5, 6);
            addeletedonorpanel.Name = "addeletedonorpanel";
            addeletedonorpanel.Size = new Size(1093, 224);
            addeletedonorpanel.TabIndex = 2;
            // 
            // deletedonortxtbtn
            // 
            deletedonortxtbtn.Anchor = AnchorStyles.None;
            deletedonortxtbtn.BackColor = SystemColors.Control;
            deletedonortxtbtn.FlatStyle = FlatStyle.Flat;
            deletedonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonortxtbtn.ForeColor = Color.Maroon;
            deletedonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            deletedonortxtbtn.Location = new Point(288, 47);
            deletedonortxtbtn.Margin = new Padding(5, 6, 5, 6);
            deletedonortxtbtn.Name = "deletedonortxtbtn";
            deletedonortxtbtn.Size = new Size(576, 112);
            deletedonortxtbtn.TabIndex = 0;
            deletedonortxtbtn.Text = "DELETE RECIPIENT";
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
            idfordeletedonorbtn.Location = new Point(303, 329);
            idfordeletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            idfordeletedonorbtn.Name = "idfordeletedonorbtn";
            idfordeletedonorbtn.Size = new Size(126, 45);
            idfordeletedonorbtn.TabIndex = 3;
            idfordeletedonorbtn.Text = "Id:";
            idfordeletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // idtxtfordeletedonor
            // 
            idtxtfordeletedonor.Anchor = AnchorStyles.None;
            idtxtfordeletedonor.Location = new Point(514, 333);
            idtxtfordeletedonor.Margin = new Padding(4, 5, 4, 5);
            idtxtfordeletedonor.Name = "idtxtfordeletedonor";
            idtxtfordeletedonor.Size = new Size(173, 35);
            idtxtfordeletedonor.TabIndex = 4;
            // 
            // deletedonorpanel
            // 
            deletedonorpanel.Anchor = AnchorStyles.None;
            deletedonorpanel.Location = new Point(146, 418);
            deletedonorpanel.Margin = new Padding(4, 5, 4, 5);
            deletedonorpanel.Name = "deletedonorpanel";
            deletedonorpanel.Size = new Size(745, 315);
            deletedonorpanel.TabIndex = 5;
            // 
            // deletedonorbtn
            // 
            deletedonorbtn.Anchor = AnchorStyles.None;
            deletedonorbtn.BackColor = Color.Maroon;
            deletedonorbtn.FlatStyle = FlatStyle.Flat;
            deletedonorbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonorbtn.ForeColor = Color.White;
            deletedonorbtn.Location = new Point(411, 765);
            deletedonorbtn.Margin = new Padding(4, 5, 4, 5);
            deletedonorbtn.Name = "deletedonorbtn";
            deletedonorbtn.Size = new Size(177, 48);
            deletedonorbtn.TabIndex = 6;
            deletedonorbtn.Text = "Delete";
            deletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // DeleteRecipient
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 865);
            Controls.Add(deletedonorbtn);
            Controls.Add(deletedonorpanel);
            Controls.Add(idtxtfordeletedonor);
            Controls.Add(idfordeletedonorbtn);
            Controls.Add(addeletedonorpanel);
            Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DeleteRecipient";
            Text = "DeleteRecipient";
            Load += DeleteRecipient_Load;
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