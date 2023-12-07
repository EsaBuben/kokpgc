using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    public class User
    {
        private int user_id;
        private string user_name;
        //private string profile_name;


        public User()
        {

        }
        public User(string user_name)
        {
            this.user_name = user_name;
        }

        public User(string user_name, int user_id)
        {
            this.user_name = user_name;
            this.user_id = user_id;
        }

        public int UserID
        {
            get { return user_id; }
            set { this.user_id = value;}
        }

        public string UserName
        {
            get { return user_name; }
            set { this.user_name = value;}
        }

        public override string ToString(){
          return $"{this.user_name}";
        }

    }
}
