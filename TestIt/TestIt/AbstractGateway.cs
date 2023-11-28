using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    abstract class AbstractGateway
    {

        protected string connectionString;
        protected MySqlConnection databaseConnection;
        public AbstractGateway()
        {
        connectionString = "server=localhost;user=root;database=testirekisteri;port=3306;password=;";
        }
        public MySqlCommand CallStack(string q)
        {
            databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand(q, databaseConnection);
            return commandDatabase;
        }
    }


}
