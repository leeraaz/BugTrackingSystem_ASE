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
        DatabaseConnection db = new DatabaseConnection();
        public TesterPanel()
        {
            InitializeComponent();
        }

        public void viewReport()
        {
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from Project where Assign_To = '" + lblUname.Text + "'", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "Project");
            testGrid.DataSource = ds.Tables["Project"];
            db.DBConnect.Close();
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
            viewReport();
        }
    }
}
