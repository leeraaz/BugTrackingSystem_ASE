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
            this.SuspendLayout();
            // 
            // btnReportD
            // 
            this.btnReportD.Location = new System.Drawing.Point(96, 46);
            this.btnReportD.Name = "btnReportD";
            this.btnReportD.Size = new System.Drawing.Size(106, 47);
            this.btnReportD.TabIndex = 0;
            this.btnReportD.Text = "Report Bug";
            this.btnReportD.UseVisualStyleBackColor = true;
            // 
            // btnViewD
            // 
            this.btnViewD.Location = new System.Drawing.Point(96, 120);
            this.btnViewD.Name = "btnViewD";
            this.btnViewD.Size = new System.Drawing.Size(106, 44);
            this.btnViewD.TabIndex = 1;
            this.btnViewD.Text = "View Reported Bug";
            this.btnViewD.UseVisualStyleBackColor = true;
            // 
            // btnLogoutD
            // 
            this.btnLogoutD.Location = new System.Drawing.Point(96, 181);
            this.btnLogoutD.Name = "btnLogoutD";
            this.btnLogoutD.Size = new System.Drawing.Size(106, 44);
            this.btnLogoutD.TabIndex = 2;
            this.btnLogoutD.Text = "Logout";
            this.btnLogoutD.UseVisualStyleBackColor = true;
            // 
            // DeveloperPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogoutD);
            this.Controls.Add(this.btnViewD);
            this.Controls.Add(this.btnReportD);
            this.Name = "DeveloperPanel";
            this.Text = "DeveloperPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportD;
        private System.Windows.Forms.Button btnViewD;
        private System.Windows.Forms.Button btnLogoutD;
    }
}