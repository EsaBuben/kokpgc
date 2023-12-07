using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    class ResultGateway:AbstractGateway, IGateway
    {
      public ResultGateway():base(){}

      public void Insert(Object obj){
        Result result = (Result)obj;
        result.Time = DateTime.Now;
        string query = @"
        INSERT INTO
        result (ref_user_id, ref_test_id, status, comment, time)
        VALUES
        (@ref_user_id, @ref_test_id, @status, @comment, @time)
        ";

        MySqlCommand cmd = CallStack(query);

        cmd.Parameters.AddWithValue("@ref_user_id", result.Ref_user_id);
        cmd.Parameters.AddWithValue("@ref_test_id", result.Ref_test_id);
        cmd.Parameters.AddWithValue("@status", result.getStatus());
        cmd.Parameters.AddWithValue("@comment", result.Comment);
        cmd.Parameters.AddWithValue("@time", result.Time);

        cmd.ExecuteNonQuery();

        result.ID = GetId(result);
      }

      private int GetId(Result result){
        int id = -1;

        string query = @"
        SELECT result_id FROM result
        WHERE ref_user_id = @ref_user_id AND ref_test_id = @ref_test_id AND status = @status ";

        MySqlCommand cmd = CallStack(query);
        cmd.Parameters.AddWithValue("@ref_user_id", result.Ref_user_id);
        cmd.Parameters.AddWithValue("@ref_test_id", result.Ref_test_id);
        cmd.Parameters.AddWithValue("@status", result.getStatus());

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
           string query = "SELECT * FROM result";
           MySqlCommand cmd = CallStack(query);
           MySqlDataReader reader = cmd.ExecuteReader();
           List<Object> resultlist = new List<Object>();
           while (reader.Read())
           {
               Result result = new Result();
               //Adding values
               result.ID = reader.GetInt32(0);
               result.Ref_user_id = reader.GetInt32(1);
               result.Ref_test_id = reader.GetInt32(2);
               result.setStatus(reader.GetInt32(3));
               result.Comment = reader.GetString(4);
               result.Time = reader.GetDateTime(5);

               resultlist.Add(result);
           }
           return resultlist;
       }


       public List<Object> SelectAll(int id)
       {
            string query = @"
            SELECT *
            FROM result
            WHERE ref_test_id = @id";
            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Object> resultlist = new List<Object>();
            while (reader.Read())
            {
                Result result = new Result();
                //Adding values
                result.ID = reader.GetInt32(0);
                result.Ref_user_id = reader.GetInt32(1);
                result.Ref_test_id = reader.GetInt32(2);
                result.setStatus(reader.GetInt32(3));
                result.Comment = reader.GetString(4);
                result.Time = reader.GetDateTime(5);

                resultlist.Add(result);
            }
            return resultlist;
        }

        public void Delete(int id)
       {
           // delete project entity.
           string query = @"
           DELETE FROM result
           WHERE result_id = @id";
           MySqlCommand cmd = CallStack(query);
           cmd.Parameters.AddWithValue("@id", id);
           cmd.ExecuteNonQuery();
       }
        public Object Find(string t)
        {
            return null;
        }

        public void Update(Object obj){
          Result result = (Result)obj;
          string query = @"
          UPDATE result
          SET status = @status, comment = @comment
          WHERE result_id = @id";
          MySqlCommand cmd = CallStack(query);
          cmd.Parameters.AddWithValue("@status", result.getStatus());
          cmd.Parameters.AddWithValue("@comment", result.Comment);
          cmd.Parameters.AddWithValue("@id", result.ID);

          cmd.ExecuteNonQuery();
      }

    }



}
