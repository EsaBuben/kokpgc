using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestIt
{
    internal class FunctionalityGateway : AbstractGateway, IGateway
    {
        public FunctionalityGateway() : base()
        {
        }
        public void Insert(Object func)
        {
            // insert functionality entity.
            Functionality funky = (Functionality)func;
            string query = "INSERT INTO functionality (functionality_name, ref_project_id)" +
                           " VALUES ('" + funky.FunctionalityName + "', '"+ funky.RefID +"' )";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
            query = "SELECT functionality_id FROM functionality " +
                    "WHERE functionality_Name = '" + funky.FunctionalityName + "'";
            commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                funky.FunctionalityID = reader.GetInt32(0);
            }
            reader.Close();
        }
        
        public Functionality Find(string functionalityName)
        {
            // find project entity.
            string query = "SELECT * FROM functionality " +
                           "WHERE functionality_name = '" + functionalityName + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            Functionality funky = new Functionality();
            while (reader.Read())
            {
                funky.FunctionalityName = reader.GetString(2);
                funky.FunctionalityID = reader.GetInt32(0);
                funky.RefID = reader.GetInt32(1);
            }

            reader.Close();
            return funky;

        }
        
        public List<Object> SelectAll(int proge)
        {
            // select all functionality entities under a project.
            string query = "SELECT functionality_id, functionality_name, given_text, when_text, then_text " +
                           "FROM functionality " +
                           "LEFT OUTER JOIN userstory ON functionality_id = ref_functionality_id " +
                           "WHERE ref_project_id = '" + proge + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            List<Object> funkies = new List<Object>();
            while (reader.Read())
            {
                Functionality funky = new Functionality();
                funky.FunctionalityName = reader.GetString(1);
                funky.FunctionalityID = reader.GetInt32(0);
                funky.RefID = proge;
                if (!reader.IsDBNull(reader.GetOrdinal("given_text")))
                {
                    funky.Given = reader.GetString(2);
                    funky.When = reader.GetString(3);
                    funky.Then = reader.GetString(4);
                }
                else
                {
                    funky.Given = "";
                    funky.When = "";
                    funky.Then = "";
                }

                funkies.Add(funky);
            }
            reader.Close();
            return funkies;
        }
        public List<Object> SelectAll()
        {
            return null;
        }
        public void Delete(int funkyId)
        {
            // delete project entity.
            string query = "DELETE FROM functionality WHERE functionality_id = '" + funkyId + "'";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }
        
    }
}
