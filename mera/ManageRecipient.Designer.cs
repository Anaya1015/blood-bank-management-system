namespace project
{
    partial class ManageRecipient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRecipient));
            managerecipienttxtpnl = new Panel();
            panel1 = new Panel();
            exitbtndonor = new Button();
            updatedonorbtn = new Button();
            viewdonorbtn = new Button();
            deletedonotbtn = new Button();
            adddonorbtn = new Button();
            managerecipienttxtlabel = new Label();
            optionrecientpanel = new Panel();
            exitrecipient = new Button();
            updaterecipient = new Button();
            viewrecipientbtn = new Button();
            deleterecipientbtn = new Button();
            addrecipientbtn = new Button();
            managerecipienttxtpnl.SuspendLayout();
            panel1.SuspendLayout();
            optionrecientpanel.SuspendLayout();
            SuspendLayout();
            // 
            // managerecipienttxtpnl
            // 
            managerecipienttxtpnl.BackColor = Color.Maroon;
            managerecipienttxtpnl.Controls.Add(panel1);
            managerecipienttxtpnl.Controls.Add(managerecipienttxtlabel);
            managerecipienttxtpnl.Dock = DockStyle.Top;
            managerecipienttxtpnl.ForeColor = Color.White;
            managerecipienttxtpnl.Location = new Point(0, 0);
            managerecipienttxtpnl.Name = "managerecipienttxtpnl";
            managerecipienttxtpnl.Size = new Size(921, 94);
            managerecipienttxtpnl.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(exitbtndonor);
            panel1.Controls.Add(updatedonorbtn);
            panel1.Controls.Add(viewdonorbtn);
            panel1.Controls.Add(deletedonotbtn);
            panel1.Controls.Add(adddonorbtn);
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 362);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // exitbtndonor
            // 
            exitbtndonor.BackColor = Color.Maroon;
            exitbtndonor.FlatStyle = FlatStyle.Popup;
            exitbtndonor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbtndonor.ForeColor = Color.White;
            exitbtndonor.Location = new Point(49, 211);
            exitbtndonor.Name = "exitbtndonor";
            exitbtndonor.Size = new Size(104, 33);
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
            updatedonorbtn.Location = new Point(44, 126);
            updatedonorbtn.Name = "updatedonorbtn";
            updatedonorbtn.Size = new Size(104, 33);
            updatedonorbtn.TabIndex = 3;
            updatedonorbtn.Text = "Update Details";
            updatedonorbtn.UseVisualStyleBackColor = false;
            // 
            // viewdonorbtn
            // 
            viewdonorbtn.BackColor = Color.Maroon;
            viewdonorbtn.FlatStyle = FlatStyle.Popup;
            viewdonorbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewdonorbtn.ForeColor = Color.White;
            viewdonorbtn.Location = new Point(49, 24);
            viewdonorbtn.Name = "viewdonorbtn";
            viewdonorbtn.Size = new Size(104, 33);
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
            deletedonotbtn.Location = new Point(44, 155);
            deletedonotbtn.Name = "deletedonotbtn";
            deletedonotbtn.Size = new Size(104, 33);
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
            adddonorbtn.Location = new Point(44, 87);
            adddonorbtn.Name = "adddonorbtn";
            adddonorbtn.Size = new Size(104, 33);
            adddonorbtn.TabIndex = 0;
            adddonorbtn.Text = "Add Donor";
            adddonorbtn.UseVisualStyleBackColor = false;
            // 
            // managerecipienttxtlabel
            // 
            managerecipienttxtlabel.Anchor = AnchorStyles.None;
            managerecipienttxtlabel.AutoSize = true;
            managerecipienttxtlabel.BackColor = Color.White;
            managerecipienttxtlabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerecipienttxtlabel.ForeColor = Color.Maroon;
            managerecipienttxtlabel.Location = new Point(338, 28);
            managerecipienttxtlabel.Name = "managerecipienttxtlabel";
            managerecipienttxtlabel.Size = new Size(264, 40);
            managerecipienttxtlabel.TabIndex = 0;
            managerecipienttxtlabel.Text = "Manage Recipient";
            managerecipienttxtlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // optionrecientpanel
            // 
            optionrecientpanel.Controls.Add(exitrecipient);
            optionrecientpanel.Controls.Add(updaterecipient);
            optionrecientpanel.Controls.Add(viewrecipientbtn);
            optionrecientpanel.Controls.Add(deleterecipientbtn);
            optionrecientpanel.Controls.Add(addrecipientbtn);
            optionrecientpanel.Dock = DockStyle.Left;
            optionrecientpanel.Location = new Point(0, 94);
            optionrecientpanel.Name = "optionrecientpanel";
            optionrecientpanel.Size = new Size(278, 404);
            optionrecientpanel.TabIndex = 2;
            // 
            // exitrecipient
            // 
            exitrecipient.Anchor = AnchorStyles.None;
            exitrecipient.BackColor = Color.Maroon;
            exitrecipient.FlatStyle = FlatStyle.Popup;
            exitrecipient.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitrecipient.ForeColor = Color.White;
            exitrecipient.Location = new Point(59, 339);
            exitrecipient.Name = "exitrecipient";
            exitrecipient.Size = new Size(181, 50);
            exitrecipient.TabIndex = 5;
            exitrecipient.Text = "Exit";
            exitrecipient.UseVisualStyleBackColor = false;
            // 
            // updaterecipient
            // 
            updaterecipient.Anchor = AnchorStyles.None;
            updaterecipient.BackColor = Color.Maroon;
            updaterecipient.FlatStyle = FlatStyle.Popup;
            updaterecipient.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updaterecipient.ForeColor = Color.White;
            updaterecipient.Location = new Point(59, 269);
            updaterecipient.Name = "updaterecipient";
            updaterecipient.Size = new Size(181, 47);
            updaterecipient.TabIndex = 4;
            updaterecipient.Text = "Update Details";
            updaterecipient.UseVisualStyleBackColor = false;
            // 
            // viewrecipientbtn
            // 
            viewrecipientbtn.Anchor = AnchorStyles.None;
            viewrecipientbtn.BackColor = Color.Maroon;
            viewrecipientbtn.FlatStyle = FlatStyle.Popup;
            viewrecipientbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewrecipientbtn.ForeColor = Color.White;
            viewrecipientbtn.Location = new Point(59, 190);
            viewrecipientbtn.Name = "viewrecipientbtn";
            viewrecipientbtn.Size = new Size(181, 52);
            viewrecipientbtn.TabIndex = 3;
            viewrecipientbtn.Text = "View Recipient";
            viewrecipientbtn.UseVisualStyleBackColor = false;
            // 
            // deleterecipientbtn
            // 
            deleterecipientbtn.Anchor = AnchorStyles.None;
            deleterecipientbtn.BackColor = Color.Maroon;
            deleterecipientbtn.FlatStyle = FlatStyle.Popup;
            deleterecipientbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleterecipientbtn.ForeColor = Color.White;
            deleterecipientbtn.Location = new Point(59, 111);
            deleterecipientbtn.Name = "deleterecipientbtn";
            deleterecipientbtn.Size = new Size(181, 51);
            deleterecipientbtn.TabIndex = 2;
            deleterecipientbtn.Text = "Delete Recipient";
            deleterecipientbtn.UseVisualStyleBackColor = false;
            // 
            // addrecipientbtn
            // 
            addrecipientbtn.Anchor = AnchorStyles.None;
            addrecipientbtn.BackColor = Color.Maroon;
            addrecipientbtn.FlatStyle = FlatStyle.Popup;
            addrecipientbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addrecipientbtn.ForeColor = Color.White;
            addrecipientbtn.Location = new Point(59, 36);
            addrecipientbtn.Name = "addrecipientbtn";
            addrecipientbtn.Size = new Size(181, 48);
            addrecipientbtn.TabIndex = 1;
            addrecipientbtn.Text = "Add Recipient";
            addrecipientbtn.UseVisualStyleBackColor = false;
            // 
            // ManageRecipient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(921, 498);
            Controls.Add(optionrecientpanel);
            Controls.Add(managerecipienttxtpnl);
            Name = "ManageRecipient";
            Text = "ManageRecipient";
            Load += ManageRecipient_Load;
            managerecipienttxtpnl.ResumeLayout(false);
            managerecipienttxtpnl.PerformLayout();
            panel1.ResumeLayout(false);
            optionrecientpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel managerecipienttxtpnl;
        private Label managerecipienttxtlabel;
        private Panel panel1;
        private Button exitbtndonor;
        private Button updatedonorbtn;
        private Button viewdonorbtn;
        private Button deletedonotbtn;
        private Button adddonorbtn;
        private Panel optionrecientpanel;
        private Button addrecipientbtn;
        private Button deleterecipientbtn;
        private Button viewrecipientbtn;
        private Button updaterecipient;
        private Button exitrecipient;
    }
}