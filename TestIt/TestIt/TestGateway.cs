using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;
using System.Runtime.CompilerServices;
//using Org.BouncyCastle.Utilities.Collections;

namespace TestIt
{
    class TestGateway : AbstractGateway, IGateway
    {
      public TestGateway():base(){}

      public void Insert(Object obj)
      {
        Test test = (Test)obj;
        string query = @"
        INSERT INTO
        test (name, ref_functionality_id, priority)
        VALUES
        (@name, @ref_functionality_id, @priority)";

        MySqlCommand cmd = CallStack(query);

        cmd.Parameters.AddWithValue("@name", test.Name);
        cmd.Parameters.AddWithValue("@ref_functionality_id", test.ref_func_id);
        cmd.Parameters.AddWithValue("@priority", test.Priority);
        cmd.ExecuteNonQuery();

        test.ID = GetIdByName(test.Name);
      }

      public int GetIdByName(string name){
        int id = -1;

        string query = @"
        SELECT test_id FROM test
        WHERE name = '@name'";

        MySqlCommand cmd = CallStack(query);
        cmd.Parameters.AddWithValue("@name", name);

        MySqlDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
              id = reader.GetInt32(0);
            }
        }
        reader.Close();
        return id;
        }


      public List<Object> SelectAll()
       {
           string query = "SELECT * FROM test";
           MySqlCommand cmd = CallStack(query);
           MySqlDataReader reader = cmd.ExecuteReader();
           List<Object> testlist = new List<Object>();
           while (reader.Read())
           {
               Test test = new Test();
               //Adding values
               test.ID = reader.GetInt32(0);
               test.ref_func_id = reader.GetInt32(1);
               test.Priority = reader.GetInt32(3);
               test.Name = reader.GetString(4);

               if(!reader.IsDBNull(reader.GetOrdinal("responsible_user_id"))){
                 test.Responsible_user_id = reader.GetInt32(2);
               }
               //else{
               //reader.GetOrdinal("responsible_user_id");
               //   test.Responsible_user_id = -1;
               // }


               testlist.Add(test);
           }
           return testlist;
       }
        public List<Object> SelectAll(int id)
        {
            string query = @"
            SELECT *
            FROM test
            WHERE ref_functionality_id = @id";
            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Object> testlist = new List<Object>();
            while (reader.Read())
            {
                Test test = new Test();
                //Adding values
                test.ID = reader.GetInt32(0);
                test.ref_func_id = reader.GetInt32(1);
                test.Priority = reader.GetInt32(3);
                test.Name = reader.GetString(4);

                if(!reader.IsDBNull(reader.GetOrdinal("responsible_user_id"))){
                  test.Responsible_user_id = reader.GetInt32(2);
                }
                //else{
                //reader.GetOrdinal("responsible_user_id");
                //   test.Responsible_user_id = -1;
                // }


                testlist.Add(test);
            }
            return testlist;
        }
        public void Delete(int testId)
       {
           // delete project entity.
           string query = @"
           DELETE FROM test
           WHERE test_id = @testid";
           MySqlCommand cmd = CallStack(query);
           cmd.Parameters.AddWithValue("@testid", testId);
           cmd.ExecuteNonQuery();
       }
        public Object Find(string name)
        {
            string query = @"
            SELECT *
            FROM test
            WHERE name = @name";
            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = cmd.ExecuteReader();
            Test test = new Test();
            while (reader.Read())
            {
                test.ID = reader.GetInt32(0);
                test.ref_func_id = reader.GetInt32(1);
                test.Priority = reader.GetInt32(3);
                test.Name = reader.GetString(4);

                if (!reader.IsDBNull(reader.GetOrdinal("responsible_user_id")))
                {
                  test.Responsible_user_id = reader.GetInt32(2);
                }
                //else{
                //reader.GetOrdinal("responsible_user_id");
                //   test.Responsible_user_id = -1;
                // }
            }
            reader.Close();
            return test;
        }
        public void Update(Object test)
        {
            // update test entity.
            Test testi = (Test)test;
            string query = "UPDATE test" +
                           " SET test_name = '" + testi.Name + "'" +
                           " priority = '" + testi.Priority + "'," +
                           " ref_functionality_id = '" + testi.ref_func_id + "'," +
                           " responsible_user_id = '" + testi.Responsible_user_id + "'," +
                           " WHERE test_id = '" + testi.ID + "'";
            MySqlCommand commandDatabase = CallStack(query);
            commandDatabase.ExecuteNonQuery();
        }





    }
}
