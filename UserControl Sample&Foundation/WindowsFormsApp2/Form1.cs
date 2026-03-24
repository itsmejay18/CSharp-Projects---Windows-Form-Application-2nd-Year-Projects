using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
