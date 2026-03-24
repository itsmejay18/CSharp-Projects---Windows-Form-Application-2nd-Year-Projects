using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pornhub.Site
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox3.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Fill The Required Data First","Message Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            { 
                try
                {
                    
                    string constring = "server=localhost;uid=root;pwd=root;database=kian_schema";
                    string sql = "INSERT INTO kian_schema.accounts (Username, Email, Password)" +
                        " VALUES ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "')";


                    MySqlConnection con = new MySqlConnection(constring);
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader myReader;

                    con.Open();
                    myReader = cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Sign Up Successfully");

                    


                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();



                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

           
        }
         

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
