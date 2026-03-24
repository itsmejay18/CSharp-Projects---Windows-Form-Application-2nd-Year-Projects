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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PopulateCombobox();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PopulateCombobox()
        {
            comboBox1.Items.AddRange(new string[] { "BACHELOR OF SCIENCE IN AGRIBUSINESS", "BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION", "BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM" });
            comboBox3.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox2.Items.AddRange(new string[] { "1st", "2nd" });
            comboBox6.Items.AddRange(new string[] { "BACHELOR IN ELEMENTARY EDUCATION", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES", "BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE" });
            comboBox4.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox5.Items.AddRange(new string[] { "1st", "2nd" });
            comboBox9.Items.AddRange(new string[] { "BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING", "BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY", "BACHELOR OF SCIENCE IN INFORMATION SYSTEM", "DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)", "ASSOCIATE IN COMPUTING TECHNOLOGY (2YEARS)" });
            comboBox7.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox8.Items.AddRange(new string[] { "1st", "2nd" });
            comboBox12.Items.AddRange(new string[] { "BACHELOR OF SCIENCE IN DEVELOPMENT COMMUNICATION", "BACHELOR OF SCIENCE IN AGROFORESTRY", "CERTIFICATE IN AGRICULTURAL SCIENCE (2YEARS)", "BACHELOR OF SCIENCE IN AGRICULTURE MAJOR IN ANIMAL SCIENCE, CROP PROTECTION, HORTICULTURE" });
            comboBox10.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox11.Items.AddRange(new string[] { "1st", "2nd" });
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string selectedCourseIBEG = comboBox1.SelectedItem as string;
            string selectedYearIBEG = comboBox3.SelectedItem as string;
            string selectedSemesterIBEG = comboBox2.SelectedItem as string;

            


            if (selectedCourseIBEG != null && selectedSemesterIBEG != null)
            {

                //BSAB
                if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("1st") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAB_1styear_1stsem bSAB_1Styear_1Stsem = new BSAB_1styear_1stsem();
                    this.Hide();
                    bSAB_1Styear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("1st") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAB_1styear_2ndsem yes = new BSAB_1styear_2ndsem();
                    this.Hide();
                    yes.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("2nd") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAB_2ndyear_1stsem bSAB_2Ndyear_1Stsem = new BSAB_2ndyear_1stsem();
                    this.Hide();
                    bSAB_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("2nd") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAB_2ndyear_2ndsem bSAB_2Ndyear_2Ndsem = new BSAB_2ndyear_2ndsem();
                    this.Hide();
                    bSAB_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("3rd") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAB_3rdyear_1stsem bSAB_3Rdyear_1Stsem = new BSAB_3rdyear_1stsem();
                    this.Hide();
                    bSAB_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("3rd") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAB_3rdyear_2ndsem bSAB_3Rdyear_2Ndsem = new BSAB_3rdyear_2ndsem();
                    this.Hide();
                    bSAB_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("4th") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAB_4thyear_1stsem bSAB_4Thyear_1Stsem = new BSAB_4thyear_1stsem();
                    this.Hide();
                    bSAB_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN AGRIBUSINESS") && selectedYearIBEG.Equals("4th") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAB_4thyear_2ndsem bSAB_4Thyear_2Ndsem = new BSAB_4thyear_2ndsem();
                    this.Hide();
                    bSAB_4Thyear_2Ndsem.Show();

                    // BSPA
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("1st") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSPA_1styear_1stsem bSPA_1Styear_1Stsem = new BSPA_1styear_1stsem();
                    this.Hide();
                    bSPA_1Styear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("1st") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSPA_1styear_2ndsem bSPA_1Styear_2Ndsem = new BSPA_1styear_2ndsem();
                    this.Hide();
                    bSPA_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("2nd") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSPA_2ndyear_1stsem bSPA_2Ndyear_1Stsem = new BSPA_2ndyear_1stsem();
                    this.Hide();
                    bSPA_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("2nd") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSPA_2ndyear_2ndsem bSPA_2Ndyear_2Ndsem = new BSPA_2ndyear_2ndsem();
                    this.Hide();
                    bSPA_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("3rd") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSPA_3rdyear_1stsem bSPA_3Rdyear_1Stsem = new BSPA_3rdyear_1stsem();
                    this.Hide();
                    bSPA_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("3rd") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSPA_3rdyear_2ndsem bSPA_3Rdyear_2Ndsem = new BSPA_3rdyear_2ndsem();
                    this.Hide();
                    bSPA_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("4th") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSPA_4thyear_1stsem bSPA_4Thyear_1Stsem = new BSPA_4thyear_1stsem();
                    this.Hide();
                    bSPA_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN PUBLIC ADMINISTRATION") && selectedYearIBEG.Equals("4th") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSPA_4thyear_2ndsem bSPA_4Thyear_2Ndsem = new BSPA_4thyear_2ndsem();
                    this.Hide();
                    bSPA_4Thyear_2Ndsem.Show();

                    //BSAIS
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("1st") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAIS_1styear_1stsem bSAIS_1Styear_1Stsem = new BSAIS_1styear_1stsem();
                    this.Hide();
                    bSAIS_1Styear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("1st") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAIS_1styear_2ndsem bSAIS_1Styear_2Ndsem = new BSAIS_1styear_2ndsem();
                    this.Hide();
                    bSAIS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("2nd") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAIS_2ndyear_1stsem bSAIS_2Ndyear_1Stsem = new BSAIS_2ndyear_1stsem();
                    this.Hide();
                    bSAIS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("2nd") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAIS_2ndyear_2ndsem bSAIS_2Ndyear_2Ndsem = new BSAIS_2ndyear_2ndsem();
                    this.Hide();
                    bSAIS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("3rd") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAIS_3rdyear_1stsem bSAIS_3Rdyear_1Stsem = new BSAIS_3rdyear_1stsem();
                    this.Hide();
                    bSAIS_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("3rd") && selectedSemesterIBEG.Equals("2nd"))
                {
                    BSAIS_3rdyear_2ndsem bSAIS_3Rdyear_2Ndsem = new BSAIS_3rdyear_2ndsem();
                    this.Hide();
                    bSAIS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("4th") && selectedSemesterIBEG.Equals("1st"))
                {
                    BSAIS_4thyear_1stsem bSAIS_4Thyear_1Stsem = new BSAIS_4thyear_1stsem();
                    this.Hide();
                    bSAIS_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseIBEG.Equals("BACHELOR OF SCIENCE IN ACCOUNTING INFORMATION SYSTEM") && selectedYearIBEG.Equals("4th") && selectedSemesterIBEG.Equals("2nd"))
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

        private void button9_Click(object sender, EventArgs e)
        {
            string selectedCourseITED = comboBox6.SelectedItem as string;
            string selectedYearITED = comboBox4.SelectedItem as string;
            string selectedSemesterITED = comboBox5.SelectedItem as string;

            if (selectedCourseITED != null && selectedSemesterITED != null)
            {

                //BSEE
                if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEE_1styear_1stsem bSEE_1Styear_1Stsem = new BSEE_1styear_1stsem();
                    this.Hide();
                    bSEE_1Styear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEE_1styear_2ndsem bSEE_1Styear_2Ndsem = new BSEE_1styear_2ndsem();
                    this.Hide();
                    bSEE_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEE_2ndyear_1sem bSEE_2Ndyear_1Sem = new BSEE_2ndyear_1sem();
                    this.Hide();
                    bSEE_2Ndyear_1Sem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEE_2ndyear_2ndsem bSEE_2Ndyear_2Ndsem = new BSEE_2ndyear_2ndsem();
                    this.Hide();
                    bSEE_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEE_3rdyear_1stsem bSEE_3Rdyear_1Stsem = new BSEE_3rdyear_1stsem();
                    this.Hide();
                    bSEE_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEE_3rdyear_2ndsem bSEE_3Rdyear_2Ndsem = new BSEE_3rdyear_2ndsem();
                    this.Hide();
                    bSEE_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEE_4thyear_1stsem bSEE_4Thyear_1Stsem = new BSEE_4thyear_1stsem();
                    this.Hide();
                    bSEE_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEE_4thyear_2ndsem bSEE_4Thyear_2Ndsem = new BSEE_4thyear_2ndsem();
                    this.Hide();
                    bSEE_4Thyear_2Ndsem.Show();


                } // BSEMSS
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMSS_1styear_1stsem bSEMSS_1Styear_1Stsem = new BSEMSS_1styear_1stsem();
                    this.Hide();
                    bSEMSS_1Styear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMSS_1styear_2ndsem bSEMSS_1Styear_2Ndsem = new BSEMSS_1styear_2ndsem();
                    this.Hide();
                    bSEMSS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMSS_2ndyear_1stsem bSEMSS_2Ndyear_1Stsem = new BSEMSS_2ndyear_1stsem();
                    this.Hide();
                    bSEMSS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMSS_2ndyear_2ndsem bSEMSS_2Ndyear_2Ndsem = new BSEMSS_2ndyear_2ndsem();
                    this.Hide();
                    bSEMSS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMSS_3rdyear_1styear bSEMSS_3Rdyear_1Styear = new BSEMSS_3rdyear_1styear();
                    this.Hide();
                    bSEMSS_3Rdyear_1Styear.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMSS_3rdyear_2ndsem bSEMSS_3Rdyear_2Ndsem = new BSEMSS_3rdyear_2ndsem();
                    this.Hide();
                    bSEMSS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMSS_4thyear_1stsem bSEMSS_4Thyear_1Stsem = new BSEMSS_4thyear_1stsem();
                    this.Hide();
                    bSEMSS_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMSS_4thyear_2ndsem bSEMSS_4Thyear_2Ndsem = new BSEMSS_4thyear_2ndsem();
                    this.Hide();
                    bSEMSS_4Thyear_2Ndsem.Show();


                } //BSEMHE
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMHE_1styear_1stsem bSEMHE_1Styear_1Stsem = new BSEMHE_1styear_1stsem();
                    this.Hide();
                    bSEMHE_1Styear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMHE_1styear_2ndsem bSEMHE_1Styear_2Ndsem = new BSEMHE_1styear_2ndsem();
                    this.Hide();
                    bSEMHE_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMHE_2ndyear_1stsem bSEMHE_2Ndyear_1Stsem = new BSEMHE_2ndyear_1stsem();
                    this.Hide();
                    bSEMHE_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMHE_2ndyear_2ndsem bSEMHE_2Ndyear_2Ndsem = new BSEMHE_2ndyear_2ndsem();
                    this.Hide();
                    bSEMHE_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMHE_3rdyear_1stsem bSEMHE_3Rdyear_1Stsem = new BSEMHE_3rdyear_1stsem();
                    this.Hide();
                    bSEMHE_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMHE_3rdyear_2ndsem bSEMHE_3Rdyear_2Ndsem = new BSEMHE_3rdyear_2ndsem();
                    this.Hide();
                    bSEMHE_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMHE_4thyear_1stsem bSEMHE_4Thyear_1Stsem = new BSEMHE_4thyear_1stsem();
                    this.Hide();
                    bSEMHE_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMHE_4htyear_2ndsem bSEMHE_4Htyear_2Ndsem = new BSEMHE_4htyear_2ndsem();
                    this.Hide();
                    bSEMHE_4Htyear_2Ndsem.Show();


                } //BSEMF
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMF_1year_1stsem bSEMF_1Year_1Stsem = new BSEMF_1year_1stsem();
                    this.Hide();
                    bSEMF_1Year_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMF_1styear_2ndsem bSEMF_1Styear_2Ndsem = new BSEMF_1styear_2ndsem();
                    this.Hide();
                    bSEMF_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMF_2ndyear_1stsem bSEMF_2Ndyear_1Stsem = new BSEMF_2ndyear_1stsem();
                    this.Hide();
                    bSEMF_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMF_2ndyear_2ndsem bSEMF_2Ndyear_2Ndsem = new BSEMF_2ndyear_2ndsem();
                    this.Hide();
                    bSEMF_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMF_3rdyear_1styear bSEMF_3Rdyear_1Styear = new BSEMF_3rdyear_1styear();
                    this.Hide();
                    bSEMF_3Rdyear_1Styear.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMF_3rdyear_2ndsem bSEMF_3Rdyear_2Ndsem = new BSEMF_3rdyear_2ndsem();
                    this.Hide();
                    bSEMF_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMF_4thyear_1stsem bSEMF_4Thyear_1Stsem = new BSEMF_4thyear_1stsem();
                    this.Hide();
                    bSEMF_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMF_4thyear_2ndsem bSEMF_4Thyear_2Ndsem = new BSEMF_4thyear_2ndsem();
                    this.Hide();
                    bSEMF_4Thyear_2Ndsem.Show();



                } //BSEME
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEME_1styear_1stsem bSEME_1Styear_1Stsem = new BSEME_1styear_1stsem();
                    this.Hide();
                    bSEME_1Styear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEME_1styear_2ndsem bSEME_1Styear_2Ndsem = new BSEME_1styear_2ndsem();
                    this.Hide();
                    bSEME_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEME_2ndyear_1stsem bSEME_2Ndyear_1Stsem = new BSEME_2ndyear_1stsem();
                    this.Hide();
                    bSEME_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEME_2ndyear_2ndsem bSEME_2Ndyear_2Ndsem = new BSEME_2ndyear_2ndsem();
                    this.Hide();
                    bSEME_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEME_3rdyear_1stsem bSEME_3Rdyear_1Stsem = new BSEME_3rdyear_1stsem();
                    this.Hide();
                    bSEME_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEME_3rdyear_2ndsem bSEME_3Rdyear_2Ndsem = new BSEME_3rdyear_2ndsem();
                    this.Hide();
                    bSEME_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEME_4thyear_1stsem bSEME_4Thyear_1Stsem = new BSEME_4thyear_1stsem();
                    this.Hide();
                    bSEME_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEME_4thyear_2ndsem bSEME_4Thyear_2Ndsem = new BSEME_4thyear_2ndsem();
                    this.Hide();
                    bSEME_4Thyear_2Ndsem.Show();



                } //BSEMM
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMM_1styear_1stsem bSEMM_1Styear_1Stsem = new BSEMM_1styear_1stsem();
                    this.Hide();
                    bSEMM_1Styear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMM_1styear_2ndsem bSEMM_1Styear_2Ndsem = new BSEMM_1styear_2ndsem();
                    this.Hide();
                    bSEMM_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMM_2ndyear_1stsem bSEMM_2Ndyear_1Stsem = new BSEMM_2ndyear_1stsem();
                    this.Hide();
                    bSEMM_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMM_2ndyear_2ndsem bSEMM_2Ndyear_2Ndsem = new BSEMM_2ndyear_2ndsem();
                    this.Hide();
                    bSEMM_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMM_3rdyear_1stsem bSEMM_3Rdyear_1Stsem = new BSEMM_3rdyear_1stsem();
                    this.Hide();
                    bSEMM_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMM_3rdyear_2ndsem bSEMM_3Rdyear_2Ndsem = new BSEMM_3rdyear_2ndsem();
                    this.Hide();
                    bSEMM_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMM_4thyear_1stsem bSEMM_4Thyear_1Stsem = new BSEMM_4thyear_1stsem();
                    this.Hide();
                    bSEMM_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMM_4thyear_2ndsem bSEMM_4Thyear_2Ndsem = new BSEMM_4thyear_2ndsem();
                    this.Hide();
                    bSEMM_4Thyear_2Ndsem.Show();



                } //BSEMS
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMS_1styear_1stsem bSEMS_1Styear_1Stsem = new BSEMS_1styear_1stsem();
                    this.Hide();
                    bSEMS_1Styear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("1st") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMS_1styear_2ndsem bSEMS_1Styear_2Ndsem = new BSEMS_1styear_2ndsem();
                    this.Hide();
                    bSEMS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMS_2ndyear_1stsem bSEMS_2Ndyear_1Stsem = new BSEMS_2ndyear_1stsem();
                    this.Hide();
                    bSEMS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("2nd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMS_2ndyear_2ndsem bSEMS_2Ndyear_2Ndsem = new BSEMS_2ndyear_2ndsem();
                    this.Hide();
                    bSEMS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMS_3rdyear_1stsem bSEMS_3Rdyear_1Stsem = new BSEMS_3rdyear_1stsem();
                    this.Hide();
                    bSEMS_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("3rd") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMS_3rdyear_2ndsem bSEMS_3Rdyear_2Ndsem = new BSEMS_3rdyear_2ndsem();
                    this.Hide();
                    bSEMS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("1st"))
                {
                    BSEMS_4thyear_1stsem bSEMS_4Thyear_1Stsem = new BSEMS_4thyear_1stsem();
                    this.Hide();
                    bSEMS_4Thyear_1Stsem.Show();
                }
                else if (selectedCourseITED.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYearITED.Equals("4th") && selectedSemesterITED.Equals("2nd"))
                {
                    BSEMS_4thyear_2ndsem bSEMS_4Thyear_2Ndsem = new BSEMS_4thyear_2ndsem();
                    this.Hide();
                    bSEMS_4Thyear_2Ndsem.Show();
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBox9.SelectedItem as string;
            string selectedYear = comboBox7.SelectedItem as string;
            string selectedSemester = comboBox8.SelectedItem as string;

            if (selectedCourse != null && selectedSemester != null)
            {

                //BSABE
                if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSABE_1st_Listview bSABE_1St_Listview = new BSABE_1st_Listview();
                    this.Hide();
                    bSABE_1St_Listview.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSABE_1styear_2ndsem bSABE_1Styear_2Ndsem = new BSABE_1styear_2ndsem();
                    this.Hide();
                    bSABE_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSABE_2nd_Listview bSABE_2Nd_Listview = new BSABE_2nd_Listview();
                    this.Hide();
                    bSABE_2Nd_Listview.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSABE_2ndyear_2ndsem bSABE_2Ndyear_2Ndsem = new BSABE_2ndyear_2ndsem();
                    this.Hide();
                    bSABE_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSABE_3rd_Listview bSABE_3Rd_Listview = new BSABE_3rd_Listview();
                    this.Hide();
                    bSABE_3Rd_Listview.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSABE_3rdyear_2ndsem bSABE_3Rdyear_2Ndsem = new BSABE_3rdyear_2ndsem();
                    this.Hide();
                    bSABE_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSABE_4th_Listview bSABE_4Th_Listview = new BSABE_4th_Listview();
                    this.Hide();
                    bSABE_4Th_Listview.Show();
                }
                else if (selectedCourse.Equals("BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSABE_4th_2ndsem bSABE_4Th_2Ndsem = new BSABE_4th_2ndsem();
                    this.Hide();
                    bSABE_4Th_2Ndsem.Show();


                } // BSIT
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSIT_1st_Listview bSIT_1St_Listview = new BSIT_1st_Listview();
                    this.Hide();
                    bSIT_1St_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSIT_1styear_2ndsem bSIT_1Styear_2Ndsem = new BSIT_1styear_2ndsem();
                    this.Hide();
                    bSIT_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSIT_2nd_LIstview bSIT_2Nd_LIstview = new BSIT_2nd_LIstview();
                    this.Hide();
                    bSIT_2Nd_LIstview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSIT_2ndyear_2ndsem bSIT_2Ndyear_2Ndsem = new BSIT_2ndyear_2ndsem();
                    this.Hide();
                    bSIT_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSIT_3rd_Listview bSIT_3Rd_Listview = new BSIT_3rd_Listview();
                    this.Hide();
                    bSIT_3Rd_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSIT_3rdyear_2ndsem bSIT_3Rdyear_2Ndsem = new BSIT_3rdyear_2ndsem();
                    this.Hide();
                    bSIT_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSIT_4th_Listview bSIT_4Th_Listview = new BSIT_4th_Listview();
                    this.Hide();
                    bSIT_4Th_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSIT_4thyear_2ndsem bSIT_4Thyear_2Ndsem = new BSIT_4thyear_2ndsem();
                    this.Hide();
                    bSIT_4Thyear_2Ndsem.Show();


                } //BSIS
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSIS_1st_Listview bSIS_1St_Listview = new BSIS_1st_Listview();
                    this.Hide();
                    bSIS_1St_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSIS_1styear_2ndsem bSIS_1Styear_2Ndsem = new BSIS_1styear_2ndsem();
                    this.Hide();
                    bSIS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSIS_2nd_Listview bSIS_2Nd_Listview = new BSIS_2nd_Listview();
                    this.Hide();
                    bSIS_2Nd_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSIS_2ndyear_2ndsem bSIS_2Ndyear_2Ndsem = new BSIS_2ndyear_2ndsem();
                    this.Hide();
                    bSIS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSIS_3rd_Listview bSIS_3Rd_Listview = new BSIS_3rd_Listview();
                    this.Hide();
                    bSIS_3Rd_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSIS_3rdyear_2ndsem bSIS_3Rdyear_2Ndsem = new BSIS_3rdyear_2ndsem();
                    this.Hide();
                    bSIS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSIS_4th_Listview bSIS_4Th_Listview = new BSIS_4th_Listview();
                    this.Hide();
                    bSIS_4Th_Listview.Show();
                }
                else if (selectedCourse.Equals("BACHELOR OF SCIENCE IN INFORMATION SYSTEM") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSIS_4thyear_2ndsem bSIS_4Thyear_2Ndsem = new BSIS_4thyear_2ndsem();
                    this.Hide();
                    bSIS_4Thyear_2Ndsem.Show();


                } //DIT
                else if (selectedCourse.Equals("DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    DIT_1st_Listview dIT_1St_Listview = new DIT_1st_Listview();
                    this.Hide();
                    dIT_1St_Listview.Show();
                }
                else if (selectedCourse.Equals("DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    DIT_1styear_2ndsem dIT_1Styear_2Ndsem = new DIT_1styear_2ndsem();
                    this.Hide();
                    dIT_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    DIT_2nd_Listview dIT_2Nd_Listview = new DIT_2nd_Listview();
                    this.Hide();
                    dIT_2Nd_Listview.Show();
                }
                else if (selectedCourse.Equals("DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    DIT_2ndyear_2ndsem dIT_2Ndyear_2Ndsem = new DIT_2ndyear_2ndsem();
                    this.Hide();
                    dIT_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    DIT_3rd_Listview dIT_3Rd_Listview = new DIT_3rd_Listview();
                    this.Hide();
                    dIT_3Rd_Listview.Show();
                }
                else if (selectedCourse.Equals("DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    DIT_3rdyear_2ndsem dIT_3Rdyear_2Ndsem = new DIT_3rdyear_2ndsem();
                    this.Hide();
                    dIT_3Rdyear_2Ndsem.Show();


                } //ACT
                else if (selectedCourse.Equals("ASSOCIATE IN COMPUTING TECHNOLOGY (2YEARS)") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    ACT_1styear_1stsem aCT_1Styear_1Stsem = new ACT_1styear_1stsem();
                    this.Hide();
                    aCT_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("ASSOCIATE IN COMPUTING TECHNOLOGY (2YEARS)") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    ACT_1styear_2ndsem aCT_1Styear_2Ndsem = new ACT_1styear_2ndsem();
                    this.Hide();
                    aCT_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("ASSOCIATE IN COMPUTING TECHNOLOGY (2YEARS)") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    ACT_2ndyear_Listview aCT_2Ndyear_Listview = new ACT_2ndyear_Listview();
                    this.Hide();
                    aCT_2Ndyear_Listview.Show();
                }
                else if (selectedCourse.Equals("ASSOCIATE IN COMPUTING TECHNOLOGY (2YEARS)") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    ACT_2ndyear_2ndsem aCT_2Ndyear_2Ndsem = new ACT_2ndyear_2ndsem();
                    this.Hide();
                    aCT_2Ndyear_2Ndsem.Show();
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBox12.SelectedItem as string;
            string selectedYear = comboBox10.SelectedItem as string;
            string selectedSemester = comboBox11.SelectedItem as string;

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select operation \r\n\r\nTo begin, please select the program, year, and semester for which you intend to input grades. Keep in mind that the subjects available may vary depending on the program you're enrolled in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select operation \r\n\r\nTo begin, please select the program, year, and semester for which you intend to input grades. Keep in mind that the subjects available may vary depending on the program you're enrolled in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select operation \r\n\r\nTo begin, please select the program, year, and semester for which you intend to input grades. Keep in mind that the subjects available may vary depending on the program you're enrolled in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select operation \r\n\r\nTo begin, please select the program, year, and semester for which you intend to input grades. Keep in mind that the subjects available may vary depending on the program you're enrolled in.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
   
    
   