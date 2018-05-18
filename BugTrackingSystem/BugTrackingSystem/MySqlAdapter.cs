using System;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    internal class MySqlAdapter
    {
        private Func<MySqlConnection> dBConnection;
        private string v;

        public MySqlAdapter(string v)
        {
            this.v = v;
        }

        public MySqlAdapter(string v, Func<MySqlConnection> dBConnection) : this(v)
        {
            this.dBConnection = dBConnection;
        }
    }
}