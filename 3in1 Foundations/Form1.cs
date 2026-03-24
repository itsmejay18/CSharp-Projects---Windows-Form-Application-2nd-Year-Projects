using Gmall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmall
{
    public partial class Form1 : Form
    {
        public static Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;

            user = textBox1.Text;
            pass = textBox2.Text;

            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Welcome");
                this.Hide();
                f2.Show();
            }

            else
            {
                MessageBox.Show("Invalid Account");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
