using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;
using System.Runtime.CompilerServices;

namespace TestIt
{
    class ProjectGateway : AbstractGateway
    {
        public ProjectGateway() : base()
        {
        }
        public void Insert(Project proge)
        {
            // insert project entity.
            string query = "INSERT INTO project (Project_Name) VALUES ('" + proge.ProjectName + "')";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
            query = "SELECT Project_ID FROM project WHERE Project_Name = '" + proge.ProjectName + "'";
            commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                proge.ProjectID = reader.GetInt32(0);
            }
            reader.Close();
        }

        public Project Find(string projectName)
        {
            // find project entity.
            string query = "SELECT * FROM project WHERE Project_Name = '" + projectName + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            Project proge = new Project(projectName);
            while (reader.Read())
            {
                proge.ProjectName = reader.GetString(1);
            }
            reader.Close();
            return proge;
            
        }

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

       //private MySqlCommand CallStack(string q)
       // {
       //     MySqlConnection databaseConnection = new MySqlConnection(connectionString);
       //     databaseConnection.Open();
       //     MySqlCommand commandDatabase = new MySqlCommand(q, databaseConnection);
       //     return commandDatabase;
       // }
    }
}
