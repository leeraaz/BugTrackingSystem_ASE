﻿using System;
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
    public partial class DeveloperPanel : Form
    {
        public DeveloperPanel()
        {
            InitializeComponent();
        }

        private void btnReportD_Click(object sender, EventArgs e)
        {
            ReportingBugDeveloper rbd = new ReportingBugDeveloper();
            rbd.Show();
        }

        private void btnLogoutD_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }
    }
}
