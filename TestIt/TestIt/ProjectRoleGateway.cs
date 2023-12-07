using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace TestIt
{
    public class ProjectRoleGateway:AbstractGateway, IGateway
    {
        public ProjectGateway():base(){}

        public void Insert(Object obj)
        {
          ProjectRole pr = (ProjectRole)obj;
          string query = @"
          INSERT INTO projectrole
          (ref_project_id, ref_user_id, role)
          VALUES
          (@ref_project_id, @ref_user_id, @role)
          "

          MysqlCommand cmd = CallStack(query);

          cmd.Parameters.AddWithValue("@ref_project_id", pr.Ref_proj_id);
          cmd.Parameters.AddWithValue("@ref_user_id", pr.Ref_proj_id);
          cmd.Parameters.AddWithValue("@role", pr.Role);

          cmd.ExecuteNonQuery();
        }

        public List<Object> SelectAll(){
          return null;
        }


        public List<Object> SelectAll(int id){
          return null;
        }

        public void Delete(int testid){

        }

        public Object Find(string name){
          
        }
    }
}
