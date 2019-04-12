using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPayFine : Form
    {
        Member myMember = new Member();
        private double SumPaid;
        private double LateFeeStart;
        private double change;
        frmMainMenu parent;
        public frmPayFine()
        {
            InitializeComponent();
        }

        public frmPayFine(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            lstMembers.Visible = false;

            if (txtMemberSearch.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberSearch.Focus();
                return;
            }

            //retrieve all members with matching surname
            DataSet ds = new DataSet();
            ds = Member.FindActiveBySurname(txtMemberSearch.Text.ToUpper());


            //if no members found
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No members Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberSearch.Focus();
                return;
            }

            lstMembers.Items.Clear();
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                lstMembers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][2].ToString() + " " + ds.Tables[0].Rows[i][1].ToString() + " - " + ds.Tables[0].Rows[i][4].ToString() + " - " + ds.Tables[0].Rows[i][5].ToString());
            lstMembers.SelectedIndex = 0;
            txtMemberSearch.Clear();
            lstMembers.Visible = true;
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpFine.Visible = false;
            myMember.findById(Convert.ToInt32(lstMembers.Text.Substring(0, 3)));

            txtSelectedMember.Text = myMember.getForename() + " " + myMember.getSurname();
            txtOutstandingFees.Text = String.Format("€{0:N2} Euro", myMember.GetLateFees());
            grpFine.Visible = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (myMember.GetLateFees() > 0)
            {
                if (validSumPaid(txtSumPaid.Text))
                {
                    SumPaid = Convert.ToDouble(txtSumPaid.Text);
                    LateFeeStart = myMember.GetLateFees();

                    if (SumPaid >= 2)
                    {
                        var confirmResult = MessageBox.Show("Confirm that " + String.Format("€{0:N2} Euro", SumPaid) + " was paid by member?",
                         "Confirm Payment",
                         MessageBoxButtons.YesNo);

                        if (confirmResult == DialogResult.Yes)
                        {



                            if (SumPaid > myMember.GetLateFees())
                            {
                                change = SumPaid - myMember.GetLateFees();
                                myMember.SetLateFees(0.00);
                                myMember.updMember();

                                MessageBox.Show("Member's late fees were paid in full. " + String.Format("€{0:N2} Euro", change) + " due in change.");
                            }
                            else if (SumPaid == myMember.GetLateFees())
                            {
                                myMember.SetLateFees(0.00);
                                myMember.updMember();
                                change = 0;

                                MessageBox.Show("Member's late fees were paid in full. No Change due.", "Success");
                            }
                            else
                            {
                                myMember.SetLateFees(myMember.GetLateFees() - SumPaid);
                                myMember.updMember();
                                change = 0;

                                MessageBox.Show("Fees were partially paid. " + String.Format("€{0:N2} Euro", myMember.GetLateFees()) + " remains to be paid.");
                            }

                            var confirmResult2 = MessageBox.Show("Print a receipt?",
                            "Confirm Payment",
                            MessageBoxButtons.YesNo);

                            if (confirmResult2 == DialogResult.Yes)
                            {
                                PrintDocument pd = new PrintDocument();
                                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

                                PrintDialog pdi = new PrintDialog();
                                pdi.Document = pd;
                                if (pdi.ShowDialog() == DialogResult.OK)
                                {
                                    pd.Print();
                                }
                                else
                                {
                                    MessageBox.Show("Print Cancelled");
                                }
                            }

                            ClearUI();

                        }
                    }
                    else
                    {
                        MessageBox.Show("The value paid was too small. Payments must be made above €2","Invalid Entry");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid money, please enter a valid euro value (nn.nn format)", "Error");
                    txtSumPaid.Text = "00.00";
                }
            }
            else
            {
                MessageBox.Show("The Member has no fines to pay");
            }
        }

        private bool validSumPaid(String inStr)
        {
            if (Regex.IsMatch(inStr, @"^\d+\.\d{2}$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearUI()
        {
            lstMembers.Items.Clear();
            lstMembers.Visible = false;
            grpFine.Visible = false;
            txtSumPaid.Text = "00.00";
            txtMemberSearch.Clear();
            txtMemberSearch.Focus();

        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(Object sender, PrintPageEventArgs e)
        {
            Font myFont = new Font("m_svoboda", 14, GraphicsUnit.Point);

            float lineHeight = myFont.GetHeight(e.Graphics) + 4;

            float yLineTop = e.MarginBounds.Top;

            string text = "\t\t\t+ Library Member Receipt + \n\n\n\tMember Charged: " + myMember.getForename() 
                + " " + myMember.getSurname() + "\n\n\tLate fee: " + String.Format("€{0:N2} Euro", LateFeeStart) 
                + "\n\tSum paid: " + String.Format("€{0:N2} Euro", SumPaid) + "\n\tRemaining Fees: " + String.Format("€{0:N2} Euro", myMember.GetLateFees()) + "\n\n\n\tChange tendered: " 
                + String.Format("€{0:N2} Euro", change) + "\n\n\n\t\t\t+++++++++++++++++++++";
      
            

            //MessageBox.Show(text);
            e.Graphics.DrawString(text, myFont, Brushes.Black,
            new PointF(e.MarginBounds.Left, yLineTop));

            yLineTop += lineHeight;

        }
    }
}
