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

    internal class Functionality
    {
        private string functionalityName;
        private int functionalityID;
        private string given;
        private string when;
        private string then;
        private Project project;
        protected int refID;

        public Functionality(string name)
        {
            this.FunctionalityName = name;
        }
        public Functionality(Project project, string functionalityName, string given, string when, string then)
        {
            this.project = project;
            this.functionalityName = functionalityName;
            this.given = given;
            this.when = when;
            this.then = then;
            this.refID = project.ProjectID;

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
            return $"{refID} {functionalityID}, {functionalityName}, {given}, {when}, {then}";
        }



    }
}
