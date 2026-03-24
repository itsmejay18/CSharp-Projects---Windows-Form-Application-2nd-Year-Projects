using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pornhub.Site
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            register register = new register();
            this.Hide();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;

            if (user=="admin" && pass=="admin")
            {
                VerifyYourAge verifyYourAge = new VerifyYourAge();
                this.Hide();
                verifyYourAge.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }
    }
}
