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
    public partial class IARS : Form
    {
        public IARS()
        {
            InitializeComponent();
            PopulateCombobox();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBox1.SelectedItem as string;
            string selectedYear = comboBox3.SelectedItem as string;
            string selectedSemester = comboBox2.SelectedItem as string;

            if (selectedCourse != null && selectedSemester != null)
            {

                //BSDC
                if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSDC_1styear_1stsem bSDC_1Styear_1Stsem = new BSDC_1styear_1stsem();
                    this.Hide();
                    bSDC_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSDC_1styear_2ndsem bSDC_1Styear_2Ndsem = new BSDC_1styear_2ndsem();
                    this.Hide();
                    bSDC_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSDC_2ndyear_1stsem bSDC_2Ndyear_1Stsem = new BSDC_2ndyear_1stsem();
                    this.Hide();
                    bSDC_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSDC_2ndyear_2ndsem bSDC_2Ndyear_2Ndsem = new BSDC_2ndyear_2ndsem();
                    this.Hide();
                    bSDC_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSDC_3rdyear_1stsem bSDC_3Rdyear_1Stsem = new BSDC_3rdyear_1stsem();
                    this.Hide();
                    bSDC_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSDC_3rdyear_2ndsem bSDC_3Rdyear_2Ndsem = new BSDC_3rdyear_2ndsem();
                    this.Hide();
                    bSDC_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSDC_4thyear_1stsem bSDC_4Thyear_1Stsem = new BSDC_4thyear_1stsem();
                    this.Hide();
                    bSDC_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSDC_4thyear_2ndsem bSDC_4Thyear_2Ndsem = new BSDC_4thyear_2ndsem();
                    this.Hide();
                    bSDC_4Thyear_2Ndsem.Show();


                } // BSA
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSA_1styear_1stsem bSA_1Styear_1Stsem = new BSA_1styear_1stsem();
                    this.Hide();
                    bSA_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSA_1styear_2ndsem bSA_1Styear_2Ndsem = new BSA_1styear_2ndsem();
                    this.Hide();
                    bSA_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSA_2ndyear_1stsem bSA_2Ndyear_1Stsem = new BSA_2ndyear_1stsem();
                    this.Hide();
                    bSA_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSA_2ndyear_2ndsem bSA_2Ndyear_2Ndsem = new BSA_2ndyear_2ndsem();
                    this.Hide();
                    bSA_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSA_3rdyear_1stsem bSA_3Rdyear_1Stsem = new BSA_3rdyear_1stsem();
                    this.Hide();
                    bSA_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSA_3rdyear_2ndsem bSA_3Rdyear_2Ndsem = new BSA_3rdyear_2ndsem();
                    this.Hide();
                    bSA_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSA_4thyear_1stsem bSA_4Thyear_1Stsem = new BSA_4thyear_1stsem();
                    this.Hide();
                    bSA_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGROFORESTRY") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSA_4thyear_2ndsem bSA_4Thyear_2Ndsem = new BSA_4thyear_2ndsem();
                    this.Hide();
                    bSA_4Thyear_2Ndsem.Show();


                } //CAS
                else if (selectedCourse.Equals("CERTIFICATE IN AGRICULTURAL SCIENCE (2YEARS)") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    CAS_1styear_1stsem cAS_1Styear_1Stsem = new CAS_1styear_1stsem();
                    this.Hide();
                    cAS_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("CERTIFICATE IN AGRICULTURAL SCIENCE (2YEARS)") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    CAS_1styear_2ndsem cAS_1Styear_2Ndsem = new CAS_1styear_2ndsem();
                    this.Hide();
                    cAS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("CERTIFICATE IN AGRICULTURAL SCIENCE (2YEARS)") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    CAS_2ndyear_1stsem cAS_2Ndyear_1Stsem = new CAS_2ndyear_1stsem();
                    this.Hide();
                    cAS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("CERTIFICATE IN AGRICULTURAL SCIENCE (2YEARS)") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    CAS_2ndyear_2ndsem cAS_2Ndyear_2Ndsem = new CAS_2ndyear_2ndsem();
                    this.Hide();
                    cAS_2Ndyear_2Ndsem.Show();



                } //BSAMASCPH
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSAMASCPH_1styear_1stsem bSAMASCPH_1Styear_1Stsem = new BSAMASCPH_1styear_1stsem();
                    this.Hide();
                    bSAMASCPH_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSAMASCPH_1styear_2ndsem bSAMASCPH_1Styear_2Ndsem = new BSAMASCPH_1styear_2ndsem();
                    this.Hide();
                    bSAMASCPH_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSAMASCPH_2ndyear_1stsem bSAMASCPH_2Ndyear_1Stsem = new BSAMASCPH_2ndyear_1stsem();
                    this.Hide();
                    bSAMASCPH_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSAMASCPH_2ndyear_2ndsem bSAMASCPH_2Ndyear_2Ndsem = new BSAMASCPH_2ndyear_2ndsem();
                    this.Hide();
                    bSAMASCPH_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSAMASCPH_3rdyear_1stsem bSAMASCPH_3Rdyear_1Stsem = new BSAMASCPH_3rdyear_1stsem();
                    this.Hide();
                    bSAMASCPH_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSAMASCPH_3rdyear_2ndsem bSAMASCPH_3Rdyear_2Ndsem = new BSAMASCPH_3rdyear_2ndsem();
                    this.Hide();
                    bSAMASCPH_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSAMASCPH_4thyear_1stsem bSAMASCPH_4Thyear_1Stsem = new BSAMASCPH_4thyear_1stsem();
                    this.Hide();
                    bSAMASCPH_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSAMASCPH_4thyear_2ndsem bSAMASCPH_4Thyear_2Ndsem = new BSAMASCPH_4thyear_2ndsem();
                    this.Hide();
                    bSAMASCPH_4Thyear_2Ndsem.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Choice");
                }



            }
            else
            {
                MessageBox.Show("Please Select a Program, Year and a semester");
            }
        }

        private void IARS_Load(object sender, EventArgs e)
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
        private void PopulateCombobox()
        {
            comboBox1.Items.AddRange(new string[] { "BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION", "BACHELOR OF SCIENCE IN AGROFORESTRY", "CERTIFICATE IN AGRICULTURAL SCIENCE (2YEARS)", "BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE" });
            comboBox3.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox2.Items.AddRange(new string[] { "1st", "2nd" });
        }
    }
}
