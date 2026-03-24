using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NosqlPracticedfgegege
{
    public partial class Form1 : Form
    {
        Repository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new Repository();
            LoadData();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            listView1.Items.Clear();
            
            foreach (var items in repository.getAll())
            {
                ListViewItem item = new ListViewItem(items.Id.ToString());
                listView1.Items.Add(item);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            User user = new User()
            {
                Id = int.Parse(textBox1.Text),  
            }; 
            repository.Add(user);
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var index = listView1.SelectedIndices[0];
                repository.Update(index, new User()
                {
                    Id = int.Parse(textBox1.Text)
                });
            }
            LoadData();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) { 
            
             ListViewItem item = listView1.SelectedItems[0];
             textBox1.Text = item.Text;
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem item = listView1.SelectedItems[0];

                repository.delete(new User()
                {
                    Id = int.Parse(item.Text)
                }); 
                textBox1.Clear();
                LoadData();

            }
        }
    }
}
