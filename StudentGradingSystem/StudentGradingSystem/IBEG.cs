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
    public partial class IBEG : Form
    {
        public IBEG()
        {
            InitializeComponent();
            PopulateCombobox();
        }

        private void IBEG_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChooseInstitute chooseInstitute = new ChooseInstitute();
            this.Hide();
            chooseInstitute.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void PopulateCombobox()
        {
            comboBox1.Items.AddRange(new string[] { "BACHELOR OF SCIENCE IN AGRIBUSINESS", "BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION", "BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM" });
            comboBox3.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox2.Items.AddRange(new string[] { "1st", "2nd" });
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBox1.SelectedItem as string;
            string selectedYear = comboBox3.SelectedItem as string;
            string selectedSemester = comboBox2.SelectedItem as string;


            if (selectedCourse != null && selectedSemester != null)
            {

                //BSAB
                if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSAB_1styear_1stsem bSAB_1Styear_1Stsem = new BSAB_1styear_1stsem();
                    this.Hide();
                    bSAB_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSAB_1styear_2ndsem bSAB_1Styear_2Ndsem = new BSAB_1styear_2ndsem();
                    this.Hide();
                    bSAB_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS")  && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSAB_2ndyear_1stsem bSAB_2Ndyear_1Stsem = new BSAB_2ndyear_1stsem();
                    this.Hide();
                    bSAB_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSAB_2ndyear_2ndsem bSAB_2Ndyear_2Ndsem = new BSAB_2ndyear_2ndsem();
                    this.Hide();
                    bSAB_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSAB_3rdyear_1stsem bSAB_3Rdyear_1Stsem = new BSAB_3rdyear_1stsem();
                    this.Hide();
                    bSAB_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSAB_3rdyear_2ndsem bSAB_3Rdyear_2Ndsem = new BSAB_3rdyear_2ndsem();
                    this.Hide();
                    bSAB_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSAB_4thyear_1stsem bSAB_4Thyear_1Stsem = new BSAB_4thyear_1stsem();
                    this.Hide();
                    bSAB_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSAB_4thyear_2ndsem bSAB_4Thyear_2Ndsem = new BSAB_4thyear_2ndsem();
                    this.Hide();
                    bSAB_4Thyear_2Ndsem.Show();

                    // BSPA
                }        
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSPA_1styear_1stsem bSPA_1Styear_1Stsem = new BSPA_1styear_1stsem();
                    this.Hide();
                    bSPA_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSPA_1styear_2ndsem bSPA_1Styear_2Ndsem = new BSPA_1styear_2ndsem();
                    this.Hide();
                    bSPA_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSPA_2ndyear_1stsem bSPA_2Ndyear_1Stsem = new BSPA_2ndyear_1stsem();
                    this.Hide();
                    bSPA_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSPA_2ndyear_2ndsem bSPA_2Ndyear_2Ndsem = new BSPA_2ndyear_2ndsem();
                    this.Hide();
                    bSPA_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSPA_3rdyear_1stsem bSPA_3Rdyear_1Stsem = new BSPA_3rdyear_1stsem();
                    this.Hide();
                    bSPA_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSPA_3rdyear_2ndsem bSPA_3Rdyear_2Ndsem = new BSPA_3rdyear_2ndsem();
                    this.Hide();
                    bSPA_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSPA_4thyear_1stsem bSPA_4Thyear_1Stsem = new BSPA_4thyear_1stsem();
                    this.Hide();
                    bSPA_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSPA_4thyear_2ndsem bSPA_4Thyear_2Ndsem = new BSPA_4thyear_2ndsem();
                    this.Hide();
                    bSPA_4Thyear_2Ndsem.Show();

                    //BSAIS
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSAIS_1styear_1stsem bSAIS_1Styear_1Stsem = new BSAIS_1styear_1stsem();
                    this.Hide();
                    bSAIS_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSAIS_1styear_2ndsem bSAIS_1Styear_2Ndsem = new BSAIS_1styear_2ndsem();
                    this.Hide();
                    bSAIS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSAIS_2ndyear_1stsem bSAIS_2Ndyear_1Stsem = new BSAIS_2ndyear_1stsem();
                    this.Hide();
                    bSAIS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSAIS_2ndyear_2ndsem bSAIS_2Ndyear_2Ndsem = new BSAIS_2ndyear_2ndsem();
                    this.Hide();
                    bSAIS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSAIS_3rdyear_1stsem bSAIS_3Rdyear_1Stsem = new BSAIS_3rdyear_1stsem();
                    this.Hide();
                    bSAIS_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSAIS_3rdyear_2ndsem bSAIS_3Rdyear_2Ndsem = new BSAIS_3rdyear_2ndsem();
                    this.Hide();
                    bSAIS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSAIS_4thyear_1stsem bSAIS_4Thyear_1Stsem = new BSAIS_4thyear_1stsem();
                    this.Hide();
                    bSAIS_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSAIS_4thyear_2ndsem bSAIS_4Thyear_2Ndsem = new BSAIS_4thyear_2ndsem();
                    this.Hide();
                    bSAIS_4Thyear_2Ndsem.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Choice");
                }




            }
            else
            {
                MessageBox.Show("Please select a Program, Year and a semester");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
