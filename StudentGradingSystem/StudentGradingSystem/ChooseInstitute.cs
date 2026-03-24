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
    public partial class ChooseInstitute : Form
    {
        public ChooseInstitute()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void ChooseInstitute_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ChooseInstitute_Load_1(object sender, EventArgs e)
        {
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ICET iCET = new ICET();
            this.Hide();
            iCET.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IARS iARS = new IARS();
            this.Hide();
            iARS.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IBEG iBEG = new IBEG();
            this.Hide();
            iBEG.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ITED iTED = new ITED();
            this.Hide();
            iTED.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ICET iCET = new ICET();
            this.Hide();
            iCET.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            IARS iARS = new IARS();
            this.Hide();
            iARS.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
