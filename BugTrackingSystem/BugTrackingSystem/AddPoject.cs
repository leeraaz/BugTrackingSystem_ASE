using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class AddPoject : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public AddPoject()
        {
            InitializeComponent();
            fillCombo();
        }

        public void fillCombo()
        {
            string userselect = "select * from staff";
            db.DBConnect = db.DBConnection();
            MySqlCommand ret = new MySqlCommand(userselect, db.DBConnect);
            MySqlDataReader myreader = ret.ExecuteReader();
            try
            {
                while (myreader.Read())
                {
                    string uName = myreader.GetString("First_Name");
                    cmbUser.Items.Add(uName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Close();
        }

        private void btnSaveN_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;
            string start = startDate.Text;
            string esti = estiDate.Text;
            string proType = cmbProjectType.Text;
            string assignTo = cmbUser.Text;

            if(String.IsNullOrEmpty(projectName) || String.IsNullOrEmpty(start) || String.IsNullOrEmpty(esti) || String.IsNullOrEmpty(proType) || String.IsNullOrEmpty(assignTo))
            {
                MessageBox.Show("All the field should be filled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string insertProject = "insert into project(Project_Name,Start_Date,Estimated_End_Date,Project_Type,Assign_To)" +
                                    "values('" + projectName + "','" + start + "','" + esti + "','" + proType + "','" + assignTo + "');";

                db.DBConnect = db.DBConnection();
                MySqlCommand myProcmd = new MySqlCommand(insertProject, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = myProcmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Project has been created.");
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
                txtProjectName.Clear();
            }
        }

        private void AddPoject_Load(object sender, EventArgs e)
        {

        }
    }
}
