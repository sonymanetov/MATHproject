﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matesha228
{
    public partial class poetry : Form
    {
        public poetry()
        {
            InitializeComponent();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void poetry_Load(object sender, EventArgs e)
        {

        }
    }
}
