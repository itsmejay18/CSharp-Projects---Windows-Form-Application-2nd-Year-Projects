using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsingMethods.Classes
{
    public class BaseClass
    {
        public MySqlDataReader DataReader { get; set; }

        public BaseClass()
        {

        }
        public BaseClass(MySqlDataReader reader)
        {
            DataReader = reader;
        }
    }
}
