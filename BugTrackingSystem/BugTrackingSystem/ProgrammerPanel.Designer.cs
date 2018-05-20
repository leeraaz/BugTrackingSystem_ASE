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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogoutD = new System.Windows.Forms.Button();
            this.btnViewD = new System.Windows.Forms.Button();
            this.btnReportD = new System.Windows.Forms.Button();
            this.txtSearchT = new System.Windows.Forms.TextBox();
            this.lblSearchP = new System.Windows.Forms.Label();
            this.btnGoP = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 431);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnLogoutD
            // 
            this.btnLogoutD.Location = new System.Drawing.Point(12, 191);
            this.btnLogoutD.Name = "btnLogoutD";
            this.btnLogoutD.Size = new System.Drawing.Size(106, 44);
            this.btnLogoutD.TabIndex = 6;
            this.btnLogoutD.Text = "Logout";
            this.btnLogoutD.UseVisualStyleBackColor = true;
            this.btnLogoutD.Click += new System.EventHandler(this.btnLogoutD_Click);
            // 
            // btnViewD
            // 
            this.btnViewD.Location = new System.Drawing.Point(12, 117);
            this.btnViewD.Name = "btnViewD";
            this.btnViewD.Size = new System.Drawing.Size(106, 44);
            this.btnViewD.TabIndex = 5;
            this.btnViewD.Text = "View Reported Bug";
            this.btnViewD.UseVisualStyleBackColor = true;
            // 
            // btnReportD
            // 
            this.btnReportD.Location = new System.Drawing.Point(12, 46);
            this.btnReportD.Name = "btnReportD";
            this.btnReportD.Size = new System.Drawing.Size(106, 47);
            this.btnReportD.TabIndex = 4;
            this.btnReportD.Text = "Report Bug";
            this.btnReportD.UseVisualStyleBackColor = true;
            this.btnReportD.Click += new System.EventHandler(this.btnReportD_Click);
            // 
            // txtSearchT
            // 
            this.txtSearchT.Location = new System.Drawing.Point(654, 20);
            this.txtSearchT.Name = "txtSearchT";
            this.txtSearchT.Size = new System.Drawing.Size(136, 20);
            this.txtSearchT.TabIndex = 10;
            // 
            // lblSearchP
            // 
            this.lblSearchP.AutoSize = true;
            this.lblSearchP.Location = new System.Drawing.Point(598, 22);
            this.lblSearchP.Name = "lblSearchP";
            this.lblSearchP.Size = new System.Drawing.Size(41, 13);
            this.lblSearchP.TabIndex = 9;
            this.lblSearchP.Text = "Search";
            // 
            // btnGoP
            // 
            this.btnGoP.Location = new System.Drawing.Point(805, 17);
            this.btnGoP.Name = "btnGoP";
            this.btnGoP.Size = new System.Drawing.Size(43, 23);
            this.btnGoP.TabIndex = 8;
            this.btnGoP.Text = "GO";
            this.btnGoP.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(72, 13);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 13);
            this.lblUname.TabIndex = 12;
            // 
            // ProgrammerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 526);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtSearchT);
            this.Controls.Add(this.lblSearchP);
            this.Controls.Add(this.btnGoP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogoutD);
            this.Controls.Add(this.btnViewD);
            this.Controls.Add(this.btnReportD);
            this.Name = "ProgrammerPanel";
            this.Text = "ProgrammerPanel";
            this.Load += new System.EventHandler(this.ProgrammerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogoutD;
        private System.Windows.Forms.Button btnViewD;
        private System.Windows.Forms.Button btnReportD;
        private System.Windows.Forms.TextBox txtSearchT;
        private System.Windows.Forms.Label lblSearchP;
        private System.Windows.Forms.Button btnGoP;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUname;
    }
}