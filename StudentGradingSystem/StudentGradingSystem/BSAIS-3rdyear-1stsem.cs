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
    public partial class BSAIS_3rdyear_1stsem : Form
    {
        public BSAIS_3rdyear_1stsem()
        {
            InitializeComponent();
        }

        private void BSAIS_3rdyear_1stsem_Load(object sender, EventArgs e)
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
            // Save button clicked

            if (textBox1.Text == "")
            {
                MessageBox.Show("Student ID# is Required");
            }
            else
            {
                // Operation
                double[] grades = new double[9];
                TextBox[] textBoxes = { textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

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







        private void button2_Click(object sender, EventArgs e)
        {
            // delete button 
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
                MessageBox.Show("Remove Successfully!");
            }
            else
            {
                MessageBox.Show("Error!!!!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Update button clicked

            if (listView1.SelectedItems.Count > 0)
            {
                // Retrieve selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Update Student ID and Full Name
                selectedItem.SubItems[0].Text = textBox1.Text;
                selectedItem.SubItems[1].Text = textBox2.Text;

                // Operation
                double[] grades = new double[9];
                TextBox[] textBoxes = { textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

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

                // Update grade subitems in the selected ListViewItem
                for (int i = 0; i < grades.Length; i++)
                {
                    selectedItem.SubItems[i + 2].Text = grades[i].ToString("0.00"); // Format to two decimal places
                }

                // Update percentage, grade point, and equivalence
                selectedItem.SubItems[11].Text = result.ToString("0.00") + "%";
                selectedItem.SubItems[12].Text = gradePoint;
                selectedItem.SubItems[13].Text = equivalence;
            }
            else
            {
                MessageBox.Show("Error: No item selected for update");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
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
            IBEG iBEG = new IBEG();
            this.Hide();
            iBEG.Show();
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
