﻿using MySql.Data.MySqlClient;
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
        
        public List<Functionality> SelectAll(Project proge)
        {
            // select all functionality entities under a project.
            string query = "SELECT * FROM functionality " +
                           "WHERE ref_project_id = '" + proge.ProjectID + "'";
            MySqlCommand commandDatabase = CallStack(query);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            List<Functionality> funkies = new List<Functionality>();
            while (reader.Read())
            {
                Functionality funky = new Functionality();
                funky.FunctionalityName = reader.GetString(2);
                funky.FunctionalityID = reader.GetInt32(0);
                funky.RefID = reader.GetInt32(1);
                funkies.Add(funky);
            }
            reader.Close();
            return funkies;
            
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
