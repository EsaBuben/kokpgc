using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace TestIt
{
    class UserGateway : AbstractGateway, IGateway
    {
        public UserGateway() : base()
        { 

        }
        public void Insert(Object obj)
        {
            User user = (User)obj;
            string query = "INSERT INTO user (user_name, profile_name)" +
                           " VALUES (@user_name, @profile_name)";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                user.UserID = reader.GetInt32(0);
            }
            reader.Close();
        }

        public Object Find(string username)
        {
            string query = "SELECT * FROM user WHERE" +
                           "WHERE functionality_name = '" + username + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            User usr = new User();
            while (reader.Read())
            {
                usr = new User(reader.GetString(1), reader.GetInt32(0));               
                
            }
            reader.Close();
            return usr;

        }

        public List<Object> SelectAll()
        {
            string query = "SELECT * FROM user";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            List<Object> allTheStuff = new List<Object>();
            while (reader.Read())
            {
                User user = new User();
                user.UserID = reader.GetInt32(0);
                user.UserName = reader.GetString(1);
                allTheStuff.Add(user);
            }
            return allTheStuff;
        }

        public List<Object> SelectAll(int userid)
        {
            return null;
        }

        public void Delete(int userid)
        {
            string query = "DELETE FROM user WHERE user_id = '" + userid + "'";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }
        
    }
}
