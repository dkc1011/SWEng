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
            this.grpFine = new System.Windows.Forms.GroupBox();
            this.lblSumPaid = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtSumPaid = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtOutstandingFees = new System.Windows.Forms.TextBox();
            this.txtSelectedMember = new System.Windows.Forms.TextBox();
            this.grpFine.SuspendLayout();
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
            this.btnFinished.Location = new System.Drawing.Point(447, 412);
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
            this.lstMembers.Size = new System.Drawing.Size(318, 147);
            this.lstMembers.TabIndex = 25;
            this.lstMembers.Visible = false;
            this.lstMembers.SelectedIndexChanged += new System.EventHandler(this.lstMembers_SelectedIndexChanged);
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
            // grpFine
            // 
            this.grpFine.Controls.Add(this.txtSelectedMember);
            this.grpFine.Controls.Add(this.txtOutstandingFees);
            this.grpFine.Controls.Add(this.lblOutstanding);
            this.grpFine.Controls.Add(this.lblSumPaid);
            this.grpFine.Controls.Add(this.lblMember);
            this.grpFine.Controls.Add(this.lblEuro);
            this.grpFine.Controls.Add(this.lblFees);
            this.grpFine.Controls.Add(this.txtSumPaid);
            this.grpFine.Controls.Add(this.btnPay);
            this.grpFine.Location = new System.Drawing.Point(15, 170);
            this.grpFine.Name = "grpFine";
            this.grpFine.Size = new System.Drawing.Size(567, 230);
            this.grpFine.TabIndex = 32;
            this.grpFine.TabStop = false;
            this.grpFine.Text = "Pay Fine";
            this.grpFine.Visible = false;
            // 
            // lblSumPaid
            // 
            this.lblSumPaid.AutoSize = true;
            this.lblSumPaid.Location = new System.Drawing.Point(267, 109);
            this.lblSumPaid.Name = "lblSumPaid";
            this.lblSumPaid.Size = new System.Drawing.Size(55, 13);
            this.lblSumPaid.TabIndex = 39;
            this.lblSumPaid.Text = "Sum Paid:";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(208, 128);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 38;
            this.lblEuro.Text = "€";
            // 
            // txtSumPaid
            // 
            this.txtSumPaid.Location = new System.Drawing.Point(227, 125);
            this.txtSumPaid.Name = "txtSumPaid";
            this.txtSumPaid.Size = new System.Drawing.Size(134, 20);
            this.txtSumPaid.TabIndex = 37;
            this.txtSumPaid.Text = "00.00";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(227, 151);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(134, 23);
            this.btnPay.TabIndex = 36;
            this.btnPay.Text = "Submit Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(267, 83);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(0, 13);
            this.lblFees.TabIndex = 35;
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Location = new System.Drawing.Point(131, 83);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(90, 13);
            this.lblOutstanding.TabIndex = 34;
            this.lblOutstanding.Text = "Outstanding fees:";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(173, 54);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(48, 13);
            this.lblMember.TabIndex = 33;
            this.lblMember.Text = "Member:";
            // 
            // txtOutstandingFees
            // 
            this.txtOutstandingFees.Location = new System.Drawing.Point(227, 80);
            this.txtOutstandingFees.Name = "txtOutstandingFees";
            this.txtOutstandingFees.ReadOnly = true;
            this.txtOutstandingFees.Size = new System.Drawing.Size(134, 20);
            this.txtOutstandingFees.TabIndex = 41;
            // 
            // txtSelectedMember
            // 
            this.txtSelectedMember.Location = new System.Drawing.Point(227, 51);
            this.txtSelectedMember.Name = "txtSelectedMember";
            this.txtSelectedMember.ReadOnly = true;
            this.txtSelectedMember.Size = new System.Drawing.Size(134, 20);
            this.txtSelectedMember.TabIndex = 42;
            this.txtSelectedMember.TextChanged += new System.EventHandler(this.txtSelectedMember_TextChanged);
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 446);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.grpFine);
            this.Controls.Add(this.btnMemberSearch);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.txtMemberSearch);
            this.Controls.Add(this.lblMemberSearch);
            this.Name = "frmPayFine";
            this.Text = "frmPayFine";
            this.Load += new System.EventHandler(this.frmPayFine_Load);
            this.grpFine.ResumeLayout(false);
            this.grpFine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.GroupBox grpFine;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label lblSumPaid;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.TextBox txtSumPaid;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtSelectedMember;
        private System.Windows.Forms.TextBox txtOutstandingFees;
    }
}