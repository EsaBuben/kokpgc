using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    public class Project
    {
        private string projectName;
        protected int projectID;

        public Project(string projectName)
        {
            this.projectName = projectName;
        }
        public Project(string projectName, int projectID)
        {
            this.projectID = projectID;
            this.ProjectName = projectName;
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public int ProjectID
        { 
            get { return projectID; } 
            set { projectID = value; }
        }
        public override string ToString()
        {
            return $"{projectID}, {ProjectName}";
        }
    }
}
