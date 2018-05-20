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
    public partial class ProgrammerPanel : Form
    {
        public static string staffID, fname, lname, add, gender, dob,contact, email, usertype, user,pass;
        public static int count;

        DatabaseConnection db = new DatabaseConnection();
        public ProgrammerPanel()
        {
            InitializeComponent();
        }

        public void staffDetails()
        {
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from staff where Username = '" + Dashboard.usname + "'", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "staff");
            proGrid.DataSource = ds.Tables["staff"];
            db.DBConnect.Close();
        }

        private void btnLogoutD_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void btnReportD_Click(object sender, EventArgs e)
        {
            ReportingBugDeveloper report = new ReportingBugDeveloper();
            report.Show();
            this.Hide();
        }

        private void ProgrammerPanel_Load(object sender, EventArgs e)
        {
            lblUname.Text = Dashboard.usname;
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from Project where Assign_To = '" + lblUname.Text + "'", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "Project");
            proGrid.DataSource = ds.Tables["Project"];
            db.DBConnect.Close();
        }

        private void btnViewD_Click(object sender, EventArgs e)
        {
            BugFix bf = new BugFix();
            bf.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            staffDetails();
        }

        private void btnUpdate021_Click(object sender, EventArgs e)
        {
            if (proGrid.SelectedRows.Count > 0)
            {
                staffID = proGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                fname = proGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                lname = proGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                add = proGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                gender = proGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                dob = proGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                contact = proGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                email = proGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                usertype = proGrid.SelectedRows[0].Cells[8].Value + string.Empty;
                user = proGrid.SelectedRows[0].Cells[9].Value + string.Empty;
                pass = proGrid.SelectedRows[0].Cells[10].Value + string.Empty;
                count = proGrid.SelectedRows.Count;

                UpdateProgrammer update = new UpdateProgrammer();
                update.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need a select a row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
