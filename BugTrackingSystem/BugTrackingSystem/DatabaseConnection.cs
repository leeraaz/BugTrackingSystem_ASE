using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public class DatabaseConnection
    {
        public MySqlConnection DBConnect;
        private string server;
        private string database;
        private string uid;
        private string pwd;

        public MySqlConnection DBConnection()
        {
            /*  server = "localhost";
              database = "bugtracker";
              uid = "root";
              pwd = "";*/
            string connectionString = "datasource=localhost;username=root;password=;database=bugtracker; SSLmode=none;";
            DBConnect = new MySqlConnection(connectionString);

            try
            {
                DBConnect.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return DBConnect;
        }
    }    
}
