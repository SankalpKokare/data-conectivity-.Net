using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnection_Connected
{
    //Added Nuget Package 'MySqlConnector'
    internal class ConnectorMySql
    {

        static string cs = "server=localhost;uid=root;password=root;database=sakila";

        public static void displayAllCustomer()
        {


            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "select * from customer";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Console.WriteLine(reader["first_name"].ToString() + " " + reader["last_name"].ToString());
                        }

                    }
                }

            }

        }

        public static void Main()
        {
            displayAllCustomer();
        }
    }
    
}
