namespace project
{
    partial class Managedonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managedonor));
            managedonortxtpnl = new Panel();
            managedonortxtlabel = new Label();
            optionmanagepnl = new Panel();
            exitbtndonor = new Button();
            updatedonorbtn = new Button();
            viewdonorbtn = new Button();
            deletedonotbtn = new Button();
            adddonorbtn = new Button();
            managedonortxtpnl.SuspendLayout();
            optionmanagepnl.SuspendLayout();
            SuspendLayout();
            // 
            // managedonortxtpnl
            // 
            managedonortxtpnl.BackColor = Color.Maroon;
            managedonortxtpnl.Controls.Add(managedonortxtlabel);
            managedonortxtpnl.Dock = DockStyle.Top;
            managedonortxtpnl.ForeColor = Color.White;
            managedonortxtpnl.Location = new Point(0, 0);
            managedonortxtpnl.Name = "managedonortxtpnl";
            managedonortxtpnl.Size = new Size(931, 100);
            managedonortxtpnl.TabIndex = 0;
            // 
            // managedonortxtlabel
            // 
            managedonortxtlabel.Anchor = AnchorStyles.None;
            managedonortxtlabel.AutoSize = true;
            managedonortxtlabel.BackColor = Color.White;
            managedonortxtlabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managedonortxtlabel.ForeColor = Color.Maroon;
            managedonortxtlabel.Location = new Point(357, 37);
            managedonortxtlabel.Name = "managedonortxtlabel";
            managedonortxtlabel.Size = new Size(237, 40);
            managedonortxtlabel.TabIndex = 0;
            managedonortxtlabel.Text = "Manage Donors";
            managedonortxtlabel.TextAlign = ContentAlignment.MiddleCenter;
            managedonortxtlabel.Click += managedonortxtlabel_Click;
            // 
            // optionmanagepnl
            // 
            optionmanagepnl.Controls.Add(exitbtndonor);
            optionmanagepnl.Controls.Add(updatedonorbtn);
            optionmanagepnl.Controls.Add(viewdonorbtn);
            optionmanagepnl.Controls.Add(deletedonotbtn);
            optionmanagepnl.Controls.Add(adddonorbtn);
            optionmanagepnl.Dock = DockStyle.Left;
            optionmanagepnl.Location = new Point(0, 100);
            optionmanagepnl.Name = "optionmanagepnl";
            optionmanagepnl.Size = new Size(278, 396);
            optionmanagepnl.TabIndex = 1;
            // 
            // exitbtndonor
            // 
            exitbtndonor.Anchor = AnchorStyles.None;
            exitbtndonor.BackColor = Color.Maroon;
            exitbtndonor.FlatStyle = FlatStyle.Popup;
            exitbtndonor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbtndonor.ForeColor = Color.White;
            exitbtndonor.Location = new Point(58, 324);
            exitbtndonor.Name = "exitbtndonor";
            exitbtndonor.Size = new Size(181, 48);
            exitbtndonor.TabIndex = 4;
            exitbtndonor.Text = "Exit";
            exitbtndonor.UseVisualStyleBackColor = false;
            // 
            // updatedonorbtn
            // 
            updatedonorbtn.Anchor = AnchorStyles.None;
            updatedonorbtn.BackColor = Color.Maroon;
            updatedonorbtn.FlatStyle = FlatStyle.Popup;
            updatedonorbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatedonorbtn.ForeColor = Color.White;
            updatedonorbtn.Location = new Point(58, 247);
            updatedonorbtn.Name = "updatedonorbtn";
            updatedonorbtn.Size = new Size(181, 48);
            updatedonorbtn.TabIndex = 3;
            updatedonorbtn.Text = "Update Details";
            updatedonorbtn.UseVisualStyleBackColor = false;
            // 
            // viewdonorbtn
            // 
            viewdonorbtn.Anchor = AnchorStyles.None;
            viewdonorbtn.BackColor = Color.Maroon;
            viewdonorbtn.FlatStyle = FlatStyle.Popup;
            viewdonorbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonorbtn.ForeColor = Color.White;
            viewdonorbtn.Location = new Point(58, 169);
            viewdonorbtn.Name = "viewdonorbtn";
            viewdonorbtn.Size = new Size(181, 48);
            viewdonorbtn.TabIndex = 2;
            viewdonorbtn.Text = "View Donors";
            viewdonorbtn.UseVisualStyleBackColor = false;
            // 
            // deletedonotbtn
            // 
            deletedonotbtn.Anchor = AnchorStyles.None;
            deletedonotbtn.BackColor = Color.Maroon;
            deletedonotbtn.FlatStyle = FlatStyle.Popup;
            deletedonotbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonotbtn.ForeColor = Color.White;
            deletedonotbtn.Location = new Point(58, 93);
            deletedonotbtn.Name = "deletedonotbtn";
            deletedonotbtn.Size = new Size(181, 48);
            deletedonotbtn.TabIndex = 1;
            deletedonotbtn.Text = "Delete Donor";
            deletedonotbtn.UseVisualStyleBackColor = false;
            // 
            // adddonorbtn
            // 
            adddonorbtn.Anchor = AnchorStyles.None;
            adddonorbtn.BackColor = Color.Maroon;
            adddonorbtn.FlatStyle = FlatStyle.Popup;
            adddonorbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adddonorbtn.ForeColor = Color.White;
            adddonorbtn.Location = new Point(58, 17);
            adddonorbtn.Name = "adddonorbtn";
            adddonorbtn.Size = new Size(181, 48);
            adddonorbtn.TabIndex = 0;
            adddonorbtn.Text = "Add Donor";
            adddonorbtn.UseVisualStyleBackColor = false;
            // 
            // Managedonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 496);
            Controls.Add(optionmanagepnl);
            Controls.Add(managedonortxtpnl);
            Name = "Managedonor";
            Text = "Managedonor";
            Load += Managedonor_Load;
            managedonortxtpnl.ResumeLayout(false);
            managedonortxtpnl.PerformLayout();
            optionmanagepnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel managedonortxtpnl;
        private Label managedonortxtlabel;
        private Panel optionmanagepnl;
        private Button exitbtndonor;
        private Button updatedonorbtn;
        private Button viewdonorbtn;
        private Button deletedonotbtn;
        private Button adddonorbtn;
    }
}