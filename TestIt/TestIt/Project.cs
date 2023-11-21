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
        private int projectID;
        Functionality[] funk;
        private const int MAX = 10;

        public Project(string projectName)
        {
            this.projectName = projectName;
            funk = new Functionality[MAX];
        }
        public Project(string projectName, int projectID)
        {
            this.projectID = projectID;
            this.ProjectName = projectName;
            funk = new Functionality[MAX];
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
