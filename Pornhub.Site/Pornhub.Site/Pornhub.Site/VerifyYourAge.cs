using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pornhub.Site
{
    public partial class VerifyYourAge : Form
    {
        public VerifyYourAge()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            introporn introporn = new introporn();
            this.Hide();
            introporn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
