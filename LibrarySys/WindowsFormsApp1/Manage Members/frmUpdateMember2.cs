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
    public partial class frmUpdateMember2 : Form
    {
        frmUpdateMember1 parent;
        public frmUpdateMember2()
        {
            InitializeComponent();
        }

        public frmUpdateMember2(frmUpdateMember1 Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblAddMemberHeader_Click(object sender, EventArgs e)
        {

        }

        private void txtDoBYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDoBMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtDoBDay.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtDoBMonth.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtDoBYear.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            else
            {
                MessageBox.Show("Member " + txtForename.Text.ToUpper() + " " + txtSurname.Text.ToUpper() + " Updated", "Success");
                txtSurname.Clear();
                txtForename.Clear();
                txtDoBDay.Text = "DD";
                txtDoBMonth.Text = "MM";
                txtDoBYear.Text = "YYYY";
                txtStreet.Clear();
                txtTown.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void txtDoBDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
