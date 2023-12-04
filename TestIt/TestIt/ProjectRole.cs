using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt
{
    public class ProjectRole
    {
        private int ref_proj_id;
        private int ref_user_id;
        private string role;


        public ProjectRole()
        {

        }

        public ProjectRole(int ref_proj_id, int ref_user_id, string role)
        {
            this.ref_proj_id = ref_proj_id;
            this.ref_user_id = ref_user_id;
            this.role = role;
        }

        public int Ref_proj_id
        {
            get { return this.Ref_proj_id; }
            set { this.Ref_proj_id = value; }
        }

        public int Ref_user_id
        {
            get { return this.Ref_user_id; }
            set { this.Ref_user_id = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }
    }
}
