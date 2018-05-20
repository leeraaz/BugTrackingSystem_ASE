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
    public partial class UpdateProgrammer : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public UpdateProgrammer()
        {
            InitializeComponent();
        }

        private void UpdateProgrammer_Load(object sender, EventArgs e)
        {
            txtSid.Text = ProgrammerPanel.staffID;
            txtFirstName.Text = ProgrammerPanel.fname;
            txtLastName.Text = ProgrammerPanel.lname;
            txtAdd.Text = ProgrammerPanel.add;
            txtGender.Text = ProgrammerPanel.gender;
            txtDate.Text = ProgrammerPanel.dob;
            txtContact.Text = ProgrammerPanel.contact;
            txtEmail.Text = ProgrammerPanel.email;
            txtUsertype.Text = ProgrammerPanel.usertype;
            txtUsernameR.Text = ProgrammerPanel.user;
            txtPasswordR.Text = ProgrammerPanel.pass;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProgrammerPanel pp = new ProgrammerPanel();
            pp.Show();
            this.Close();
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

            string updateOProg = "update staff set First_Name = '" + fname + 
                                                 "',Last_Name = '" + lname + 
                                                 "',Address = '" + add + 
                                                 "',Gender = '" + gender + 
                                                 "',Date_of_Birth = '" + dob + 
                                                 "',Contact_No = '" + contact + 
                                                 "',Email = '" + email + 
                                                 "',User_Type = '" + usertype + 
                                                 "',Username = '" + usern + 
                                                 "',Password = '" + passd + 
                                                 "' where Staff_ID = '" + sid + "';";
            db.DBConnect = db.DBConnection();
            MySqlCommand updatecommand = new MySqlCommand(updateOProg, db.DBConnect);
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
    }
}
