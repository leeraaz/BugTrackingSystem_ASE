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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnViewProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportA
            // 
            this.btnReportA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportA.Location = new System.Drawing.Point(12, 135);
            this.btnReportA.Name = "btnReportA";
            this.btnReportA.Size = new System.Drawing.Size(173, 32);
            this.btnReportA.TabIndex = 2;
            this.btnReportA.Text = "View Reported Bug";
            this.btnReportA.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(11, 317);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaffA
            // 
            this.btnStaffA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffA.Location = new System.Drawing.Point(12, 66);
            this.btnStaffA.Name = "btnStaffA";
            this.btnStaffA.Size = new System.Drawing.Size(173, 28);
            this.btnStaffA.TabIndex = 4;
            this.btnStaffA.Text = "Staff Details";
            this.btnStaffA.UseVisualStyleBackColor = true;
            this.btnStaffA.Click += new System.EventHandler(this.btnStaffA_Click);
            // 
            // btnSolvedA
            // 
            this.btnSolvedA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolvedA.Location = new System.Drawing.Point(12, 100);
            this.btnSolvedA.Name = "btnSolvedA";
            this.btnSolvedA.Size = new System.Drawing.Size(173, 29);
            this.btnSolvedA.TabIndex = 5;
            this.btnSolvedA.Text = "View Solved Bug";
            this.btnSolvedA.UseVisualStyleBackColor = true;
            this.btnSolvedA.Click += new System.EventHandler(this.btnSolvedA_Click);
            // 
            // adminDataGrid
            // 
            this.adminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGrid.Location = new System.Drawing.Point(191, 44);
            this.adminDataGrid.Name = "adminDataGrid";
            this.adminDataGrid.Size = new System.Drawing.Size(692, 402);
            this.adminDataGrid.TabIndex = 6;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(82, 20);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(12, 173);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(173, 30);
            this.btnAddProject.TabIndex = 9;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(136, 9);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 20);
            this.lblUname.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(11, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Staff";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(683, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProject.Location = new System.Drawing.Point(12, 281);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(173, 30);
            this.btnDeleteProject.TabIndex = 13;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnViewProject
            // 
            this.btnViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProject.Location = new System.Drawing.Point(11, 209);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(173, 30);
            this.btnViewProject.TabIndex = 14;
            this.btnViewProject.Text = "View Project";
            this.btnViewProject.UseVisualStyleBackColor = true;
            this.btnViewProject.Click += new System.EventHandler(this.btnViewProject_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 485);
            this.Controls.Add(this.btnViewProject);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnViewProject;
    }
}