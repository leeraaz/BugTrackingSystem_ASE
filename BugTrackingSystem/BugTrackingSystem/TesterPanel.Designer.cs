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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(12, 186);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(106, 44);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log History";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnReportT
            // 
            this.btnReportT.Location = new System.Drawing.Point(12, 60);
            this.btnReportT.Name = "btnReportT";
            this.btnReportT.Size = new System.Drawing.Size(106, 44);
            this.btnReportT.TabIndex = 3;
            this.btnReportT.Text = "View Reported Bug";
            this.btnReportT.UseVisualStyleBackColor = true;
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
            this.btnSolvedT.Location = new System.Drawing.Point(12, 295);
            this.btnSolvedT.Name = "btnSolvedT";
            this.btnSolvedT.Size = new System.Drawing.Size(106, 44);
            this.btnSolvedT.TabIndex = 5;
            this.btnSolvedT.Text = "View Solved Bug";
            this.btnSolvedT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 407);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(751, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "GO";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TesterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 488);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSolvedT);
            this.Controls.Add(this.btnLogoutT);
            this.Controls.Add(this.btnReportT);
            this.Controls.Add(this.btnLog);
            this.Name = "TesterPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReportT;
        private System.Windows.Forms.Button btnLogoutT;
        private System.Windows.Forms.Button btnSolvedT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}