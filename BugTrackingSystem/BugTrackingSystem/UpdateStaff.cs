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
    public partial class UpdateStaff : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public UpdateStaff()
        {
            InitializeComponent();
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            txtID.Text = DeveloperPanel.staffID;
            txtFname.Text = DeveloperPanel.fname;
            txtLname.Text = DeveloperPanel.lname;
            txtAdd.Text = DeveloperPanel.add;
            txtGender.Text = DeveloperPanel.gender;
            txtContact.Text = DeveloperPanel.contact;
            txtEmail.Text = DeveloperPanel.email;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DeveloperPanel dep = new DeveloperPanel();
            dep.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sid = txtID.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string add = txtAdd.Text;
            string gender = txtGender.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;

            string update = "update staff set First_Name = '" + fname + "',Last_Name = '" + lname + "',Address = '" + add + "',Contact_No = '" + contact + "',Email = '" + email + "' where Staff_ID = '"+ sid +"';";
            db.DBConnect = db.DBConnection();
            MySqlCommand updatecommand = new MySqlCommand(update, db.DBConnect);
            try
            {
                int count = updatecommand.ExecuteNonQuery();
                if(count > 0)
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
