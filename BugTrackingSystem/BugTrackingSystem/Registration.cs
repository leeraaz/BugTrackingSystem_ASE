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
            string gender;
            string dob = datePick.Text;
            string contact = Convert.ToString(txtContact.Text);
            string email = Convert.ToString(txtEmail.Text);
            string usertype = Convert.ToString(cmbUserType.Text);
            string uname = Convert.ToString(txtUsernameR.Text);
            string pwd = Convert.ToString(txtPasswordR.Text);
            string rpwd = Convert.ToString(txtRePassword.PasswordChar);

            if (radioMale.Checked)
            {
                gender = radioMale.Text;
            }
            else if (radioFemale.Checked)
            {
                gender = radioFemale.Text;
            }
            else if (radioOther.Checked)
            {
                gender = radioOther.Text;
            }
            else
            {
                gender = null;
            }

            //Registration validation for empty fields.
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdd.Focus();
            }
            else if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioMale.Focus();
            }
            else if (string.IsNullOrEmpty(dob))
            {
                MessageBox.Show("Date of birth cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datePick.Focus();
            }
            else if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Contact number cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContact.Focus();
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(usertype))
            {
                MessageBox.Show("User type cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUserType.Focus();
            }
            else if (string.IsNullOrEmpty(uname))
            {
                MessageBox.Show("Username cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsernameR.Focus();
            }
            else if(string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Password cannot be empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswordR.Focus();
            }
        
            else if (txtPasswordR.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password not matched.");
                txtPasswordR.Clear();
                txtRePassword.Clear();
                txtPasswordR.Focus();
            }
            else if(cmbUserType.Text == "Admin")
            {
                string checkusertype = cmbUserType.Text;
                string sqlcmd = "select User_Type from staff where User_Type = '" + checkusertype + "'";

                db.DBConnect = db.DBConnection();
                MySqlCommand ret = new MySqlCommand(sqlcmd, db.DBConnect);
                MySqlDataReader reader = ret.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show(checkusertype + " cannot be used because Admin has been already identified.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string checkuser = txtUsernameR.Text;
                string sqlcmd = "select Username from staff where Username = '" + checkuser + "'";
                             
                db.DBConnect = db.DBConnection();
                MySqlCommand ret = new MySqlCommand(sqlcmd, db.DBConnect);
                MySqlDataReader reader = ret.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show(checkuser + " alreadt in use. Try another user name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsernameR.Clear();
                    txtPasswordR.Clear();
                    txtRePassword.Clear();
                    txtUsernameR.Focus();
                }
                else
                {
                    //MessageBox.Show("First Name " + firstName + " Last name " + lastName + " address " + address + " gender " + gender +
                    //                " DOB " + dob + " contact " + contact + " email " + email + " usertype " + usertype + " username " + uname + " password " + pwd);

                    string query = "insert into staff(First_Name,Last_Name,Address,Gender,Date_of_Birth,Contact_No,Email,User_Type,Username,Password)" +
                                    "values('" + firstName + "','" + lastName + "','" + address + "','" + gender + "','" + dob + "'," +
                                    "'" + contact + "','" + email + "','" + usertype + "','" + uname + "','" + pwd + "');";

                    db.DBConnect = db.DBConnection();
                    MySqlCommand cmd = new MySqlCommand(query, db.DBConnect);
                    try
                    {
                        //MySqlDataReader inscmd = cmd.ExecuteReader();
                        int num = cmd.ExecuteNonQuery();
                        if (num > 0)
                        {
                            MessageBox.Show("Staff inserted successfully.");                           
                        }
                        else
                        {
                            MessageBox.Show("Data not inserted.");
                        }
                    }
                    catch (MySqlException er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAdd.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    txtUsernameR.Clear();
                    txtPasswordR.Clear();
                    txtRePassword.Clear();
                }
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
