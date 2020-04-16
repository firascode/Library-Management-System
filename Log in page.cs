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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form2().Show();
            //this.Hide();
            if (textBox1.Text == "firas" && textBox2.Text == "2017")

            {

                MessageBox.Show("WELCOME (Firas) to the MLS");
                new Home().Show();
                this.Hide();

            }
            else if (textBox1.Text == "turki" && textBox2.Text == "2016")
            {
                MessageBox.Show("WELCOME turki   ");
                new Home().Show();
                this.Hide();
            }


            else if (textBox1.Text == "murad" && textBox2.Text == "2015")
            {
                MessageBox.Show("WELCOME murad   ");
                new Home().Show();
                this.Hide();
            }

            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show(" It Is Empty ");
               
               
            }
            else
            {
                MessageBox.Show("PAASWORD OR USERNAME IS NOT CORRECT");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
