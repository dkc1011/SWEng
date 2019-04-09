namespace WindowsFormsApp1
{
    partial class frmBorrowBook
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
            this.lblRentalHeader = new System.Windows.Forms.Label();
            this.btnSelectBooks = new System.Windows.Forms.Button();
            this.lstSelectedBooks = new System.Windows.Forms.ListBox();
            this.lblBookSelected = new System.Windows.Forms.Label();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lblSelectedMember = new System.Windows.Forms.Label();
            this.txtSelectedMember = new System.Windows.Forms.TextBox();
            this.lstBookSearch = new System.Windows.Forms.ListBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.lstMemberSearch = new System.Windows.Forms.ListBox();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRentalHeader
            // 
            this.lblRentalHeader.AutoSize = true;
            this.lblRentalHeader.Location = new System.Drawing.Point(306, 9);
            this.lblRentalHeader.Name = "lblRentalHeader";
            this.lblRentalHeader.Size = new System.Drawing.Size(61, 13);
            this.lblRentalHeader.TabIndex = 10;
            this.lblRentalHeader.Text = "Book rental";
            // 
            // btnSelectBooks
            // 
            this.btnSelectBooks.Location = new System.Drawing.Point(274, 91);
            this.btnSelectBooks.Name = "btnSelectBooks";
            this.btnSelectBooks.Size = new System.Drawing.Size(134, 23);
            this.btnSelectBooks.TabIndex = 9;
            this.btnSelectBooks.Text = "Select Book(s)";
            this.btnSelectBooks.UseVisualStyleBackColor = true;
            this.btnSelectBooks.Click += new System.EventHandler(this.btnSelectBooks_Click);
            // 
            // lstSelectedBooks
            // 
            this.lstSelectedBooks.FormattingEnabled = true;
            this.lstSelectedBooks.Location = new System.Drawing.Point(414, 50);
            this.lstSelectedBooks.Name = "lstSelectedBooks";
            this.lstSelectedBooks.Size = new System.Drawing.Size(259, 108);
            this.lstSelectedBooks.TabIndex = 10;
            this.lstSelectedBooks.Visible = false;
            this.lstSelectedBooks.SelectedIndexChanged += new System.EventHandler(this.lstSelectedBooks_SelectedIndexChanged);
            // 
            // lblBookSelected
            // 
            this.lblBookSelected.AutoSize = true;
            this.lblBookSelected.Location = new System.Drawing.Point(509, 34);
            this.lblBookSelected.Name = "lblBookSelected";
            this.lblBookSelected.Size = new System.Drawing.Size(88, 13);
            this.lblBookSelected.TabIndex = 3;
            this.lblBookSelected.Text = "Books Selected :";
            this.lblBookSelected.Visible = false;
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Location = new System.Drawing.Point(274, 267);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(134, 23);
            this.btnSelectMember.TabIndex = 15;
            this.btnSelectMember.Text = "Select Member";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(538, 334);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(134, 23);
            this.btnFinished.TabIndex = 17;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lblSelectedMember
            // 
            this.lblSelectedMember.AutoSize = true;
            this.lblSelectedMember.Location = new System.Drawing.Point(439, 272);
            this.lblSelectedMember.Name = "lblSelectedMember";
            this.lblSelectedMember.Size = new System.Drawing.Size(93, 13);
            this.lblSelectedMember.TabIndex = 6;
            this.lblSelectedMember.Text = "Selected Member:";
            this.lblSelectedMember.Visible = false;
            // 
            // txtSelectedMember
            // 
            this.txtSelectedMember.Location = new System.Drawing.Point(538, 269);
            this.txtSelectedMember.Name = "txtSelectedMember";
            this.txtSelectedMember.ReadOnly = true;
            this.txtSelectedMember.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSelectedMember.Size = new System.Drawing.Size(112, 20);
            this.txtSelectedMember.TabIndex = 7;
            this.txtSelectedMember.Text = "None";
            this.txtSelectedMember.Visible = false;
            this.txtSelectedMember.TextChanged += new System.EventHandler(this.txtSelectedMember_TextChanged);
            // 
            // lstBookSearch
            // 
            this.lstBookSearch.FormattingEnabled = true;
            this.lstBookSearch.Location = new System.Drawing.Point(12, 50);
            this.lstBookSearch.Name = "lstBookSearch";
            this.lstBookSearch.Size = new System.Drawing.Size(256, 108);
            this.lstBookSearch.TabIndex = 8;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(107, 34);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(43, 13);
            this.lblBooks.TabIndex = 18;
            this.lblBooks.Text = "Books :";
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(48, 163);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(159, 20);
            this.txtBookSearch.TabIndex = 6;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(213, 164);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(55, 20);
            this.btnBookSearch.TabIndex = 7;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // lstMemberSearch
            // 
            this.lstMemberSearch.FormattingEnabled = true;
            this.lstMemberSearch.Location = new System.Drawing.Point(12, 218);
            this.lstMemberSearch.Name = "lstMemberSearch";
            this.lstMemberSearch.Size = new System.Drawing.Size(256, 108);
            this.lstMemberSearch.TabIndex = 14;
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(213, 337);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(55, 20);
            this.btnMemberSearch.TabIndex = 13;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(68, 337);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(141, 20);
            this.txtMemberSearch.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(398, 334);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(414, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(258, 20);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(107, 202);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(56, 13);
            this.lblMemberSearch.TabIndex = 17;
            this.lblMemberSearch.Text = "Members :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 168);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 339);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname :";
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMemberSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtMemberSearch);
            this.Controls.Add(this.btnMemberSearch);
            this.Controls.Add(this.lstMemberSearch);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.txtBookSearch);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lstBookSearch);
            this.Controls.Add(this.txtSelectedMember);
            this.Controls.Add(this.lblSelectedMember);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.lblBookSelected);
            this.Controls.Add(this.lstSelectedBooks);
            this.Controls.Add(this.btnSelectBooks);
            this.Controls.Add(this.lblRentalHeader);
            this.Name = "frmBorrowBook";
            this.Text = "frmBorrowBook";
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRentalHeader;
        private System.Windows.Forms.Button btnSelectBooks;
        private System.Windows.Forms.ListBox lstSelectedBooks;
        private System.Windows.Forms.Label lblBookSelected;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label lblSelectedMember;
        private System.Windows.Forms.TextBox txtSelectedMember;
        private System.Windows.Forms.ListBox lstBookSearch;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.ListBox lstMemberSearch;
        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSurname;
    }
}