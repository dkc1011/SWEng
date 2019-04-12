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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnFinished = new System.Windows.Forms.Button();
            this.chtAnnualGenre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpChart = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnnualGenre)).BeginInit();
            this.grpChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(189, 12);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(158, 21);
            this.btnViewStatistics.TabIndex = 7;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(29, 12);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(154, 21);
            this.cboYear.TabIndex = 6;
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(428, 366);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(154, 21);
            this.btnFinished.TabIndex = 5;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // chtAnnualGenre
            // 
            chartArea2.Name = "ChartArea1";
            this.chtAnnualGenre.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtAnnualGenre.Legends.Add(legend2);
            this.chtAnnualGenre.Location = new System.Drawing.Point(34, 18);
            this.chtAnnualGenre.Name = "chtAnnualGenre";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtAnnualGenre.Series.Add(series2);
            this.chtAnnualGenre.Size = new System.Drawing.Size(479, 292);
            this.chtAnnualGenre.TabIndex = 8;
            this.chtAnnualGenre.Text = "chart1";
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chtAnnualGenre);
            this.grpChart.Location = new System.Drawing.Point(29, 44);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(535, 316);
            this.grpChart.TabIndex = 9;
            this.grpChart.TabStop = false;
            this.grpChart.Text = "Chart";
            // 
            // frmAdminRentalsGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 399);
            this.Controls.Add(this.grpChart);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnFinished);
            this.Name = "frmAdminRentalsGenre";
            this.Text = "frmAdminRentalsGenre";
            this.Load += new System.EventHandler(this.frmAdminRentalsGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnnualGenre)).EndInit();
            this.grpChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnnualGenre;
        private System.Windows.Forms.GroupBox grpChart;
    }
}