namespace BugTrackingSystem
{
    partial class AddPoject
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
            this.lblProjectType = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.estiDate = new System.Windows.Forms.DateTimePicker();
            this.lblAssignUser = new System.Windows.Forms.Label();
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.btnSaveN = new System.Windows.Forms.Button();
            this.btnCancelN = new System.Windows.Forms.Button();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoSize = true;
            this.lblProjectType.Location = new System.Drawing.Point(23, 166);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(67, 13);
            this.lblProjectType.TabIndex = 0;
            this.lblProjectType.Text = "Project Type";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(22, 130);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(101, 13);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Estimated End Date";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(22, 61);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(71, 13);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project Name";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(22, 95);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start Date";
            // 
            // lblNewProject
            // 
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Location = new System.Drawing.Point(130, 24);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(65, 13);
            this.lblNewProject.TabIndex = 4;
            this.lblNewProject.Text = "New Project";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(148, 61);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 20);
            this.txtProjectName.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "yyyy-MM-dd";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(148, 88);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 7;
            // 
            // estiDate
            // 
            this.estiDate.CustomFormat = "yyyy-MM-dd";
            this.estiDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.estiDate.Location = new System.Drawing.Point(148, 128);
            this.estiDate.Name = "estiDate";
            this.estiDate.Size = new System.Drawing.Size(200, 20);
            this.estiDate.TabIndex = 8;
            // 
            // lblAssignUser
            // 
            this.lblAssignUser.AutoSize = true;
            this.lblAssignUser.Location = new System.Drawing.Point(23, 197);
            this.lblAssignUser.Name = "lblAssignUser";
            this.lblAssignUser.Size = new System.Drawing.Size(54, 13);
            this.lblAssignUser.TabIndex = 9;
            this.lblAssignUser.Text = "Assign To";
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Items.AddRange(new object[] {
            "Database",
            "PHP",
            "Java",
            "C Sharp",
            "HTML"});
            this.cmbProjectType.Location = new System.Drawing.Point(148, 163);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(200, 21);
            this.cmbProjectType.TabIndex = 10;
            // 
            // btnSaveN
            // 
            this.btnSaveN.Location = new System.Drawing.Point(94, 247);
            this.btnSaveN.Name = "btnSaveN";
            this.btnSaveN.Size = new System.Drawing.Size(75, 23);
            this.btnSaveN.TabIndex = 11;
            this.btnSaveN.Text = "Save";
            this.btnSaveN.UseVisualStyleBackColor = true;
            this.btnSaveN.Click += new System.EventHandler(this.btnSaveN_Click);
            // 
            // btnCancelN
            // 
            this.btnCancelN.Location = new System.Drawing.Point(201, 247);
            this.btnCancelN.Name = "btnCancelN";
            this.btnCancelN.Size = new System.Drawing.Size(75, 23);
            this.btnCancelN.TabIndex = 12;
            this.btnCancelN.Text = "Cancel";
            this.btnCancelN.UseVisualStyleBackColor = true;
            this.btnCancelN.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(148, 197);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(200, 21);
            this.cmbUser.TabIndex = 13;
            // 
            // AddPoject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 311);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnCancelN);
            this.Controls.Add(this.btnSaveN);
            this.Controls.Add(this.cmbProjectType);
            this.Controls.Add(this.lblAssignUser);
            this.Controls.Add(this.estiDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblNewProject);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblProjectType);
            this.Name = "AddPoject";
            this.Text = "AddPoject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectType;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker estiDate;
        private System.Windows.Forms.Label lblAssignUser;
        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.Button btnSaveN;
        private System.Windows.Forms.Button btnCancelN;
        private System.Windows.Forms.ComboBox cmbUser;
    }
}