using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{

    public partial class frmAddMember : Form
    {
        frmMainMenu parent; //define the instance variable

        public frmAddMember()
        {
            InitializeComponent();
        }

        public frmAddMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int dateCompare = DateTime.Compare(DateTime.Now, dtpDOB.Value);

            if(txtSurname.Text.Equals("") || !IsNonNumeric(txtSurname.Text))
            {
                MessageBox.Show("Invalid Surname Entered.", "Error");
            }
            else if(txtForename.Text.Equals("") || !IsNonNumeric(txtForename.Text))
            {
                MessageBox.Show("Invalid Forename Entered.", "Error");
            }
            else if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtTown.Text.Equals("") || !IsNonNumeric(txtTown.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (dateCompare < 0)
            {
                MessageBox.Show("Date selected cannot be a future date.");
            }
            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (!validEmail(txtEmail.Text))
            {
                MessageBox.Show("Email Address is Invalid. Please enter a valid email address.", "Error");
                txtEmail.Clear();
            }
            else
            {                
                Member myMember = new Member(Member.nextMemberId(),txtSurname.Text, frmAddMember.apostChecker(txtForename.Text), String.Format("{0:dd-MMM-yy}", dtpDOB.Value), txtStreet.Text, txtTown.Text, txtPhone.Text, txtEmail.Text, 'a');

                myMember.addMember();

                
                //Reset UI
                MessageBox.Show("Member " + txtForename.Text.ToUpper() + " " + txtSurname.Text.ToUpper() + " Added", "Success");
                txtSurname.Clear();
                txtForename.Clear();
                dtpDOB.ResetText();
                txtStreet.Clear();
                txtTown.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSurname.Focus();
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        public bool validEmail(String inStr)
        {
            if (Regex.IsMatch(inStr, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z09]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static string apostChecker(string text)
        {
            string newText = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] ==  '\'')
                {
                    newText += text[i] + "\'";
                }
                else
                {
                    newText += text[i];
                }
            }
            return newText;
        }

        internal static bool IsNonNumeric(string text)
        {
            double Num;

            bool isNum = double.TryParse(text, out Num);

            if (isNum)

                return false;

            else

                return true;
        }
    }
}
