using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace TestIt
{
    public class UserStory
    {
        private int functionalityID;
        private string given;
        private string when;
        private string then;

        public UserStory() { }
        public UserStory(int func, string give, string whe, string the)
        {
            this.functionalityID = func;
            this.given = give;
            this.when = whe;
            this.then = the;
        }
        public int FunctionalityID
        {
            get { return functionalityID; }
            set { functionalityID = value; }
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
            return $"{functionalityID}, {given}, {when}, {then}";
        }
    }
}
