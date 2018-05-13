using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    public class DatabaseConnection
    {
        public void DBConnection()
        {
            string connectionString;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connectionString = "Data Source=localhost;Database = 'bugtracker';User ID='';Password=''";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand();  
        }
    }
}
