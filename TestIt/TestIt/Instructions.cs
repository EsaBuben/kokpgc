using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace TestIt
{
    class Instructions
    {
        private int instructionID;
        private string instructionText;
        private int refTestID;

        public Instructions()
        {
        }

        public Instructions(int refTestID, string instructionText)
        {
            this.instructionText = instructionText;
            this.refTestID = refTestID;
        }

        public int InstructionID
        {
            get
            {
                return instructionID;
            }

            set
            {
                instructionID = value;
            }
        }

        public string InstructionText
        {
            get
            {
                return instructionText;
            }

            set
            {
                instructionText = value;
            }
        }

        public int RefTestID
        {
            get
            {
                return refTestID;
            }

            set
            {
                refTestID = value;
            }
        }
        public override string ToString()
        {
            return this.InstructionText;
        }
    }
}
