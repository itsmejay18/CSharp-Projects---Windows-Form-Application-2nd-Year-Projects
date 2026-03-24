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
    public partial class ITED : Form
    {
        public ITED()
        {
            InitializeComponent();
            PopulateCombobox();
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

        private void button8_Click(object sender, EventArgs e)
        {
            ChooseInstitute chooseInstitute = new ChooseInstitute();
            this.Hide();
            chooseInstitute.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ITED_Load(object sender, EventArgs e)
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
            comboBox1.Items.AddRange(new string[] { "BACHELOR IN ELEMENTARY EDUCATION", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES", "BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS", "BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE" });
            comboBox3.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox2.Items.AddRange(new string[] { "1st", "2nd" });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBox1.SelectedItem as string;
            string selectedYear = comboBox3.SelectedItem as string;
            string selectedSemester = comboBox2.SelectedItem as string;

            if (selectedCourse != null && selectedSemester != null)
            {

                //BSEE
                if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEE_1styear_1stsem bSEE_1Styear_1Stsem = new BSEE_1styear_1stsem();
                    this.Hide();
                    bSEE_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEE_1styear_2ndsem bSEE_1Styear_2Ndsem = new BSEE_1styear_2ndsem();
                    this.Hide();
                    bSEE_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEE_2ndyear_1sem bSEE_2Ndyear_1Sem = new BSEE_2ndyear_1sem();
                    this.Hide();
                    bSEE_2Ndyear_1Sem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEE_2ndyear_2ndsem bSEE_2Ndyear_2Ndsem = new BSEE_2ndyear_2ndsem();
                    this.Hide();
                    bSEE_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEE_3rdyear_1stsem bSEE_3Rdyear_1Stsem = new BSEE_3rdyear_1stsem();
                    this.Hide();
                    bSEE_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEE_3rdyear_2ndsem bSEE_3Rdyear_2Ndsem = new BSEE_3rdyear_2ndsem();
                    this.Hide();
                    bSEE_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEE_4thyear_1stsem bSEE_4Thyear_1Stsem = new BSEE_4thyear_1stsem();
                    this.Hide();
                    bSEE_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN ELEMENTARY EDUCATION") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSEE_4thyear_2ndsem bSEE_4Thyear_2Ndsem = new BSEE_4thyear_2ndsem();
                    this.Hide();
                    bSEE_4Thyear_2Ndsem.Show();


                } // BSEMSS
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEMSS_1styear_1stsem bSEMSS_1Styear_1Stsem = new BSEMSS_1styear_1stsem();
                    this.Hide();
                    bSEMSS_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEMSS_1styear_2ndsem bSEMSS_1Styear_2Ndsem = new BSEMSS_1styear_2ndsem();
                    this.Hide();
                    bSEMSS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEMSS_2ndyear_1stsem bSEMSS_2Ndyear_1Stsem = new BSEMSS_2ndyear_1stsem();
                    this.Hide();
                    bSEMSS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEMSS_2ndyear_2ndsem bSEMSS_2Ndyear_2Ndsem = new BSEMSS_2ndyear_2ndsem();
                    this.Hide();
                    bSEMSS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEMSS_3rdyear_1styear bSEMSS_3Rdyear_1Styear = new BSEMSS_3rdyear_1styear();
                    this.Hide();
                    bSEMSS_3Rdyear_1Styear.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEMSS_3rdyear_2ndsem bSEMSS_3Rdyear_2Ndsem = new BSEMSS_3rdyear_2ndsem();
                    this.Hide();
                    bSEMSS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEMSS_4thyear_1stsem bSEMSS_4Thyear_1Stsem = new BSEMSS_4thyear_1stsem();
                    this.Hide();
                    bSEMSS_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : SOCIAL STUDIES") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSEMSS_4thyear_2ndsem bSEMSS_4Thyear_2Ndsem = new BSEMSS_4thyear_2ndsem();
                    this.Hide();
                    bSEMSS_4Thyear_2Ndsem.Show();


                } //BSEMHE
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEMHE_1styear_1stsem bSEMHE_1Styear_1Stsem = new BSEMHE_1styear_1stsem();
                    this.Hide();
                    bSEMHE_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEMHE_1styear_2ndsem bSEMHE_1Styear_2Ndsem = new BSEMHE_1styear_2ndsem();
                    this.Hide();
                    bSEMHE_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEMHE_2ndyear_1stsem bSEMHE_2Ndyear_1Stsem = new BSEMHE_2ndyear_1stsem();
                    this.Hide();
                    bSEMHE_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEMHE_2ndyear_2ndsem bSEMHE_2Ndyear_2Ndsem = new BSEMHE_2ndyear_2ndsem();
                    this.Hide();
                    bSEMHE_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEMHE_3rdyear_1stsem bSEMHE_3Rdyear_1Stsem = new BSEMHE_3rdyear_1stsem();
                    this.Hide();
                    bSEMHE_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEMHE_3rdyear_2ndsem bSEMHE_3Rdyear_2Ndsem = new BSEMHE_3rdyear_2ndsem();
                    this.Hide();
                    bSEMHE_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEMHE_4thyear_1stsem bSEMHE_4Thyear_1Stsem = new BSEMHE_4thyear_1stsem();
                    this.Hide();
                    bSEMHE_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN TECHNOLOGY AND LIVELIHOOD EDUCATION MAJOR IN : HOME ECONOMICS") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSEMHE_4htyear_2ndsem bSEMHE_4Htyear_2Ndsem = new BSEMHE_4htyear_2ndsem();
                    this.Hide();
                    bSEMHE_4Htyear_2Ndsem.Show();


                } //BSEMF
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEMF_1year_1stsem bSEMF_1Year_1Stsem = new BSEMF_1year_1stsem();
                    this.Hide();
                    bSEMF_1Year_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEMF_1styear_2ndsem bSEMF_1Styear_2Ndsem = new BSEMF_1styear_2ndsem();
                    this.Hide();
                    bSEMF_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEMF_2ndyear_1stsem bSEMF_2Ndyear_1Stsem = new BSEMF_2ndyear_1stsem();
                    this.Hide();
                    bSEMF_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEMF_2ndyear_2ndsem bSEMF_2Ndyear_2Ndsem = new BSEMF_2ndyear_2ndsem();
                    this.Hide();
                    bSEMF_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEMF_3rdyear_1styear bSEMF_3Rdyear_1Styear = new BSEMF_3rdyear_1styear();
                    this.Hide();
                    bSEMF_3Rdyear_1Styear.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEMF_3rdyear_2ndsem bSEMF_3Rdyear_2Ndsem = new BSEMF_3rdyear_2ndsem();
                    this.Hide();
                    bSEMF_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEMF_4thyear_1stsem bSEMF_4Thyear_1Stsem = new BSEMF_4thyear_1stsem();
                    this.Hide();
                    bSEMF_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : FILIPINO") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSEMF_4thyear_2ndsem bSEMF_4Thyear_2Ndsem = new BSEMF_4thyear_2ndsem();
                    this.Hide();
                    bSEMF_4Thyear_2Ndsem.Show();



                } //BSEME
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEME_1styear_1stsem bSEME_1Styear_1Stsem = new BSEME_1styear_1stsem();
                    this.Hide();
                    bSEME_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEME_1styear_2ndsem bSEME_1Styear_2Ndsem = new BSEME_1styear_2ndsem();
                    this.Hide();
                    bSEME_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEME_2ndyear_1stsem bSEME_2Ndyear_1Stsem = new BSEME_2ndyear_1stsem();
                    this.Hide();
                    bSEME_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEME_2ndyear_2ndsem bSEME_2Ndyear_2Ndsem = new BSEME_2ndyear_2ndsem();
                    this.Hide();
                    bSEME_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEME_3rdyear_1stsem bSEME_3Rdyear_1Stsem = new BSEME_3rdyear_1stsem();
                    this.Hide();
                    bSEME_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEME_3rdyear_2ndsem bSEME_3Rdyear_2Ndsem = new BSEME_3rdyear_2ndsem();
                    this.Hide();
                    bSEME_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEME_4thyear_1stsem bSEME_4Thyear_1Stsem = new BSEME_4thyear_1stsem();
                    this.Hide();
                    bSEME_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : ENGLISH") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSEME_4thyear_2ndsem bSEME_4Thyear_2Ndsem = new BSEME_4thyear_2ndsem();
                    this.Hide();
                    bSEME_4Thyear_2Ndsem.Show();



                } //BSEMM
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEMM_1styear_1stsem bSEMM_1Styear_1Stsem = new BSEMM_1styear_1stsem();
                    this.Hide();
                    bSEMM_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEMM_1styear_2ndsem bSEMM_1Styear_2Ndsem = new BSEMM_1styear_2ndsem();
                    this.Hide();
                    bSEMM_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEMM_2ndyear_1stsem bSEMM_2Ndyear_1Stsem = new BSEMM_2ndyear_1stsem();
                    this.Hide();
                    bSEMM_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEMM_2ndyear_2ndsem bSEMM_2Ndyear_2Ndsem = new BSEMM_2ndyear_2ndsem();
                    this.Hide();
                    bSEMM_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEMM_3rdyear_1stsem bSEMM_3Rdyear_1Stsem = new BSEMM_3rdyear_1stsem();
                    this.Hide();
                    bSEMM_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEMM_3rdyear_2ndsem bSEMM_3Rdyear_2Ndsem = new BSEMM_3rdyear_2ndsem();
                    this.Hide();
                    bSEMM_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEMM_4thyear_1stsem bSEMM_4Thyear_1Stsem = new BSEMM_4thyear_1stsem();
                    this.Hide();
                    bSEMM_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : MATHEMATICS") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
                {
                    BSEMM_4thyear_2ndsem bSEMM_4Thyear_2Ndsem = new BSEMM_4thyear_2ndsem();
                    this.Hide();
                    bSEMM_4Thyear_2Ndsem.Show();



                } //BSEMS
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("1st") && selectedSemester.Equals("1st"))
                {
                    BSEMS_1styear_1stsem bSEMS_1Styear_1Stsem = new BSEMS_1styear_1stsem();
                    this.Hide();
                    bSEMS_1Styear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("1st") && selectedSemester.Equals("2nd"))
                {
                    BSEMS_1styear_2ndsem bSEMS_1Styear_2Ndsem = new BSEMS_1styear_2ndsem();
                    this.Hide();
                    bSEMS_1Styear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("2nd") && selectedSemester.Equals("1st"))
                {
                    BSEMS_2ndyear_1stsem bSEMS_2Ndyear_1Stsem = new BSEMS_2ndyear_1stsem();
                    this.Hide();
                    bSEMS_2Ndyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("2nd") && selectedSemester.Equals("2nd"))
                {
                    BSEMS_2ndyear_2ndsem bSEMS_2Ndyear_2Ndsem = new BSEMS_2ndyear_2ndsem();
                    this.Hide();
                    bSEMS_2Ndyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("3rd") && selectedSemester.Equals("1st"))
                {
                    BSEMS_3rdyear_1stsem bSEMS_3Rdyear_1Stsem = new BSEMS_3rdyear_1stsem();
                    this.Hide();
                    bSEMS_3Rdyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("3rd") && selectedSemester.Equals("2nd"))
                {
                    BSEMS_3rdyear_2ndsem bSEMS_3Rdyear_2Ndsem = new BSEMS_3rdyear_2ndsem();
                    this.Hide();
                    bSEMS_3Rdyear_2Ndsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("4th") && selectedSemester.Equals("1st"))
                {
                    BSEMS_4thyear_1stsem bSEMS_4Thyear_1Stsem = new BSEMS_4thyear_1stsem();
                    this.Hide();
                    bSEMS_4Thyear_1Stsem.Show();
                }
                else if (selectedCourse.Equals("BACHELOR IN SECONDARY EDUCATION  MAJOR IN : GENERAL SCIENCE") && selectedYear.Equals("4th") && selectedSemester.Equals("2nd"))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
