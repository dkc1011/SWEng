namespace WindowsFormsApp1
{
    partial class frmCheckBookAvailable
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
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheckAvailable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(79, 164);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(170, 22);
            this.btnBookSearch.TabIndex = 32;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(79, 192);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(170, 22);
            this.btnFinished.TabIndex = 31;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(264, 14);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(318, 264);
            this.lstBooks.TabIndex = 30;
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(79, 138);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(170, 20);
            this.txtBookSearch.TabIndex = 29;
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(12, 141);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(61, 13);
            this.lblMemberSearch.TabIndex = 28;
            this.lblMemberSearch.Text = "Book Title :";
            // 
            // btnCheckAvailable
            // 
            this.btnCheckAvailable.Location = new System.Drawing.Point(264, 289);
            this.btnCheckAvailable.Name = "btnCheckAvailable";
            this.btnCheckAvailable.Size = new System.Drawing.Size(318, 61);
            this.btnCheckAvailable.TabIndex = 33;
            this.btnCheckAvailable.Text = "Check Available";
            this.btnCheckAvailable.UseVisualStyleBackColor = true;
            // 
            // frmCheckBookAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.btnCheckAvailable);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtBookSearch);
            this.Controls.Add(this.lblMemberSearch);
            this.Name = "frmCheckBookAvailable";
            this.Text = "frmCheckBookAvailable";
            this.Load += new System.EventHandler(this.frmCheckBookAvailable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheckAvailable;
    }
}