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
    public partial class BugFix : Form
    {
        public static string usname;
        DatabaseConnection db = new DatabaseConnection();

        public BugFix()
        {
            InitializeComponent();
            fillComboProject();
        }

        public void fillComboProject()
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

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userselect = "select * from report where Project_Name = '" + cmbProject.Text +"'";
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
                    string line = myreader.GetInt32("Line_Number").ToString();
                    string code = myreader.GetString("Code");
                    string expected = myreader.GetString("Expected_Result");
                    string actual = myreader.GetString("Actual_Result");
                    string desc = myreader.GetString("Description");
                    string status = myreader.GetString("Status");
                    string report = myreader.GetString("Report_By");

                    lblReportID.Text = reportID;
                    txtProject.Text = project;
                    txtClassFile.Text = classs;
                    txtMethod.Text = methods;
                    txtLine.Text = line;
                    txtcode.Text = code;
                    txtExpectedResult.Text = expected;
                    txtActualResult.Text = actual;
                    txtDescription.Text = desc;
                    cmbStatus.Text = status;
                    txtReportBy.Text = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BugFix_Load(object sender, EventArgs e)
        {
            lblFixer.Text = Dashboard.usname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reportID = lblReportID.Text;
            string projectName = txtProject.Text;
            string clases = txtClassFile.Text;
            string methods = txtMethod.Text;
            string line = txtLine.Text;
            string code = txtcode.Text;
            string expected = txtExpectedResult.Text;
            string act = txtActualResult.Text;
            string desc = txtDescription.Text;
            string status = cmbStatus.Text;
            string report = txtReportBy.Text;

            string updateReport = "update report set Project_Name = '" + projectName + "',Class_File = '" + clases + "',Method = '" + methods + "',Line_Number = '" + line + "',Code = '" + code + "',Expected_Result = '" + expected + "',Actual_Result = '" + act + "',Description = '" + desc + "',Status = '" + status + "',Report_By = '" + report + "' where Report_ID = '" + reportID + "';";
            db.DBConnect = db.DBConnection();
            MySqlCommand updatecommand = new MySqlCommand(updateReport, db.DBConnect);
            try
            {
                int count = updatecommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("The report have been updated.");
                }
                else
                {
                    MessageBox.Show("The report cannot be updated. Try Again!!!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string reportID = lblReportID.Text;
            string projectName = txtProject.Text;
            string clases = txtClassFile.Text;
            string methods = txtMethod.Text;
            string line = txtLine.Text;
            string code = txtcode.Text;
            string reportby = txtReportBy.Text;
            string fixedby = lblFixer.Text;
            string fixdate = dateFix.Text;
            string desc = txtDescription.Text;

          //  string status = cmbStatus.Text;

            if(String.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please fill all the required fields.");
            }
            else if(cmbStatus.Text == "Completed")
            {
                string insertFix = "insert into fixed_bug (Report_ID,Project_Name,Class_File,Method,Code,Report_By,Fix_By,Fix_Date,Description)" +
                                    "values('" + reportID + "','" + projectName + "','" + clases + "','" + methods + "','" + code + "','" + reportby + "','" + fixedby + "','" + fixdate + "','" + desc + "')";

                db.DBConnect = db.DBConnection();
                MySqlCommand fixcmd = new MySqlCommand(insertFix, db.DBConnect);

                try
                {
                    int count = fixcmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Inserted into log history.");
                    }
                    else
                    {
                        MessageBox.Show("Cannot insert into log history");
                    }
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
            {
                MessageBox.Show("The status of this project is not completed.","Message",MessageBoxButtons.OK,MessageBoxIcon.Hand);
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
                        usname = lblFixer.Text;
                        AdminPanel ap = new AdminPanel();
                        ap.Show();
                        this.Hide();
                    }
                    else if (users == "Programmer")
                    {
                        //MessageBox.Show("You are a Programmer");
                        usname = lblFixer.Text;
                        ProgrammerPanel ap = new ProgrammerPanel();
                        ap.Show();
                        this.Hide();
                    }
                    else if (users == "Developer")
                    {
                        //MessageBox.Show("You are a Developer ");
                        usname = lblFixer.Text;
                        DeveloperPanel ap = new DeveloperPanel();
                        ap.Show();
                        this.Hide();
                    }
                    else if (users == "Tester")
                    {
                        //MessageBox.Show("You are a Tester");
                        usname = lblFixer.Text;
                        TesterPanel ap = new TesterPanel();
                        ap.Show();
                        this.Hide();
                    }
                }
        }
    }
}
