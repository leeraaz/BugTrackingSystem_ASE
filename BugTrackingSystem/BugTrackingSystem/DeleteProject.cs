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
    public partial class DeleteProject : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public DeleteProject()
        {
            InitializeComponent();
        }

        private void DeleteProject_Load(object sender, EventArgs e)
        {
            txtProjectID.Text = AdminPanel.projectid;
            txtProjectName.Text = AdminPanel.proName;
            txtSDate.Text = AdminPanel.sDate;
            txtEDate.Text = AdminPanel.eDate;
            txtPtype.Text = AdminPanel.pType;
            txtAss.Text = AdminPanel.assTO;
        } 

        private void btnCancelN_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string pid = txtProjectID.Text;
            string proName = txtProjectName.Text;
            string sdate = txtSDate.Text;
            string edate = txtEDate.Text;
            string ptype = txtPtype.Text;
            string assd = txtAss.Text;

            string del = "delete from project where Project_ID = '" + pid + "'";

            db.DBConnect = db.DBConnection();
            MySqlCommand delcommand = new MySqlCommand(del, db.DBConnect);
            try
            {
                int count = delcommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Project has been deleted sucessfully.");
                }
                else
                {
                    MessageBox.Show("Project cannot be deleted.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
