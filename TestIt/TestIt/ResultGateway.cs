using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    public class ResultGateway:AbstractGateway
    {
      public ResultGateway():base(){}

      public void Insert(Result result){

        result.Time = DateTime.Now;
        string query = @"
        INSERT INTO
        result (ref_user_id, ref_test_id, comment, time)
        VALUES
        (@ref_user_id, @ref_test_id, @comment, @time)
        ";

        MySqlCommand cmd = CallStack(query);

        cmd.Parameters.AddWithValue("@ref_user_id", result.Ref_user_id);
        cmd.Parameters.AddWithValue("@ref_test_id", result.Ref_test_id);
        cmd.Parameters.AddWithValue("@comment", result.Comment);
        cmd.Parameters.AddWithValue("@time", result.Time);

        cmd.ExecuteNonQuery();

        result.ID = GetIdByDate(result.Time);
      }

      public int GetIdByDate(DateTime date){
        int id = -1;

        string query = @"
        SELECT result_id FROM result
        WHERE time = '@time'";

        MySqlCommand cmd = CallStack(query);
        cmd.Parameters.AddWithValue("@time", date);

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


    }
}
