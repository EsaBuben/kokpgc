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
    class ProjectRoleGateway : AbstractGateway, IGateway
    {
        public ProjectRoleGateway():base(){}

        public void Insert(Object obj)
        {
            ProjectRole pr = (ProjectRole)obj;
            string query = @"
          INSERT INTO projectrole
          (ref_project_id, ref_user_id, role)
          VALUES
          (@ref_project_id, @ref_user_id, @role)
          ";

          MySqlCommand cmd = CallStack(query);

            cmd.Parameters.AddWithValue("@ref_project_id", pr.Ref_proj_id);
            cmd.Parameters.AddWithValue("@ref_user_id", pr.Ref_proj_id);
            cmd.Parameters.AddWithValue("@role", pr.Role);

            cmd.ExecuteNonQuery();
        }

        public List<Object> SelectAll()
        {
            return null;
        }


        public List<Object> SelectAll(int id)
        {
          string query = @"
          SELECT *
          FROM projectrole
          WHERE ref_project_id = @ref_proj_id
          ";

          MySqlCommand cmd = CallStack(query);
          cmd.Parameters.AddWithValue("@ref_proj_id", id);
          MySqlDataReader reader = cmd.ExecuteReader();

          List<Object> projrolelist = new List<Object>();
          while(reader.Read())
          {
              ProjectRole pr = new ProjectRole();

              pr.Ref_proj_id = id;
              pr.Ref_user_id = reader.GetInt32(1);
              pr.Role = reader.GetString(2);
              projrolelist.Add(pr);
          }

          return projrolelist;

        }

        public void Delete(int testid){
          return;
        }

        public void Update(Object obj){
          return;
        }

        public Object Find(string name)
        {
            return null;
        }
    }
}
