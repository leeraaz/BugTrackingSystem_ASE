namespace BugTrackingSystem
{
    partial class DeveloperPanel
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
            this.btnReportD = new System.Windows.Forms.Button();
            this.btnViewD = new System.Windows.Forms.Button();
            this.btnLogoutD = new System.Windows.Forms.Button();
            this.deveGrid = new System.Windows.Forms.DataGridView();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSolveBug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deveGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportD
            // 
            this.btnReportD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportD.Location = new System.Drawing.Point(12, 58);
            this.btnReportD.Name = "btnReportD";
            this.btnReportD.Size = new System.Drawing.Size(151, 35);
            this.btnReportD.TabIndex = 0;
            this.btnReportD.Text = "Report Bug";
            this.btnReportD.UseVisualStyleBackColor = true;
            this.btnReportD.Click += new System.EventHandler(this.btnReportD_Click);
            // 
            // btnViewD
            // 
            this.btnViewD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewD.Location = new System.Drawing.Point(12, 146);
            this.btnViewD.Name = "btnViewD";
            this.btnViewD.Size = new System.Drawing.Size(151, 32);
            this.btnViewD.TabIndex = 1;
            this.btnViewD.Text = "View Reported Bug";
            this.btnViewD.UseVisualStyleBackColor = true;
            this.btnViewD.Click += new System.EventHandler(this.btnViewD_Click);
            // 
            // btnLogoutD
            // 
            this.btnLogoutD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutD.Location = new System.Drawing.Point(12, 445);
            this.btnLogoutD.Name = "btnLogoutD";
            this.btnLogoutD.Size = new System.Drawing.Size(151, 32);
            this.btnLogoutD.TabIndex = 2;
            this.btnLogoutD.Text = "Logout";
            this.btnLogoutD.UseVisualStyleBackColor = true;
            this.btnLogoutD.Click += new System.EventHandler(this.btnLogoutD_Click);
            // 
            // deveGrid
            // 
            this.deveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deveGrid.Location = new System.Drawing.Point(189, 58);
            this.deveGrid.Name = "deveGrid";
            this.deveGrid.Size = new System.Drawing.Size(657, 431);
            this.deveGrid.TabIndex = 3;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(118, 15);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 20);
            this.lblUname.TabIndex = 14;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(82, 20);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(12, 281);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(151, 32);
            this.btnViewDetails.TabIndex = 16;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(631, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btnSolveBug
            // 
            this.btnSolveBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolveBug.Location = new System.Drawing.Point(12, 217);
            this.btnSolveBug.Name = "btnSolveBug";
            this.btnSolveBug.Size = new System.Drawing.Size(151, 32);
            this.btnSolveBug.TabIndex = 18;
            this.btnSolveBug.Text = "View Solved Bug";
            this.btnSolveBug.UseVisualStyleBackColor = true;
            this.btnSolveBug.Click += new System.EventHandler(this.btnSolveBug_Click);
            // 
            // DeveloperPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 501);
            this.Controls.Add(this.btnSolveBug);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.deveGrid);
            this.Controls.Add(this.btnLogoutD);
            this.Controls.Add(this.btnViewD);
            this.Controls.Add(this.btnReportD);
            this.Name = "DeveloperPanel";
            this.Text = "DeveloperPanel";
            this.Load += new System.EventHandler(this.DeveloperPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deveGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportD;
        private System.Windows.Forms.Button btnViewD;
        private System.Windows.Forms.Button btnLogoutD;
        private System.Windows.Forms.DataGridView deveGrid;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSolveBug;
    }
}