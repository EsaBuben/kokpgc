
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this is the class needed for the connection
// to add this Tools -> NuGet Package Manager -> Package Manager Console -> Install-Package MySql.Data
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace TestIt
{
    class SqlExample
    {
        static void Main(string[] args)
        {
            // This is used to make the actual connection, change the details as needed, if using XAMPP, you can check the port from the UI
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testirekisteri;port=3306;password=;");
            connection.Open();

            // Save the query to a string and add easily identifiable placeholders for variables (here @value1 and @value2
            string query = "INSERT INTO movie (movie_name, movie_year) VALUES (@value1, @value2)";
            string query2 = "CREATE TABLE If NOT EXISTS movie (movie_id INT NOT NULL AUTO_INCREMENT, movie_name VARCHAR(100) NOT NULL, movie_year INT NOT NULL, PRIMARY KEY (movie_id))";
            // Form the object to be used to run the actual query
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);

            // set the values for the variables
            MySqlCommand cmd = new MySqlCommand(query, connection);
            // set the values for the variables
            cmd.Parameters.AddWithValue("@value1", "Wild Bunch");
            cmd.Parameters.AddWithValue("@value2", 1968);

            // execute the query, the weird name implies that there is no expectation of returning anything from the database, but data is inserted
            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            query = "SELECT movie_name, movie_year FROM movie WHERE movie_year<@value ORDER BY movie_year";

            cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@value", 1970);

            // Now we are looking to get information from the database, so we make and run a DataReader
            MySqlDataReader reader = cmd.ExecuteReader();

            // checking that there are rows in the results
            if (reader.HasRows)
            {
                // using while loop to go through each row in the result - Read() returns one row and moves the internal pointer to the next row
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetString(0),
                        reader.GetInt32(1));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
        }
    }
}
