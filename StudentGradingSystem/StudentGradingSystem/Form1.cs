using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Siticone.Desktop.UI.HtmlRenderer.Adapters.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Compiler.CodeGeneratorResponse.Types;
using static Siticone.Desktop.UI.Native.WinApi;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Bcpg;

namespace StudentGradingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string user = tblUsername.Text;
            string pass = tblPassword.Text;

            if (user == "admin" && pass == "admin")
            {
             ChooseInstitute chooseInstitute = new ChooseInstitute();   
                this.Hide();
                chooseInstitute.Show();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {                                                  

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Authentication\n\n1. Login Screen - Enter your username and password in the designated fields.\n2. Submit Button - Click the submit button to send your login credentials for verification.\n3. Authentication Process - The system will verify your username and password against the database.\n- If the credentials are correct, you'll be granted access to your account.\n- If the credentials are incorrect, you'll receive an error message prompting you to re-enter your information.\n4. Remember Me - Optionally, you may select the Remember Me checkbox to store your login credentials for future sessions.\n5. Logout - To log out of your account, click the logout button located in the menu or designated area.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
