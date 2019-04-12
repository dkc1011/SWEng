namespace WindowsFormsApp1
{
    partial class frmReturnBook
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lstMemberSearch = new System.Windows.Forms.ListBox();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMemSearch = new System.Windows.Forms.Label();
            this.grpReturnBook = new System.Windows.Forms.GroupBox();
            this.grdRentedBooks = new System.Windows.Forms.DataGridView();
            this.lblCloseRental = new System.Windows.Forms.Button();
            this.grpReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(249, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(72, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Book Returns";
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(113, 70);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(135, 22);
            this.btnMemberSearch.TabIndex = 28;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(451, 338);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(135, 22);
            this.btnFinished.TabIndex = 27;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lstMemberSearch
            // 
            this.lstMemberSearch.FormattingEnabled = true;
            this.lstMemberSearch.Location = new System.Drawing.Point(268, 44);
            this.lstMemberSearch.Name = "lstMemberSearch";
            this.lstMemberSearch.Size = new System.Drawing.Size(318, 95);
            this.lstMemberSearch.TabIndex = 26;
            this.lstMemberSearch.SelectedIndexChanged += new System.EventHandler(this.lstMemberSearch_SelectedIndexChanged);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(113, 44);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(135, 20);
            this.txtMemberSearch.TabIndex = 25;
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(11, 47);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(96, 13);
            this.lblMemberSearch.TabIndex = 24;
            this.lblMemberSearch.Text = "Member Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Member\'s Rented Books :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMemSearch
            // 
            this.lblMemSearch.AutoSize = true;
            this.lblMemSearch.Location = new System.Drawing.Point(265, 28);
            this.lblMemSearch.Name = "lblMemSearch";
            this.lblMemSearch.Size = new System.Drawing.Size(56, 13);
            this.lblMemSearch.TabIndex = 30;
            this.lblMemSearch.Text = "Members :";
            // 
            // grpReturnBook
            // 
            this.grpReturnBook.Controls.Add(this.grdRentedBooks);
            this.grpReturnBook.Controls.Add(this.lblCloseRental);
            this.grpReturnBook.Controls.Add(this.label1);
            this.grpReturnBook.Location = new System.Drawing.Point(14, 159);
            this.grpReturnBook.Name = "grpReturnBook";
            this.grpReturnBook.Size = new System.Drawing.Size(572, 173);
            this.grpReturnBook.TabIndex = 32;
            this.grpReturnBook.TabStop = false;
            this.grpReturnBook.Text = "Return Book";
            // 
            // grdRentedBooks
            // 
            this.grdRentedBooks.AllowUserToAddRows = false;
            this.grdRentedBooks.AllowUserToDeleteRows = false;
            this.grdRentedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRentedBooks.Location = new System.Drawing.Point(22, 32);
            this.grdRentedBooks.Name = "grdRentedBooks";
            this.grdRentedBooks.Size = new System.Drawing.Size(340, 125);
            this.grdRentedBooks.TabIndex = 34;
            // 
            // lblCloseRental
            // 
            this.lblCloseRental.Location = new System.Drawing.Point(389, 87);
            this.lblCloseRental.Name = "lblCloseRental";
            this.lblCloseRental.Size = new System.Drawing.Size(177, 22);
            this.lblCloseRental.TabIndex = 33;
            this.lblCloseRental.Text = "Close Rental";
            this.lblCloseRental.UseVisualStyleBackColor = true;
            this.lblCloseRental.Click += new System.EventHandler(this.lblCloseRental_Click);
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.grpReturnBook);
            this.Controls.Add(this.lblMemSearch);
            this.Controls.Add(this.btnMemberSearch);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lstMemberSearch);
            this.Controls.Add(this.txtMemberSearch);
            this.Controls.Add(this.lblMemberSearch);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmReturnBook";
            this.Text = "frmReturnBook";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            this.grpReturnBook.ResumeLayout(false);
            this.grpReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox lstMemberSearch;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemSearch;
        private System.Windows.Forms.GroupBox grpReturnBook;
        private System.Windows.Forms.Button lblCloseRental;
        private System.Windows.Forms.DataGridView grdRentedBooks;
    }
}