using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradingSystem
{
    public partial class BSIS_1styear_2ndsem : Form
    {
        public BSIS_1styear_2ndsem()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void BSIS_1styear_2ndsem_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("STUDENT ID#", 100);
            listView1.Columns.Add("FULLNAME", 120);
            listView1.Columns.Add("SUB 1", 65);
            listView1.Columns.Add("SUB 2", 65);
            listView1.Columns.Add("SUB 3", 65);
            listView1.Columns.Add("SUB 4", 65);
            listView1.Columns.Add("SUB 5", 65);
            listView1.Columns.Add("SUB 6", 65);
            listView1.Columns.Add("SUB 7", 65);
            listView1.Columns.Add("SUB 8", 65);
            listView1.Columns.Add("SUB 9", 65);
            listView1.Columns.Add("PERCENTAGE", 100);
            listView1.Columns.Add("GRADE POINT", 100);
            listView1.Columns.Add("EQUIVALENCE", 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text) || String.IsNullOrEmpty(textBox8.Text) || String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Please Fill The Required Data First", "Message Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string constring = "server=localhost;uid=root;pwd=root;database=sys";
                    string sql = "INSERT INTO sys.`bsit1styear-2ndsem` (`student id#`, `fullname`, `subject 1`, `subject 2`, `subject 3`, `subject 4`, `subject 5`, `subject 6`, `subject 7`, `subject 8`, `subject 9`, `percentage`, `grade point`, `equivalence`) " +
                                 "VALUES (@student_id, @fullname, @subject_1, @subject_2, @subject_3, @subject_4, @subject_5, @subject_6, @subject_7, @subject_8, @subject_9, @percentage, @grade_point, @equivalence)";

                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@student_id", textBox1.Text);
                            cmd.Parameters.AddWithValue("@fullname", textBox2.Text);
                            cmd.Parameters.AddWithValue("@subject_1", textBox3.Text);
                            cmd.Parameters.AddWithValue("@subject_2", textBox4.Text);
                            cmd.Parameters.AddWithValue("@subject_3", textBox5.Text);
                            cmd.Parameters.AddWithValue("@subject_4", textBox6.Text);
                            cmd.Parameters.AddWithValue("@subject_5", textBox7.Text);
                            cmd.Parameters.AddWithValue("@subject_6", textBox8.Text);
                            cmd.Parameters.AddWithValue("@subject_7", textBox9.Text);
                            cmd.Parameters.AddWithValue("@subject_8", textBox10.Text);
                            cmd.Parameters.AddWithValue("@subject_9", textBox11.Text);

                            // Operation
                            double[] grades = new double[9];
                            System.Windows.Forms.TextBox[] textBoxes = { textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

                            for (int i = 0; i < grades.Length; i++)
                            {
                                grades[i] = ParseGrade(textBoxes[i].Text);
                            }


                            // Calculate result only for non-empty grades
                            int count = 0;
                            double total = 0;

                            foreach (double grade in grades)
                            {
                                if (grade != 0)
                                {
                                    total += grade;
                                    count++;
                                }
                            }

                            double result = count > 0 ? total / count : 0;

                            // Calculate Grade Point and Equivalence only if at least one grade is entered
                            string gradePoint = count > 0 ? CalculateGradePoint(result) : "";
                            string equivalence = count > 0 ? CalculateEquivalence(result) : "";

                            cmd.Parameters.AddWithValue("@percentage", result.ToString("0.00") + "%");
                            cmd.Parameters.AddWithValue("@grade_point", gradePoint);
                            cmd.Parameters.AddWithValue("@equivalence", equivalence);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data Successfully Saved");

                                // Display input in ListView 
                                ListViewItem newItem = new ListViewItem(textBox1.Text);
                                newItem.SubItems.Add(textBox2.Text);

                                foreach (double grade in grades)
                                {
                                    newItem.SubItems.Add(grade.ToString("0.00")); // Format to two decimal places
                                }

                                newItem.SubItems.Add(result.ToString("0.00") + "%");
                                newItem.SubItems.Add(gradePoint);
                                newItem.SubItems.Add(equivalence);

                                listView1.Items.Add(newItem);
                            }
                            else
                            {
                                MessageBox.Show("Failed to save data.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }




        // Method to parse grade, returns 0 if empty or invalid
        private double ParseGrade(string grade)
        {
            if (string.IsNullOrWhiteSpace(grade))
            {
                return 0;
            }
            else
            {
                double parsedGrade;
                if (double.TryParse(grade, out parsedGrade))
                {
                    return parsedGrade;
                }
                else
                {
                    MessageBox.Show("Invalid grade format: " + grade);
                    return 0;
                }
            }
        }

        // Method to calculate Grade Point based on result
        private string CalculateGradePoint(double result)
        {
            if (result >= 96 && result <= 100)
            {
                return "1.00-1.25";
            }
            else if (result >= 87 && result <= 95)
            {
                return "1.50-2.00";
            }
            else if (result >= 81 && result <= 86)
            {
                return "2.25-2.50";
            }
            else if (result >= 78 && result <= 80)
            {
                return "2.75";
            }
            else if (result >= 75 && result <= 77)
            {
                return "3.00";
            }
            else
            {
                return "F/INC/IP";
            }
        }

        // Method to calculate Equivalence based on result
        private string CalculateEquivalence(double result)
        {
            if (result >= 96 && result <= 100)
            {
                return "Outstanding";
            }
            else if (result >= 87 && result <= 95)
            {
                return "Very Satisfactory";
            }
            else if (result >= 81 && result <= 86)
            {
                return "Satisfactory";
            }
            else if (result >= 78 && result <= 80)
            {
                return "Low Satisfactory";
            }
            else if (result >= 75 && result <= 77)
            {
                return "Fair or Passing";
            }
            else
            {
                return "F/INC/IP";
            }
        }


        private void LoadDataFromDatabase()
        {
            try
            {
                string constring = "server=localhost;uid=root;pwd=root;database=sys";
                string sql = "SELECT `student id#`, `fullname`, `subject 1`, `subject 2`, `subject 3`, `subject 4`, `subject 5`, `subject 6`, `subject 7`, `subject 8`, `subject 9`, `percentage`, `grade point`, `equivalence` FROM sys.`bsit1styear-2ndsem`";

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem newItem = new ListViewItem(reader["student id#"].ToString());
                                newItem.SubItems.Add(reader["fullname"].ToString());

                                // Add subject grades
                                for (int i = 2; i < 11; i++)
                                {
                                    newItem.SubItems.Add(reader["subject " + (i - 1)].ToString());
                                }

                                // Add percentage, grade point, and equivalence
                                newItem.SubItems.Add(reader["percentage"].ToString());
                                newItem.SubItems.Add(reader["grade point"].ToString());
                                newItem.SubItems.Add(reader["equivalence"].ToString());

                                listView1.Items.Add(newItem);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Retrieve the selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string studentId = selectedItem.SubItems[0].Text;

                // Remove the selected item from the ListView
                listView1.Items.Remove(selectedItem);

                // Delete the corresponding record from the database
                DeleteRecordFromDatabase(studentId);

                MessageBox.Show("Record deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a record to delete!");
            }
        }

        private void DeleteRecordFromDatabase(string studentId)
        {
            try
            {
                string constring = "server=localhost;uid=root;pwd=root;database=sys";
                string sql = "DELETE FROM sys.`bsit1styear-2ndsem` WHERE `student id#` = @studentId";

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Record deleted from the database
                        }
                        else
                        {
                            MessageBox.Show("Record not found in the database!");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Retrieve the selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string studentId = selectedItem.SubItems[0].Text;

                // Update the ListViewItem in the ListView


                // Update the record in the database
                UpdateRecordInDatabase(studentId);

                MessageBox.Show("Record updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a record to update!");
            }
        }

        private void UpdateRecordInDatabase(string studentId)
        {
            try
            {
                string constring = "server=localhost;uid=root;pwd=root;database=sys";
                string sql = "UPDATE sys.`bsit1styear-2ndsem` SET `fullname` = @fullname, `subject 1` = @subject_1, `subject 2` = @subject_2, `subject 3` = @subject_3, `subject 4` = @subject_4, `subject 5` = @subject_5, `subject 6` = @subject_6, `subject 7` = @subject_7, `subject 8` = @subject_8, `subject 9` = @subject_9, `percentage` = @percentage, `grade point` = @grade_point, `equivalence` = @equivalence WHERE `student id#` = @studentId";

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@fullname", textBox2.Text);
                        cmd.Parameters.AddWithValue("@subject_1", textBox3.Text);
                        cmd.Parameters.AddWithValue("@subject_2", textBox4.Text);
                        cmd.Parameters.AddWithValue("@subject_3", textBox5.Text);
                        cmd.Parameters.AddWithValue("@subject_4", textBox6.Text);
                        cmd.Parameters.AddWithValue("@subject_5", textBox7.Text);
                        cmd.Parameters.AddWithValue("@subject_6", textBox8.Text);
                        cmd.Parameters.AddWithValue("@subject_7", textBox9.Text);
                        cmd.Parameters.AddWithValue("@subject_8", textBox10.Text);
                        cmd.Parameters.AddWithValue("@subject_9", textBox11.Text);

                        // Calculate result
                        double[] grades = new double[9];
                        System.Windows.Forms.TextBox[] textBoxes = { textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

                        for (int i = 0; i < grades.Length; i++)
                        {
                            grades[i] = ParseGrade(textBoxes[i].Text);
                        }

                        int count = 0;
                        double total = 0;

                        foreach (double grade in grades)
                        {
                            if (grade != 0)
                            {
                                total += grade;
                                count++;
                            }
                        }

                        double result = count > 0 ? total / count : 0;
                        string gradePoint = count > 0 ? CalculateGradePoint(result) : "";
                        string equivalence = count > 0 ? CalculateEquivalence(result) : "";

                        cmd.Parameters.AddWithValue("@percentage", result.ToString("0.00") + "%");
                        cmd.Parameters.AddWithValue("@grade_point", gradePoint);
                        cmd.Parameters.AddWithValue("@equivalence", equivalence);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Record not found in the database!");
                        }
                        else
                        {
                            // Update the corresponding ListView item with the new data
                            ListViewItem updatedItem = listView1.SelectedItems[0];
                            updatedItem.SubItems[1].Text = textBox2.Text;

                            for (int i = 0; i < 9; i++)
                            {
                                updatedItem.SubItems[i + 2].Text = textBoxes[i].Text;
                            }

                            updatedItem.SubItems[11].Text = result.ToString("0.00") + "%";
                            updatedItem.SubItems[12].Text = gradePoint;
                            updatedItem.SubItems[13].Text = equivalence;

                            MessageBox.Show("Record updated successfully!");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.ToString());
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            // to clear all data
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ICET iCET = new ICET();
            this.Hide();
            iCET.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
                textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
                textBox8.Text = listView1.SelectedItems[0].SubItems[7].Text;
                textBox9.Text = listView1.SelectedItems[0].SubItems[8].Text;
                textBox10.Text = listView1.SelectedItems[0].SubItems[9].Text;
                textBox11.Text = listView1.SelectedItems[0].SubItems[10].Text;
            }
        }
    }
}
