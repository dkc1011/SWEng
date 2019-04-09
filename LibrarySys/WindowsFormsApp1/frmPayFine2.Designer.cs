namespace WindowsFormsApp1
{
    partial class frmPayFine2
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
            this.lblMember = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtSumPaid = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblSumPaid = new System.Windows.Forms.Label();
            this.btnFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(238, 127);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(114, 13);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Member: Liam Dowling";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Location = new System.Drawing.Point(196, 149);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(90, 13);
            this.lblOutstanding.TabIndex = 1;
            this.lblOutstanding.Text = "Outstanding fees:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(283, 149);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(0, 13);
            this.lblFees.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(243, 214);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(111, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Submit Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtSumPaid
            // 
            this.txtSumPaid.Location = new System.Drawing.Point(243, 188);
            this.txtSumPaid.Name = "txtSumPaid";
            this.txtSumPaid.Size = new System.Drawing.Size(111, 20);
            this.txtSumPaid.TabIndex = 4;
            this.txtSumPaid.Text = "00.00";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(224, 191);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "€";
            // 
            // lblSumPaid
            // 
            this.lblSumPaid.AutoSize = true;
            this.lblSumPaid.Location = new System.Drawing.Point(272, 172);
            this.lblSumPaid.Name = "lblSumPaid";
            this.lblSumPaid.Size = new System.Drawing.Size(55, 13);
            this.lblSumPaid.TabIndex = 6;
            this.lblSumPaid.Text = "Sum Paid:";
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(243, 243);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(111, 23);
            this.btnFinished.TabIndex = 7;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // frmPayFine2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lblSumPaid);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtSumPaid);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblOutstanding);
            this.Controls.Add(this.lblMember);
            this.Name = "frmPayFine2";
            this.Text = "frmPayFine2";
            this.Load += new System.EventHandler(this.frmPayFine2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtSumPaid;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblSumPaid;
        private System.Windows.Forms.Button btnFinished;
    }
}