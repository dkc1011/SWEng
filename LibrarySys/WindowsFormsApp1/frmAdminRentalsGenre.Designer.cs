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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnFinished = new System.Windows.Forms.Button();
            this.chtAnnualRentals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnnualRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(217, 314);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(159, 21);
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
            this.cboGenre.Location = new System.Drawing.Point(57, 314);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(154, 21);
            this.cboGenre.TabIndex = 6;
            this.cboGenre.Text = "Year";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(382, 314);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(154, 21);
            this.btnFinished.TabIndex = 5;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // chtAnnualRentals
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnnualRentals.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnnualRentals.Legends.Add(legend1);
            this.chtAnnualRentals.Location = new System.Drawing.Point(57, 12);
            this.chtAnnualRentals.Name = "chtAnnualRentals";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnnualRentals.Series.Add(series1);
            this.chtAnnualRentals.Size = new System.Drawing.Size(479, 292);
            this.chtAnnualRentals.TabIndex = 8;
            this.chtAnnualRentals.Text = "chart1";
            // 
            // frmAdminRentalsGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.chtAnnualRentals);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.btnFinished);
            this.Name = "frmAdminRentalsGenre";
            this.Text = "frmAdminRentalsGenre";
            this.Load += new System.EventHandler(this.frmAdminRentalsGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnnualRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnnualRentals;
    }
}