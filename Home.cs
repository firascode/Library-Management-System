using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_PROJECT_LMS___FINAL_v
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modi1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            srch1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            borr1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rtr1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hom1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hom1.BringToFront();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            hom1.BringToFront();
        }
    }
}
