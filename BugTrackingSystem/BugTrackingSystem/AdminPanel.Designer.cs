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
            this.SuspendLayout();
            // 
            // btnReportA
            // 
            this.btnReportA.Location = new System.Drawing.Point(12, 107);
            this.btnReportA.Name = "btnReportA";
            this.btnReportA.Size = new System.Drawing.Size(106, 44);
            this.btnReportA.TabIndex = 2;
            this.btnReportA.Text = "View Reported Bug";
            this.btnReportA.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(89, 168);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 44);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnStaffA
            // 
            this.btnStaffA.Location = new System.Drawing.Point(89, 46);
            this.btnStaffA.Name = "btnStaffA";
            this.btnStaffA.Size = new System.Drawing.Size(106, 44);
            this.btnStaffA.TabIndex = 4;
            this.btnStaffA.Text = "Staff Details";
            this.btnStaffA.UseVisualStyleBackColor = true;
            // 
            // btnSolvedA
            // 
            this.btnSolvedA.Location = new System.Drawing.Point(166, 107);
            this.btnSolvedA.Name = "btnSolvedA";
            this.btnSolvedA.Size = new System.Drawing.Size(106, 44);
            this.btnSolvedA.TabIndex = 5;
            this.btnSolvedA.Text = "View Solved Bug";
            this.btnSolvedA.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSolvedA);
            this.Controls.Add(this.btnStaffA);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReportA);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportA;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStaffA;
        private System.Windows.Forms.Button btnSolvedA;
    }
}