namespace BugTrackingSystem
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(249, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Bug Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BugTrackingSystem.Properties.Resources.Bugs;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 359);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.lblRegister);
            this.loginPanel.Controls.Add(this.RegisterLink);
            this.loginPanel.Controls.Add(this.btnCancel);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.txtUsername);
            this.loginPanel.Location = new System.Drawing.Point(362, 56);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(305, 207);
            this.loginPanel.TabIndex = 2;
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRegister.Location = new System.Drawing.Point(52, 168);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(107, 23);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Are you new?";
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.LinkColor = System.Drawing.Color.Blue;
            this.RegisterLink.Location = new System.Drawing.Point(165, 170);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(72, 13);
            this.RegisterLink.TabIndex = 4;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Register Here";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Location = new System.Drawing.Point(64, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(43, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(568, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button button1;
    }
}

