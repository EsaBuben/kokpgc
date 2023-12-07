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
        public void Update(Object obj)
        {
            UserStory story = (UserStory)obj;
            string query = "UPDATE userstory" +
                " SET given_text = '" + story.Given + "'," +
                " when_text = '" + story.When + "'," +
                " then_text = '" + story.Then + "'" +
                " WHERE ref_functionality_id = '" + story.FunctionalityID + "'";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }

        public Object Find(string t)
        {
            // find project entity.
            int i = Convert.ToInt32(t);
            string query = "SELECT * FROM userstory WHERE ref_functionality_id = '" + i + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            UserStory story = new UserStory();
            if (!reader.HasRows)
            {
                return null;
            } else
            while (reader.Read())
            {
                story.FunctionalityID = reader.GetInt32(0);
                story.Given = reader.GetString(1);
                story.When = reader.GetString(2);
                story.Then = reader.GetString(3);
            }
            reader.Close();
            return story;

        }

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
