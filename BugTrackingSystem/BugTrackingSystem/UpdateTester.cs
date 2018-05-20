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
    public partial class UpdateTester : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public UpdateTester()
        {
            InitializeComponent();
        }
        private void UpdateTester_Load(object sender, EventArgs e)
        {
            txtSid.Text = TesterPanel.staffID;
            txtFirstName.Text = TesterPanel.fname;
            txtLastName.Text = TesterPanel.lname;
            txtAdd.Text = TesterPanel.add;
            txtGender.Text = TesterPanel.gender;
            txtDate.Text = TesterPanel.dob;
            txtContact.Text = TesterPanel.contact;
            txtEmail.Text = TesterPanel.email;
            txtUsertype.Text = TesterPanel.usertype;
            txtUsernameR.Text = TesterPanel.user;
            txtPasswordR.Text = TesterPanel.pass;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TesterPanel tp = new TesterPanel();
            tp.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sid = txtSid.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string add = txtAdd.Text;
            string gender = txtGender.Text;
            string dob = txtDate.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string usertype = txtUsertype.Text;
            string usern = txtUsernameR.Text;
            string passd = txtPasswordR.Text;

            string update = "update staff set First_Name = '" + fname + "',Last_Name = '" + lname + "',Address = '" + add + "',Gender = '" + gender + "'Contact_No = '" + contact + "',Email = '" + email + "',User_Type = '" + usertype + "'Username = '" + usern + "',Password = '" + passd + "' where Staff_ID = '" + sid + "';";
            db.DBConnect = db.DBConnection();
            MySqlCommand updatecommand = new MySqlCommand(update, db.DBConnect);
            try
            {
                int count = updatecommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("The details have been updated.");
                }
                else
                {
                    MessageBox.Show("The details cannot be updated. Try Again!!!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                txtPasswordR.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordR.UseSystemPasswordChar = false;
            }
        }
    }
}
