namespace BugTrackingSystem
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportA = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStaffA = new System.Windows.Forms.Button();
            this.btnSolvedA = new System.Windows.Forms.Button();
            this.adminDataGrid = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.lblUname = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportA
            // 
            this.btnReportA.Location = new System.Drawing.Point(12, 151);
            this.btnReportA.Name = "btnReportA";
            this.btnReportA.Size = new System.Drawing.Size(106, 44);
            this.btnReportA.TabIndex = 2;
            this.btnReportA.Text = "View Reported Bug";
            this.btnReportA.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 418);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 28);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaffA
            // 
            this.btnStaffA.Location = new System.Drawing.Point(11, 44);
            this.btnStaffA.Name = "btnStaffA";
            this.btnStaffA.Size = new System.Drawing.Size(106, 47);
            this.btnStaffA.TabIndex = 4;
            this.btnStaffA.Text = "Staff Details";
            this.btnStaffA.UseVisualStyleBackColor = true;
            this.btnStaffA.Click += new System.EventHandler(this.btnStaffA_Click);
            // 
            // btnSolvedA
            // 
            this.btnSolvedA.Location = new System.Drawing.Point(11, 97);
            this.btnSolvedA.Name = "btnSolvedA";
            this.btnSolvedA.Size = new System.Drawing.Size(106, 48);
            this.btnSolvedA.TabIndex = 5;
            this.btnSolvedA.Text = "View Solved Bug";
            this.btnSolvedA.UseVisualStyleBackColor = true;
            // 
            // adminDataGrid
            // 
            this.adminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGrid.Location = new System.Drawing.Point(140, 44);
            this.adminDataGrid.Name = "adminDataGrid";
            this.adminDataGrid.Size = new System.Drawing.Size(743, 402);
            this.adminDataGrid.TabIndex = 6;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(30, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(11, 201);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(106, 49);
            this.btnAddProject.TabIndex = 9;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(88, 13);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 13);
            this.lblUname.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 49);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Staff";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 485);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.adminDataGrid);
            this.Controls.Add(this.btnSolvedA);
            this.Controls.Add(this.btnStaffA);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReportA);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportA;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStaffA;
        private System.Windows.Forms.Button btnSolvedA;
        private System.Windows.Forms.DataGridView adminDataGrid;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Button btnDelete;
    }
}