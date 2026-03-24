using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsingMethods.Classes
{
    public class Product: BaseClass
    {
        public Product()
        {

        }
        public Product(MySqlDataReader reader): base(reader)
        {
            id = Convert.ToInt32(DataReader["id"].ToString());
            names = DataReader["names"].ToString();
            price = DataReader["price"].ToString();
            quantity = DataReader["quantity"].ToString();
            quality = DataReader["quality"].ToString();
            color = DataReader["color"].ToString();
        }

        public int id { get; set; }
        public string names { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string quality { get; set; }
        public string color { get; set; }
    }
}
