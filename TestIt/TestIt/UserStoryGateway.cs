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
    class UserStoryGateway : AbstractGateway, IGateway
    {
        public UserStoryGateway() : base()
        {
        }
        public void Insert(Object obj)
        {
            UserStory story = (UserStory)obj;
            string query = "INSERT INTO userstory " +
                "(ref_functionality_id, given_text, when_text, then_text)" +
                " VALUES ('" + story.FunctionalityID + "'," +
                         "'" + story.Given + "'," +
                         "'" + story.When + "'," +
                         "'" + story.Then + "')";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }

        //public Project Find(string projectName)
        //{
        //    // find project entity.
        //    string query = "SELECT * FROM project WHERE Project_Name = '" + projectName + "'";
        //    MySqlCommand commandDatabase = CallStack(query);
        //    MySqlDataReader reader = commandDatabase.ExecuteReader();
        //    Project proge = new Project(projectName);
        //    while (reader.Read())
        //    {
        //        proge.ProjectName = reader.GetString(1);
        //    }
        //    reader.Close();
        //    return proge;

        //}

        public List<Object> SelectAll()
        {
            //string query = "SELECT given_text, when_text, then_text FROM userstory" +
            //    "WHERE ref_functionality_id = " +;
            //MySqlCommand commandDatabase = CallStack(query);
            //MySqlDataReader reader = commandDatabase.ExecuteReader();
            //List<Object> allTheStuff = new List<Object>();
            //while (reader.Read())
            //{
            //    Project proge = new Project(reader.GetString(1), reader.GetInt32(0));
            //    allTheStuff.Add(proge);
            //}
            //return allTheStuff;
            return null;
        }
        public List<Object> SelectAll(int funcID)
        {
            string query = "SELECT given_text, when_text, then_text FROM userstory" +
                "WHERE ref_functionality_id = " + funcID + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            List<Object> uStory = new List<Object>();
            while (reader.Read())
            {
                UserStory story = new UserStory();
                story.FunctionalityID = reader.GetInt32(0);
                story.Given = reader.GetString(1);
                story.When = reader.GetString(2);
                story.Then = reader.GetString(3);
                uStory.Add(story);
            }
            reader.Close();
            return uStory;
        }
        public void Delete(int projectId)
        {
            // delete project entity.
            string query = "DELETE FROM project WHERE Project_ID = '" + projectId + "'";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }
    }
}
