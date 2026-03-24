using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Login_Reg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // This Pattern is use to verify the email
            //pattern
            bool flag =false;
            string email = regEmail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool isValidEmail = regex.IsMatch(email);
            if (email == "")
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Email is empty";
                flag = true;
                
                return;

            }
            if (regMainPass.Text == "")
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "password is empty";
                flag = true;
                return;

            }
            if (regSubPassword.Text == "")
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Password is empty";
                flag = true;
                
                return;

            }
            if (regPhone.Text == "")
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Phone is empty";
                flag = true;
               
                return;

            }
            if (regName.Text == "")
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Name is empty";
                flag = true;
                
                return;


            }
            if (isValidEmail==false)
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Please Enter a Valid Email";
                flag = true;
                regEmail.Clear();
                return;

            }
            
            if (!(regMainPass.Text.Equals(regSubPassword.Text)))
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Password is not Match";
                flag=true;
                regMainPass.Clear();
                regSubPassword.Clear();
                return;


            }
            if (!flag)
            {
                MessageBox.Show("done ^^");
                regEmail.Clear();
                regMainPass.Clear();
                regSubPassword.Clear();
                regPhone.Clear();
                regName.Clear();
                return;

            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
