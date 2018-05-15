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
            this.btnSolvedT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(166, 102);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(106, 44);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log History";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnReportT
            // 
            this.btnReportT.Location = new System.Drawing.Point(89, 41);
            this.btnReportT.Name = "btnReportT";
            this.btnReportT.Size = new System.Drawing.Size(106, 44);
            this.btnReportT.TabIndex = 3;
            this.btnReportT.Text = "View Reported Bug";
            this.btnReportT.UseVisualStyleBackColor = true;
            // 
            // btnLogoutT
            // 
            this.btnLogoutT.Location = new System.Drawing.Point(89, 166);
            this.btnLogoutT.Name = "btnLogoutT";
            this.btnLogoutT.Size = new System.Drawing.Size(106, 44);
            this.btnLogoutT.TabIndex = 4;
            this.btnLogoutT.Text = "Logout";
            this.btnLogoutT.UseVisualStyleBackColor = true;
            // 
            // btnSolvedT
            // 
            this.btnSolvedT.Location = new System.Drawing.Point(12, 102);
            this.btnSolvedT.Name = "btnSolvedT";
            this.btnSolvedT.Size = new System.Drawing.Size(106, 44);
            this.btnSolvedT.TabIndex = 5;
            this.btnSolvedT.Text = "View Solved Bug";
            this.btnSolvedT.UseVisualStyleBackColor = true;
            // 
            // TesterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSolvedT);
            this.Controls.Add(this.btnLogoutT);
            this.Controls.Add(this.btnReportT);
            this.Controls.Add(this.btnLog);
            this.Name = "TesterPanel";
            this.Text = "TesterPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReportT;
        private System.Windows.Forms.Button btnLogoutT;
        private System.Windows.Forms.Button btnSolvedT;
    }
}