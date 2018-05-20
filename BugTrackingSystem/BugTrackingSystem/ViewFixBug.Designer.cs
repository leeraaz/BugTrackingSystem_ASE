namespace BugTrackingSystem
{
    partial class ViewFixBug
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.txtReportBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassFile = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.txtFix = new System.Windows.Forms.TextBox();
            this.lblFixby = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.lblUsernames = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Report ID";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(406, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 27);
            this.btnBack.TabIndex = 101;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Search for bug report";
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(223, 101);
            this.txtProject.Name = "txtProject";
            this.txtProject.ReadOnly = true;
            this.txtProject.Size = new System.Drawing.Size(234, 26);
            this.txtProject.TabIndex = 99;
            // 
            // cmbProject
            // 
            this.cmbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(573, 18);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(266, 28);
            this.cmbProject.TabIndex = 98;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // txtReportBy
            // 
            this.txtReportBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportBy.Location = new System.Drawing.Point(223, 210);
            this.txtReportBy.Name = "txtReportBy";
            this.txtReportBy.ReadOnly = true;
            this.txtReportBy.Size = new System.Drawing.Size(234, 26);
            this.txtReportBy.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Reported By";
            // 
            // txtClassFile
            // 
            this.txtClassFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassFile.Location = new System.Drawing.Point(223, 146);
            this.txtClassFile.Name = "txtClassFile";
            this.txtClassFile.ReadOnly = true;
            this.txtClassFile.Size = new System.Drawing.Size(234, 26);
            this.txtClassFile.TabIndex = 89;
            // 
            // txtMethod
            // 
            this.txtMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethod.Location = new System.Drawing.Point(223, 180);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(234, 26);
            this.txtMethod.TabIndex = 88;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(75, 183);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(69, 20);
            this.lblMethod.TabIndex = 85;
            this.lblMethod.Text = "Method";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(75, 149);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(87, 20);
            this.lblClass.TabIndex = 84;
            this.lblClass.Text = "Class File";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(463, 58);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(51, 20);
            this.lblCode.TabIndex = 81;
            this.lblCode.Text = "Code";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(75, 104);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(116, 20);
            this.lblProject.TabIndex = 80;
            this.lblProject.Text = "Project Name";
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(520, 57);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(467, 330);
            this.txtcode.TabIndex = 79;
            // 
            // txtFix
            // 
            this.txtFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFix.Location = new System.Drawing.Point(223, 246);
            this.txtFix.Name = "txtFix";
            this.txtFix.ReadOnly = true;
            this.txtFix.Size = new System.Drawing.Size(234, 26);
            this.txtFix.TabIndex = 107;
            // 
            // lblFixby
            // 
            this.lblFixby.AutoSize = true;
            this.lblFixby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixby.Location = new System.Drawing.Point(75, 246);
            this.lblFixby.Name = "lblFixby";
            this.lblFixby.Size = new System.Drawing.Size(77, 20);
            this.lblFixby.TabIndex = 106;
            this.lblFixby.Text = "Fixed By";
            // 
            // txtReportID
            // 
            this.txtReportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportID.Location = new System.Drawing.Point(223, 58);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(234, 26);
            this.txtReportID.TabIndex = 108;
            // 
            // lblUsernames
            // 
            this.lblUsernames.AutoSize = true;
            this.lblUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernames.Location = new System.Drawing.Point(75, 21);
            this.lblUsernames.Name = "lblUsernames";
            this.lblUsernames.Size = new System.Drawing.Size(91, 20);
            this.lblUsernames.TabIndex = 109;
            this.lblUsernames.Text = "Username";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(220, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 20);
            this.lblUsername.TabIndex = 110;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(223, 282);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(234, 26);
            this.txtDate.TabIndex = 112;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(75, 282);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 20);
            this.lblDate.TabIndex = 111;
            this.lblDate.Text = "Fix Date";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(223, 320);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(272, 74);
            this.txtDescription.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Description";
            // 
            // ViewFixBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 452);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUsernames);
            this.Controls.Add(this.txtReportID);
            this.Controls.Add(this.txtFix);
            this.Controls.Add(this.lblFixby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.txtReportBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassFile);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtcode);
            this.Name = "ViewFixBug";
            this.Text = "ViewFixBug";
            this.Load += new System.EventHandler(this.ViewFixBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.TextBox txtReportBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassFile;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblProject;
        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.TextBox txtFix;
        private System.Windows.Forms.Label lblFixby;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label lblUsernames;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
    }
}