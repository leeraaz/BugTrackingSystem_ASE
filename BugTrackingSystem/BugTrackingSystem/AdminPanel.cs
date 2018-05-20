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
        public static string staffid, fname, lname, add, gender, dob, contact, email, usertype, user, pass;

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

        public void StaffDetails()
        {
            db.DBConnect = db.DBConnection();
            //DataTable table = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select * from staff", db.DBConnect);

            DataSet ds = new DataSet();
            adpt.Fill(ds, "staff");
            adminDataGrid.DataSource = ds.Tables["staff"];
            db.DBConnect.Close();
        }

        private void btnStaffA_Click(object sender, EventArgs e)
        {
            StaffDetails();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddPoject addproject = new AddPoject();
            addproject.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lblUname.Text = Dashboard.usname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminDataGrid.SelectedRows.Count > 0)
            {
                staffid = adminDataGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                fname = adminDataGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                lname = adminDataGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                add = adminDataGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                gender = adminDataGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                dob = adminDataGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                contact = adminDataGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                email = adminDataGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                usertype = adminDataGrid.SelectedRows[0].Cells[8].Value + string.Empty;
                user = adminDataGrid.SelectedRows[0].Cells[9].Value + string.Empty;
                pass = adminDataGrid.SelectedRows[0].Cells[10].Value + string.Empty;
                
                DeleteStaff delete = new DeleteStaff();
                delete.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need a select a row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
