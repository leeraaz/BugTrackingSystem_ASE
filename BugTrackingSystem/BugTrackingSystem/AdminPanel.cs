using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    public partial class AdminPanel : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
        }

        public void StaffDetails()
        {
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select First_Name,Last_Name,Address,Email from staff", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "staff");
            staffDetails.DataSource = ds.Tables["staff"];
            db.DBConnect.Close();
        }

        private void btnStaffA_Click(object sender, EventArgs e)
        {
            StaffDetails();
        }       
    }
}
