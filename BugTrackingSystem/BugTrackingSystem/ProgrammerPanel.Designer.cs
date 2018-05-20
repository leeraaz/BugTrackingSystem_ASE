namespace BugTrackingSystem
{
    partial class ProgrammerPanel
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
            this.proGrid = new System.Windows.Forms.DataGridView();
            this.btnLogoutD = new System.Windows.Forms.Button();
            this.btnViewD = new System.Windows.Forms.Button();
            this.btnReportD = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnUpdate021 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // proGrid
            // 
            this.proGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proGrid.Location = new System.Drawing.Point(140, 57);
            this.proGrid.Name = "proGrid";
            this.proGrid.Size = new System.Drawing.Size(718, 449);
            this.proGrid.TabIndex = 7;
            // 
            // btnLogoutD
            // 
            this.btnLogoutD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutD.Location = new System.Drawing.Point(12, 253);
            this.btnLogoutD.Name = "btnLogoutD";
            this.btnLogoutD.Size = new System.Drawing.Size(122, 32);
            this.btnLogoutD.TabIndex = 6;
            this.btnLogoutD.Text = "Logout";
            this.btnLogoutD.UseVisualStyleBackColor = true;
            this.btnLogoutD.Click += new System.EventHandler(this.btnLogoutD_Click);
            // 
            // btnViewD
            // 
            this.btnViewD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewD.Location = new System.Drawing.Point(12, 139);
            this.btnViewD.Name = "btnViewD";
            this.btnViewD.Size = new System.Drawing.Size(122, 32);
            this.btnViewD.TabIndex = 5;
            this.btnViewD.Text = "View Reported Bug";
            this.btnViewD.UseVisualStyleBackColor = true;
            this.btnViewD.Click += new System.EventHandler(this.btnViewD_Click);
            // 
            // btnReportD
            // 
            this.btnReportD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportD.Location = new System.Drawing.Point(12, 100);
            this.btnReportD.Name = "btnReportD";
            this.btnReportD.Size = new System.Drawing.Size(122, 33);
            this.btnReportD.TabIndex = 4;
            this.btnReportD.Text = "Report Bug";
            this.btnReportD.UseVisualStyleBackColor = true;
            this.btnReportD.Click += new System.EventHandler(this.btnReportD_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(82, 20);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(118, 19);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 20);
            this.lblUname.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(649, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(12, 177);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(122, 32);
            this.btnProfile.TabIndex = 14;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnUpdate021
            // 
            this.btnUpdate021.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate021.Location = new System.Drawing.Point(12, 215);
            this.btnUpdate021.Name = "btnUpdate021";
            this.btnUpdate021.Size = new System.Drawing.Size(122, 32);
            this.btnUpdate021.TabIndex = 15;
            this.btnUpdate021.Text = "Update Profile";
            this.btnUpdate021.UseVisualStyleBackColor = true;
            this.btnUpdate021.Click += new System.EventHandler(this.btnUpdate021_Click);
            // 
            // ProgrammerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 511);
            this.Controls.Add(this.btnUpdate021);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.proGrid);
            this.Controls.Add(this.btnLogoutD);
            this.Controls.Add(this.btnViewD);
            this.Controls.Add(this.btnReportD);
            this.Name = "ProgrammerPanel";
            this.Text = "ProgrammerPanel";
            this.Load += new System.EventHandler(this.ProgrammerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proGrid;
        private System.Windows.Forms.Button btnLogoutD;
        private System.Windows.Forms.Button btnViewD;
        private System.Windows.Forms.Button btnReportD;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnUpdate021;
    }
}