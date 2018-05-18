using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace BugTrackingSystem
{
    public partial class Dashboard : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // string sql = "select User_type,Username,Password from staff where Username ='" + user + "' and Password ='" + pass + "'";
            //string sql = "select  Username, Password from testuser where Username='" + user + "' and Password='" + pass + "'";
            //string sql = "insert into testuser(Username,Password) values('" + user + "','" + pass + "')";

            db.DBConnect = db.DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select User_type,Username,Password from staff where Username ='" + user + "' and Password ='" + pass + "'", db.DBConnect);
            // MySqlCommand ret = new MySqlCommand(sql, db.DBConnect);
            //MySqlDataReader reader = ret.ExecuteReader();
            //int count = reader.HasRows;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string utype;
                utype = table.Rows[0][0].ToString();
               // MessageBox.Show("User type is " + utype);
                if (utype == "Admin")
                {
                    //MessageBox.Show("User inserted.");
                    user = txtUsername.Text;
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    ap.txtLogUser.Text = user;
                    this.Hide();
                }
                else if (utype == "Programmer")
                {
                    //MessageBox.Show("You are a Programmer");
                    user = txtUsername.Text;
                    ProgrammerPanel ap = new ProgrammerPanel();
                    ap.Show();
                   // ap.txtLogUser.Text = user;
                    this.Hide();
                }
                else if (utype == "Developer")
                {
                    //MessageBox.Show("You are a Developer ");
                    user = txtUsername.Text;
                    DeveloperPanel ap = new DeveloperPanel();
                    ap.Show();
                   // ap.txtLogUser.Text = user;
                    this.Hide();
                }
                else if (utype == "Tester")
                {
                    //MessageBox.Show("You are a Tester");
                    user = txtUsername.Text;
                    TesterPanel ap = new TesterPanel();
                    ap.Show();
                    //ap.txtLogUser.Text = user;
                    this.Hide();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
