using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    class Project
    {
        private string projectName;
        Functionality[] funk;

        public Project(string projectName)
        {
            this.projectName = projectName;
            funk = new Functionality[10];
        }
        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public override string ToString()
        {
            return projectName;
        }
    }
}
