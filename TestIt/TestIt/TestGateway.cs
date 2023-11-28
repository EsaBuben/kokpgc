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
    class TestGateway : AbstractGateway
    {
      public TestGateway():base(){}

      public void Insert(Test test)
      {
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

      public List<Test> SelectAll()
       {
           string query = "SELECT * FROM test";
           MySqlCommand cmd = CallStack(query);
           MySqlDataReader reader = cmd.ExecuteReader();
           List<Test> testlist = new List<Test>();
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
           WHERE test_id = '@testid'";
           MySqlCommand cmd = CallStack(query);
           cmd.Parameters.AddWithValue("@testid", testId);
           cmd.ExecuteNonQuery();
       }





    }
}
