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
    public partial class ICET : Form
    {
        public ICET()
        {
            InitializeComponent();
            PopulateCombobox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChooseInstitute chooseInstitute = new ChooseInstitute();
            this.Hide();
            chooseInstitute.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void ICET_Load(object sender, EventArgs e)
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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        private void PopulateCombobox()
        {
            comboBox1.Items.AddRange(new string[] { "BS IN AGRICULTURAL AND BIO-SYSTEM ENGINEERING", "BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY", "BACHELOR OF SCIENCE IN INFORMATION SYSTEM", "DIPLOMA IN INFORMATION TECHNOLOGY (3YEARS)", "ASSOCIATE IN COMPUTING TECHNOLOGY (2YEARS)" });
            comboBox3.Items.AddRange(new string[] { "1st", "2nd", "3rd", "4th" });
            comboBox2.Items.AddRange(new string[] { "1st", "2nd" });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectedCourse = comboBox1.SelectedItem as string;
            string selectedYear = comboBox3.SelectedItem as string;
            string selectedSemester = comboBox2.SelectedItem as string;

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
