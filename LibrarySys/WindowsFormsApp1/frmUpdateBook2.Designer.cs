namespace WindowsFormsApp1
{
    partial class frmUpdateBook2
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
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblUpdateBookHeader = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Thriller",
            "Horror",
            "Nature",
            "History",
            "Crime",
            "Fantasy",
            "Science Fiction"});
            this.cboGenre.Location = new System.Drawing.Point(251, 173);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(147, 21);
            this.cboGenre.TabIndex = 30;
            this.cboGenre.Text = "Genre";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(251, 250);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(147, 23);
            this.btnFinished.TabIndex = 29;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(251, 221);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 23);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(196, 176);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 27;
            this.lblGenre.Text = "Genre:";
            // 
            // lblUpdateBookHeader
            // 
            this.lblUpdateBookHeader.AutoSize = true;
            this.lblUpdateBookHeader.Location = new System.Drawing.Point(291, 97);
            this.lblUpdateBookHeader.Name = "lblUpdateBookHeader";
            this.lblUpdateBookHeader.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateBookHeader.TabIndex = 26;
            this.lblUpdateBookHeader.Text = "Update Book";
            this.lblUpdateBookHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdateBookHeader.Click += new System.EventHandler(this.lblAddBookHeader_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(251, 131);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(147, 20);
            this.txtTitle.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(205, 134);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Title:";
            // 
            // frmUpdateBook2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblUpdateBookHeader);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmUpdateBook2";
            this.Text = "frmUpdateBook2";
            this.Load += new System.EventHandler(this.frmUpdateBook2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblUpdateBookHeader;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}