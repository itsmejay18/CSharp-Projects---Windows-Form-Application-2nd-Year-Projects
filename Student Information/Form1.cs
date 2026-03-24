using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // Allow browsing for common image formats
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.gif) | *.jpg; *.jpeg; *.png; *.bmp; *.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                    pictureBox1.Tag = open.FileName; // Store the file path for later use
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve input data
            string studentName = textBox1.Text;
            string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : null;
            string address = comboBox1.Text;

            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill out all fields and select a gender.");
                return;
            }

            if (pictureBox1.Image == null || pictureBox1.Tag == null)
            {
                MessageBox.Show("Please upload an image.");
                return;
            }

            byte[] pictureData;
            try
            {
                // Convert the image file to a byte array
                pictureData = File.ReadAllBytes(pictureBox1.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading image file: " + ex.Message);
                return;
            }

            try
            {
                // MySQL connection string
                string connectionString = "Server=localhost;Database=student_informations;Uid=root;Pwd=root;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to insert data
                    string query = "INSERT INTO infos (picture_name, picture_data, student_name, birthday, sex, address) " +
                                   "VALUES (@pictureName, @pictureData, @studentName, @birthday, @gender, @address)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Bind parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@pictureName", Path.GetFileName(pictureBox1.Tag.ToString()));
                        command.Parameters.AddWithValue("@pictureData", pictureData);
                        command.Parameters.AddWithValue("@studentName", studentName);
                        command.Parameters.AddWithValue("@birthday", birthday);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Add functionality if needed
        }
    }
}
