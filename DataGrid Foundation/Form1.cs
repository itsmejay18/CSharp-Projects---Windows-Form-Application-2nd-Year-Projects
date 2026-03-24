using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2 ();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));

            dt.Rows.Add(1, "First A", "Last A", 18);
            dt.Rows.Add(2, "First B", "Last B", 18);
            dt.Rows.Add(3, "First C", "Last C", 18);
            dt.Rows.Add(4, "First D", "Last D", 18);
            dt.Rows.Add(5, "First E", "Last E", 18);
            dt.Rows.Add(6, "First F", "Last F", 18);
            dt.Rows.Add(7, "First G", "Last G", 18);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }
    }
}
