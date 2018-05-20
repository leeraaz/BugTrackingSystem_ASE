namespace BugTrackingSystem
{
    partial class BugFix
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
            this.txtReportBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtActualResult = new System.Windows.Forms.TextBox();
            this.txtExpectedResult = new System.Windows.Forms.TextBox();
            this.lblActualRe = new System.Windows.Forms.Label();
            this.lblExpectedRe = new System.Windows.Forms.Label();
            this.txtClassFile = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.dateFix = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFixer = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReportID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReportBy
            // 
            this.txtReportBy.Location = new System.Drawing.Point(211, 405);
            this.txtReportBy.Name = "txtReportBy";
            this.txtReportBy.ReadOnly = true;
            this.txtReportBy.Size = new System.Drawing.Size(115, 20);
            this.txtReportBy.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Reported By";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Completed",
            "Not Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(211, 432);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(115, 21);
            this.cmbStatus.TabIndex = 64;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(57, 435);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 63;
            this.lblStatus.Text = "Status";
            // 
            // txtActualResult
            // 
            this.txtActualResult.Location = new System.Drawing.Point(211, 276);
            this.txtActualResult.Multiline = true;
            this.txtActualResult.Name = "txtActualResult";
            this.txtActualResult.Size = new System.Drawing.Size(231, 49);
            this.txtActualResult.TabIndex = 61;
            // 
            // txtExpectedResult
            // 
            this.txtExpectedResult.Location = new System.Drawing.Point(211, 216);
            this.txtExpectedResult.Multiline = true;
            this.txtExpectedResult.Name = "txtExpectedResult";
            this.txtExpectedResult.ReadOnly = true;
            this.txtExpectedResult.Size = new System.Drawing.Size(231, 51);
            this.txtExpectedResult.TabIndex = 60;
            // 
            // lblActualRe
            // 
            this.lblActualRe.AutoSize = true;
            this.lblActualRe.Location = new System.Drawing.Point(57, 276);
            this.lblActualRe.Name = "lblActualRe";
            this.lblActualRe.Size = new System.Drawing.Size(70, 13);
            this.lblActualRe.TabIndex = 59;
            this.lblActualRe.Text = "Actual Result";
            // 
            // lblExpectedRe
            // 
            this.lblExpectedRe.AutoSize = true;
            this.lblExpectedRe.Location = new System.Drawing.Point(56, 216);
            this.lblExpectedRe.Name = "lblExpectedRe";
            this.lblExpectedRe.Size = new System.Drawing.Size(85, 13);
            this.lblExpectedRe.TabIndex = 58;
            this.lblExpectedRe.Text = "Expected Result";
            // 
            // txtClassFile
            // 
            this.txtClassFile.Location = new System.Drawing.Point(211, 108);
            this.txtClassFile.Name = "txtClassFile";
            this.txtClassFile.ReadOnly = true;
            this.txtClassFile.Size = new System.Drawing.Size(115, 20);
            this.txtClassFile.TabIndex = 57;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(211, 145);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(115, 20);
            this.txtMethod.TabIndex = 56;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(211, 182);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(115, 20);
            this.txtLine.TabIndex = 55;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(56, 185);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(27, 13);
            this.lblLine.TabIndex = 54;
            this.lblLine.Text = "Line";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(56, 152);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 53;
            this.lblMethod.Text = "Method";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(56, 115);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(51, 13);
            this.lblClass.TabIndex = 52;
            this.lblClass.Text = "Class File";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(211, 331);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(231, 64);
            this.txtDescription.TabIndex = 51;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(56, 341);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(450, 73);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 49;
            this.lblCode.Text = "Code";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(56, 80);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(71, 13);
            this.lblProject.TabIndex = 48;
            this.lblProject.Text = "Project Name";
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(507, 72);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(467, 330);
            this.txtcode.TabIndex = 47;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(842, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 40);
            this.btnBack.TabIndex = 67;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(639, 27);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(98, 21);
            this.cmbProject.TabIndex = 68;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(211, 73);
            this.txtProject.Name = "txtProject";
            this.txtProject.ReadOnly = true;
            this.txtProject.Size = new System.Drawing.Size(115, 20);
            this.txtProject.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Search for bug report";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(682, 417);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(132, 40);
            this.btnSolve.TabIndex = 71;
            this.btnSolve.Text = "Send to Fixed Bug";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // dateFix
            // 
            this.dateFix.CustomFormat = "yyyy-MM-dd";
            this.dateFix.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFix.Location = new System.Drawing.Point(846, 27);
            this.dateFix.Name = "dateFix";
            this.dateFix.Size = new System.Drawing.Size(100, 20);
            this.dateFix.TabIndex = 72;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(810, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 73;
            this.lblDate.Text = "Date";
            // 
            // lblFixer
            // 
            this.lblFixer.AutoSize = true;
            this.lblFixer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixer.Location = new System.Drawing.Point(122, 25);
            this.lblFixer.Name = "lblFixer";
            this.lblFixer.Size = new System.Drawing.Size(0, 24);
            this.lblFixer.TabIndex = 74;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(56, 32);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(48, 13);
            this.lblDebug.TabIndex = 75;
            this.lblDebug.Text = "Debuger";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 40);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Report ID";
            // 
            // lblReportID
            // 
            this.lblReportID.AutoSize = true;
            this.lblReportID.Location = new System.Drawing.Point(387, 33);
            this.lblReportID.Name = "lblReportID";
            this.lblReportID.Size = new System.Drawing.Size(0, 13);
            this.lblReportID.TabIndex = 78;
            // 
            // BugFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 469);
            this.Controls.Add(this.lblReportID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblFixer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateFix);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtReportBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtActualResult);
            this.Controls.Add(this.txtExpectedResult);
            this.Controls.Add(this.lblActualRe);
            this.Controls.Add(this.lblExpectedRe);
            this.Controls.Add(this.txtClassFile);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtcode);
            this.Name = "BugFix";
            this.Text = " ";
            this.Load += new System.EventHandler(this.BugFix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReportBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtActualResult;
        private System.Windows.Forms.TextBox txtExpectedResult;
        private System.Windows.Forms.Label lblActualRe;
        private System.Windows.Forms.Label lblExpectedRe;
        private System.Windows.Forms.TextBox txtClassFile;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblProject;
        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.DateTimePicker dateFix;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFixer;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReportID;
    }
}