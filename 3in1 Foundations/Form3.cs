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
    public partial class Form3 : Form
    {
        public static Form2 f2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            String a = "1";

            textBox1.Text += a;         
        }

        private void two_Click(object sender, EventArgs e)
        {
            String a = "2";

            textBox1.Text += a;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            String a = "3";

            textBox1.Text += a;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            String a = "4";

            textBox1.Text += a;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            String a = "5";

            textBox1.Text += a;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            String a = "6";

            textBox1.Text += a;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            String a = "7";

            textBox1.Text += a;
        }

        private void Eigth_Click(object sender, EventArgs e)
        {
            String a = "8";

            textBox1.Text += a;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            String a = "9";
            textBox1.Text += a;

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            String a = "0";

            textBox1.Text += a;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
           
        }

        private void Enter_Click_1(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);

            if (b >= Form2.final)
            {
                string s = "";
                s += ("_________ GMALL _________\n");
                s += ("--------------------------\n");
                s += ("  ----------------------\n  ");
                s += ("\nTotal__________________" + Form2.final);
                s += ("\nPayment__________________" + b);
                int c = b -= Form2.final;
                s += ("\nChange___________________" + c);
                MessageBox.Show(s);

            }
            else
            {
                MessageBox.Show("Insufficient Payment");
            }
        }
    }
}
