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
    public partial class DeveloperPanel : Form
    {
        public static string staffID, fname, lname, add, contact, gender, email;
        public static int count;

        DatabaseConnection db = new DatabaseConnection();
        public DeveloperPanel()
        {
            InitializeComponent();
        }

        private void btnReportD_Click(object sender, EventArgs e)
        {
            ReportingBugDeveloper rbd = new ReportingBugDeveloper();
            rbd.Show();
        }

        public void reportDetails()
        {
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from report where Assign_To = '" + lblUname.Text + "'", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "report");
            deveGrid.DataSource = ds.Tables["report"];
            db.DBConnect.Close();
        }

        public void staffDetails()
        {
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from staff where Username = '" + Dashboard.usname + "'", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "staff");
            deveGrid.DataSource = ds.Tables["staff"];
            db.DBConnect.Close();
        }

    private void btnLogoutD_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void DeveloperPanel_Load(object sender, EventArgs e)
        {
            lblUname.Text = Dashboard.usname;
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from Project where Assign_To = '" + lblUname.Text + "'", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "Project");
            deveGrid.DataSource = ds.Tables["Project"];
            db.DBConnect.Close();
        }

        private void btnViewD_Click(object sender, EventArgs e)
        {
            reportDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (deveGrid.SelectedRows.Count > 0)
            {
                staffID = deveGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                fname = deveGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                lname = deveGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                add = deveGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                gender = deveGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                contact = deveGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                email = deveGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                count = deveGrid.SelectedRows.Count;

                //id = adminDataGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                //pname = adminDataGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                UpdateStaff update = new UpdateStaff();
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
