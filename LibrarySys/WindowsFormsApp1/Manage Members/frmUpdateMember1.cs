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

namespace WindowsFormsApp1
{
    public partial class frmUpdateMember1 : Form
    {
        frmMainMenu parent;
        //create an instance of Member using MemberID from listbox
        Member myMember = new Member();

        public frmUpdateMember1()
        {
            InitializeComponent();
        }

        public frmUpdateMember1(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            myMember.findById(Convert.ToInt32(lstMembers.Text.Substring(0, 3)));

            //load text boxes
            txtSurname.Text = myMember.getSurname();
            txtForename.Text = myMember.getForename();
            txtStreet.Text = myMember.getStreet();
            dtpDOB.Text = myMember.getDOB();
            txtTown.Text = myMember.getTown();
            txtPhone.Text = myMember.getPhone();
            txtEmail.Text = myMember.getEmail();



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
                MessageBox.Show("All fields must be filled.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMemberSearch.Focus();
                return;
            }

            //retrieve all members with matching surname
            DataSet ds = new DataSet();
            ds = Member.FindActiveBySurname(txtMemberSearch.Text.ToUpper());


            //if no members found
            if(ds.Tables[0].Rows.Count==0)
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
        

        private void frmUpdateMember1_Load(object sender, EventArgs e)
        {

        }


        private void txtMemberSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMemberSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            int dateCompare = DateTime.Compare(DateTime.Now, dtpDOB.Value);

            if (txtSurname.Text.Equals("") || !frmAddMember.IsNonNumeric(txtSurname.Text))
            {
                MessageBox.Show("Invalid Surname Entered.", "Error");
            }
            else if (txtForename.Text.Equals("") || !frmAddMember.IsNonNumeric(txtForename.Text))
            {
                MessageBox.Show("Invalid Forename Entered.", "Error");
            }
            else if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtTown.Text.Equals("") || !frmAddMember.IsNonNumeric(txtTown.Text))
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
                myMember.setSurname(txtSurname.Text.ToUpper());
                myMember.setForename(txtForename.Text.ToUpper());
                myMember.setStreet(txtStreet.Text.ToUpper());
                myMember.setTown(txtTown.Text.ToUpper());
                myMember.setPhone(txtPhone.Text.ToUpper());
                myMember.setEmail(txtEmail.Text.ToUpper());

                myMember.updMember();

                MessageBox.Show("Member " + txtForename.Text.ToUpper() + " " + txtSurname.Text.ToUpper() + " Updated", "Success");

                txtMemberSearch.Clear();
                txtMemberSearch.Focus();
            }
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

    }
}
