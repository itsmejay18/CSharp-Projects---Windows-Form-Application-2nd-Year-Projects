using CrudUsingMethods.Classes;
using CrudUsingMethods.Classes.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsingMethods
{
    public partial class Form1 : Form
    {
        //List <Product> products = new List <Product> ();
        public Form1()
        {
            InitializeComponent();
            Load();
        }
        ProductsRepository productsRepository = new ProductsRepository();

        private void Form1_Load(object sender, EventArgs e)
        {
            //MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=root;database=product");
            //try
            //{
            //    connection.Open();
            //    MySqlDataReader reader = null;
            //    MySqlCommand command = new MySqlCommand("Select * From product.tbl_product", connection);
            //    reader = command.ExecuteReader();

            //    if (reader.HasRows == true)
            //    {
            //        while (reader.Read())
            //        {
            //            Product product = new Product(reader);
            //            products.Add(product);
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{

            //    connection.Close();
            //}


            //Insert Data
            //Product newproduct = productsRepository.Create(new Product()
            //{
            //    names = "Kape",
            //    price = "15",
            //    quantity = "10",
            //    quality = "Good",
            //    color = "Black"
            //});

            //Update Data
            //Product newproduct = productsRepository.Update(new Product()
            //{
            //    id = 5,
            //    names = "Toyo",
            //    price = "12",
            //    quantity = "10",
            //    quality = "Moderate",
            //    color = "Red"
            //}) ;

            //Delete Data
            //Product newproduct = productsRepository.Delete(new Product()
            //{
            //    id = 5
            //});

            //Select All Data
           
            


            //Select Specific Data
            //List<Product> products = new List<Product>();
            //Product product = productsRepository.Read(1);
            //products.Add(product);
            //dataGridView1.DataSource = products;

        }

        public void Load()
        {
            listView1.Items.Clear();
            productsRepository.Read().ForEach (product =>
            {
                ListViewItem NewItem = new ListViewItem(product.id.ToString());
                NewItem.SubItems.Add(product.names);
                NewItem.SubItems.Add(product.price);
                NewItem.SubItems.Add(product.quantity);
                NewItem.SubItems.Add(product.quality);
                NewItem.SubItems.Add(product.color);

                listView1.Items.Add(NewItem);
            }
            );
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Id_TXT.Text = item.Text;
                Name_TXT.Text = item.SubItems[1].Text;
                Price_TXT.Text = item.SubItems[2].Text;
                Quantity_TXT.Text = item.SubItems[3].Text;
                Quality_TXT.Text = item.SubItems[4].Text;
                Color_TXT.Text = item.SubItems[5].Text;
            }
        }

        private void Insert_BTN_Click(object sender, EventArgs e)
        {
            Product newproduct = productsRepository.Create(new Product()
            {
                names = Name_TXT.Text,
                price = Price_TXT.Text,
                quantity = Quantity_TXT.Text,
                quality = Quality_TXT.Text,
                color =Color_TXT.Text
            });
            Load();
        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {
            Product newproduct = productsRepository.Update(new Product()
            {
                id = int.Parse(Id_TXT.Text),
                names = Name_TXT.Text,
                price = Price_TXT.Text,
                quantity = Quantity_TXT.Text,
                quality = Quality_TXT.Text,
                color = Color_TXT.Text
            });
            Load();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Product newproduct = productsRepository.Delete(new Product()
            {
                id = int.Parse(Id_TXT.Text)
            });
            Load();
        }
    }
}
