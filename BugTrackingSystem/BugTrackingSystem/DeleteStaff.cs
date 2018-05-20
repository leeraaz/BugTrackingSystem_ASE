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
    public partial class DeleteStaff : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public DeleteStaff()
        {
            InitializeComponent();
            getStaffDetails();
        }

        private void bnBack_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Close();
        }

        private void getStaffDetails()
        {
            txtStaffID.Text = AdminPanel.staffid;
            txtFirstName.Text = AdminPanel.fname;
            txtLastName.Text = AdminPanel.lname;
            txtAdd.Text = AdminPanel.add;
            txtGender.Text = AdminPanel.gender;
            txtDOB.Text = AdminPanel.dob;
            txtContact.Text = AdminPanel.contact;
            txtEmail.Text = AdminPanel.email;
            txtUserType.Text = AdminPanel.usertype;
            txtUsernameR.Text = AdminPanel.user;
            txtPasswordR.Text = AdminPanel.pass;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sid = txtStaffID.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string add = txtAdd.Text;
            string gender = txtGender.Text;
            string dob = txtDOB.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string usertype = txtUserType.Text;
            string uname = txtUsernameR.Text;
            string pass = txtPasswordR.Text;

            string del = "delete from staff where Staff_ID = '" + sid + "'";

            db.DBConnect = db.DBConnection();
            MySqlCommand delcommand = new MySqlCommand(del, db.DBConnect);
            try
            {
                int count = delcommand.ExecuteNonQuery();
                if(count > 0)
                {
                    MessageBox.Show("Staff has been deleted sucessfully.");
                }
                else
                {
                    MessageBox.Show("Staff cannot be deleted.");
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }
    }
}
