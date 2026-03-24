using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsingMethods.Classes.Repositories
{
    public class ProductsRepository : BaseRepositoty
    {
        // Select All Data
        public List<Product> Read()
        {
            List<Product> products = new List<Product>();
            Connect();
            ExecuteQuery("Select * From product.tbl_product");
            reader = command.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    Product product = new Product(reader);
                    products.Add(product);
                }
            }
            else
            {
                MessageBox.Show("No Data Available");
            }
            Disconnect();
            return products;
        }

        // Select Specific Data
        public Product Read(int productId)
        {
            Product product = new Product();
            Connect();
            parameters = new List<MySql.Data.MySqlClient.MySqlParameter>();
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter{ParameterName = "@productId",MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.Int32,Value = productId});   
            ExecuteQuery("Select * From product.tbl_product Where id=@productId");
            reader = command.ExecuteReader();
            if (reader.HasRows == true)
            {
                reader.Read();
                product = new Product(reader);
            }
            else
            {
                MessageBox.Show("No Data Available");
            }
            parameters = null;
            Disconnect();
            return product;
        }

        //Insert Data
        public Product Create (Product product)
        {

            parameters = new List<MySql.Data.MySqlClient.MySqlParameter>
            {
                new MySql.Data.MySqlClient.MySqlParameter("@names", MySql.Data.MySqlClient.MySqlDbType.VarChar) { Value = product.names },
                new MySql.Data.MySqlClient.MySqlParameter("@price", MySql.Data.MySqlClient.MySqlDbType.VarChar) { Value = product.price },
                new MySql.Data.MySqlClient.MySqlParameter("@quantity", MySql.Data.MySqlClient.MySqlDbType.VarChar) { Value = product.quantity },
                new MySql.Data.MySqlClient.MySqlParameter("@quality", MySql.Data.MySqlClient.MySqlDbType.VarChar) { Value = product.quality },
                new MySql.Data.MySqlClient.MySqlParameter("@color", MySql.Data.MySqlClient.MySqlDbType.VarChar) { Value = product.color }
            };


            ExecuteQuery("insert into tbl_product (names, price, quantity, quality, color) values (@names, @price, @quantity, @quality, @color)");

            try
            {
                Connect();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //using (MySqlCommand command = new MySqlCommand(@"insert into tbl_product (id, names, price, quantity, quality, color) values (@id, @names, @price, @quantity, @quality, @color)", connection));
            //{
            //    parameters = new List<MySqlParameter>();

            //    parameters.Add(new MySqlParameter() { ParameterName = "@name", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.names });
            //    parameters.Add(new MySqlParameter() { ParameterName = "@price", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.price });
            //    parameters.Add(new MySqlParameter() { ParameterName = "@quantity", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.quantity });
            //    parameters.Add(new MySqlParameter() { ParameterName = "@quality", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.quality });
            //    parameters.Add(new MySqlParameter() { ParameterName = "@color", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.color });

            //    parameters.Add(new MySqlParameter() { ParameterName = "@id", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.Int64, Direction = System.Data.ParameterDirection.Output });

            //    command.Parameters.AddRange(parameters.ToArray());

            //    command.ExecuteNonQuery();

            //    product.id = (int)command.Parameters["@id"].Value;

            //    parameters = null;
            //}
            parameters = null;
            Disconnect();
            return product;
        }

        //Update Data
        public Product Update(Product product)
        {

            parameters = new List<MySql.Data.MySqlClient.MySqlParameter>();
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@id", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.id });
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@names", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.names });
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@price", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.price });
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@quantity", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.quantity });
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@quality", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.quality });
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@color", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.color });


            ExecuteQuery("Update tbl_product Set names = @names, price = @price, quantity = @quantity, quality = @quality, color = @color Where id = @id");

            try
            {
                Connect();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            parameters = null;
            Disconnect();
            return product;
        }

        // Delete Data
        public Product Delete(Product product)
        {

            parameters = new List<MySql.Data.MySqlClient.MySqlParameter>();
            parameters.Add(new MySql.Data.MySqlClient.MySqlParameter { ParameterName = "@id", MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.VarChar, Value = product.id });

            ExecuteQuery("Delete From tbl_product Where id = @id");

            try
            {
                Connect();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            parameters = null;
            Disconnect();
            return product;
        }
    }
}
