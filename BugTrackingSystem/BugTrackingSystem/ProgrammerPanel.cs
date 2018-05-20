using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class ProgrammerPanel : Form
    {
        public ProgrammerPanel()
        {
            InitializeComponent();
        }

        private void btnLogoutD_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void btnReportD_Click(object sender, EventArgs e)
        {
            ReportingBugDeveloper report = new ReportingBugDeveloper();
            report.Show();
            this.Hide();
        }

        private void ProgrammerPanel_Load(object sender, EventArgs e)
        {
            lblUname.Text = Dashboard.usname;
        }
    }
}
