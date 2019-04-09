namespace WindowsFormsApp1
{
    partial class frmAdminRentalsGenre
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
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnFinished = new System.Windows.Forms.Button();
            this.imgGenre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(224, 310);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(138, 25);
            this.btnViewStatistics.TabIndex = 7;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018"});
            this.cboGenre.Location = new System.Drawing.Point(57, 310);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(138, 21);
            this.cboGenre.TabIndex = 6;
            this.cboGenre.Text = "Year";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(398, 310);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(138, 25);
            this.btnFinished.TabIndex = 5;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // imgGenre
            // 
            this.imgGenre.Image = global::WindowsFormsApp1.Properties.Resources.SampleGraph1;
            this.imgGenre.Location = new System.Drawing.Point(57, 12);
            this.imgGenre.Name = "imgGenre";
            this.imgGenre.Size = new System.Drawing.Size(479, 292);
            this.imgGenre.TabIndex = 8;
            this.imgGenre.TabStop = false;
            // 
            // frmAdminRentalsGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.imgGenre);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.btnFinished);
            this.Name = "frmAdminRentalsGenre";
            this.Text = "frmAdminRentalsGenre";
            ((System.ComponentModel.ISupportInitialize)(this.imgGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.PictureBox imgGenre;
    }
}