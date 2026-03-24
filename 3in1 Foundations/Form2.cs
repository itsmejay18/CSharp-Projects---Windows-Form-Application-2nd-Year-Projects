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

namespace Gmall
{
    public partial class Form2 : Form
    {
        public static int final;
        int price, quantity, total;
        public static Form3 f3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Product #", 100);
            listView1.Columns.Add("Product Name", 100);
            listView1.Columns.Add("Quantiy", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Total Price", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(textBox3.Text);
            price = int.Parse(textBox4.Text);

            total = quantity * price;

            final += total;

            if (textBox1.Text == "")
            {

                MessageBox.Show("Product Number are Required!!!!");


            }
            else
            {
                ListViewItem NewItem = new ListViewItem(textBox1.Text);
                NewItem.SubItems.Add(textBox2.Text);
                NewItem.SubItems.Add(textBox3.Text);
                NewItem.SubItems.Add(textBox4.Text);
                NewItem.SubItems.Add(total.ToString());

                listView1.Items.Add(NewItem);

                MessageBox.Show("Successfully Save");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
                MessageBox.Show("Remove Successfully!!!!");
            }
            else
            {
                MessageBox.Show("Error!!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListViewItem NewItem = new ListViewItem("Final Total");
            NewItem.SubItems.Add("");
            NewItem.SubItems.Add("");
            NewItem.SubItems.Add("");
            NewItem.SubItems.Add(final.ToString());

            listView1.Items.Add(NewItem);
        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            List<ListViewItem> foundItems = new List<ListViewItem>();
            string searchText = Search_TXT.Text.ToLower();

            foreach (ListViewItem item in listView1.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        item.Selected = true;
                        item.EnsureVisible();
                        foundItems.Add(item);
                        if (foundItems.Count > 0)
                        {
                            listView1.Items.Clear();
                            listView1.Items.AddRange(foundItems.ToArray());
                        }
                        return;
                    }
                }
            }
            MessageBox.Show("Item Not Found");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;

                MessageBox.Show("Data Successfully Updated");
            }
            else
            {
                MessageBox.Show("Error!!!!");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
