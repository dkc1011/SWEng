namespace WindowsFormsApp1
{
    partial class frmAdminRentalsAnnual
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
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.chtAnnualRentals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpChart = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnnualRentals)).BeginInit();
            this.grpChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(432, 352);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(150, 20);
            this.btnFinished.TabIndex = 1;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(181, 10);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(144, 21);
            this.btnViewStatistics.TabIndex = 3;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // chtAnnualRentals
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnnualRentals.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnnualRentals.Legends.Add(legend1);
            this.chtAnnualRentals.Location = new System.Drawing.Point(27, 19);
            this.chtAnnualRentals.Name = "chtAnnualRentals";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnnualRentals.Series.Add(series1);
            this.chtAnnualRentals.Size = new System.Drawing.Size(493, 278);
            this.chtAnnualRentals.TabIndex = 4;
            this.chtAnnualRentals.Text = "chart1";
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.chtAnnualRentals);
            this.grpChart.Location = new System.Drawing.Point(24, 36);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(558, 310);
            this.grpChart.TabIndex = 6;
            this.grpChart.TabStop = false;
            this.grpChart.Text = "Chart";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(24, 10);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(151, 21);
            this.cboYear.TabIndex = 7;
            // 
            // frmAdminRentalsAnnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 382);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.grpChart);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnViewStatistics);
            this.Name = "frmAdminRentalsAnnual";
            this.Text = "frmAdminRentalsAnnual";
            this.Load += new System.EventHandler(this.frmAdminRentalsAnnual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnnualRentals)).EndInit();
            this.grpChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnnualRentals;
        private System.Windows.Forms.GroupBox grpChart;
        private System.Windows.Forms.ComboBox cboYear;
    }
}