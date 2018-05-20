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
            this.testGrid = new System.Windows.Forms.DataGridView();
            this.lblSearchT = new System.Windows.Forms.Label();
            this.txtSearchT = new System.Windows.Forms.TextBox();
            this.btnGoT = new System.Windows.Forms.TextBox();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(12, 184);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(106, 44);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log History";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnReportT
            // 
            this.btnReportT.Location = new System.Drawing.Point(12, 93);
            this.btnReportT.Name = "btnReportT";
            this.btnReportT.Size = new System.Drawing.Size(106, 44);
            this.btnReportT.TabIndex = 3;
            this.btnReportT.Text = "View Reported Bug";
            this.btnReportT.UseVisualStyleBackColor = true;
            this.btnReportT.Click += new System.EventHandler(this.btnReportT_Click);
            // 
            // btnLogoutT
            // 
            this.btnLogoutT.Location = new System.Drawing.Point(12, 406);
            this.btnLogoutT.Name = "btnLogoutT";
            this.btnLogoutT.Size = new System.Drawing.Size(106, 44);
            this.btnLogoutT.TabIndex = 4;
            this.btnLogoutT.Text = "Logout";
            this.btnLogoutT.UseVisualStyleBackColor = true;
            this.btnLogoutT.Click += new System.EventHandler(this.btnLogoutT_Click);
            // 
            // btnSolvedT
            // 
            this.btnSolvedT.Location = new System.Drawing.Point(12, 305);
            this.btnSolvedT.Name = "btnSolvedT";
            this.btnSolvedT.Size = new System.Drawing.Size(106, 44);
            this.btnSolvedT.TabIndex = 5;
            this.btnSolvedT.Text = "View Solved Bug";
            this.btnSolvedT.UseVisualStyleBackColor = true;
            // 
            // testGrid
            // 
            this.testGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGrid.Location = new System.Drawing.Point(145, 62);
            this.testGrid.Name = "testGrid";
            this.testGrid.Size = new System.Drawing.Size(660, 407);
            this.testGrid.TabIndex = 6;
            // 
            // lblSearchT
            // 
            this.lblSearchT.AutoSize = true;
            this.lblSearchT.Location = new System.Drawing.Point(517, 35);
            this.lblSearchT.Name = "lblSearchT";
            this.lblSearchT.Size = new System.Drawing.Size(41, 13);
            this.lblSearchT.TabIndex = 7;
            this.lblSearchT.Text = "Search";
            // 
            // txtSearchT
            // 
            this.txtSearchT.Location = new System.Drawing.Point(578, 32);
            this.txtSearchT.Name = "txtSearchT";
            this.txtSearchT.Size = new System.Drawing.Size(149, 20);
            this.txtSearchT.TabIndex = 8;
            // 
            // btnGoT
            // 
            this.btnGoT.Location = new System.Drawing.Point(751, 32);
            this.btnGoT.Name = "btnGoT";
            this.btnGoT.Size = new System.Drawing.Size(37, 20);
            this.btnGoT.TabIndex = 9;
            this.btnGoT.Text = "GO";
            this.btnGoT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(68, 19);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 13);
            this.lblUname.TabIndex = 14;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(9, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Solve Bug";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TesterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnGoT);
            this.Controls.Add(this.txtSearchT);
            this.Controls.Add(this.lblSearchT);
            this.Controls.Add(this.testGrid);
            this.Controls.Add(this.btnSolvedT);
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
        private System.Windows.Forms.Button btnSolvedT;
        private System.Windows.Forms.DataGridView testGrid;
        private System.Windows.Forms.Label lblSearchT;
        private System.Windows.Forms.TextBox txtSearchT;
        private System.Windows.Forms.TextBox btnGoT;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button button1;
    }
}