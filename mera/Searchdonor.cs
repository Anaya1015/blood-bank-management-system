﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Searchdonor : Form
    {
        public Searchdonor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recipientdashboard managerec = new Recipientdashboard();
            managerec.Show();
            managerec.FormClosed += (s, args) => this.Close();
        }
    }
}
