using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows;

namespace TestIt
{

    public class Functionality
    {
        private string functionalityName;
        private int functionalityID;
        string given;
        string when;
        string then;
        private Project project;
        protected int refID;

        public Functionality()
        {

        }
        public Functionality(string name)
        {
            this.FunctionalityName = name;
        }
        public Functionality(Project project, string functionalityName)
        {
            this.project = project;
            this.functionalityName = functionalityName;
            this.refID = project.ProjectID;

        }
        public Functionality(string functionalityName, int refID)
        {
            this.functionalityName = functionalityName;
            this.functionalityID = refID;
        }
        public Functionality(string name, int refID, string given, string when, string then)
        {
            this.functionalityName = name;
            this.refID = refID;
            this.given = given;
            this.when = when;
            this.then = then;
        }
        public string FunctionalityName
        {
            get { return functionalityName; }
            set { functionalityName = value; }
        }
        public int FunctionalityID
        {
            get { return functionalityID; }
            set { functionalityID = value; }
        }
        
        public int RefID
        {
            get { return refID; }
            set { refID = value; }
        }
        public string Given
        {
            get { return given; }
            set { given = value; }
        }
        public string When
        {
            get { return when; }
            set { when = value; }
        }
        public string Then
        {
            get { return then; }
            set { then = value; }
        }
        public override string ToString()
        {
            return $"{refID} {functionalityID}, {functionalityName}";
        }



    }
}
