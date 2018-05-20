namespace BugTrackingSystem
{
    partial class TesterPanel
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
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReportT = new System.Windows.Forms.Button();
            this.btnLogoutT = new System.Windows.Forms.Button();
            this.testGrid = new System.Windows.Forms.DataGridView();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(12, 173);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(127, 44);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log History";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReportT
            // 
            this.btnReportT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportT.Location = new System.Drawing.Point(12, 103);
            this.btnReportT.Name = "btnReportT";
            this.btnReportT.Size = new System.Drawing.Size(127, 44);
            this.btnReportT.TabIndex = 3;
            this.btnReportT.Text = "View Reported Bug";
            this.btnReportT.UseVisualStyleBackColor = true;
            this.btnReportT.Click += new System.EventHandler(this.btnReportT_Click);
            // 
            // btnLogoutT
            // 
            this.btnLogoutT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutT.Location = new System.Drawing.Point(12, 376);
            this.btnLogoutT.Name = "btnLogoutT";
            this.btnLogoutT.Size = new System.Drawing.Size(127, 44);
            this.btnLogoutT.TabIndex = 4;
            this.btnLogoutT.Text = "Logout";
            this.btnLogoutT.UseVisualStyleBackColor = true;
            this.btnLogoutT.Click += new System.EventHandler(this.btnLogoutT_Click);
            // 
            // testGrid
            // 
            this.testGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGrid.Location = new System.Drawing.Point(145, 62);
            this.testGrid.Name = "testGrid";
            this.testGrid.Size = new System.Drawing.Size(660, 407);
            this.testGrid.TabIndex = 6;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(141, 20);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 20);
            this.lblUname.TabIndex = 14;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(36, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(82, 20);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(605, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(12, 239);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(127, 44);
            this.btnProfile.TabIndex = 17;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 44);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TesterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 488);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.testGrid);
            this.Controls.Add(this.btnLogoutT);
            this.Controls.Add(this.btnReportT);
            this.Controls.Add(this.btnLog);
            this.Name = "TesterPanel";
            this.Load += new System.EventHandler(this.TesterPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReportT;
        private System.Windows.Forms.Button btnLogoutT;
        private System.Windows.Forms.DataGridView testGrid;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnUpdate;
    }
}