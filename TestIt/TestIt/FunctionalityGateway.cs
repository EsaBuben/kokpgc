using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    internal class FunctionalityGateway : AbstractGateway
    {
        public FunctionalityGateway() : base()
        {
        }
        public void Insert(Functionality funky)
        {
            // insert functionality entity.
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
        /*
        public List<Project> SelectAll()
        {
            string query = "SELECT * FROM project";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            List<Project> allTheStuff = new List<Project>();
            while (reader.Read())
            {
                Project proge = new Project(reader.GetString(1), reader.GetInt32(0));
                allTheStuff.Add(proge);
            }
            return allTheStuff;
        }
        public void Delete(int projectId)
        {
            // delete project entity.
            string query = "DELETE FROM project WHERE Project_ID = '" + projectId + "'";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }
        */
    }
}
