namespace BugTrackingSystem
{
    partial class ReportingBugDeveloper
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
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancelR = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtClassFile = new System.Windows.Forms.TextBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.txtActualResult = new System.Windows.Forms.TextBox();
            this.txtExpectedResult = new System.Windows.Forms.TextBox();
            this.lblActualRe = new System.Windows.Forms.Label();
            this.lblExpectedRe = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReportBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(230, 204);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(231, 128);
            this.txtcode.TabIndex = 19;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(75, 62);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(71, 13);
            this.lblProject.TabIndex = 20;
            this.lblProject.Text = "Project Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(75, 204);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 21;
            this.lblCode.Text = "Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(75, 470);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(230, 467);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(231, 64);
            this.txtDescription.TabIndex = 23;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(138, 617);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 25;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCancelR
            // 
            this.btnCancelR.Location = new System.Drawing.Point(269, 617);
            this.btnCancelR.Name = "btnCancelR";
            this.btnCancelR.Size = new System.Drawing.Size(75, 23);
            this.btnCancelR.TabIndex = 26;
            this.btnCancelR.Text = "Cancel";
            this.btnCancelR.UseVisualStyleBackColor = true;
            this.btnCancelR.Click += new System.EventHandler(this.btnCancelR_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(75, 97);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(51, 13);
            this.lblClass.TabIndex = 29;
            this.lblClass.Text = "Class File";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(75, 134);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 30;
            this.lblMethod.Text = "Method";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(75, 167);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(27, 13);
            this.lblLine.TabIndex = 31;
            this.lblLine.Text = "Line";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(230, 164);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(231, 20);
            this.txtLine.TabIndex = 33;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(230, 127);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(231, 20);
            this.txtMethod.TabIndex = 34;
            // 
            // txtClassFile
            // 
            this.txtClassFile.Location = new System.Drawing.Point(230, 90);
            this.txtClassFile.Name = "txtClassFile";
            this.txtClassFile.Size = new System.Drawing.Size(231, 20);
            this.txtClassFile.TabIndex = 35;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(184, 18);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(79, 13);
            this.lblReport.TabIndex = 37;
            this.lblReport.Text = "Report the Bug";
            // 
            // txtActualResult
            // 
            this.txtActualResult.Location = new System.Drawing.Point(230, 405);
            this.txtActualResult.Multiline = true;
            this.txtActualResult.Name = "txtActualResult";
            this.txtActualResult.Size = new System.Drawing.Size(231, 49);
            this.txtActualResult.TabIndex = 41;
            // 
            // txtExpectedResult
            // 
            this.txtExpectedResult.Location = new System.Drawing.Point(230, 345);
            this.txtExpectedResult.Multiline = true;
            this.txtExpectedResult.Name = "txtExpectedResult";
            this.txtExpectedResult.Size = new System.Drawing.Size(231, 51);
            this.txtExpectedResult.TabIndex = 40;
            // 
            // lblActualRe
            // 
            this.lblActualRe.AutoSize = true;
            this.lblActualRe.Location = new System.Drawing.Point(76, 405);
            this.lblActualRe.Name = "lblActualRe";
            this.lblActualRe.Size = new System.Drawing.Size(70, 13);
            this.lblActualRe.TabIndex = 39;
            this.lblActualRe.Text = "Actual Result";
            // 
            // lblExpectedRe
            // 
            this.lblExpectedRe.AutoSize = true;
            this.lblExpectedRe.Location = new System.Drawing.Point(75, 345);
            this.lblExpectedRe.Name = "lblExpectedRe";
            this.lblExpectedRe.Size = new System.Drawing.Size(85, 13);
            this.lblExpectedRe.TabIndex = 38;
            this.lblExpectedRe.Text = "Expected Result";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(230, 59);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(231, 21);
            this.cmbProjectName.TabIndex = 42;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(78, 548);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 43;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Completed",
            "Not Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(230, 548);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(231, 21);
            this.cmbStatus.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Reported By";
            // 
            // txtReportBy
            // 
            this.txtReportBy.Location = new System.Drawing.Point(230, 580);
            this.txtReportBy.Name = "txtReportBy";
            this.txtReportBy.Size = new System.Drawing.Size(231, 20);
            this.txtReportBy.TabIndex = 46;
            // 
            // ReportingBugDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 703);
            this.Controls.Add(this.txtReportBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbProjectName);
            this.Controls.Add(this.txtActualResult);
            this.Controls.Add(this.txtExpectedResult);
            this.Controls.Add(this.lblActualRe);
            this.Controls.Add(this.lblExpectedRe);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.txtClassFile);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnCancelR);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtcode);
            this.Name = "ReportingBugDeveloper";
            this.Text = "ReportingBugDeveloper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCancelR;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtClassFile;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox txtActualResult;
        private System.Windows.Forms.TextBox txtExpectedResult;
        private System.Windows.Forms.Label lblActualRe;
        private System.Windows.Forms.Label lblExpectedRe;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReportBy;
    }
}