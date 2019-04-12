using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Manage_Members
{

    public partial class frmDeregisterMember : Form
    {
        frmMainMenu parent;
        private int mno;

        public frmDeregisterMember()
        {
            InitializeComponent();
        }

        public frmDeregisterMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            mno = Convert.ToInt32(lstMembers.Text.Substring(0, 3));
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this member?",
                         "Confirm Remove Member",
                         MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Member.removeMember(mno);
                MessageBox.Show("Member was successfully removed", "Success");
            }
            else
            {
                txtMemberSearch.Clear();
                txtMemberSearch.Focus();
                lstMembers.Hide();
                btnRemoveMember.Hide();
            }

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
            btnRemoveMember.Visible = true;

        }

        /*private void lblLDowling_Click(object sender, EventArgs e)
        {
            //Source https://stackoverflow.com/questions/3845695/is-there-a-builtin-confirmation-dialog-in-windows-forms
            var confirmResult = MessageBox.Show("Are you sure to delete this member?",
                                     "Confirm Remove Member",
                                     MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Member LIAM DOWLING Removed!", "Success");
            }
            else
            {
                this.Close();
                parent.Show();
            }
        }*/

        private void frmRemoveMember1_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveMember_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this member?",
             "Confirm Remove Member",
             MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Member.removeMember(mno);
                MessageBox.Show("Member was successfully removed", "Success");
                txtMemberSearch.Clear();
                txtMemberSearch.Focus();
                lstMembers.Hide();
                btnRemoveMember.Hide();
            }
            else
            {
                txtMemberSearch.Clear();
                txtMemberSearch.Focus();
                lstMembers.Hide();
                btnRemoveMember.Hide();
            }
        }
    }
}
