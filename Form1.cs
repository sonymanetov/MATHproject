using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            crossword cw = new crossword();
            cw.Show();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            poetry pt = new poetry();
            pt.Show();
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            snowdrop sd = new snowdrop();
            sd.Show();
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            info info = new info();
            info.Show();
        }
    }
}
