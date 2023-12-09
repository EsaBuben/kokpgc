using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace TestIt
{
    class InstructionsGateway : AbstractGateway, IGateway
    {
        public InstructionsGateway() : base() { }
        public void Insert(Object obj)
        {
            Instructions instr = (Instructions)obj;
            string query = @"
            INSERT INTO
            instruction (info, ref_test_id)
            VALUES
            (@Instruction_Text, @ref_test_id)
            ";

            MySqlCommand cmd = CallStack(query);

            cmd.Parameters.AddWithValue("@Instruction_Text", instr.InstructionText);
            cmd.Parameters.AddWithValue("@ref_test_id", instr.RefTestID);

            cmd.ExecuteNonQuery();

            instr.InstructionID = GetId(instr);
        }
        public int GetId(Instructions instr)
        {
            int id = -1;

            string query = @"
            SELECT Instruction_ID FROM instruction
            WHERE info = @Instruction_Text AND ref_test_id = @ref_test_id ";

            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@Instruction_Text", instr.InstructionText);
            cmd.Parameters.AddWithValue("@ref_test_id", instr.RefTestID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            return id;
        }
        public List<Object> SelectAll()
        {
            return null;
        }
        public List<Object> SelectAll(int id)
        {
            string query = @"
            SELECT *
            FROM instruction
            WHERE ref_test_id = @ref_test_id
            ";

            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@ref_test_id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Object> instrlist = new List<Object>();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    Instructions instr = new Instructions();

                    instr.InstructionID = reader.GetInt32(0);
                    instr.InstructionText = reader.GetString(1);
                    instr.RefTestID = reader.GetInt32(2);

                    instrlist.Add(instr);
                }
            }
            reader.Close();
            return instrlist;
        }
        public void Delete(int id)
        {
            string query = @"
            DELETE FROM instruction
            WHERE Instruction_ID = @id
            ";

            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public void Update(Object obj)
        {
            Instructions instr = (Instructions)obj;
            string query = @"
            UPDATE instruction
            SET info = @Instruction_Text
            WHERE Instruction_ID = @Instruction_ID
            ";

            MySqlCommand cmd = CallStack(query);

            cmd.Parameters.AddWithValue("@Instruction_Text", instr.InstructionText);
            cmd.Parameters.AddWithValue("@Instruction_ID", instr.InstructionID);

            cmd.ExecuteNonQuery();
        }
        public Object Find(string t)
        {
            return null;
        }
        public Object Find(int id)
        {
               string query = @"
            SELECT *
            FROM instruction
            WHERE Instruction_ID = @id
            ";

            MySqlCommand cmd = CallStack(query);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            Instructions instr = new Instructions();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    instr.InstructionID = reader.GetInt32(0);
                    instr.InstructionText = reader.GetString(1);
                    instr.RefTestID = reader.GetInt32(2);
                }
            }
            reader.Close();
            return instr;
        }


    }
}
