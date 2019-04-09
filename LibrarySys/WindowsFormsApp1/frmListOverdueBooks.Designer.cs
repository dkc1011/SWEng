namespace WindowsFormsApp1
{
    partial class frmListOverdueBooks
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
            this.lstOverdueBooks = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(18, 213);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(227, 22);
            this.btnBookSearch.TabIndex = 32;
            this.btnBookSearch.Text = "List Overdue Books";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(18, 241);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(227, 22);
            this.btnFinished.TabIndex = 31;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lstOverdueBooks
            // 
            this.lstOverdueBooks.FormattingEnabled = true;
            this.lstOverdueBooks.Location = new System.Drawing.Point(257, 14);
            this.lstOverdueBooks.Name = "lstOverdueBooks";
            this.lstOverdueBooks.Size = new System.Drawing.Size(325, 342);
            this.lstOverdueBooks.TabIndex = 30;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 39);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 33;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(85, 17);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(103, 13);
            this.lblDueDate.TabIndex = 34;
            this.lblDueDate.Text = "Select Today\'s Date";
            // 
            // frmListOverdueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lstOverdueBooks);
            this.Name = "frmListOverdueBooks";
            this.Text = "frmListOverdueBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox lstOverdueBooks;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDueDate;
    }
}