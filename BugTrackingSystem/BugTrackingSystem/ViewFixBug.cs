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

namespace BugTrackingSystem
{
    public partial class ViewFixBug : Form
    {
        public static string usname;

        DatabaseConnection db = new DatabaseConnection();
        public ViewFixBug()
        {
            InitializeComponent();
            fillComboReport();
        }

        private void ViewFixBug_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Dashboard.usname;
        }

        public void fillComboReport()
        {
            string userselect = "select * from report";
            db.DBConnect = db.DBConnection();
            MySqlCommand ret = new MySqlCommand(userselect, db.DBConnect);
            MySqlDataReader myreader = ret.ExecuteReader();
            try
            {
                while (myreader.Read())
                {
                    string project = myreader.GetString("Project_Name");
                    cmbProject.Items.Add(project);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string selectUser = "select * from staff where Username = '" + Dashboard.usname + "'";
            db.DBConnect = db.DBConnection();
            MySqlCommand usercmd = new MySqlCommand(selectUser, db.DBConnect);
            MySqlDataReader reader = usercmd.ExecuteReader();
            while (reader.Read())
            {
                string users = reader.GetString("User_Type");
                if (users == "Admin")
                {
                    //MessageBox.Show("User inserted.");
                    usname = lblUsername.Text;
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    this.Hide();
                }
                else if (users == "Programmer")
                {
                    //MessageBox.Show("You are a Programmer");
                    usname = lblUsername.Text;
                    ProgrammerPanel ap = new ProgrammerPanel();
                    ap.Show();
                    this.Hide();
                }
                else if (users == "Developer")
                {
                    //MessageBox.Show("You are a Developer ");
                    usname = lblUsername.Text;
                    DeveloperPanel ap = new DeveloperPanel();
                    ap.Show();
                    this.Hide();
                }
                else if (users == "Tester")
                {
                    //MessageBox.Show("You are a Tester");
                    usname = lblUsername.Text;
                    TesterPanel ap = new TesterPanel();
                    ap.Show();
                    this.Hide();
                }
            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userselect = "select * from fixed_bug where Project_Name = '" + cmbProject.Text + "'";
            db.DBConnect = db.DBConnection();
            MySqlCommand ret = new MySqlCommand(userselect, db.DBConnect);
            MySqlDataReader myreader = ret.ExecuteReader();
            try
            {
                while (myreader.Read())
                {
                    string reportID = myreader.GetInt32("Report_ID").ToString();
                    string project = myreader.GetString("Project_Name");
                    string classs = myreader.GetString("Class_File");
                    string methods = myreader.GetString("Method");
                    string code = myreader.GetString("Code");
                    string report = myreader.GetString("Report_By");
                    string fix = myreader.GetString("Fix_By");
                    string fixdate = myreader.GetString("Fix_Date");
                    string desc = myreader.GetString("Description");

                    txtReportID.Text = reportID;
                    txtProject.Text = project;
                    txtClassFile.Text = classs;
                    txtMethod.Text = methods;
                    txtcode.Text = code;
                    txtReportBy.Text = report;
                    txtFix.Text = fix;
                    txtDate.Text = fixdate;
                    txtDescription.Text = desc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
