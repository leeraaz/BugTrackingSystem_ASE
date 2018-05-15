using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    public partial class Registration : Form
    {
        DatabaseConnection ins = new DatabaseConnection();
        public Registration()
        {
            InitializeComponent();
        }

        public MySqlConnection DBConnect { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            string firstName = Convert.ToString(txtFirstName.Text);
            string lastName = Convert.ToString(txtLastName.Text);
            string address = Convert.ToString(txtAdd.Text);
            string gender = Convert.ToString(radioFemale.Text);
            string dob = Convert.ToString(datePick.Text);
            string contact = Convert.ToString(txtContact.Text);
            string email = Convert.ToString(txtContact.Text);
            string uname = Convert.ToString(txtEmail.Text);
            string pwd = Convert.ToString(txtPasswordR.Text);
            string rpwd = Convert.ToString(txtRePassword.Text);

            //MessageBox.Show("First Name" + firstName);
            string query = "insert into testUser (Username,Password) values (" + uname + "," + pwd + ");";
            ins.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, DBConnect);
            MySqlDataReader inscmd = cmd.ExecuteReader();

            MessageBox.Show("User inserted successfully");
            
        }
    }
}
