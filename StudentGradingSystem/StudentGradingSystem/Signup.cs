using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;

namespace StudentGradingSystem
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null && textBox5.Text == null && textBox6.Text == null)
            {
                MessageBox.Show("You need to Put all of this Information to Proceed");
            } 
            else if (textBox5.Text!=textBox6.Text)
            {
                MessageBox.Show("Password Doesn't Match");
            }
            else
            {
                MessageBox.Show("Welcome Mr/Ms." + textBox1.Text + " " + textBox3.Text);
                ChooseInstitute chooseInstitute = new ChooseInstitute();
                this.Hide();
                chooseInstitute.Show();

            }
                
            
                   
                
            }
        }


       

       
    
}
