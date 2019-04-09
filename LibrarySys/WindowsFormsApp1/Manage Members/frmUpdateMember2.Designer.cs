namespace WindowsFormsApp1.Manage_Members
{
    partial class frmUpdateMember2
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
            this.btnFinished = new System.Windows.Forms.Button();
            this.txtDoBYear = new System.Windows.Forms.TextBox();
            this.txtDoBMonth = new System.Windows.Forms.TextBox();
            this.lblAddMemberHeader = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtDoBDay = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(279, 324);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(118, 22);
            this.btnFinished.TabIndex = 37;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // txtDoBYear
            // 
            this.txtDoBYear.Location = new System.Drawing.Point(341, 133);
            this.txtDoBYear.Name = "txtDoBYear";
            this.txtDoBYear.Size = new System.Drawing.Size(56, 20);
            this.txtDoBYear.TabIndex = 36;
            this.txtDoBYear.Text = "YYYY";
            this.txtDoBYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoBYear.TextChanged += new System.EventHandler(this.txtDoBYear_TextChanged);
            // 
            // txtDoBMonth
            // 
            this.txtDoBMonth.Location = new System.Drawing.Point(310, 133);
            this.txtDoBMonth.Name = "txtDoBMonth";
            this.txtDoBMonth.Size = new System.Drawing.Size(25, 20);
            this.txtDoBMonth.TabIndex = 35;
            this.txtDoBMonth.Text = "MM";
            this.txtDoBMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoBMonth.TextChanged += new System.EventHandler(this.txtDoBMonth_TextChanged);
            // 
            // lblAddMemberHeader
            // 
            this.lblAddMemberHeader.AutoSize = true;
            this.lblAddMemberHeader.Location = new System.Drawing.Point(301, 24);
            this.lblAddMemberHeader.Name = "lblAddMemberHeader";
            this.lblAddMemberHeader.Size = new System.Drawing.Size(83, 13);
            this.lblAddMemberHeader.TabIndex = 34;
            this.lblAddMemberHeader.Text = "Update Member";
            this.lblAddMemberHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddMemberHeader.Click += new System.EventHandler(this.lblAddMemberHeader_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(279, 296);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(118, 22);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(230, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(279, 270);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 20);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(225, 240);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 30;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(279, 237);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 20);
            this.txtPhone.TabIndex = 29;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(279, 202);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(118, 20);
            this.txtTown.TabIndex = 28;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(228, 205);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 27;
            this.lblTown.Text = "Town:";
            this.lblTown.Click += new System.EventHandler(this.lblTown_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(279, 168);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(118, 20);
            this.txtStreet.TabIndex = 26;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(228, 171);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 25;
            this.lblStreet.Text = "Street:";
            this.lblStreet.Click += new System.EventHandler(this.lblStreet_Click);
            // 
            // txtDoBDay
            // 
            this.txtDoBDay.Location = new System.Drawing.Point(279, 133);
            this.txtDoBDay.Name = "txtDoBDay";
            this.txtDoBDay.Size = new System.Drawing.Size(25, 20);
            this.txtDoBDay.TabIndex = 24;
            this.txtDoBDay.Text = "DD";
            this.txtDoBDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoBDay.TextChanged += new System.EventHandler(this.txtDoBDay_TextChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(197, 136);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 23;
            this.lblDateOfBirth.Text = "Date of Birth:";
            this.lblDateOfBirth.Click += new System.EventHandler(this.lblDateOfBirth_Click);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(279, 96);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(118, 20);
            this.txtForename.TabIndex = 22;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(209, 99);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 21;
            this.lblForename.Text = "Forename:";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(279, 58);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(118, 20);
            this.txtSurname.TabIndex = 20;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(214, 61);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname:";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // frmUpdateMember2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.txtDoBYear);
            this.Controls.Add(this.txtDoBMonth);
            this.Controls.Add(this.lblAddMemberHeader);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtDoBDay);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Name = "frmUpdateMember2";
            this.Text = "frmUpdateMember2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.TextBox txtDoBYear;
        private System.Windows.Forms.TextBox txtDoBMonth;
        private System.Windows.Forms.Label lblAddMemberHeader;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtDoBDay;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
    }
}