namespace WindowsFormsApp1
{
    partial class frmUpdateBook1
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
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAddBookHeader = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(76, 40);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(173, 22);
            this.btnBookSearch.TabIndex = 27;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(409, 394);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(173, 22);
            this.btnFinished.TabIndex = 26;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(264, 14);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(318, 108);
            this.lstBooks.TabIndex = 25;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(76, 14);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(173, 20);
            this.txtBookSearch.TabIndex = 24;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(12, 17);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(58, 13);
            this.lblBookTitle.TabIndex = 23;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblISBN);
            this.grpBook.Controls.Add(this.txtISBN);
            this.grpBook.Controls.Add(this.lblAuthor);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.cboGenre);
            this.grpBook.Controls.Add(this.lblGenre);
            this.grpBook.Controls.Add(this.lblAddBookHeader);
            this.grpBook.Controls.Add(this.txtTitle);
            this.grpBook.Controls.Add(this.lblTitle);
            this.grpBook.Controls.Add(this.btnUpdate);
            this.grpBook.Location = new System.Drawing.Point(22, 148);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(550, 240);
            this.grpBook.TabIndex = 28;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Edit Book Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(409, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 22);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Edit Book";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(169, 140);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 36;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(220, 137);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(147, 20);
            this.txtISBN.TabIndex = 35;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(163, 114);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 34;
            this.lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(220, 111);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(147, 20);
            this.txtAuthor.TabIndex = 33;
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(220, 84);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(147, 21);
            this.cboGenre.TabIndex = 32;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(165, 87);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 31;
            this.lblGenre.Text = "Genre:";
            // 
            // lblAddBookHeader
            // 
            this.lblAddBookHeader.AutoSize = true;
            this.lblAddBookHeader.Location = new System.Drawing.Point(262, 30);
            this.lblAddBookHeader.Name = "lblAddBookHeader";
            this.lblAddBookHeader.Size = new System.Drawing.Size(54, 13);
            this.lblAddBookHeader.TabIndex = 30;
            this.lblAddBookHeader.Text = "Add Book";
            this.lblAddBookHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(220, 58);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(147, 20);
            this.txtTitle.TabIndex = 29;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(174, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Title:";
            // 
            // frmUpdateBook1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 426);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtBookSearch);
            this.Controls.Add(this.lblBookTitle);
            this.Name = "frmUpdateBook1";
            this.Text = "frmUpdateBook1";
            this.Load += new System.EventHandler(this.frmUpdateBook1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAddBookHeader;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}