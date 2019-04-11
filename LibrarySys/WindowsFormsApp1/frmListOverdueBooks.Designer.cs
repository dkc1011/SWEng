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
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpSelectedDate = new System.Windows.Forms.DateTimePicker();
            this.grdOverdueBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOverdueBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(18, 69);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(227, 22);
            this.btnBookSearch.TabIndex = 32;
            this.btnBookSearch.Text = "List Overdue Books";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(18, 337);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(227, 22);
            this.btnFinished.TabIndex = 31;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
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
            // dtpSelectedDate
            // 
            this.dtpSelectedDate.Location = new System.Drawing.Point(18, 43);
            this.dtpSelectedDate.Name = "dtpSelectedDate";
            this.dtpSelectedDate.Size = new System.Drawing.Size(227, 20);
            this.dtpSelectedDate.TabIndex = 35;
            // 
            // grdOverdueBooks
            // 
            this.grdOverdueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOverdueBooks.Location = new System.Drawing.Point(266, 17);
            this.grdOverdueBooks.Name = "grdOverdueBooks";
            this.grdOverdueBooks.Size = new System.Drawing.Size(316, 342);
            this.grdOverdueBooks.TabIndex = 36;
            // 
            // frmListOverdueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.grdOverdueBooks);
            this.Controls.Add(this.dtpSelectedDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnFinished);
            this.Name = "frmListOverdueBooks";
            this.Text = "frmListOverdueBooks";
            this.Load += new System.EventHandler(this.frmListOverdueBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOverdueBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpSelectedDate;
        private System.Windows.Forms.DataGridView grdOverdueBooks;
    }
}