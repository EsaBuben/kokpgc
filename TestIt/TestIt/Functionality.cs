using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{

    internal class Functionality
    {
        private string functionalityName;
        private int functionalityID;
        private int projectID;
        // private string given;
        // private string when;
        // private string then;

        public Functionality(string functionalityName, int projectID)
        {
            this.functionalityName = functionalityName;
            this.projectID = projectID;
        }
        public int FunctionalityID
        {
            get { return functionalityID; }
            set { functionalityID = value; }
        }
        public string FunctionalityName
        {
            get { return functionalityName; }
            set { functionalityName = value; }
        }
        public int ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }

    }
}
