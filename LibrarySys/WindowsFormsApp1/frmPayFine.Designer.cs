namespace WindowsFormsApp1
{
    partial class frmPayFine
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
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.lblLDowling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(114, 40);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(135, 22);
            this.btnMemberSearch.TabIndex = 27;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(114, 68);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(135, 22);
            this.btnFinished.TabIndex = 26;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(264, 14);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(318, 342);
            this.lstMembers.TabIndex = 25;
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(114, 14);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(135, 20);
            this.txtMemberSearch.TabIndex = 24;
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(12, 17);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(96, 13);
            this.lblMemberSearch.TabIndex = 23;
            this.lblMemberSearch.Text = "Member Surname :";
            // 
            // lblLDowling
            // 
            this.lblLDowling.AutoSize = true;
            this.lblLDowling.Location = new System.Drawing.Point(274, 20);
            this.lblLDowling.Name = "lblLDowling";
            this.lblLDowling.Size = new System.Drawing.Size(73, 13);
            this.lblLDowling.TabIndex = 31;
            this.lblLDowling.Text = "Dowling, Liam";
            this.lblLDowling.Click += new System.EventHandler(this.lblLDowling_Click);
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.lblLDowling);
            this.Controls.Add(this.btnMemberSearch);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.txtMemberSearch);
            this.Controls.Add(this.lblMemberSearch);
            this.Name = "frmPayFine";
            this.Text = "frmPayFine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Label lblLDowling;
    }
}