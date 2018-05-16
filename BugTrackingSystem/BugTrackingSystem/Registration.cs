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
        DatabaseConnection db = new DatabaseConnection();
        //MySqlConnection DBConnect;
        public Registration()
        {
            InitializeComponent();
        }
        

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
            string uname = txtUsernameR.Text;
            string pwd = txtPasswordR.Text;
            string rpwd = Convert.ToString(txtRePassword.Text);

            
            //MessageBox.Show("First Name" + firstName);
            string query = "insert into testuser(Username,Password) values('" + uname + "','" + pwd + "');";
            
            db.DBConnect = db.DBConnection();   
            MySqlCommand cmd = new MySqlCommand(query, db.DBConnect);
            try
            {
                //MySqlDataReader inscmd = cmd.ExecuteReader();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("User inserted successfully");
                }
                else
                {
                    MessageBox.Show("Data not inserted");
                }
            }
            catch(MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
