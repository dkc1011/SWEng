namespace WindowsFormsApp1.Manage_Members
{
    partial class frmRemoveMember1
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
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(264, 14);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(318, 303);
            this.lstMembers.TabIndex = 5;
            this.lstMembers.Visible = false;
            this.lstMembers.SelectedIndexChanged += new System.EventHandler(this.lstMembers_SelectedIndexChanged);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(113, 129);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(135, 20);
            this.txtMemberSearch.TabIndex = 4;
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(11, 132);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(96, 13);
            this.lblMemberSearch.TabIndex = 3;
            this.lblMemberSearch.Text = "Member Surname :";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(113, 184);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(135, 22);
            this.btnFinished.TabIndex = 19;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(113, 155);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(135, 22);
            this.btnMemberSearch.TabIndex = 20;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(362, 332);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(135, 22);
            this.btnRemoveMember.TabIndex = 21;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Visible = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click_1);
            // 
            // frmRemoveMember1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnMemberSearch);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.txtMemberSearch);
            this.Controls.Add(this.lblMemberSearch);
            this.Name = "frmRemoveMember1";
            this.Text = "frmRemoveMember1";
            this.Load += new System.EventHandler(this.frmRemoveMember1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.Button btnRemoveMember;
    }
}