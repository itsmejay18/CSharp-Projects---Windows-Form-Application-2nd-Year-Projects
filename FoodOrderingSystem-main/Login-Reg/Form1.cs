using System.Text.RegularExpressions;
namespace Login_Reg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string email = emailBox.Text;

            if (email == "admin" && passwordBox.Text == "admin")
            {
                MessageBox.Show("done ^^");
                alert.Text = "";
                alert.BackColor = Color.FromArgb(33, 33, 33);
                emailBox.Clear();
                passwordBox.Clear();
            }



            else if (email == "" && passwordBox.Text == "")
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "Enter Valid Data";
                emailBox.Clear();
                passwordBox.Clear();
            }
            else
            {
                alert.BackColor = Color.FromArgb(255, 192, 192);
                alert.Text = "invalid email or password";
                emailBox.Clear();
                passwordBox.Clear();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}