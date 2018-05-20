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
    public partial class TesterPanel : Form
    {
        public static string staffID, fname, lname, add, gender, dob, contact, email, usertype, user, pass;
        public static int count;

        DatabaseConnection db = new DatabaseConnection();
        public TesterPanel()
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
            testGrid.DataSource = ds.Tables["staff"];
            db.DBConnect.Close();
        }

        public void logHistory()
        {
            ViewFixBug vfb = new ViewFixBug();
            vfb.Show();
            this.Close();
        }

        private void btnLogoutT_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void TesterPanel_Load(object sender, EventArgs e)
        {
            lblUname.Text = Dashboard.usname;
        }

        private void btnReportT_Click(object sender, EventArgs e)
        {
            BugFix bf = new BugFix();
            bf.Show();
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            logHistory();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            staffDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (testGrid.SelectedRows.Count > 0)
            {
                staffID = testGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                fname = testGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                lname = testGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                add = testGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                gender = testGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                dob = testGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                contact = testGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                email = testGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                usertype = testGrid.SelectedRows[0].Cells[8].Value + string.Empty;
                user = testGrid.SelectedRows[0].Cells[9].Value + string.Empty;
                pass = testGrid.SelectedRows[0].Cells[10].Value + string.Empty;
                count = testGrid.SelectedRows.Count;

                UpdateTester update = new UpdateTester();
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
