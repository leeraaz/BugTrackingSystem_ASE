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
    public partial class ReportingBugDeveloper : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public ReportingBugDeveloper()
        {
            InitializeComponent();
            fillComboProject();
            txtReportBy.Text = Dashboard.usname;
        }

        public void fillComboProject()
        {
            string projectSelect = "select * from project";
            db.DBConnect = db.DBConnection();
            MySqlCommand rec = new MySqlCommand(projectSelect, db.DBConnect);
            MySqlDataReader myreader = rec.ExecuteReader();
            try
            {
                while (myreader.Read())
                {
                    string projectName = myreader.GetString("Project_Name");
                    cmbProjectName.Items.Add(projectName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }

        private void btnCancelR_Click(object sender, EventArgs e)
        {
            DeveloperPanel dp = new DeveloperPanel();
            dp.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string proName = cmbProjectName.Text;
            string classes = txtClassFile.Text;
            string methods = txtMethod.Text;
            string line = txtLine.Text;
            string codes = txtcode.Text;
            string expected = txtExpectedResult.Text;
            string actual = txtActualResult.Text;
            string desc = txtDescription.Text;
            string status = cmbStatus.Text;
            string reportby = txtReportBy.Text;

            if (String.IsNullOrEmpty(proName) || String.IsNullOrEmpty(classes) || String.IsNullOrEmpty(methods) || String.IsNullOrEmpty(line) || String.IsNullOrEmpty(codes) ||
                String.IsNullOrEmpty(expected) || String.IsNullOrEmpty(actual) || String.IsNullOrEmpty(methods) || String.IsNullOrEmpty(desc) || String.IsNullOrEmpty(status) ||
                String.IsNullOrEmpty(reportby))
            {
                MessageBox.Show("All the field should be filled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string report = "insert into report(Project_Name,Class_File,Method,Line_Number,Code,Expected_Result,Actual_Result,Description,Status,Report_By)" +
                                    "values('" + proName + "','" + classes + "','" + methods + "','" + line + "','" + codes + "','" + expected + "','" + actual + "','" + desc + "','" + status + "','" + reportby + "');";

                db.DBConnect = db.DBConnection();
                MySqlCommand myReport = new MySqlCommand(report, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = myReport.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Bug has been reported.");
                    }
                    else
                    {
                        MessageBox.Show("Data not inserted.");
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
                txtClassFile.Clear();
                txtMethod.Clear();
                txtLine.Clear();
                txtExpectedResult.Clear();
                txtActualResult.Clear();
                txtDescription.Clear();
            }
        }
    }
}
