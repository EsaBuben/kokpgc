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

    public class Functionality : UserStory
    {
        private string functionalityName;
        private int functionalityID;
        UserStory story;
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
            this.refID = refID;
        }
        public Functionality(string name, int refID, string given, string when, string then)
        {
            this.functionalityName = name;
            this.refID = refID;
            story = new UserStory(this.functionalityID, given, when, then);
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
        public UserStory Story
        {
            get { return story; }
            set { story = value; }
        }
        public override string ToString()
        {
            return $"{refID} {functionalityID}, {functionalityName}";
        }



    }
}
