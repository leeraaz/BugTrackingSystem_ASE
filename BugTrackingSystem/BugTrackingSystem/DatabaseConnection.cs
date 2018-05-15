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

        public void DBConnection()
        {
            /*  server = "localhost";
              database = "bugtracker";
              uid = "root";
              pwd = "";*/
           string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bugtracker;";
            DBConnect = new MySqlConnection(connectionString);
        }

        
        public bool OpenConnection()
        {
            try
            {
                DBConnect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                DBConnect.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
