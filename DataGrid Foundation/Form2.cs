using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(textBox1.Text);
            string b = textBox2.Text;
            string c = textBox3.Text;
            int d = Convert.ToInt32(textBox4.Text);

            dt.Rows.Add(a, b, c, d);
            dataGridView1.DataSource = dt;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dataGridView1.SelectedRows[index];
            textBox1.Text = selectedrow.Cells[0].Value.ToString();
            textBox2.Text = selectedrow.Cells[1].Value.ToString();
            textBox3.Text = selectedrow.Cells[2].Value.ToString();
            textBox4.Text = selectedrow.Cells[3].Value.ToString();
        }

    }
}
