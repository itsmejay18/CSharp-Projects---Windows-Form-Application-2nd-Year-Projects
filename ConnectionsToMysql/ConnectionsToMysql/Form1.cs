using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace ConnectionsToMysql
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public class person 
        {

            public string FirstName { get; set; }
            public string Middlename { get; set; }
            public string lastname { get; set; }
           
        }

        public class User : person 
        {
            public string Email { get; set; }
            public string Role { get; set; }
        }

        public void InsertUser()

        {
            
            User user = new User
            {
                FirstName = textBox1.Text,
                Middlename = textBox2.Text,
                lastname = textBox3.Text,
                Email = textBox4.Text,
                Role = comboBox1.Text
            };

         
            string ConString = "server=localhost;uid=root;pwd=root;database=oop";

           
            string query = "INSERT INTO tbl_user(firstname, middlename, lastname, email, role) " +
                           "VALUES (@Firstname, @Middlename, @Lastname, @Email, @Role)";

            try
            {
                
                using (MySqlConnection con = new MySqlConnection(ConString))
                {
                    con.Open(); 

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@Firstname", user.FirstName);
                        cmd.Parameters.AddWithValue("@Middlename", user.Middlename);
                        cmd.Parameters.AddWithValue("@Lastname", user.lastname);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Role", user.Role);                   
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User saved successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            InsertUser();
                


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
