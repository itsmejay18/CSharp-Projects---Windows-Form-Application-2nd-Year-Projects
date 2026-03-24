using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsingMethods.Classes.Repositories
{
    public class BaseRepositoty
    {
        public MySqlConnection connection { get; set; }
        public MySqlCommand command { get; set; }
        public MySqlDataReader reader { get; set; }
        public List<MySqlParameter> parameters { get; set; }

        public BaseRepositoty()
        {
            connection = new MySqlConnection("server=localhost;uid=root;pwd=root;database=product");
            reader = null; 
        }

       public void Connect ()
       {
            try
            {
                connection.Open ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }
       public void Disconnect ()
       {
            if (connection == null)
            {
                return;
            }
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close ();
            }
       }
       public void ExecuteQuery (String Query)
        {
            command = new MySqlCommand(Query, connection);
            
            if (parameters != null)
            {
                if (parameters.Count > 0)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }
            }

            //reader = command.ExecuteReader();
        }
    }
}
